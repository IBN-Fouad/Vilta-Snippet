using Guna.UI2.WinForms.Enums;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Database_Access.Snippets;
using Vilta_Logic;
using Vilta_Logic.Snippets;
using Vilta_Logic.Vilta_Functions;
using Vilta_Snippet.Controls;

namespace Vilta_Snippet
{
    public partial class frmSnippets : Form
    {
        private string _SelectedTag = "";

        public frmSnippets()
        {
            InitializeComponent();
        }

        private void SwitchTags(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2GradientButton btn = (Guna.UI2.WinForms.Guna2GradientButton)sender;

            foreach (ctrlTag TagBtn in TagsContainer.Controls)
                TagBtn.btnTag.Checked = false;

            btn.Checked = true;
            _SelectedTag = btn.Text;

            SnippetsContainer.Controls.Clear();
            _LoadSnippets();
        }

        private void _FillSnippetData(ref clsSnippets Snippet, DataView Row, int Counter, bool IsAllSnippets)
        {
            Snippet.SnippetID             = (int)Row[Counter][0];
            Snippet.Title                 = (string)Row[Counter][1];
            Snippet.Date                  = (string)Row[Counter][2];
            Snippet.Description           = (string)Row[Counter][3];
            Snippet.Code                  = (string)Row[Counter][4];
            Snippet.Deleted               = (int)Row[Counter][5];
            Snippet.Favorited             = (int)Row[Counter][6];
            Snippet.Language              = (string)Row[Counter][7];
            Snippet.SnippetTags.TagName   = _SelectedTag;
            Snippet.SnippetTags.TagsNames = clsSnippets.GetSnippetTags(Snippet.SnippetID);
        }

        private string _GetSection()
        {
            switch (clsUtil.Section)
            {
                case clsUtil.enSection.eAll:
                    return "";
                case clsUtil.enSection.eTrash:
                    return " Deleted";
                case clsUtil.enSection.eFavorites:
                    return " Favorited";
            }

            return null;
        }

        private void _ShowEmptyMessage()
        {
            ctrlEmptyMessage Message = new ctrlEmptyMessage();

            //Set Colors
            Message.BackColor = Color.WhiteSmoke;
            Message.EmptyMegImg.BackColor = Color.WhiteSmoke;
            Message.txtMainText.BackColor = Color.WhiteSmoke;
            Message.txtSecondText.BackColor = Color.WhiteSmoke;

            //Set Values
            Message.EmptyMegImg.Load(@"D:\Vilta Snippet\Images\Icons\UnChecked Icons\Empty_Snippets.png");
            Message.txtMainText.Text   = $"There's No{_GetSection()} Snippets...";
            Message.txtSecondText.Text = "Add a snippet to make your code more organized !";
            Message.Show();

            SnippetsContainer.Controls.Add(Message);
            SnippetsContainer.Padding = new System.Windows.Forms.Padding(530, 200, 0, 0);
        }

        private void _SetSnippetContainer(ref ctrlSnippetContainer SnippetContainer, bool EditMode)
        {
            SnippetContainer.EditSnippet  = _EditSnippet;
            SnippetContainer.EmptyMessage = _EmptyMessageHandler;
            SnippetContainer.Undo         = _UndoDeletion;

            if (EditMode)
            {
                SnippetContainer.UnEnabledFavorite   = false;
                SnippetContainer.UnEnabledEditing    = false;
                SnippetContainer.UnEnabledDeleting   = false;
                SnippetContainer.UnEnabledRetreaving = false;
            }
        }

        private void _SetSnippetsLogic(DataView SnippetsFilter, int EditedSnippet, bool EditMode)
        {
            ctrlSnippetContainer SnippetContainer;
            clsSnippets Snippet = new clsSnippets();

            for (int i = 0; i < SnippetsFilter.Count; i++)
            {
                if ((int)SnippetsFilter[i][0] == EditedSnippet)
                    continue;

                _FillSnippetData(ref Snippet, SnippetsFilter, i, (_SelectedTag == "All"));

                SnippetContainer = new ctrlSnippetContainer(ref Snippet);
                _SetSnippetContainer(ref SnippetContainer, EditMode);

                SnippetsContainer.Controls.Add(SnippetContainer);
            }
        }

        private void _FilterCommand(ref DataView SnippetFilter, string Command, string SearchText)
        {
            if (SearchText != "")
                SnippetFilter.RowFilter = $"{Command} and {SearchText}";
            else
                SnippetFilter.RowFilter = $"{Command}";
        }

        private void _SnippetsFilter(ref DataView SnippetFilter, string SearchText)
        {
            switch (clsUtil.Section)
            {
                case clsUtil.enSection.eAll:
                    {
                        _FilterCommand(ref SnippetFilter, "Deleted = 0", SearchText);
                        break;
                    }
                case clsUtil.enSection.eFavorites:
                    {
                        _FilterCommand(ref SnippetFilter, "Favorited = 1 and Deleted = 0", SearchText);
                        break;
                    }
                case clsUtil.enSection.eTrash:
                    {
                        _FilterCommand(ref SnippetFilter, "Deleted = 1", SearchText);
                        break;
                    }
            }
        }

