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
using Vilta_Snippet.Login_Page;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Vilta_Snippet.General.Forms
{
    public partial class frmEditAccount : Form
    {
        ctrlAddEditAccount EditAccount = new ctrlAddEditAccount(clsCurrentUser.CurrentUser.UserID);

        public frmEditAccount()
        {
            InitializeComponent();
            _ShowEditContainer();

            EditAccount.Close += _Close;
        }

        private void _Close()
        {
            this.Close();
            this.Owner.Close();
        }

        private void _ShowEditContainer()
        {
            EditAccount.Size     = new Size(1433, 627);
            EditAccount.Location = new Point(44, 79);

            this.Controls.Add(EditAccount);
            EditAccount.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Close();
        }
    }
}
