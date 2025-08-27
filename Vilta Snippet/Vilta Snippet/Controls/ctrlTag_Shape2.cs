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
using Vilta_Snippet.General.General_Forms;
using Vilta_Snippet.General_Forms;

namespace Vilta_Snippet.Controls
{
    public partial class ctrlTag_Shape2 : UserControl
    {
        public delegate void SelectedEventHandler(string TagName, bool SelectState);
        public SelectedEventHandler SelecteEvent;

        public delegate void TagUpdatedEventHandler(bool UpdateResult);
        public TagUpdatedEventHandler TagUpdated;

        public ctrlTag_Shape2(string TagName, int Snippets, bool IsNormalMode)
        {
            InitializeComponent();
            btnTag.Text = TagName;
            txtSnippets.Text = Snippets + (Snippets == 1 ? " Snippet" : " Snippets");

            if (IsNormalMode)
                _NormalModeUI();
        }

        private void _NormalModeUI()
        {
            btnSelect.Visible  = false;
            btnEdit.Location   = btnDelete.Location;
            btnDelete.Location = btnSelect.Location;
        }

        private void btnTag_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            btnEdit.Visible = true;
        }

        private void btnTag_MouseLeave(object sender, EventArgs e)
        {
            if(!btnDelete.Bounds.Contains(PointToClient(MousePosition)) && !btnEdit.Bounds.Contains(PointToClient(MousePosition)))
            {
                btnDelete.Visible = false;
                btnEdit.Visible = false;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (btnTag.Checked == false)
                clsTags.SelectedTagsNames.Remove(btnTag.Text);

            if (clsTags.SelectedTagsNames.Count < 3)
                SelecteEvent?.Invoke(btnTag.Text, btnSelect.Checked);
            else
            {
                clsViltaUiFunctions.ShowAlert("You can't select more than 3 Tags...");
                btnSelect.Checked = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmPopupBackGround popupBackGround = new frmPopupBackGround(new frmPopup($"Are you sure you want to delete \"{btnTag.Text}\" tag ?", "Delete"), true);
            popupBackGround.PopupResult += _DeleteTag;
            popupBackGround.Show();
        }

        private void _DeleteTag(bool IsDeleted)
        {
            if (IsDeleted)
            {
                clsTags.DeleteTag(clsTags.Find(btnTag.Text));
                clsViltaUiFunctions.ShowAlert($"The tag \"{btnTag.Text}\" has been deleted successfully !", false);

                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmPopupBackGround PopupBackGround = new frmPopupBackGround(new frmAddEditTag(btnTag.Text), true);
            PopupBackGround.PopupResult += _UpdateResult;
            PopupBackGround.Show();
        }

        private void _UpdateResult(bool UpdatedResult)
        {
            if (UpdatedResult)
            {
                clsViltaUiFunctions.ShowAlert($"The tag has been updated successfully !", false);
                TagUpdated?.Invoke(true);
            }
        }
    }
}
