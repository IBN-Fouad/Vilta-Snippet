using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Logic;
using Vilta_Logic.Vilta_Functions;
using static Vilta_Logic.Vilta_Functions.clsValidations;

namespace Vilta_Snippet.Login_Page
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtSignupPage_Click(object sender, EventArgs e)
        {
            frmSignup frm = new frmSignup();
            frm.ShowDialog();
        }

        private void _FieldsState(bool IsErrorState, ref Guna.UI2.WinForms.Guna2TextBox TargetField)
        {
            if (IsErrorState)
                TargetField.BorderColor = Color.Red;
            else
                TargetField.BorderColor = Color.WhiteSmoke;
        }

        private bool _CheckFilds(enCheckState CheckState)
        {
            string ErrorMessage = "";
            bool IsError = false;

            switch (CheckState)
            {
                case clsValidations.enCheckState.eEmptyCheck:
                    {
                        ErrorMessage = "You must fill in ";

                        if (clsValidations.CheckEmptyField(tbUserName.Text))
                        {
                            _FieldsState(true, ref tbUserName);
                            ErrorMessage += "User Name Field";
                            IsError = true;
                        }
                        else
                        {
                            _FieldsState(false, ref tbUserName);
                        }

                        if (clsValidations.CheckEmptyField(tbPassword.Text))
                        {
                            if(IsError)
                                ErrorMessage += " And Password Field";
                            else
                                ErrorMessage += "Password Field";

                            _FieldsState(true, ref tbPassword);
                            IsError = true;
                        }
                        else
                        {
                            _FieldsState(false, ref tbPassword);
                        }

                        break;
                    }
                case clsValidations.enCheckState.eValidation:
                    {
                        ErrorMessage = "Login failed, you have to refill in : ";

                        switch (clsUsers.Login(tbUserName.Text, tbPassword.Text))
                        {
                            case -1:
                            {
                                ErrorMessage += "User Name field ";
                                _FieldsState(true, ref tbUserName);
                                IsError = true;
                                break;
                            }
                            case 0:
                            {
                                if(!IsError)
                                    ErrorMessage += "Password field";
                                else
                                    ErrorMessage += "& Password fields.";
                                IsError = true;
                                break;
                            }
                        }

                        break;
                    }
            }

            if (IsError)
                clsViltaUiFunctions.ShowAlert(ErrorMessage);

            return !IsError;
        }

        private void _SetAccountSettings()
        {
            if (QuickAccount.Checked)
                clsUsers.SaveAccountAsQuickAccount();

            clsUserSettings.Settings = clsSettings.SetAppSettings();
        }

        private void _SetAsQuickAccountsPage(ref frmMain Main)
        {
            Main.ShowQuickAccountsPage += clsViltaUiFunctions.ShowQuickAccountsPage;
            clsViltaUiFunctions.ShowMain(MainPage: Main, LocatedForm: clsViltaUiFunctions.QuickAccountsPage);
            clsViltaUiFunctions.QuickAccountsPage.Hide();

            this.Close();
        }

        private void _SetAsLoginPage(ref frmMain Main)
        {
            Main.ShowLoginPage += _ShowLoginPage;
            clsViltaUiFunctions.ShowMain(MainPage: Main);

            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsValidations.CheckState = clsValidations.enCheckState.eEmptyCheck;
            if (!_CheckFilds(clsValidations.CheckState))
                return;

            clsValidations.CheckState = clsValidations.enCheckState.eValidation;
            if (_CheckFilds(clsValidations.CheckState))
            {
                _SetAccountSettings();
                frmMain Main = new frmMain();

                if (clsCurrentUser.Mode == clsCurrentUser.enLoginMode.eQuickAccounts)
                    _SetAsQuickAccountsPage(ref Main);
                else
                    _SetAsLoginPage(ref Main);
            }
        }

        private void _ShowLoginPage()
        {
            this.Show();
        }
    }
}
