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

namespace Vilta_Snippet
{
    public partial class frmStartPage : Form
    {
        public frmStartPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            clsCurrentUser.Mode = clsCurrentUser.enLoginMode.eLogin;

            frm.FormClosed += (s, args) => this.Close();
            frm.Show();

            clsUsers.QuickAccountsState(ShowQuickAccounts.Checked);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignup frm = new frmSignup();
            clsCurrentUser.Mode = clsCurrentUser.enLoginMode.eStartPage;

            frm.Show();
            clsUsers.QuickAccountsState(ShowQuickAccounts.Checked);
        }
    }
}
