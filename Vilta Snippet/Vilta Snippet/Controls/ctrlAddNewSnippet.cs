using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Vilta_Database_Access.Snippets;
using Vilta_Logic;
using Vilta_Logic.Snippets;
using Vilta_Logic.Vilta_Functions;

namespace Vilta_Snippet.Controls
{
    public partial class ctrlAddNewSnippet : UserControl
    {
        clsSnippets NewSnippet = new clsSnippets();

        public delegate void ClearTagsEventHandler();
        public ClearTagsEventHandler ClearTags;

        public event Action<string>  SyncTitleEvent;
        public event Action<ctrlTag> SyncTagsEvent;
        public event Action<string>  SyncLanguage;
        public event Action<string>  SyncDescriptionEvent;
        public event Action<string>  SyncEditorEvent;

        public ctrlAddNewSnippet()
        {
            InitializeComponent();
            cbLangs.SelectedIndex = 0;
        }

        public ctrlAddNewSnippet(clsSnippets Snippet)
        {
            InitializeComponent();
            _FillData(Snippet);
        }

        private void ctrlSaveButton_Load(object sender, EventArgs e)
        {
            ctrlSaveButton.SetNormalUi();

            ctrlCopyBtn1.Copy -= CopyText;
            ctrlCopyBtn1.Copy += CopyText;

            ctrlSaveButton.Check -= _Check;
            ctrlSaveButton.Check += _Check;

            ctrlSaveButton.SaveEvent -= _Save;
            ctrlSaveButton.SaveEvent += _Save;
        }

        private void _FillData(clsSnippets Snippet)
        {
            NewSnippet = new clsSnippets(Snippet.SnippetID, Snippet.Title, Snippet.Date, Snippet.Description, Snippet.Code, Snippet.Deleted, Snippet.Favorited, Snippet.Language, 2, Snippet.SnippetTags.TagsNames);

            txtSelectTags.Text   = "Selected Tags :";
            tbTitle.Text         = NewSnippet.Title;
            tbDescription.Rtf    = NewSnippet.Description;
            CodeEditor.Text      = NewSnippet.Code;
            cbLangs.SelectedItem = NewSnippet.Language;
            clsViltaUiFunctions.LoadTags(NewSnippet.SnippetTags.TagsNames, ref TagsContainer);

            int TagID = 0;
            foreach (string Tag in Snippet.SnippetTags.TagsNames)
            {
                if (Tag == "All")
                    continue;

                TagID = clsTags.Find(Tag);

                clsTags.SelectedTagsIDs.Add(TagID);
                clsTags.SelectedTagsNames.Add(Tag);
            }
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
                SyncTitleEvent?.Invoke("Title Text");
            else
                SyncTitleEvent?.Invoke(tbTitle.Text);
        }

        private void cbLangs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncLanguage?.Invoke(cbLangs.Text);
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {
            if (tbDescription.Text.Length <= 150)
                txtMaxText.Text = tbDescription.Text.Length + "/150";

            SyncDescriptionEvent?.Invoke(tbDescription.Rtf);
        }

        private void CodeEditor_TextChanged(object sender, EventArgs e)
        {
            SyncEditorEvent?.Invoke(CodeEditor.Text);
        }

        private void tbTitle_Enter(object sender, EventArgs e)
        {
            txtTitleIcon.ForeColor = Color.Crimson;
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            txtTitleIcon.ForeColor = Color.DarkGray;
        }

        private void txtSelectTags_MouseEnter(object sender, EventArgs e)
        {
            txtSelectTags.ForeColor = Color.Crimson;
            pbTagsIcon.Load(@"D:\Vilta Snippet\Images\Icons\Hover Icons\Tag.png");
        }

