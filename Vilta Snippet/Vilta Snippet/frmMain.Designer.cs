namespace Vilta_Snippet
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LanguagesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTags = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTrash = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnFavorites = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAllSnippets = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SectionsContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LanguagesContainer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnTags);
            this.panel1.Controls.Add(this.btnTrash);
            this.panel1.Controls.Add(this.btnFavorites);
            this.panel1.Controls.Add(this.btnAllSnippets);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 747);
            this.panel1.TabIndex = 0;
            // 
            // LanguagesContainer
            // 
            this.LanguagesContainer.Location = new System.Drawing.Point(37, 555);
            this.LanguagesContainer.Name = "LanguagesContainer";
            this.LanguagesContainer.Size = new System.Drawing.Size(249, 189);
            this.LanguagesContainer.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(18, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Languages";
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BorderColor = System.Drawing.Color.White;
            this.btnLogout.BorderRadius = 5;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.Crimson;
            this.btnLogout.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.CheckedState.Image")));
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.White;
            this.btnLogout.FillColor2 = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogout.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogout.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.HoverState.Image")));
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageOffset = new System.Drawing.Point(-19, 0);
            this.btnLogout.Location = new System.Drawing.Point(37, 453);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(172, 40);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Tag = "Profile";
            this.btnLogout.Text = "Profile";
            this.btnLogout.TextOffset = new System.Drawing.Point(-15, 0);
            this.btnLogout.Click += new System.EventHandler(this.SwitchSections);
            // 
            // btnTags
            // 
            this.btnTags.Animated = true;
            this.btnTags.BorderColor = System.Drawing.Color.White;
            this.btnTags.BorderRadius = 5;
            this.btnTags.BorderThickness = 1;
            this.btnTags.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTags.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnTags.CheckedState.FillColor = System.Drawing.Color.Crimson;
            this.btnTags.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTags.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTags.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnTags.CheckedState.Image")));
            this.btnTags.CheckedState.Parent = this.btnTags;
            this.btnTags.CustomImages.Parent = this.btnTags;
            this.btnTags.FillColor = System.Drawing.Color.White;
            this.btnTags.FillColor2 = System.Drawing.Color.White;
            this.btnTags.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTags.ForeColor = System.Drawing.Color.DarkGray;
            this.btnTags.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.btnTags.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTags.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btnTags.HoverState.ForeColor = System.Drawing.Color.Crimson;
            this.btnTags.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnTags.HoverState.Image")));
            this.btnTags.HoverState.Parent = this.btnTags;
            this.btnTags.Image = ((System.Drawing.Image)(resources.GetObject("btnTags.Image")));
            this.btnTags.ImageOffset = new System.Drawing.Point(-23, 0);
            this.btnTags.Location = new System.Drawing.Point(37, 407);
            this.btnTags.Name = "btnTags";
            this.btnTags.ShadowDecoration.Parent = this.btnTags;
            this.btnTags.Size = new System.Drawing.Size(172, 40);
            this.btnTags.TabIndex = 10;
            this.btnTags.Tag = "Tags";
            this.btnTags.Text = "Tags";
            this.btnTags.TextOffset = new System.Drawing.Point(-19, 0);
            this.btnTags.Click += new System.EventHandler(this.SwitchSections);
            // 
            // btnTrash
            // 
            this.btnTrash.Animated = true;
            this.btnTrash.BorderColor = System.Drawing.Color.White;
            this.btnTrash.BorderRadius = 5;
            this.btnTrash.BorderThickness = 1;
            this.btnTrash.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTrash.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnTrash.CheckedState.FillColor = System.Drawing.Color.Crimson;
            this.btnTrash.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTrash.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTrash.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnTrash.CheckedState.Image")));
            this.btnTrash.CheckedState.Parent = this.btnTrash;
            this.btnTrash.CustomImages.Parent = this.btnTrash;
            this.btnTrash.FillColor = System.Drawing.Color.White;
            this.btnTrash.FillColor2 = System.Drawing.Color.White;
            this.btnTrash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTrash.ForeColor = System.Drawing.Color.DarkGray;
            this.btnTrash.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.btnTrash.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTrash.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btnTrash.HoverState.ForeColor = System.Drawing.Color.Crimson;
            this.btnTrash.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnTrash.HoverState.Image")));
            this.btnTrash.HoverState.Parent = this.btnTrash;
            this.btnTrash.Image = ((System.Drawing.Image)(resources.GetObject("btnTrash.Image")));
            this.btnTrash.ImageOffset = new System.Drawing.Point(-22, 0);
            this.btnTrash.Location = new System.Drawing.Point(37, 334);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.ShadowDecoration.Parent = this.btnTrash;
            this.btnTrash.Size = new System.Drawing.Size(172, 40);
            this.btnTrash.TabIndex = 9;
            this.btnTrash.Tag = "Trash";
            this.btnTrash.Text = "Trash";
            this.btnTrash.TextOffset = new System.Drawing.Point(-18, 0);
            this.btnTrash.Click += new System.EventHandler(this.SwitchSections);
            // 
            // btnFavorites
            // 
            this.btnFavorites.Animated = true;
            this.btnFavorites.BorderColor = System.Drawing.Color.White;
            this.btnFavorites.BorderRadius = 5;
            this.btnFavorites.BorderThickness = 1;
            this.btnFavorites.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFavorites.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnFavorites.CheckedState.FillColor = System.Drawing.Color.Crimson;
            this.btnFavorites.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFavorites.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnFavorites.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnFavorites.CheckedState.Image")));
            this.btnFavorites.CheckedState.Parent = this.btnFavorites;
            this.btnFavorites.CustomImages.Parent = this.btnFavorites;
            this.btnFavorites.FillColor = System.Drawing.Color.White;
            this.btnFavorites.FillColor2 = System.Drawing.Color.White;
            this.btnFavorites.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFavorites.ForeColor = System.Drawing.Color.DarkGray;
            this.btnFavorites.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.btnFavorites.HoverState.FillColor = System.Drawing.Color.White;
            this.btnFavorites.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btnFavorites.HoverState.ForeColor = System.Drawing.Color.Crimson;
            this.btnFavorites.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnFavorites.HoverState.Image")));
            this.btnFavorites.HoverState.Parent = this.btnFavorites;
            this.btnFavorites.Image = ((System.Drawing.Image)(resources.GetObject("btnFavorites.Image")));
            this.btnFavorites.ImageOffset = new System.Drawing.Point(-15, 0);
            this.btnFavorites.Location = new System.Drawing.Point(37, 288);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.ShadowDecoration.Parent = this.btnFavorites;
            this.btnFavorites.Size = new System.Drawing.Size(172, 40);
            this.btnFavorites.TabIndex = 8;
            this.btnFavorites.Tag = "Favorites";
            this.btnFavorites.Text = "Favorites";
            this.btnFavorites.TextOffset = new System.Drawing.Point(-12, 0);
            this.btnFavorites.Click += new System.EventHandler(this.SwitchSections);
            // 
            // btnAllSnippets
            // 
            this.btnAllSnippets.Animated = true;
            this.btnAllSnippets.BorderColor = System.Drawing.Color.White;
            this.btnAllSnippets.BorderRadius = 5;
            this.btnAllSnippets.BorderThickness = 1;
            this.btnAllSnippets.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllSnippets.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnAllSnippets.CheckedState.FillColor = System.Drawing.Color.Crimson;
            this.btnAllSnippets.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAllSnippets.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAllSnippets.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnAllSnippets.CheckedState.Image")));
            this.btnAllSnippets.CheckedState.Parent = this.btnAllSnippets;
            this.btnAllSnippets.CustomImages.Parent = this.btnAllSnippets;
            this.btnAllSnippets.FillColor = System.Drawing.Color.White;
            this.btnAllSnippets.FillColor2 = System.Drawing.Color.White;
            this.btnAllSnippets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAllSnippets.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAllSnippets.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.btnAllSnippets.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAllSnippets.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btnAllSnippets.HoverState.ForeColor = System.Drawing.Color.Crimson;
            this.btnAllSnippets.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnAllSnippets.HoverState.Image")));
            this.btnAllSnippets.HoverState.Parent = this.btnAllSnippets;
            this.btnAllSnippets.Image = ((System.Drawing.Image)(resources.GetObject("btnAllSnippets.Image")));
            this.btnAllSnippets.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnAllSnippets.Location = new System.Drawing.Point(37, 242);
            this.btnAllSnippets.Name = "btnAllSnippets";
            this.btnAllSnippets.ShadowDecoration.Parent = this.btnAllSnippets;
            this.btnAllSnippets.Size = new System.Drawing.Size(172, 40);
            this.btnAllSnippets.TabIndex = 1;
            this.btnAllSnippets.Tag = "All Snippets";
            this.btnAllSnippets.Text = "All Snippets";
            this.btnAllSnippets.TextOffset = new System.Drawing.Point(-7, 0);
            this.btnAllSnippets.Click += new System.EventHandler(this.SwitchSections);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(18, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quick Links";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(132, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Snippet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(80, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vilta";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(27, 27);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(60, 43);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 8;
            // 
            // SectionsContainer
            // 
            this.SectionsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionsContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SectionsContainer.Location = new System.Drawing.Point(295, 0);
            this.SectionsContainer.Name = "SectionsContainer";
            this.SectionsContainer.ShadowDecoration.Parent = this.SectionsContainer;
            this.SectionsContainer.Size = new System.Drawing.Size(1058, 747);
            this.SectionsContainer.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1357, 747);
            this.Controls.Add(this.SectionsContainer);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btnAllSnippets;
        private Guna.UI2.WinForms.Guna2GradientButton btnFavorites;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogout;
        private Guna.UI2.WinForms.Guna2GradientButton btnTags;
        private Guna.UI2.WinForms.Guna2GradientButton btnTrash;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel SectionsContainer;
        private System.Windows.Forms.FlowLayoutPanel LanguagesContainer;
    }
}