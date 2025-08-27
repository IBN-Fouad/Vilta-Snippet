using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Logic;
using Vilta_Logic.Snippets;
using Vilta_Logic.Vilta_Functions;
using Vilta_Snippet.Controls;

namespace Vilta_Snippet
{
    public partial class frmMain : Form
    {
        private frmSnippets _SnippetsForm;
        private bool _IsLogout = false;

        public delegate void ShowLoginPageEventHandler();
        public ShowLoginPageEventHandler ShowLoginPage;

        public delegate void ShowQuickAccountsPageEventHandler();
        public ShowQuickAccountsPageEventHandler ShowQuickAccountsPage;

        public frmMain()
        {
            InitializeComponent();
            _IsLogout = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnTrash.Visible = clsUserSettings.Settings.Trash;

            clsUtil.Section = clsUtil.enSection.eAll;
            _SnippetsForm = new frmSnippets();
            LoadForm(_SnippetsForm);
            _LoadTopLanguages();

            btnAllSnippets.Checked = true;
        }

        private void _LoadTopLanguages()
        {
            DataTable SnippetsCount = clsSnippets.GetSnippetsCount();

            foreach (DataRow Lang in SnippetsCount.Rows)
            {
                ctrlLanguage Language = new ctrlLanguage(Lang["Language"].ToString(), (int)Lang["SnippetsCount"]);
                LanguagesContainer.Controls.Add(Language);
            }
        }

        public void LoadForm(Form frm)
        {
            if (this.SectionsContainer.Controls.Count > 0)
            {
                if (frm != _SnippetsForm)
                    _SnippetsForm = null;

                this.SectionsContainer.Controls[0].Dispose();
            }

            frm.TopLevel = false;
            this.SectionsContainer.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;

            frm.Show();
        }

        private void _FilterSections(Guna.UI2.WinForms.Guna2GradientButton Section)
        {
            switch (Section.Tag.ToString())
            {
                case "All Snippets":
                    clsUtil.Section = clsUtil.enSection.eAll;
                    break;
                case "Favorites":
                    clsUtil.Section = clsUtil.enSection.eFavorites;
                    break;
                case "Trash":
                    clsUtil.Section = clsUtil.enSection.eTrash;
                    break;
                case "Tags":
                    frmPopupBackGround frm = new frmPopupBackGround(new frmChoseTags(true));
                    frm.Show();
                    return;
                case "Profile":
                    frmProfile Profile = new frmProfile();
                    Profile.Quit += _Logout;
                    Profile.TrashUnabled  += _HideShowTrashSection;

                    LoadForm(Profile);
                    return;
            }

            if (_SnippetsForm != null)
                _SnippetsForm.LoadSectionSnippets();
            else
            {
                _SnippetsForm = new frmSnippets();
                LoadForm(_SnippetsForm);
            }
        }

        private void _Logout()
        {
            _IsLogout = true;
            if (clsCurrentUser.Mode == clsCurrentUser.enLoginMode.eQuickAccounts)
                ShowQuickAccountsPage?.Invoke();
            else
                ShowLoginPage?.Invoke();

            this.Close();
        }

        private void _HideShowTrashSection(bool IsOn)
        {
            btnTrash.Visible = IsOn;

            if(!IsOn)
            {
                List<int> SnippetsIDs = new List<int>();
                clsSnippets.CheckUserTrashItems(ref SnippetsIDs);

                if(SnippetsIDs != null) clsSnippets.DeleteTrashItems(SnippetsIDs);
            }
        }

        private void SwitchSections(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2GradientButton Section = (Guna.UI2.WinForms.Guna2GradientButton)sender;
            Section.Checked = true;

            _FilterSections(Section);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_IsLogout)
                Application.Exit();
        }
    }
}
