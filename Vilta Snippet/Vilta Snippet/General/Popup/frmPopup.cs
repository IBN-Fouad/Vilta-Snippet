using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vilta_Snippet.General.General_Forms
{
    public partial class frmPopup : Form
    {
        public delegate void ConfirmDeletionEventHandler();
        public ConfirmDeletionEventHandler ConfirmDeletion;

        public frmPopup(string Message, string MainBtn)
        {
            InitializeComponent();
            txtMessage.Text = Message;
            btnAccept.Text  = MainBtn;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
