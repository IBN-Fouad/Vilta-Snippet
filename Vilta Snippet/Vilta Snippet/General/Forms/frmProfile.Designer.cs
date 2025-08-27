namespace Vilta_Snippet
{
    partial class frmProfile
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.btnDeleteAccount = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditAccount = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.ProfileImg = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnLogout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.CaseSensitiveToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnCaseSensitive = new Guna.UI2.WinForms.Guna2Button();
            this.UndoFeatureToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnUndoFeature = new Guna.UI2.WinForms.Guna2Button();
            this.ActiveQuickAccountsToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnActiveQuickAccounts = new Guna.UI2.WinForms.Guna2Button();
            this.ActiveTrashToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnActiveTrash = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2GradientPanel3.SuspendLayout();
            this.guna2GradientPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAccount.Animated = true;
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAccount.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteAccount.BorderRadius = 7;
            this.btnDeleteAccount.BorderThickness = 1;
            this.btnDeleteAccount.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteAccount.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteAccount.CheckedState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDeleteAccount.CheckedState.Parent = this.btnDeleteAccount;
            this.btnDeleteAccount.CustomImages.Parent = this.btnDeleteAccount;
            this.btnDeleteAccount.FillColor = System.Drawing.Color.White;
            this.btnDeleteAccount.FillColor2 = System.Drawing.Color.White;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Rubik", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteAccount.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteAccount.HoverState.FillColor = System.Drawing.Color.MistyRose;
            this.btnDeleteAccount.HoverState.FillColor2 = System.Drawing.Color.Snow;
            this.btnDeleteAccount.HoverState.Parent = this.btnDeleteAccount;
            this.btnDeleteAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAccount.Image")));
            this.btnDeleteAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteAccount.ImageOffset = new System.Drawing.Point(5, -1);
            this.btnDeleteAccount.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteAccount.Location = new System.Drawing.Point(583, 118);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.PressedDepth = 0;
            this.btnDeleteAccount.ShadowDecoration.Parent = this.btnDeleteAccount;
            this.btnDeleteAccount.Size = new System.Drawing.Size(137, 49);
            this.btnDeleteAccount.TabIndex = 39;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteAccount.TextOffset = new System.Drawing.Point(5, 0);
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.RosyBrown;
            this.label8.Location = new System.Drawing.Point(46, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(674, 63);
            this.label8.TabIndex = 5;
            this.label8.Text = "If you click on \"Delete\", your account will be permanently deleted along with all" +
    " the data thats associated with it.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.RosyBrown;
            this.label7.Location = new System.Drawing.Point(9, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 37);
            this.label7.TabIndex = 3;
            this.label7.Text = "Danger Zone";
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditAccount.Animated = true;
            this.btnEditAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnEditAccount.BorderColor = System.Drawing.Color.White;
            this.btnEditAccount.BorderRadius = 7;
            this.btnEditAccount.CheckedState.Parent = this.btnEditAccount;
            this.btnEditAccount.CustomImages.Parent = this.btnEditAccount;
            this.btnEditAccount.FillColor = System.Drawing.Color.MistyRose;
            this.btnEditAccount.FillColor2 = System.Drawing.Color.MistyRose;
            this.btnEditAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditAccount.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnEditAccount.HoverState.FillColor = System.Drawing.Color.MistyRose;
            this.btnEditAccount.HoverState.FillColor2 = System.Drawing.Color.Snow;
            this.btnEditAccount.HoverState.Parent = this.btnEditAccount;
            this.btnEditAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAccount.Image")));
            this.btnEditAccount.Location = new System.Drawing.Point(1101, 10);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.ShadowDecoration.Parent = this.btnEditAccount;
            this.btnEditAccount.Size = new System.Drawing.Size(43, 42);
            this.btnEditAccount.TabIndex = 37;
            this.btnEditAccount.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(58, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(115, 15);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Text = "Ahmed@gmail.com";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtName.Location = new System.Drawing.Point(57, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(68, 23);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "Ahmed";
            // 
            // ProfileImg
            // 
            this.ProfileImg.BackColor = System.Drawing.Color.Transparent;
            this.ProfileImg.Image = ((System.Drawing.Image)(resources.GetObject("ProfileImg.Image")));
            this.ProfileImg.Location = new System.Drawing.Point(16, 10);
            this.ProfileImg.Name = "ProfileImg";
            this.ProfileImg.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProfileImg.ShadowDecoration.Parent = this.ProfileImg;
            this.ProfileImg.Size = new System.Drawing.Size(39, 40);
            this.ProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ProfileImg.TabIndex = 2;
            this.ProfileImg.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Animated = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnLogout.BorderRadius = 7;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.White;
            this.btnLogout.FillColor2 = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Rubik", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnLogout.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.MistyRose;
            this.btnLogout.HoverState.FillColor2 = System.Drawing.Color.Snow;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogout.Location = new System.Drawing.Point(251, 119);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedDepth = 0;
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(137, 49);
            this.btnLogout.TabIndex = 38;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextOffset = new System.Drawing.Point(8, 0);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(50, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Logout form your account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Logout";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.CaseSensitiveToggle);
            this.guna2GradientPanel1.Controls.Add(this.btnCaseSensitive);
            this.guna2GradientPanel1.Controls.Add(this.UndoFeatureToggle);
            this.guna2GradientPanel1.Controls.Add(this.btnUndoFeature);
            this.guna2GradientPanel1.Controls.Add(this.ActiveQuickAccountsToggle);
            this.guna2GradientPanel1.Controls.Add(this.btnActiveQuickAccounts);
            this.guna2GradientPanel1.Controls.Add(this.ActiveTrashToggle);
            this.guna2GradientPanel1.Controls.Add(this.btnActiveTrash);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(10, 84);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1158, 295);
            this.guna2GradientPanel1.TabIndex = 12;
            // 
            // CaseSensitiveToggle
            // 
            this.CaseSensitiveToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CaseSensitiveToggle.Animated = true;
            this.CaseSensitiveToggle.AutoRoundedCorners = true;
            this.CaseSensitiveToggle.BackColor = System.Drawing.Color.Transparent;
            this.CaseSensitiveToggle.CheckedState.BorderColor = System.Drawing.Color.White;
            this.CaseSensitiveToggle.CheckedState.BorderRadius = 14;
            this.CaseSensitiveToggle.CheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.CaseSensitiveToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.CaseSensitiveToggle.CheckedState.InnerBorderRadius = 10;
            this.CaseSensitiveToggle.CheckedState.InnerColor = System.Drawing.Color.MistyRose;
            this.CaseSensitiveToggle.CheckedState.Parent = this.CaseSensitiveToggle;
            this.CaseSensitiveToggle.Location = new System.Drawing.Point(1029, 170);
            this.CaseSensitiveToggle.Name = "CaseSensitiveToggle";
            this.CaseSensitiveToggle.ShadowDecoration.Parent = this.CaseSensitiveToggle;
            this.CaseSensitiveToggle.Size = new System.Drawing.Size(61, 30);
            this.CaseSensitiveToggle.TabIndex = 28;
            this.CaseSensitiveToggle.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.CaseSensitiveToggle.UncheckedState.BorderRadius = 14;
            this.CaseSensitiveToggle.UncheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.CaseSensitiveToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.CaseSensitiveToggle.UncheckedState.InnerBorderRadius = 10;
            this.CaseSensitiveToggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.CaseSensitiveToggle.UncheckedState.Parent = this.CaseSensitiveToggle;
            this.CaseSensitiveToggle.Click += new System.EventHandler(this.ToggleFeaturesItems);
            // 
            // btnCaseSensitive
            // 
            this.btnCaseSensitive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaseSensitive.Animated = true;
            this.btnCaseSensitive.BackColor = System.Drawing.Color.Transparent;
            this.btnCaseSensitive.BorderColor = System.Drawing.Color.LightGray;
            this.btnCaseSensitive.BorderRadius = 7;
            this.btnCaseSensitive.BorderThickness = 1;
            this.btnCaseSensitive.CheckedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnCaseSensitive.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnCaseSensitive.CheckedState.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnCaseSensitive.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnCaseSensitive.CheckedState.Image")));
            this.btnCaseSensitive.CheckedState.Parent = this.btnCaseSensitive;
            this.btnCaseSensitive.CustomImages.Parent = this.btnCaseSensitive;
            this.btnCaseSensitive.FillColor = System.Drawing.Color.Transparent;
            this.btnCaseSensitive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCaseSensitive.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCaseSensitive.HoverState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnCaseSensitive.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnCaseSensitive.HoverState.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnCaseSensitive.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnCaseSensitive.HoverState.Image")));
            this.btnCaseSensitive.HoverState.Parent = this.btnCaseSensitive;
            this.btnCaseSensitive.Image = ((System.Drawing.Image)(resources.GetObject("btnCaseSensitive.Image")));
            this.btnCaseSensitive.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCaseSensitive.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnCaseSensitive.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCaseSensitive.Location = new System.Drawing.Point(63, 153);
            this.btnCaseSensitive.Name = "btnCaseSensitive";
            this.btnCaseSensitive.ShadowDecoration.Parent = this.btnCaseSensitive;
            this.btnCaseSensitive.Size = new System.Drawing.Size(1040, 56);
            this.btnCaseSensitive.TabIndex = 27;
            this.btnCaseSensitive.Tag = "CaseSensitive";
            this.btnCaseSensitive.Text = "Make search case sensitive";
            this.btnCaseSensitive.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCaseSensitive.MouseEnter += new System.EventHandler(this.ShowExplainPopup);
            this.btnCaseSensitive.MouseLeave += new System.EventHandler(this.HideExplainPopup);
            // 
            // UndoFeatureToggle
            // 
            this.UndoFeatureToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UndoFeatureToggle.Animated = true;
            this.UndoFeatureToggle.AutoRoundedCorners = true;
            this.UndoFeatureToggle.BackColor = System.Drawing.Color.Transparent;
            this.UndoFeatureToggle.CheckedState.BorderColor = System.Drawing.Color.White;
            this.UndoFeatureToggle.CheckedState.BorderRadius = 14;
            this.UndoFeatureToggle.CheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.UndoFeatureToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.UndoFeatureToggle.CheckedState.InnerBorderRadius = 10;
            this.UndoFeatureToggle.CheckedState.InnerColor = System.Drawing.Color.MistyRose;
            this.UndoFeatureToggle.CheckedState.Parent = this.UndoFeatureToggle;
            this.UndoFeatureToggle.Location = new System.Drawing.Point(1029, 229);
            this.UndoFeatureToggle.Name = "UndoFeatureToggle";
            this.UndoFeatureToggle.ShadowDecoration.Parent = this.UndoFeatureToggle;
            this.UndoFeatureToggle.Size = new System.Drawing.Size(61, 30);
            this.UndoFeatureToggle.TabIndex = 26;
            this.UndoFeatureToggle.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.UndoFeatureToggle.UncheckedState.BorderRadius = 14;
            this.UndoFeatureToggle.UncheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.UndoFeatureToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.UndoFeatureToggle.UncheckedState.InnerBorderRadius = 10;
            this.UndoFeatureToggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.UndoFeatureToggle.UncheckedState.Parent = this.UndoFeatureToggle;
            this.UndoFeatureToggle.Click += new System.EventHandler(this.ToggleFeaturesItems);
            // 
            // btnUndoFeature
            // 
            this.btnUndoFeature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndoFeature.Animated = true;
            this.btnUndoFeature.BackColor = System.Drawing.Color.Transparent;
            this.btnUndoFeature.BorderColor = System.Drawing.Color.LightGray;
            this.btnUndoFeature.BorderRadius = 7;
            this.btnUndoFeature.BorderThickness = 1;
            this.btnUndoFeature.CheckedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnUndoFeature.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnUndoFeature.CheckedState.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnUndoFeature.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoFeature.CheckedState.Image")));
            this.btnUndoFeature.CheckedState.Parent = this.btnUndoFeature;
            this.btnUndoFeature.CustomImages.Parent = this.btnUndoFeature;
            this.btnUndoFeature.FillColor = System.Drawing.Color.Transparent;
            this.btnUndoFeature.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUndoFeature.ForeColor = System.Drawing.Color.DarkGray;
            this.btnUndoFeature.HoverState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnUndoFeature.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnUndoFeature.HoverState.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnUndoFeature.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoFeature.HoverState.Image")));
            this.btnUndoFeature.HoverState.Parent = this.btnUndoFeature;
            this.btnUndoFeature.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoFeature.Image")));
            this.btnUndoFeature.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUndoFeature.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnUndoFeature.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUndoFeature.Location = new System.Drawing.Point(63, 215);
            this.btnUndoFeature.Name = "btnUndoFeature";
            this.btnUndoFeature.ShadowDecoration.Parent = this.btnUndoFeature;
            this.btnUndoFeature.Size = new System.Drawing.Size(1040, 56);
            this.btnUndoFeature.TabIndex = 25;
            this.btnUndoFeature.Tag = "UndoFeature";
            this.btnUndoFeature.Text = "Turn on the \"Undo\" feature";
            this.btnUndoFeature.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUndoFeature.MouseEnter += new System.EventHandler(this.ShowExplainPopup);
            this.btnUndoFeature.MouseLeave += new System.EventHandler(this.HideExplainPopup);
            // 
            // ActiveQuickAccountsToggle
            // 
            this.ActiveQuickAccountsToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveQuickAccountsToggle.Animated = true;
            this.ActiveQuickAccountsToggle.AutoRoundedCorners = true;
            this.ActiveQuickAccountsToggle.BackColor = System.Drawing.Color.Transparent;
            this.ActiveQuickAccountsToggle.CheckedState.BorderColor = System.Drawing.Color.White;
            this.ActiveQuickAccountsToggle.CheckedState.BorderRadius = 14;
            this.ActiveQuickAccountsToggle.CheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.ActiveQuickAccountsToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ActiveQuickAccountsToggle.CheckedState.InnerBorderRadius = 10;
            this.ActiveQuickAccountsToggle.CheckedState.InnerColor = System.Drawing.Color.MistyRose;
            this.ActiveQuickAccountsToggle.CheckedState.Parent = this.ActiveQuickAccountsToggle;
            this.ActiveQuickAccountsToggle.Location = new System.Drawing.Point(1029, 102);
            this.ActiveQuickAccountsToggle.Name = "ActiveQuickAccountsToggle";
            this.ActiveQuickAccountsToggle.ShadowDecoration.Parent = this.ActiveQuickAccountsToggle;
            this.ActiveQuickAccountsToggle.Size = new System.Drawing.Size(61, 30);
            this.ActiveQuickAccountsToggle.TabIndex = 24;
            this.ActiveQuickAccountsToggle.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.ActiveQuickAccountsToggle.UncheckedState.BorderRadius = 14;
            this.ActiveQuickAccountsToggle.UncheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.ActiveQuickAccountsToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ActiveQuickAccountsToggle.UncheckedState.InnerBorderRadius = 10;
            this.ActiveQuickAccountsToggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ActiveQuickAccountsToggle.UncheckedState.Parent = this.ActiveQuickAccountsToggle;
            this.ActiveQuickAccountsToggle.Click += new System.EventHandler(this.ToggleFeaturesItems);
            // 
            // btnActiveQuickAccounts
            // 
            this.btnActiveQuickAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActiveQuickAccounts.Animated = true;
            this.btnActiveQuickAccounts.BackColor = System.Drawing.Color.Transparent;
            this.btnActiveQuickAccounts.BorderColor = System.Drawing.Color.LightGray;
            this.btnActiveQuickAccounts.BorderRadius = 7;
            this.btnActiveQuickAccounts.BorderThickness = 1;
            this.btnActiveQuickAccounts.CheckedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnActiveQuickAccounts.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnActiveQuickAccounts.CheckedState.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnActiveQuickAccounts.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnActiveQuickAccounts.CheckedState.Image")));
            this.btnActiveQuickAccounts.CheckedState.Parent = this.btnActiveQuickAccounts;
            this.btnActiveQuickAccounts.CustomImages.Parent = this.btnActiveQuickAccounts;
            this.btnActiveQuickAccounts.FillColor = System.Drawing.Color.Transparent;
            this.btnActiveQuickAccounts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActiveQuickAccounts.ForeColor = System.Drawing.Color.DarkGray;
            this.btnActiveQuickAccounts.HoverState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnActiveQuickAccounts.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnActiveQuickAccounts.HoverState.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnActiveQuickAccounts.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnActiveQuickAccounts.HoverState.Image")));
            this.btnActiveQuickAccounts.HoverState.Parent = this.btnActiveQuickAccounts;
            this.btnActiveQuickAccounts.Image = ((System.Drawing.Image)(resources.GetObject("btnActiveQuickAccounts.Image")));
            this.btnActiveQuickAccounts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnActiveQuickAccounts.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnActiveQuickAccounts.ImageSize = new System.Drawing.Size(25, 25);
            this.btnActiveQuickAccounts.Location = new System.Drawing.Point(653, 89);
            this.btnActiveQuickAccounts.Name = "btnActiveQuickAccounts";
            this.btnActiveQuickAccounts.ShadowDecoration.Parent = this.btnActiveQuickAccounts;
            this.btnActiveQuickAccounts.Size = new System.Drawing.Size(450, 56);
            this.btnActiveQuickAccounts.TabIndex = 23;
            this.btnActiveQuickAccounts.Tag = "QuickAccounts";
            this.btnActiveQuickAccounts.Text = "Active Quick Accounts";
            this.btnActiveQuickAccounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnActiveQuickAccounts.MouseEnter += new System.EventHandler(this.ShowExplainPopup);
            this.btnActiveQuickAccounts.MouseLeave += new System.EventHandler(this.HideExplainPopup);
            // 
            // ActiveTrashToggle
            // 
            this.ActiveTrashToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveTrashToggle.Animated = true;
            this.ActiveTrashToggle.AutoRoundedCorners = true;
            this.ActiveTrashToggle.BackColor = System.Drawing.Color.Transparent;
            this.ActiveTrashToggle.CheckedState.BorderColor = System.Drawing.Color.White;
            this.ActiveTrashToggle.CheckedState.BorderRadius = 14;
            this.ActiveTrashToggle.CheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.ActiveTrashToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ActiveTrashToggle.CheckedState.InnerBorderRadius = 10;
            this.ActiveTrashToggle.CheckedState.InnerColor = System.Drawing.Color.MistyRose;
            this.ActiveTrashToggle.CheckedState.Parent = this.ActiveTrashToggle;
            this.ActiveTrashToggle.Location = new System.Drawing.Point(575, 102);
            this.ActiveTrashToggle.Name = "ActiveTrashToggle";
            this.ActiveTrashToggle.ShadowDecoration.Parent = this.ActiveTrashToggle;
            this.ActiveTrashToggle.Size = new System.Drawing.Size(61, 30);
            this.ActiveTrashToggle.TabIndex = 22;
            this.ActiveTrashToggle.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.ActiveTrashToggle.UncheckedState.BorderRadius = 14;
            this.ActiveTrashToggle.UncheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.ActiveTrashToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ActiveTrashToggle.UncheckedState.InnerBorderRadius = 10;
            this.ActiveTrashToggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ActiveTrashToggle.UncheckedState.Parent = this.ActiveTrashToggle;
            this.ActiveTrashToggle.Click += new System.EventHandler(this.ToggleFeaturesItems);
            // 
            // btnActiveTrash
            // 
            this.btnActiveTrash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActiveTrash.Animated = true;
            this.btnActiveTrash.BackColor = System.Drawing.Color.Transparent;
            this.btnActiveTrash.BorderColor = System.Drawing.Color.LightGray;
            this.btnActiveTrash.BorderRadius = 7;
            this.btnActiveTrash.BorderThickness = 1;
            this.btnActiveTrash.CheckedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnActiveTrash.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnActiveTrash.CheckedState.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnActiveTrash.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnActiveTrash.CheckedState.Image")));
            this.btnActiveTrash.CheckedState.Parent = this.btnActiveTrash;
            this.btnActiveTrash.CustomImages.Parent = this.btnActiveTrash;
            this.btnActiveTrash.FillColor = System.Drawing.Color.Transparent;
            this.btnActiveTrash.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Bold);
            this.btnActiveTrash.ForeColor = System.Drawing.Color.DarkGray;
            this.btnActiveTrash.HoverState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnActiveTrash.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnActiveTrash.HoverState.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnActiveTrash.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnActiveTrash.HoverState.Image")));
            this.btnActiveTrash.HoverState.Parent = this.btnActiveTrash;
            this.btnActiveTrash.Image = ((System.Drawing.Image)(resources.GetObject("btnActiveTrash.Image")));
            this.btnActiveTrash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnActiveTrash.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnActiveTrash.ImageSize = new System.Drawing.Size(25, 25);
            this.btnActiveTrash.Location = new System.Drawing.Point(63, 89);
            this.btnActiveTrash.Name = "btnActiveTrash";
            this.btnActiveTrash.ShadowDecoration.Parent = this.btnActiveTrash;
            this.btnActiveTrash.Size = new System.Drawing.Size(584, 56);
            this.btnActiveTrash.TabIndex = 21;
            this.btnActiveTrash.Tag = "Trash";
            this.btnActiveTrash.Text = "Active Trash";
            this.btnActiveTrash.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnActiveTrash.MouseEnter += new System.EventHandler(this.ShowExplainPopup);
            this.btnActiveTrash.MouseLeave += new System.EventHandler(this.HideExplainPopup);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rubik", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 43);
            this.label1.TabIndex = 20;
            this.label1.Text = "Settings";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel2.BorderRadius = 20;
            this.guna2GradientPanel2.Controls.Add(this.btnDeleteAccount);
            this.guna2GradientPanel2.Controls.Add(this.label8);
            this.guna2GradientPanel2.Controls.Add(this.label7);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(10, 571);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(744, 180);
            this.guna2GradientPanel2.TabIndex = 13;
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel3.BorderRadius = 20;
            this.guna2GradientPanel3.Controls.Add(this.btnLogout);
            this.guna2GradientPanel3.Controls.Add(this.label2);
            this.guna2GradientPanel3.Controls.Add(this.label3);
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.guna2GradientPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel3.Location = new System.Drawing.Point(760, 571);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.ShadowDecoration.Parent = this.guna2GradientPanel3;
            this.guna2GradientPanel3.Size = new System.Drawing.Size(408, 180);
            this.guna2GradientPanel3.TabIndex = 14;
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel4.BorderRadius = 5;
            this.guna2GradientPanel4.Controls.Add(this.btnEditAccount);
            this.guna2GradientPanel4.Controls.Add(this.ProfileImg);
            this.guna2GradientPanel4.Controls.Add(this.txtEmail);
            this.guna2GradientPanel4.Controls.Add(this.txtName);
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.guna2GradientPanel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel4.Location = new System.Drawing.Point(10, 7);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.ShadowDecoration.Parent = this.guna2GradientPanel4;
            this.guna2GradientPanel4.Size = new System.Drawing.Size(1158, 61);
            this.guna2GradientPanel4.TabIndex = 15;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1176, 772);
            this.Controls.Add(this.guna2GradientPanel4);
            this.Controls.Add(this.guna2GradientPanel3);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProfile";
            this.Text = "frmProfile";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.guna2GradientPanel3.ResumeLayout(false);
            this.guna2GradientPanel3.PerformLayout();
            this.guna2GradientPanel4.ResumeLayout(false);
            this.guna2GradientPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditAccount;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ProfileImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteAccount;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch CaseSensitiveToggle;
        private Guna.UI2.WinForms.Guna2Button btnCaseSensitive;
        private Guna.UI2.WinForms.Guna2ToggleSwitch UndoFeatureToggle;
        private Guna.UI2.WinForms.Guna2Button btnUndoFeature;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ActiveQuickAccountsToggle;
        private Guna.UI2.WinForms.Guna2Button btnActiveQuickAccounts;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ActiveTrashToggle;
        private Guna.UI2.WinForms.Guna2Button btnActiveTrash;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogout;
    }
}