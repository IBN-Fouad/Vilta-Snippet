namespace Vilta_Snippet
{
    partial class frmChoseTags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoseTags));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TagsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddTag = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTilte = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.TagsContainer;
            // 
            // TagsContainer
            // 
            this.TagsContainer.AutoScroll = true;
            this.TagsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TagsContainer.Location = new System.Drawing.Point(35, 183);
            this.TagsContainer.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.TagsContainer.Name = "TagsContainer";
            this.TagsContainer.Padding = new System.Windows.Forms.Padding(20);
            this.TagsContainer.Size = new System.Drawing.Size(872, 481);
            this.TagsContainer.TabIndex = 27;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 20;
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(897, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(43, 42);
            this.btnClose.TabIndex = 32;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbSearch.Animated = true;
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BorderColor = System.Drawing.Color.White;
            this.tbSearch.BorderRadius = 10;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.Parent = this.tbSearch;
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbSearch.FocusedState.Parent = this.tbSearch;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbSearch.HoverState.Parent = this.tbSearch;
            this.tbSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbSearch.IconLeft")));
            this.tbSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.tbSearch.Location = new System.Drawing.Point(35, 125);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.tbSearch.PlaceholderText = "Search a tag...";
            this.tbSearch.SelectedText = "";
            this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
            this.tbSearch.Size = new System.Drawing.Size(697, 50);
            this.tbSearch.TabIndex = 33;
            this.tbSearch.TextOffset = new System.Drawing.Point(5, -2);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.IconLeftClick += new System.EventHandler(this.tbSearch_IconLeftClick);
            // 
            // btnAddTag
            // 
            this.btnAddTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTag.Animated = true;
            this.btnAddTag.BorderColor = System.Drawing.Color.White;
            this.btnAddTag.BorderRadius = 10;
            this.btnAddTag.BorderThickness = 1;
            this.btnAddTag.CheckedState.Parent = this.btnAddTag;
            this.btnAddTag.CustomImages.Parent = this.btnAddTag;
            this.btnAddTag.FillColor = System.Drawing.Color.MistyRose;
            this.btnAddTag.FillColor2 = System.Drawing.Color.MistyRose;
            this.btnAddTag.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddTag.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnAddTag.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAddTag.HoverState.FillColor = System.Drawing.Color.MistyRose;
            this.btnAddTag.HoverState.FillColor2 = System.Drawing.Color.Snow;
            this.btnAddTag.HoverState.Parent = this.btnAddTag;
            this.btnAddTag.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTag.Image")));
            this.btnAddTag.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btnAddTag.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddTag.Location = new System.Drawing.Point(740, 125);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.ShadowDecoration.Parent = this.btnAddTag;
            this.btnAddTag.Size = new System.Drawing.Size(167, 50);
            this.btnAddTag.TabIndex = 34;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.TextOffset = new System.Drawing.Point(-3, 0);
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // txtTilte
            // 
            this.txtTilte.AutoSize = true;
            this.txtTilte.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtTilte.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtTilte.Location = new System.Drawing.Point(56, 24);
            this.txtTilte.Name = "txtTilte";
            this.txtTilte.Size = new System.Drawing.Size(65, 32);
            this.txtTilte.TabIndex = 36;
            this.txtTilte.Text = "Tags";
            this.txtTilte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // frmChoseTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 676);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTilte);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.TagsContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChoseTags";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChoseTags";
            this.Load += new System.EventHandler(this.frmChoseTags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel TagsContainer;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddTag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtTilte;
    }
}