        private void txtSelectTags_MouseLeave(object sender, EventArgs e)
        {
            txtSelectTags.ForeColor = Color.FromArgb(193, 200, 207);
            pbTagsIcon.Load(@"D:\Vilta Snippet\Images\Icons\UnChecked Icons\Tag.png");
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (tbDescription.SelectionFont != null)
            {
                FontStyle SelectionStyle = tbDescription.SelectionFont.Bold ? FontStyle.Regular : FontStyle.Bold;
                tbDescription.SelectionFont = new Font(tbDescription.SelectionFont, SelectionStyle);
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (tbDescription.SelectionFont != null)
            {
                FontStyle SelectionStyle = tbDescription.SelectionFont.Italic ? FontStyle.Regular : FontStyle.Italic;
                tbDescription.SelectionFont = new Font(tbDescription.SelectionFont, SelectionStyle);
            }
        }

        private void btnUnderLine_Click(object sender, EventArgs e)
        {
            if (tbDescription.SelectionFont != null)
            {
                FontStyle SelectionStyle = tbDescription.SelectionFont.Underline ? FontStyle.Regular : FontStyle.Underline;
                tbDescription.SelectionFont = new Font(tbDescription.SelectionFont, SelectionStyle);
            }
        }

        private void btnHeader_Click(object sender, EventArgs e)
        {
            if (tbDescription.SelectionFont != null)
            {
                Font SelectionStyle = tbDescription.SelectionFont;
                tbDescription.SelectionFont = new Font(SelectionStyle.FontFamily, 14, SelectionStyle.Style);
            }
        }

        private void btnSubTitle_Click(object sender, EventArgs e)
        {
            if (tbDescription.SelectionFont != null)
            {
                Font SelectionStyle = tbDescription.SelectionFont;
                tbDescription.SelectionFont = new Font(SelectionStyle.FontFamily, 12, SelectionStyle.Style);
            }
        }

        private void tbDescription_Enter(object sender, EventArgs e)
        {
            pbDescriptionIcon.Load(@"D:\Vilta Snippet\Images\Icons\Hover Icons\Description Hover.png");
        }

        private void tbDescription_Leave(object sender, EventArgs e)
        {
            pbDescriptionIcon.Load(@"D:\Vilta Snippet\Images\Icons\UnChecked Icons\Description.png");
        }

        private void CodeEditor_Enter(object sender, EventArgs e)
        {
            pbCodeIcon.Load(@"D:\Vilta Snippet\Images\Icons\Hover Icons\Code.png");
        }

        private void CodeEditor_Leave(object sender, EventArgs e)
        {
            pbCodeIcon.Load(@"D:\Vilta Snippet\Images\Icons\UnChecked Icons\Code.png");
        }

        private bool _CheckFields()
        {
            if (tbTitle.Text == "")
            {
                clsViltaUiFunctions.ShowAlert("You have to write a title for your sinppet...");
                return true;
            }

            if (clsTags.SelectedTagsNames.Count == 0)
            {
                clsViltaUiFunctions.ShowAlert("You have to choose at least one tag for your sinppet...");
                return true;
            }

            if (tbDescription.Text == "")
            {
                clsViltaUiFunctions.ShowAlert("You have to write a description for your sinppet...");
                return true;
            }

            if (cbLangs.SelectedItem == null)
            {
                clsViltaUiFunctions.ShowAlert("You have to choose a language for your sinppet...");
                return true;
            }

            if (CodeEditor.Text == "")
            {
                clsViltaUiFunctions.ShowAlert("You have to write a code in the editor...");
                return true;
            }

            return false;
        }

        private void _Check()
        {
            ctrlSaveButton.IsWrongData(_CheckFields());
        }

        private void _Save()
        {
            NewSnippet.Title = tbTitle.Text;
            NewSnippet.Date = DateTime.Now.ToString("MMM d");
            NewSnippet.Description = tbDescription.Rtf;
            NewSnippet.Language = cbLangs.Text;
            NewSnippet.Code = CodeEditor.Text;
            NewSnippet.UserID = clsCurrentUser.CurrentUser.UserID;
            NewSnippet.Favorited = 0;
            NewSnippet.Deleted = 0;

            foreach (int Tag in clsTags.SelectedTagsIDs)
                NewSnippet.SnippetTags.Tags.Add(Tag);

            NewSnippet.Save();
            _LockEditor();
        }

        private void _LockEditor()
        {
            tbTitle.Enabled              = false;
            txtSelectTags.Enabled        = false;
            DescriptionEditor.Enabled    = false;
            cbLangs.Enabled              = false;
            EditorContainer.Enabled      = false;
        }

        private void txtSelectTags_Click(object sender, EventArgs e)
        {
            frmPopupBackGround PopupBackGround = new frmPopupBackGround(new frmChoseTags());
            PopupBackGround.FormClosed += GetSelectedTags;
            PopupBackGround.Show();
        }

        private void GetSelectedTags(object sender, FormClosedEventArgs e)
        {
            TagsContainer.Controls.Clear();
            ClearTags?.Invoke();

            if (clsTags.SelectedTagsNames.Count != 0)
            {
                txtSelectTags.Text = "Selected Tags :";
                foreach (string Tag in clsTags.SelectedTagsNames)
                {
                    ctrlTag SelectedTag = new ctrlTag(Tag);
                    ctrlTag SelectedTagViewer = new ctrlTag(Tag);

                    clsViltaUiFunctions.TagUi(ref SelectedTag);
                    clsViltaUiFunctions.TagUi(ref SelectedTagViewer);
                    TagsContainer.Controls.Add(SelectedTag);
                    SyncTagsEvent?.Invoke(SelectedTagViewer);
                }
            }
            else
            {
                txtSelectTags.Text = "Select Tags...";
            }
        }

        public void CopyText()
        {
            ctrlCopyBtn1.SetText(CodeEditor.Text);
        }
    }
}
