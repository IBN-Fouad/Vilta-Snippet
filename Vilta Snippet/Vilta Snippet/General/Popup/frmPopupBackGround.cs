using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Logic.Snippets;

namespace Vilta_Snippet
{
    public partial class frmPopupBackGround : Form
    {
        public delegate void PopupDialogResultEventHandler(bool PopupResult);
        public PopupDialogResultEventHandler PopupResult;

        private bool _PopupDialogResult = false;

        private Form _frm;

        public frmPopupBackGround(Form SelectedForm)
        {
            InitializeComponent();
            _frm = SelectedForm;
        }

        public frmPopupBackGround(Form SelectedForm, bool DialogPopupActive)
        {
            InitializeComponent();
            _frm = SelectedForm;
            _PopupDialogResult = DialogPopupActive;
        }

        private void frmPopupBackGround_Load(object sender, EventArgs e)
        {
            _frm.Owner = this;

            if(_PopupDialogResult)
            {
                if (_frm.ShowDialog() == DialogResult.Cancel)
                    PopupResult?.Invoke(false);
                else
                    PopupResult?.Invoke(true);

                this.Close();
            }
            else
                _frm.ShowDialog();
        }
    }
}
