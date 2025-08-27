using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Database_Access.Snippets;
using Vilta_Logic;
using Vilta_Logic.Snippets;
using Vilta_Snippet.General.General_Forms;

namespace Vilta_Snippet.Controls
{
    public partial class ctrlSnippetContainer : UserControl
    {
        enum enMode { eNormal = 0, eDeleted = 1};
        private enMode Mode;

        public delegate void EditSnippetEventHandler(int SnippetID);
        public EditSnippetEventHandler EditSnippet;

        public delegate void EmptyMessageEventHandler();
        public EmptyMessageEventHandler EmptyMessage;

        public delegate void UndoEventHandler();
        public UndoEventHandler Undo;

        public bool UnEnabledFavorite
        {
            set { btnFavorite.Enabled = value; }
        }

        public bool UnEnabledEditing
        {
            set { btnEdit.Enabled = value; }
        }

        public bool UnEnabledDeleting
        {
            set { btnDelete.Enabled = value; }
        }

        public bool UnEnabledRetreaving
        {
            set { btnMoveFromTrash.Enabled = value; }
        }

        public ctrlSnippetContainer(ref clsSnippets SnippetData)
        {
            InitializeComponent();
            _FillSnippetData(ref SnippetData);
            _EditorLogic();
        }

        public ctrlSnippetContainer()
        {
            InitializeComponent();
            _EditorLogic();
        }

        public void SyncTitle(string Title)
        {
            txtTilte.Text = Title;
        }

        public void SyncTags(ctrlTag Tag)
        {
            TagsContainer.Controls.Add(Tag);
        }
        
        public void ClearTags()
        {
            TagsContainer.Controls.Clear();
        }

        public void SyncLanguage(string Language)
        {
            txtLanguage.Text    = Language;
            LanguageImage.Image = clsViltaUiFunctions.GetLanguageImg(Language);
        }

        public void SyncDescription(string Description)
        {
            tbDescription.Rtf = Description;
        }

        public void SyncEditor(string Code)
        {
            CodeEditor.Text = Code;
        }

        private void _FillSnippetData(ref clsSnippets SnippetData)
        {
            txtTilte.Text              = SnippetData.Title;
            txtDate.Text               = SnippetData.Date;
            tbDescription.Rtf          = SnippetData.Description;
            txtLanguage.Text           = SnippetData.Language;
            LanguageImage.Image        = clsViltaUiFunctions.GetLanguageImg(SnippetData.Language);
            CodeEditor.Text            = SnippetData.Code;
            btnEdit.Tag                = SnippetData.SnippetID;
            btnFavorite.Checked        = (SnippetData.Favorited == 1);
            
            if (SnippetData.Deleted == 1)
            {
                Mode = enMode.eDeleted;
                btnDelete.Checked        = true;
                btnMoveFromTrash.Visible = true;
            }
            
            if(!clsUserSettings.Settings.Trash && Mode != enMode.eDeleted)
                Mode = enMode.eDeleted;

            if (SnippetData.SnippetTags.TagName != "All")
            { 
                SnippetData.SnippetTags.TagsNames.Clear();
                SnippetData.SnippetTags.TagsNames.Add(SnippetData.SnippetTags.TagName);
            }

            clsViltaUiFunctions.LoadTags(SnippetData.SnippetTags.TagsNames, ref TagsContainer);
        }

        private void CodeEditor_TextChanged(object sender, EventArgs e)
        {
            _EditorLogic();
        }

        private void _EditorLogic()
        {
            int selectionStart = CodeEditor.SelectionStart;
            int selectionLength = CodeEditor.SelectionLength;

            string currentText = CodeEditor.Text;

            CodeEditor.SuspendLayout();

            CodeEditor.SelectAll();
            CodeEditor.SelectionColor = Color.Black;
            HighlightSyntax(currentText);

            CodeEditor.Select(selectionStart, selectionLength);
            CodeEditor.ResumeLayout();
        }

        private void HighlightSyntax(string text)
        {
            string[] keywords = { "abstract", "console", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked",
                                  "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else",
                                  "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for",
                                  "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock",
                                  "long", "namespace", "new", "null", "object", "operator", "out", "override", "params",
                                  "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed",
                                  "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this",
                                  "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort",
                                  "using", "virtual", "void", "volatile", "while" };

            foreach (string keyword in keywords)
            {
                MatchCollection keywordMatches = Regex.Matches(text, @"\b" + keyword + @"\b");
                foreach (Match match in keywordMatches)
                {
                    CodeEditor.Select(match.Index, keyword.Length);
                    CodeEditor.SelectionColor = Color.Blue;
                }
            }

            MatchCollection commentMatches = Regex.Matches(text, @"(\/\/.?$|\/\.?\\/)", RegexOptions.Multiline);
            foreach (Match match in commentMatches)
            {
                CodeEditor.Select(match.Index, match.Length);
                CodeEditor.SelectionColor = Color.Green;
            }

            MatchCollection stringMatches = Regex.Matches(text, "\".*?\"");
            foreach (Match match in stringMatches)
            {
                CodeEditor.Select(match.Index, match.Length);
                CodeEditor.SelectionColor = Color.Brown;
            }
        }

