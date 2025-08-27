using Guna.UI2.WinForms.Suite;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Logic;
using Vilta_Logic.Vilta_Functions;
using Vilta_Snippet.Controls;
using Vilta_Snippet.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Vilta_Snippet
{

    public partial class ctrlAddEditAccount : UserControl
    {
        enum enMode { eAddNew = 0, eUpdate};
        private enMode Mode;

        private clsUsers _User;
        ProfileImage ImageContainer;
        frmPasswordChecker PasswordCheker;

        public delegate void CloseEventHandler();
        public event CloseEventHandler Close;

        public ctrlAddEditAccount()
        {
            InitializeComponent();
            Mode = enMode.eAddNew;

            _SetSaveEvents();
            _SetNormalMode();
            _User = new clsUsers();
            ctrlSaveButton.SetNormalUi();
        }

        public ctrlAddEditAccount(int UserID)
        {
            InitializeComponent();
            Mode = enMode.eUpdate;

            _SetSaveEvents();
            _SetEditModeTheme();
            _FillUserData(UserID);
        }

        private void _FillUserData(int UserID)
        {
            _User = clsUsers.Find(UserID);

            if (_User != null)
            {
                btnUploadImage.Visible = false;
                _LoadImageContainer(_User.Image);

                tbName.Text     = _User.Person.Name;
                tbUserName.Text = _User.UserName;
                tbEmail.Text    = _User.Person.Email;
                tbPhone.Text    = _User.Person.Phone;
            }
        }

        private void _SetEditModeTheme()
        {
            txtBasicInfo.ForeColor = Color.RosyBrown;

            txtProfileImage.ForeColor  = Color.RosyBrown;
            btnUploadImage.BorderColor = Color.RosyBrown;
            btnUploadImage.ForeColor   = Color.RosyBrown;

            txtName.ForeColor  = Color.RosyBrown;
            tbName.BorderColor = Color.RosyBrown;

            txtUserName.ForeColor  = Color.RosyBrown;
            tbUserName.BorderColor = Color.RosyBrown;

            txtEmail.ForeColor  = Color.RosyBrown;
            tbEmail.BorderColor = Color.RosyBrown;

            txtPhone.ForeColor  = Color.RosyBrown;
            tbPhone.BorderColor = Color.RosyBrown;

            txtSetPassword.ForeColor = Color.RosyBrown;
            txtSetPassword.Text      = "Change Password";

            txtOldPassword.ForeColor  = Color.RosyBrown;
            tbOldPassword.BorderColor = Color.RosyBrown;

            txtPassword.ForeColor  = Color.RosyBrown;
            tbPassword.BorderColor = Color.RosyBrown;

            txtConfirmPassword.ForeColor  = Color.RosyBrown;
            tbConfirmPassword.BorderColor = Color.RosyBrown;
        }

        private void _SetNormalMode()
        {
            tbOldPassword.Visible  = false;
            txtOldPassword.Visible = false;

            //Set Container
            SetPasswordContainer.Size     = new System.Drawing.Size(640, 252);
            SetPasswordContainer.Location = new Point(761, 16);

            //Set Password
            tbPassword.Location  = new Point(13, 88);
            txtPassword.Location = new Point(22, 75);

            //Set Confirm Password
            tbConfirmPassword.Location  = new Point(13, 162);
            txtConfirmPassword.Location = new Point(22, 148);
        }

        private void _SetSaveEvents()
        {
            ctrlSaveButton.SaveEvent += _Save;
            ctrlSaveButton.Check     += _Check;
            ctrlSaveButton.SendClose += _Close;
        }

        private void _Check()
        {
            if (!_CheckFilds())
                ctrlSaveButton.IsWrongData(true);
            else
                ctrlSaveButton.IsWrongData(false);
        }

        private void _Save()
        {
            if (SaveData())
                StopEditing(true);
        }

        private void _Close()
        {
            Close?.Invoke();
        }

        private bool _CheckPassword(ref string ErrorMessage)
        {
            if (Mode == enMode.eUpdate)
            {
                if(clsValidations.CheckEmptyField(tbOldPassword.Text))
                {
                    ErrorMessage += "Old Password Field !";
                    clsViltaUiFunctions.ShowAlert(ErrorMessage);
                    return false;
                }
                else if (tbOldPassword.Text != clsCurrentUser.CurrentUser.Password)
                {
                    ErrorMessage = "The Old Password Is Wrong !, Try Again...";
                    clsViltaUiFunctions.ShowAlert(ErrorMessage);
                    return false;
                }
            }

            if (clsValidations.CheckEmptyField(tbPassword.Text))
            {
                ErrorMessage += "Password Field !";
                clsViltaUiFunctions.ShowAlert(ErrorMessage);
                return false;
            }
            else if (!clsValidations.VerifyPasswordConditions(tbPassword.Text))
            {
                ErrorMessage = "Password does not meet the conditions !, Try again...";
                clsViltaUiFunctions.ShowAlert(ErrorMessage);
                return false;
            }
            else if (clsValidations.CheckEmptyField(tbConfirmPassword.Text))
            {
                ErrorMessage = "You have to confirm the password !";
                clsViltaUiFunctions.ShowAlert(ErrorMessage);
                return false;
            }
            else if (tbPassword.Text != tbConfirmPassword.Text)
            {
                ErrorMessage = "There's no match betwwen \"Password\" field and \"Confirm Password\" field, Try again...";
                clsViltaUiFunctions.ShowAlert(ErrorMessage);
                return false;
            }

            return true;
        }

        private bool _CheckFilds()
        {
            string ErrorMessage = "You must fill in ";

            if (btnUploadImage.Visible)
            {
                ErrorMessage = "You have to upload an image !";
                clsViltaUiFunctions.ShowAlert(ErrorMessage);
                return false;
            }

            if (clsValidations.CheckEmptyField(tbName.Text))
            {
                ErrorMessage += "Name Field !";
                clsViltaUiFunctions.ShowAlert(ErrorMessage);
                return false;
            }

            if (clsValidations.CheckEmptyField(tbUserName.Text))
            {
                ErrorMessage += "User Name Field !";
                clsViltaUiFunctions.ShowAlert(ErrorMessage);
                return false;
            }
            else if (clsUsers.IsUserNameExist(tbUserName.Text) && Mode == enMode.eAddNew)
            {
                ErrorMessage = "User Name is alerdy used !, Write another...";
                clsViltaUiFunctions.ShowAlert(ErrorMessage);
                return false;
            }

            if (clsValidations.CheckEmptyField(tbEmail.Text))
            {
                ErrorMessage += "Email Field !";
                clsViltaUiFunctions.ShowAlert(ErrorMessage);
                return false;
            }

            if (clsValidations.CheckEmptyField(tbPhone.Text))
            {
                ErrorMessage += "Phone Field !";
                clsViltaUiFunctions.ShowAlert(ErrorMessage);
                return false;
            }

            if (Mode == enMode.eUpdate)
            {
                if (!clsValidations.CheckEmptyField(tbPassword.Text) || !clsValidations.CheckEmptyField(tbOldPassword.Text))
                {
                    if (!_CheckPassword(ref ErrorMessage))
                        return false;
                }
            }
            else if (Mode == enMode.eAddNew)
            {
                if (!_CheckPassword(ref ErrorMessage))
                    return false;
            }

            return true;
        }

        private bool _HandelImage()
        {
            if (_User.Image != ImageContainer.GetImage)
            {
                //if (_User.Image != "")
                //{
                //    try
                //    {
                //        File.Delete(_User.Image);
                //    }
                //    catch (IOException e)
                //    {
                //        return false;
                //    }
                //}

                if (ImageContainer.GetImage != "")
                {
                    string SourcePath = ImageContainer.GetImage;

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourcePath))
                    {
                        ImageContainer.SetImage = SourcePath;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }

            return true;
        }

        public bool SaveData()
        {
            if (!_HandelImage())
                return false;

            _User.UserName     = tbUserName.Text;

            if(tbPassword.Text != "")
                _User.Password = tbPassword.Text;
            else
                _User.Password = clsCurrentUser.CurrentUser.Password;

            _User.Person.Name  = tbName.Text;
            _User.Person.Email = tbEmail.Text;
            _User.Person.Phone = tbPhone.Text;
            _User.Image        = ImageContainer.GetImage;

            if (_User.Save())
            {
                if (Mode == enMode.eAddNew)
                    clsSettings.SaveDefaultAppSettings(_User.UserID);

                return true;
            }
            else
                return false;
        }

        private void _LoadImageContainer(string ImagePath)
        {
            ImageContainer = new ProfileImage(ImagePath);
            ImageContainer.Location = new Point(45, 140);
            ImageContainer.Size = new Size(165, 140);
            ImageContainer.DeleteEvent += _IsImageDeleted;

            this.Controls.Add(ImageContainer);
            ImageContainer.BringToFront();

            btnUploadImage.Visible = false;
        }

        private void _IsImageDeleted(bool IsDeleted)
        {
            if (IsDeleted)
                btnUploadImage.Visible = true;
        }

        private void _UploadImage()
        {
            if (GetImage.ShowDialog() == DialogResult.OK)
                _LoadImageContainer(GetImage.FileName);
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            _UploadImage();
        }

        public void StopEditing(bool Value)
        {
            tbName.ReadOnly            = Value;
            tbUserName.ReadOnly        = Value;
            tbEmail.ReadOnly           = Value;
            tbPhone.ReadOnly           = Value;
            tbPassword.ReadOnly        = Value;
            tbConfirmPassword.ReadOnly = Value;

            ImageContainer.DisabledDeleting(Value);
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if(tbOldPassword.Visible)
                PasswordCheker = new frmPasswordChecker(tbPassword.Text, false);
            else
                PasswordCheker = new frmPasswordChecker(tbPassword.Text);

            PasswordCheker.Show();
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            PasswordCheker.AnimationTimer_Closer.Start();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            PasswordCheker.ctrlPasswordCheker.CheckPasswordConditions(tbPassword.Text);
        }

        public void LocatePasswordChecker()
        {
            if (PasswordCheker != null)
            {
                Point RealLocation  = SetPasswordContainer.PointToScreen(tbPassword.Location);
                PasswordCheker.Location = new Point(RealLocation.X, (RealLocation.Y + 60));
            }
        }
    }
}
