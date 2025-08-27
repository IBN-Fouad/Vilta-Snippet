namespace Vilta_Snippet
{
    partial class ctrlAddEditAccount
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAddEditAccount));
            this.BasicInfoContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.txtPhone = new System.Windows.Forms.Label();
            this.tbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new System.Windows.Forms.Label();
            this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProfileImage = new System.Windows.Forms.Label();
            this.txtBasicInfo = new System.Windows.Forms.Label();
            this.btnUploadImage = new Guna.UI2.WinForms.Guna2Button();
            this.GetImage = new System.Windows.Forms.OpenFileDialog();
            this.SetPasswordContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.txtOldPassword = new System.Windows.Forms.Label();
            this.tbOldPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSetPassword = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ctrlSaveButton = new Vilta_Snippet.Controls.ctrlSaveButton();
            this.BasicInfoContainer.SuspendLayout();
            this.SetPasswordContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasicInfoContainer
            // 
            this.BasicInfoContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BasicInfoContainer.Controls.Add(this.txtPhone);
            this.BasicInfoContainer.Controls.Add(this.tbPhone);
            this.BasicInfoContainer.Controls.Add(this.txtEmail);
            this.BasicInfoContainer.Controls.Add(this.tbEmail);
            this.BasicInfoContainer.Controls.Add(this.txtUserName);
            this.BasicInfoContainer.Controls.Add(this.tbUserName);
            this.BasicInfoContainer.Controls.Add(this.txtName);
            this.BasicInfoContainer.Controls.Add(this.tbName);
            this.BasicInfoContainer.Controls.Add(this.txtProfileImage);
            this.BasicInfoContainer.Controls.Add(this.txtBasicInfo);
            this.BasicInfoContainer.Controls.Add(this.btnUploadImage);
            this.BasicInfoContainer.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BasicInfoContainer.Location = new System.Drawing.Point(8, 16);
            this.BasicInfoContainer.Name = "BasicInfoContainer";
            this.BasicInfoContainer.ShadowDecoration.Parent = this.BasicInfoContainer;
            this.BasicInfoContainer.Size = new System.Drawing.Size(747, 531);
            this.BasicInfoContainer.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.AutoSize = true;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtPhone.ForeColor = System.Drawing.Color.Crimson;
            this.txtPhone.Location = new System.Drawing.Point(45, 439);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(59, 23);
            this.txtPhone.TabIndex = 20;
            this.txtPhone.Text = "Phone";
            this.txtPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPhone
            // 
            this.tbPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPhone.Animated = true;
            this.tbPhone.BorderColor = System.Drawing.Color.Crimson;
            this.tbPhone.BorderRadius = 5;
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.DefaultText = "";
            this.tbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.DisabledState.Parent = this.tbPhone;
            this.tbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbPhone.FocusedState.Parent = this.tbPhone;
            this.tbPhone.HoverState.BorderColor = System.Drawing.Color.Red;
            this.tbPhone.HoverState.Parent = this.tbPhone;
            this.tbPhone.Location = new System.Drawing.Point(36, 452);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PasswordChar = '\0';
            this.tbPhone.PlaceholderText = "";
            this.tbPhone.SelectedText = "";
            this.tbPhone.ShadowDecoration.Parent = this.tbPhone;
            this.tbPhone.Size = new System.Drawing.Size(684, 52);
            this.tbPhone.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.Crimson;
            this.txtEmail.Location = new System.Drawing.Point(45, 366);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 23);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Text = "Email Address";
            this.txtEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Animated = true;
            this.tbEmail.BorderColor = System.Drawing.Color.Crimson;
            this.tbEmail.BorderRadius = 5;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.Parent = this.tbEmail;
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbEmail.FocusedState.Parent = this.tbEmail;
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.Red;
            this.tbEmail.HoverState.Parent = this.tbEmail;
            this.tbEmail.Location = new System.Drawing.Point(36, 379);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "";
            this.tbEmail.SelectedText = "";
            this.tbEmail.ShadowDecoration.Parent = this.tbEmail;
            this.tbEmail.Size = new System.Drawing.Size(684, 52);
            this.tbEmail.TabIndex = 17;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtUserName.ForeColor = System.Drawing.Color.Crimson;
            this.txtUserName.Location = new System.Drawing.Point(391, 293);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(97, 23);
            this.txtUserName.TabIndex = 16;
            this.txtUserName.Text = "User Name";
            this.txtUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUserName.Animated = true;
            this.tbUserName.BorderColor = System.Drawing.Color.Crimson;
            this.tbUserName.BorderRadius = 5;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.DefaultText = "";
            this.tbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.DisabledState.Parent = this.tbUserName;
            this.tbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbUserName.FocusedState.Parent = this.tbUserName;
            this.tbUserName.HoverState.BorderColor = System.Drawing.Color.Red;
            this.tbUserName.HoverState.Parent = this.tbUserName;
            this.tbUserName.Location = new System.Drawing.Point(382, 306);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PlaceholderText = "";
            this.tbUserName.SelectedText = "";
            this.tbUserName.ShadowDecoration.Parent = this.tbUserName;
            this.tbUserName.Size = new System.Drawing.Size(338, 52);
            this.tbUserName.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.Crimson;
            this.txtName.Location = new System.Drawing.Point(43, 293);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(57, 23);
            this.txtName.TabIndex = 14;
            this.txtName.Text = "Name";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbName.Animated = true;
            this.tbName.BorderColor = System.Drawing.Color.Crimson;
            this.tbName.BorderRadius = 5;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.Parent = this.tbName;
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbName.FocusedState.Parent = this.tbName;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.Red;
            this.tbName.HoverState.Parent = this.tbName;
            this.tbName.Location = new System.Drawing.Point(36, 306);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "";
            this.tbName.SelectedText = "";
            this.tbName.ShadowDecoration.Parent = this.tbName;
            this.tbName.Size = new System.Drawing.Size(338, 52);
            this.tbName.TabIndex = 13;
            // 
            // txtProfileImage
            // 
            this.txtProfileImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProfileImage.AutoSize = true;
            this.txtProfileImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtProfileImage.ForeColor = System.Drawing.Color.Crimson;
            this.txtProfileImage.Location = new System.Drawing.Point(22, 103);
            this.txtProfileImage.Name = "txtProfileImage";
            this.txtProfileImage.Size = new System.Drawing.Size(118, 23);
            this.txtProfileImage.TabIndex = 12;
            this.txtProfileImage.Text = "Profile Image";
            this.txtProfileImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBasicInfo
            // 
            this.txtBasicInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBasicInfo.AutoSize = true;
            this.txtBasicInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtBasicInfo.ForeColor = System.Drawing.Color.Crimson;
            this.txtBasicInfo.Location = new System.Drawing.Point(18, 27);
            this.txtBasicInfo.Name = "txtBasicInfo";
            this.txtBasicInfo.Size = new System.Drawing.Size(129, 35);
            this.txtBasicInfo.TabIndex = 11;
            this.txtBasicInfo.Text = "Basic Info";
            this.txtBasicInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUploadImage.Animated = true;
            this.btnUploadImage.BackColor = System.Drawing.Color.White;
            this.btnUploadImage.BorderColor = System.Drawing.Color.IndianRed;
            this.btnUploadImage.BorderRadius = 5;
            this.btnUploadImage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnUploadImage.BorderThickness = 4;
            this.btnUploadImage.CheckedState.Parent = this.btnUploadImage;
            this.btnUploadImage.CustomImages.Parent = this.btnUploadImage;
            this.btnUploadImage.FillColor = System.Drawing.Color.White;
            this.btnUploadImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUploadImage.ForeColor = System.Drawing.Color.IndianRed;
            this.btnUploadImage.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUploadImage.HoverState.Parent = this.btnUploadImage;
            this.btnUploadImage.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadImage.Image")));
            this.btnUploadImage.ImageOffset = new System.Drawing.Point(27, -15);
            this.btnUploadImage.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUploadImage.Location = new System.Drawing.Point(36, 138);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.PressedColor = System.Drawing.Color.White;
            this.btnUploadImage.PressedDepth = 15;
            this.btnUploadImage.ShadowDecoration.Parent = this.btnUploadImage;
            this.btnUploadImage.Size = new System.Drawing.Size(684, 131);
            this.btnUploadImage.TabIndex = 10;
            this.btnUploadImage.Text = "Uplad image";
            this.btnUploadImage.TextOffset = new System.Drawing.Point(-13, 30);
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // GetImage
            // 
            this.GetImage.FileName = "Profile Image";
            this.GetImage.InitialDirectory = "D:\\";
            // 
            // SetPasswordContainer
            // 
            this.SetPasswordContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetPasswordContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SetPasswordContainer.Controls.Add(this.txtOldPassword);
            this.SetPasswordContainer.Controls.Add(this.tbOldPassword);
            this.SetPasswordContainer.Controls.Add(this.txtConfirmPassword);
            this.SetPasswordContainer.Controls.Add(this.txtPassword);
            this.SetPasswordContainer.Controls.Add(this.tbPassword);
            this.SetPasswordContainer.Controls.Add(this.txtSetPassword);
            this.SetPasswordContainer.Controls.Add(this.tbConfirmPassword);
            this.SetPasswordContainer.FillColor = System.Drawing.Color.WhiteSmoke;
            this.SetPasswordContainer.Location = new System.Drawing.Point(761, 16);
            this.SetPasswordContainer.Name = "SetPasswordContainer";
            this.SetPasswordContainer.ShadowDecoration.Parent = this.SetPasswordContainer;
            this.SetPasswordContainer.Size = new System.Drawing.Size(640, 326);
            this.SetPasswordContainer.TabIndex = 25;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOldPassword.AutoSize = true;
            this.txtOldPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtOldPassword.ForeColor = System.Drawing.Color.Crimson;
            this.txtOldPassword.Location = new System.Drawing.Point(23, 79);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(119, 23);
            this.txtOldPassword.TabIndex = 28;
            this.txtOldPassword.Text = "Old Password";
            this.txtOldPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOldPassword.Animated = true;
            this.tbOldPassword.BorderColor = System.Drawing.Color.Crimson;
            this.tbOldPassword.BorderRadius = 5;
            this.tbOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOldPassword.DefaultText = "";
            this.tbOldPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbOldPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbOldPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOldPassword.DisabledState.Parent = this.tbOldPassword;
            this.tbOldPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOldPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbOldPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbOldPassword.FocusedState.Parent = this.tbOldPassword;
            this.tbOldPassword.HoverState.BorderColor = System.Drawing.Color.Red;
            this.tbOldPassword.HoverState.Parent = this.tbOldPassword;
            this.tbOldPassword.Location = new System.Drawing.Point(14, 92);
            this.tbOldPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.PasswordChar = '\0';
            this.tbOldPassword.PlaceholderText = "";
            this.tbOldPassword.SelectedText = "";
            this.tbOldPassword.ShadowDecoration.Parent = this.tbOldPassword;
            this.tbOldPassword.Size = new System.Drawing.Size(612, 52);
            this.tbOldPassword.TabIndex = 27;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword.AutoSize = true;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Crimson;
            this.txtConfirmPassword.Location = new System.Drawing.Point(23, 221);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(157, 23);
            this.txtConfirmPassword.TabIndex = 25;
            this.txtConfirmPassword.Text = "Confirm password";
            this.txtConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.AutoSize = true;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.Crimson;
            this.txtPassword.Location = new System.Drawing.Point(23, 148);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(85, 23);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Animated = true;
            this.tbPassword.BorderColor = System.Drawing.Color.Crimson;
            this.tbPassword.BorderRadius = 5;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.Red;
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.Location = new System.Drawing.Point(14, 161);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(612, 52);
            this.tbPassword.TabIndex = 22;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // txtSetPassword
            // 
            this.txtSetPassword.AutoSize = true;
            this.txtSetPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtSetPassword.ForeColor = System.Drawing.Color.Crimson;
            this.txtSetPassword.Location = new System.Drawing.Point(8, 12);
            this.txtSetPassword.Name = "txtSetPassword";
            this.txtSetPassword.Size = new System.Drawing.Size(171, 35);
            this.txtSetPassword.TabIndex = 21;
            this.txtSetPassword.Text = "Set password";
            this.txtSetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConfirmPassword.Animated = true;
            this.tbConfirmPassword.BorderColor = System.Drawing.Color.Crimson;
            this.tbConfirmPassword.BorderRadius = 5;
            this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPassword.DefaultText = "";
            this.tbConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPassword.DisabledState.Parent = this.tbConfirmPassword;
            this.tbConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbConfirmPassword.FocusedState.Parent = this.tbConfirmPassword;
            this.tbConfirmPassword.HoverState.BorderColor = System.Drawing.Color.Red;
            this.tbConfirmPassword.HoverState.Parent = this.tbConfirmPassword;
            this.tbConfirmPassword.Location = new System.Drawing.Point(14, 235);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '\0';
            this.tbConfirmPassword.PlaceholderText = "";
            this.tbConfirmPassword.SelectedText = "";
            this.tbConfirmPassword.ShadowDecoration.Parent = this.tbConfirmPassword;
            this.tbConfirmPassword.Size = new System.Drawing.Size(612, 52);
            this.tbConfirmPassword.TabIndex = 26;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.BasicInfoContainer;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 25;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 25;
            this.guna2Elipse4.TargetControl = this.SetPasswordContainer;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.btnUploadImage;
            // 
            // ctrlSaveButton
            // 
            this.ctrlSaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.ctrlSaveButton.Location = new System.Drawing.Point(1235, 553);
            this.ctrlSaveButton.Name = "ctrlSaveButton";
            this.ctrlSaveButton.Size = new System.Drawing.Size(151, 58);
            this.ctrlSaveButton.TabIndex = 27;
            // 
            // ctrlAddEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ctrlSaveButton);
            this.Controls.Add(this.SetPasswordContainer);
            this.Controls.Add(this.BasicInfoContainer);
            this.Name = "ctrlAddEditAccount";
            this.Size = new System.Drawing.Size(1426, 627);
            this.BasicInfoContainer.ResumeLayout(false);
            this.BasicInfoContainer.PerformLayout();
            this.SetPasswordContainer.ResumeLayout(false);
            this.SetPasswordContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel BasicInfoContainer;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtProfileImage;
        private System.Windows.Forms.Label txtBasicInfo;
        private System.Windows.Forms.OpenFileDialog GetImage;
        public Guna.UI2.WinForms.Guna2TextBox tbPhone;
        public Guna.UI2.WinForms.Guna2TextBox tbEmail;
        public Guna.UI2.WinForms.Guna2TextBox tbUserName;
        public Guna.UI2.WinForms.Guna2TextBox tbName;
        private Guna.UI2.WinForms.Guna2Panel SetPasswordContainer;
        private System.Windows.Forms.Label txtConfirmPassword;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.Label txtSetPassword;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        public Guna.UI2.WinForms.Guna2Button btnUploadImage;
        public Guna.UI2.WinForms.Guna2TextBox tbPassword;
        public Guna.UI2.WinForms.Guna2TextBox tbConfirmPassword;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Controls.ctrlSaveButton ctrlSaveButton;
        private System.Windows.Forms.Label txtOldPassword;
        public Guna.UI2.WinForms.Guna2TextBox tbOldPassword;
    }
}