        private void _LoadSnippets(int EditedSnippet = -1, bool EditMode = false, string SearchText = "")
        {
            DataTable Snippets = _SelectedTag == "All" ? clsSnippets.LoadSnippets() : clsSnippets.LoadSnippets(_SelectedTag);
            DataView SnippetsFilter     = new DataView();

            if (Snippets != null)
            {
                if(!EditMode)
                    tbSearch.Enabled = true;

                SnippetsFilter = Snippets.DefaultView;
                _SnippetsFilter(ref SnippetsFilter, SearchText);
            }
            
            if ((Snippets == null && !EditMode) || (SnippetsFilter.Count == 0 && !EditMode))
            {
                _ShowEmptyMessage();
                return;
            }

            _SetSnippetsLogic(SnippetsFilter, EditedSnippet, EditMode);
            SnippetsContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
        }

        public void LoadSectionSnippets()
        {
            SnippetsContainer.Controls.Clear();
            _ClearTagsData();

            _LoadSnippets();
        }

        private void _UndoDeletion()
        {
            SnippetsContainer.Controls.Clear();
            _LoadSnippets();
        }

        private void _EmptyMessageHandler()
        {
            if (SnippetsContainer.Controls.Count == 0)
                _ShowEmptyMessage();
        }

        private void _EditSnippet(int SnippetID)
        {
            _AddOrEditSnippet("Edit", SnippetID);
        }
        
        private void _AddTheAllTag()
        {
            ctrlTag AllTag = new ctrlTag("All");

            AllTag.btnTag.Click += SwitchTags;
            AllTag.CheckedTag = true;
            _SelectedTag = "All";

            TagsContainer.Controls.Add(AllTag);
        }

        private void _SetTagsLogic(clsTags Tags)
        {
            _AddTheAllTag();
            
            foreach (string SnippetsTag in Tags.TagsNames)
            {
                ctrlTag Tag = new ctrlTag(SnippetsTag);
                Tag.btnTag.Click += SwitchTags;

                TagsContainer.Controls.Add(Tag);
            }
        }

        private void _LoadTags()
        {
            clsTags Tags   = new clsTags();
            Tags.TagsNames = clsTags.LoadTags();

            if (Tags.TagsNames != null)
                _SetTagsLogic(Tags);
            else
                _AddTheAllTag();
        }

        private void _SetUserInfo()
        {
            txtName.Text     = clsCurrentUser.CurrentUser.Person.Name;
            txtEmail.Text    = clsCurrentUser.CurrentUser.Person.Email;
            ProfileImg.Image = clsViltaUiFunctions.ReszieImage(0.1, 0.1, Image.FromFile(clsCurrentUser.CurrentUser.Image));
        }

        private void frmSnippets_Load(object sender, EventArgs e)
        {
            _SetUserInfo();

            this.Disposed += _ClearTags;
            _LoadTags();
            _LoadSnippets();
        }

        private void _AddOrEditSnippet(string Mode, int SnippetID = -1)
        {
            tbSearch.Enabled = false;
            SnippetsContainer.Controls.Clear();

            clsSnippets          Snippet;
            ctrlAddNewSnippet    SnippetEditor;
            ctrlSnippetContainer SnippetContainer;

            if (Mode == "Add")
            {
                SnippetEditor = new ctrlAddNewSnippet();
                SnippetContainer = new ctrlSnippetContainer();
            }
            else
            {
                Snippet = clsSnippets.GetSnippetByID(SnippetID);
                Snippet.SnippetTags.TagName = _SelectedTag;
                SnippetContainer = new ctrlSnippetContainer(ref Snippet);
                SnippetEditor = new ctrlAddNewSnippet(Snippet);
            }

            SnippetEditor.SyncTitleEvent           += SnippetContainer.SyncTitle;
            SnippetEditor.SyncTagsEvent            += SnippetContainer.SyncTags;
            SnippetEditor.ClearTags                += SnippetContainer.ClearTags;
            SnippetEditor.SyncLanguage             += SnippetContainer.SyncLanguage;
            SnippetEditor.SyncDescriptionEvent     += SnippetContainer.SyncDescription;
            SnippetEditor.SyncEditorEvent          += SnippetContainer.SyncEditor;
            SnippetEditor.ctrlSaveButton.SendClose += _RefreshSnippets;
            SnippetEditor.btnClose.Click           += _RefreshSnippets;

            SnippetContainer.Height = SnippetEditor.Height;
            SnippetContainer.Width += 50;

            SnippetContainer.UnEnabledFavorite   = false;
            SnippetContainer.UnEnabledEditing    = false;
            SnippetContainer.UnEnabledDeleting   = false;
            SnippetContainer.UnEnabledRetreaving = false;

            SnippetsContainer.Controls.Add(SnippetContainer);
            SnippetsContainer.Controls.Add(SnippetEditor);

            _LoadSnippets(SnippetID, true);
        }

        private void _RefreshSnippets()
        {
            TagsContainer.Controls.Clear();
            SnippetsContainer.Controls.Clear();
            _LoadTags();
            _LoadSnippets();
        }

        private void _RefreshSnippets(object sender, EventArgs e)
        {
            _RefreshSnippets();
        }

        private void _ClearTagsData()
        {
            clsTags.SelectedTagsNames.Clear();
            clsTags.SelectedTagsIDs.Clear();
        }

        private void _ClearTags(object sender, EventArgs e)
        {
            _ClearTagsData();
        }

        private void SnippetsContainer_ControlRemoved(object sender, ControlEventArgs e)
        {
            _ClearTagsData();
        }

        private void btnAddSnippet_Click(object sender, EventArgs e)
        {
            _AddOrEditSnippet("Add");
        }

        private void tbSearch_IconLeftClick(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
                return;

            SnippetsContainer.Controls.Clear();
            _LoadSnippets(SearchText:  $"Title Like '%{tbSearch.Text}%'");
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                SnippetsContainer.Controls.Clear();
                _LoadSnippets();
            }
        }
    }
}
