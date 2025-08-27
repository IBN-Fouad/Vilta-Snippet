using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Vilta_Logic.Vilta_Functions.clsValidations;
using Vilta_Logic.Vilta_Functions;
using Vilta_Logic;
using Vilta_Snippet.Login_Page;

namespace Vilta_Snippet
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            ctrlSignup.Close += _Close;
        }

        private void _Close()
        {
            if (clsCurrentUser.Mode == clsCurrentUser.enLoginMode.eStartPage ||
                clsCurrentUser.Mode == clsCurrentUser.enLoginMode.eQuickAccounts)
            {
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }

            this.Close();
        }

        private void frmSignup_Resize(object sender, EventArgs e)
        {
            ctrlSignup.LocatePasswordChecker();
        }

        private void frmSignup_Move(object sender, EventArgs e)
        {
            ctrlSignup.LocatePasswordChecker();
        }
    }
}
