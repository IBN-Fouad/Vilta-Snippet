using Guna.UI2.WinForms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Vilta_Database_Access.Snippets;
using Vilta_Logic;
using Vilta_Logic.Snippets;
using Vilta_Snippet.General.Forms;
using Vilta_Snippet.General.General_Forms;
using Vilta_Snippet.General.Popup;

namespace Vilta_Snippet
{
    public partial class frmProfile : Form
    {
        private bool _CancelClosingTrashResult = false;
        private frmSettingsItemPopup _SettingsItemPopup;

        public delegate void TrashUnabledEventHandler(bool IsOn);
        public TrashUnabledEventHandler TrashUnabled;

        public delegate void QuitEventHandler();
        public QuitEventHandler Quit;

        public frmProfile()
        {
            InitializeComponent();
            _SetUserData();
        }

        private void _SetUserData()
        {
            txtName.Text     = clsCurrentUser.CurrentUser.Person.Name;
            txtEmail.Text    = clsCurrentUser.CurrentUser.Person.Email;
            ProfileImg.Image = clsViltaUiFunctions.ReszieImage(0.1, 0.1, Image.FromFile(clsCurrentUser.CurrentUser.Image));
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            _CancelClosingTrashResult = false;

            _LoadSettings();
        }

        private void _LoadSettings()
        {
            ActiveTrashToggle.Checked = clsUserSettings.Settings.Trash;
            btnActiveTrash.Checked    = clsUserSettings.Settings.Trash;

            ActiveQuickAccountsToggle.Checked = clsUserSettings.Settings.QuickAccounts;
            btnActiveQuickAccounts.Checked    = clsUserSettings.Settings.QuickAccounts;

            CaseSensitiveToggle.Checked = clsUserSettings.Settings.CaseSensitive;
            btnCaseSensitive.Checked    = clsUserSettings.Settings.CaseSensitive;

            UndoFeatureToggle.Checked = clsUserSettings.Settings.UndoFeature;
            btnUndoFeature.Checked    = clsUserSettings.Settings.UndoFeature;
        }

        private void _SetToggleAffect(ref Guna.UI2.WinForms.Guna2Button FeatureItem, bool Value)
        {
            clsSettings.UpdateFeatureState(Value, FeatureItem.Tag.ToString());

            FeatureItem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            FeatureItem.Checked    = Value;
        }

        private void _ConfirmClosingTrashFeature()
        {
            frmPopupBackGround PopupBackGround = new frmPopupBackGround(new frmPopup("If you deactivate the Trash, all data in it will be deleted", "Deactivate"), true);
            PopupBackGround.PopupResult += _IsDeactivated;

            PopupBackGround.Show();
        }

        private void _IsDeactivated(bool IsDeactivated)
        {
            if (IsDeactivated)
            {
                _CancelClosingTrashResult = false;
                _TrashFeatureLogic(false);
            }
            else
            {
                _CancelClosingTrashResult = true;
            }
        }

        private void _TrashFeatureLogic(bool Active)
        {
            TrashUnabled?.Invoke(Active);
            clsUserSettings.Settings.Trash = Active;
            _SetToggleAffect(ref btnActiveTrash, Active);
        }

        private void _LinkToggleWithButton(Guna.UI2.WinForms.Guna2ToggleSwitch Toggle, bool Value)
        {
            switch (Toggle.Name)
            {
                case "ActiveTrashToggle":
                    {
                        if (!Value)
                        {
                            _ConfirmClosingTrashFeature();

                            if(_CancelClosingTrashResult)
                                Toggle.Checked = true;

                            _CancelClosingTrashResult = false;
                            break;
                        }

                        _TrashFeatureLogic(Value);
                        break;
                    }
                case "ActiveQuickAccountsToggle":
                    clsUserSettings.Settings.QuickAccounts = Value;
                    _SetToggleAffect(ref btnActiveQuickAccounts, Value);
                    break;
                case "CaseSensitiveToggle":
                    clsUserSettings.Settings.CaseSensitive = Value;
                    _SetToggleAffect(ref btnCaseSensitive, Value);
                    break;
                case "UndoFeatureToggle":
                    clsUserSettings.Settings.UndoFeature = Value;
                    _SetToggleAffect(ref btnUndoFeature, Value);
                    break;
            }
        }

        private void ToggleFeaturesItems(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2ToggleSwitch Toggle = (Guna.UI2.WinForms.Guna2ToggleSwitch)sender;

            if(!_CancelClosingTrashResult)
                _LinkToggleWithButton(Toggle, Toggle.Checked);
        }

        private void ShowExplainPopup(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;

            switch (btn.Name)
            {
                case "btnActiveTrash":
                    _SettingsItemPopup = new frmSettingsItemPopup("When this option is activated, deleted snippets will be moved to the trash automatically");
                    break;
                case "btnActiveQuickAccounts":
                    _SettingsItemPopup = new frmSettingsItemPopup("When this option is activated, your account will be registered under \"Quick Access\" accounts");
                    break;
                case "btnCaseSensitive":
                    _SettingsItemPopup = new frmSettingsItemPopup("When this option is activated the search will be made more accurate in tags section, so that it cares about the status of each character");
                    break;
                default:
                    _SettingsItemPopup = new frmSettingsItemPopup("\"Undo\" feature allows you to quickly return the deleted snippet from the trash");
                    break;
            }

            _SettingsItemPopup.Show();
        }

        private void HideExplainPopup(object sender, EventArgs e)
        {
            if (_SettingsItemPopup != null)
            {
                _SettingsItemPopup.Close();
                _SettingsItemPopup.Dispose();
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            frmPopupBackGround PopupBackGround = new frmPopupBackGround(new frmEditAccount());
            PopupBackGround.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            frmPopupBackGround PopupBackGround = new frmPopupBackGround(new frmPopup("Are You Sure You Want To Delete This Account ?", "Delete"), true);
            PopupBackGround.PopupResult += _DeleteResult;

            PopupBackGround.Show();
        }

        private void _DeleteResult(bool Result)
        {
            if (Result)
            {
                clsUsers.Delete();
                Quit?.Invoke();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmPopupBackGround PopupBackGround = new frmPopupBackGround(new frmPopup("Are You Sure You Want To Logout ?", "Logout"), true);
            PopupBackGround.PopupResult += _LogoutResult;

            PopupBackGround.Show();
        }

        private void _LogoutResult(bool Result)
        {
            if (Result)
                Quit?.Invoke();
        }

    }
}
