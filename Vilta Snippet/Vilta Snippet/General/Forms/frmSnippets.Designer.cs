namespace Vilta_Snippet
{
    partial class frmSnippets
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnippets));
            this.SnippetsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddSnippet = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TagsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.HeaderContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.ProfileImg = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.HeaderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).BeginInit();
            this.SuspendLayout();
            // 
            // SnippetsContainer
            // 
            this.SnippetsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SnippetsContainer.AutoScroll = true;
            this.SnippetsContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SnippetsContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SnippetsContainer.Location = new System.Drawing.Point(9, 152);
            this.SnippetsContainer.Name = "SnippetsContainer";
            this.SnippetsContainer.Size = new System.Drawing.Size(1001, 465);
            this.SnippetsContainer.TabIndex = 108;
            this.SnippetsContainer.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.SnippetsContainer_ControlRemoved);
            // 
            // btnAddSnippet
            // 
            this.btnAddSnippet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSnippet.Animated = true;
            this.btnAddSnippet.BorderColor = System.Drawing.Color.White;
            this.btnAddSnippet.BorderRadius = 8;
            this.btnAddSnippet.BorderThickness = 1;
            this.btnAddSnippet.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnAddSnippet.CheckedState.FillColor = System.Drawing.Color.Crimson;
            this.btnAddSnippet.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddSnippet.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAddSnippet.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSnippet.CheckedState.Image")));
            this.btnAddSnippet.CheckedState.Parent = this.btnAddSnippet;
            this.btnAddSnippet.CustomImages.Parent = this.btnAddSnippet;
            this.btnAddSnippet.FillColor = System.Drawing.Color.Crimson;
            this.btnAddSnippet.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddSnippet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddSnippet.ForeColor = System.Drawing.Color.White;
            this.btnAddSnippet.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.btnAddSnippet.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddSnippet.HoverState.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnAddSnippet.HoverState.ForeColor = System.Drawing.Color.Crimson;
            this.btnAddSnippet.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSnippet.HoverState.Image")));
            this.btnAddSnippet.HoverState.Parent = this.btnAddSnippet;
            this.btnAddSnippet.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSnippet.Image")));
            this.btnAddSnippet.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnAddSnippet.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddSnippet.Location = new System.Drawing.Point(853, 85);
            this.btnAddSnippet.Name = "btnAddSnippet";
            this.btnAddSnippet.ShadowDecoration.Parent = this.btnAddSnippet;
            this.btnAddSnippet.Size = new System.Drawing.Size(157, 61);
            this.btnAddSnippet.TabIndex = 8;
            this.btnAddSnippet.Text = "Add Snippet";
            this.btnAddSnippet.TextOffset = new System.Drawing.Point(-1, 0);
            this.btnAddSnippet.Click += new System.EventHandler(this.btnAddSnippet_Click);
            // 
            // TagsContainer
            // 
            this.TagsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TagsContainer.AutoScroll = true;
            this.TagsContainer.BackColor = System.Drawing.Color.White;
            this.TagsContainer.Location = new System.Drawing.Point(9, 85);
            this.TagsContainer.Name = "TagsContainer";
            this.TagsContainer.Size = new System.Drawing.Size(844, 61);
            this.TagsContainer.TabIndex = 7;
            // 
            // HeaderContainer
            // 
            this.HeaderContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderContainer.Controls.Add(this.tbSearch);
            this.HeaderContainer.Controls.Add(this.txtEmail);
            this.HeaderContainer.Controls.Add(this.txtName);
            this.HeaderContainer.Controls.Add(this.ProfileImg);
            this.HeaderContainer.FillColor = System.Drawing.Color.White;
            this.HeaderContainer.Location = new System.Drawing.Point(9, 8);
            this.HeaderContainer.Name = "HeaderContainer";
            this.HeaderContainer.ShadowDecoration.Parent = this.HeaderContainer;
            this.HeaderContainer.Size = new System.Drawing.Size(1001, 61);
            this.HeaderContainer.TabIndex = 6;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbSearch.Animated = true;
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BorderColor = System.Drawing.Color.White;
            this.tbSearch.BorderRadius = 20;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.Parent = this.tbSearch;
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbSearch.FocusedState.Parent = this.tbSearch;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbSearch.HoverState.Parent = this.tbSearch;
            this.tbSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbSearch.IconLeft")));
            this.tbSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.tbSearch.Location = new System.Drawing.Point(531, 9);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.tbSearch.PlaceholderText = "Search";
            this.tbSearch.SelectedText = "";
            this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
            this.tbSearch.Size = new System.Drawing.Size(449, 43);
            this.tbSearch.TabIndex = 109;
            this.tbSearch.TabStop = false;
            this.tbSearch.TextOffset = new System.Drawing.Point(5, 0);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.IconLeftClick += new System.EventHandler(this.tbSearch_IconLeftClick);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.BackColor = System.Drawing.Color.White;
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
            this.txtName.BackColor = System.Drawing.Color.White;
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
            this.ProfileImg.BackColor = System.Drawing.Color.White;
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
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 8;
            this.guna2Elipse2.TargetControl = this.TagsContainer;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this.HeaderContainer;
            // 
            // frmSnippets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1022, 629);
            this.Controls.Add(this.SnippetsContainer);
            this.Controls.Add(this.btnAddSnippet);
            this.Controls.Add(this.TagsContainer);
            this.Controls.Add(this.HeaderContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSnippets";
            this.Text = "frmSnippets";
            this.Load += new System.EventHandler(this.frmSnippets_Load);
            this.HeaderContainer.ResumeLayout(false);
            this.HeaderContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SnippetsContainer;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddSnippet;
        private System.Windows.Forms.FlowLayoutPanel TagsContainer;
        private Guna.UI2.WinForms.Guna2Panel HeaderContainer;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ProfileImg;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}