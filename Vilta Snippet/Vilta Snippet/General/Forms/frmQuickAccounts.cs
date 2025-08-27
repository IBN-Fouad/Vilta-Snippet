using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Logic;
using Vilta_Snippet.Controls;
using Vilta_Snippet.Login_Page;

namespace Vilta_Snippet.General.Forms
{
    public partial class frmQuickAccounts : Form
    {
        public frmQuickAccounts()
        {
            InitializeComponent();
        }

        private void LoadAccounts(object sender, EventArgs e)
        {
            LoadQuickAccounts();
        }

        public void LoadQuickAccounts()
        {
            DataTable Accounts  = clsUsers.LoadQuickAccounts();

            foreach(DataRow Row in Accounts.Rows)
            {
                ctrlQuickAccount Account = new ctrlQuickAccount((int)Row["UserID"], (string)Row["UserName"], (string)Row["Image"]);
                Account.SendUserID += _Login;

                AccountsContainer.Controls.Add(Account);
            }
        }

        private void _Login(int ID)
        {
            frmMain Main = new frmMain();

            clsCurrentUser.CurrentUser        = new clsUsers();
            clsCurrentUser.CurrentUser.UserID = ID;
            clsUserSettings.Settings = clsSettings.SetAppSettings();

            Main.ShowQuickAccountsPage += clsViltaUiFunctions.ShowQuickAccountsPage;
            clsViltaUiFunctions.ShowMain(MainPage: Main, UserID: ID, LocatedForm: this);

            this.Hide();
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            frmSignup signup = new frmSignup();
            signup.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void frmQuickAccounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsUsers.QuickAccountsState(ShowQuickAccounts.Checked);
        }
    }
}