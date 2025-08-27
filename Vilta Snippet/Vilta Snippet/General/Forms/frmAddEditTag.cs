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

namespace Vilta_Snippet.General_Forms
{
    public partial class frmAddEditTag : Form
    {
        private clsTags _Tag = new clsTags();
        private string _OldTagName = "";
        private enum enMode { eAddNew = 0, eUpdate = 1 };
        private enMode _Mode;
        
        public frmAddEditTag()
        {
            InitializeComponent();
            _Mode = enMode.eAddNew;

            _SetUI();
        }

        public frmAddEditTag(string TagName)
        {
            InitializeComponent();

            _Mode = enMode.eUpdate;
            _OldTagName = TagName;
            _Tag = new clsTags(TagName);
            
            _SetUI();
        }

        private void _SetUI()
        {
            if (_Mode == enMode.eAddNew)
            {
                txtTilte.Text  = "Add New Tag";
            }
            else
            {
                txtTilte.Text  = "Update Tag";
                tbTagName.Text = _OldTagName;
            }
        }

        private void frmAddNewTag_Load(object sender, EventArgs e)
        {
            ctrlSaveButton.Check     += _CheckTagData;
            ctrlSaveButton.SaveEvent += _SaveTag;
            ctrlSaveButton.SendClose += _Close;
        }

        private bool _CheckData()
        {
            if (tbTagName.Text == "")
            {
                clsViltaUiFunctions.ShowAlert("You have to type a name for your tag...");
                return true;
            }

            if (tbTagName.Text == _OldTagName)
            {
                clsViltaUiFunctions.ShowAlert("There is no changes !, You have to type a new name for the tag...");
                return true;
            }

            if (clsTags.IsTagExist(tbTagName.Text))
            {
                clsViltaUiFunctions.ShowAlert("The tag is exist !, write another tag...");
                return true;
            }

            return false;
        }

        private void _CheckTagData()
        {
            if (!_CheckData())
                ctrlSaveButton.IsWrongData(false);
            else
                ctrlSaveButton.IsWrongData(true);
        }
    
        private void _SaveTag()
        {
            _Tag.TagID = clsTags.Find(_Tag.TagName);
            _Tag.TagName = tbTagName.Text;
            _Tag.Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Close();
        }

        private void _Close()
        {
            if(_Mode == enMode.eAddNew)
                clsViltaUiFunctions.ShowAlert($"The tag \"{_Tag.TagName}\" has been added successfully !", false);

            this.DialogResult = DialogResult.OK;
            this.Close();
            this.Owner.Close();
        }
    }
}