        private void _ConfirmTheDeletion()
        {
            frmPopupBackGround popupBackGround = new frmPopupBackGround(new frmPopup($"Are you sure to delete the snippet? Remember you can never get them back...", "Delete"), true);
            popupBackGround.PopupResult += _DeletionResult;
            popupBackGround.Show();

            _DeleteSnippet();
        }

        private void _Undo()
        {
            frmUndoAlert UndoAlert = new frmUndoAlert("Do you want to undo the deletion ?");
            UndoAlert.Undo = _UndoResult;
            UndoAlert.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Checked = true;
            if(Mode == enMode.eDeleted || !clsUserSettings.Settings.Trash)
            {
                _ConfirmTheDeletion();
                return;
            }

            frmAlert Alert = new frmAlert("The snippet has been moved to trash successfully !", false);
            Alert.Show();

            if (clsUserSettings.Settings.UndoFeature)
                _Undo();

            _SetTheStateOfTheSnippet(MoveToTrash: true);
        }

        private void _UndoResult(bool Undo)
        {
            if (Undo)
            {
                _SetTheStateOfTheSnippet(false);
                this.Undo?.Invoke();
            }
        }

        private void _DeletionResult(bool DeletionConfirmed)
        {
            if (DeletionConfirmed)
            {
                _DeleteSnippet();
                _SetTheStateOfTheSnippet(Deleted: true);
            }
            else if(!clsUserSettings.Settings.Trash)
            {
                btnDelete.Checked = false;
            }
        }

        private void _SetTheStateOfTheSnippet(bool MoveToTrash = false, bool Deleted = false)
        {
            if(!Deleted)
            {
                if (int.TryParse(btnEdit.Tag.ToString(), out int SnippetID))
                    clsSnippets.ManageDeletions(SnippetID, MoveToTrash);
            }

           if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                EmptyMessage?.Invoke();
                this.Dispose();
            }
        }

        private int _GetCurrentSnippetID()
        {
            if (int.TryParse(btnEdit.Tag.ToString(), out int ID))
                return ID;
            else
                return -1;
        }

        private void _DeleteSnippet()
        {
            clsSnippets.DeleteSnippet(_GetCurrentSnippetID());
        }

        private void ctrlSnippetContainer_Leave(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSnippet?.Invoke(_GetCurrentSnippetID());
        }

        private void ctrlSnippetContainer_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
        }

        private void ctrlSnippetContainer_MouseLeave(object sender, EventArgs e)
        {
            if (!txtTilte.Bounds.Contains(PointToClient(MousePosition)) &&
                !txtDate.Bounds.Contains(PointToClient(MousePosition)) &&
                !btnFavorite.Bounds.Contains(PointToClient(MousePosition)) &&
                !tbDescription.Bounds.Contains(PointToClient(MousePosition)) &&
                !CodeEditorContainer.Bounds.Contains(PointToClient(MousePosition)) &&
                !CodeEditor.Bounds.Contains(PointToClient(MousePosition)) &&
                !LanguageImage.Bounds.Contains(PointToClient(MousePosition)) &&
                !txtLanguage.Bounds.Contains(PointToClient(MousePosition)) &&
                !btnDelete.Bounds.Contains(PointToClient(MousePosition)))
            {
                btnEdit.Visible = false;
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if(int.TryParse(btnEdit.Tag.ToString(), out int SnippetID))
                clsSnippets.ManageFavorites(SnippetID, btnFavorite.Checked);
        }

        private void btnMoveFromTrash_Click(object sender, EventArgs e)
        {
            _SetTheStateOfTheSnippet(false);

            frmAlert Alert = new frmAlert("The snippet has been retrieved successfully !", false);
            Alert.Show();
        }

        private void ctrlSnippetContainer_Load(object sender, EventArgs e)
        {
            ctrlCopyBtn1.Copy -= CopyText;
            ctrlCopyBtn1.Copy += CopyText;
        }

        public void CopyText()
        {
            ctrlCopyBtn1.SetText(CodeEditor.Text);
        }
    }
}
