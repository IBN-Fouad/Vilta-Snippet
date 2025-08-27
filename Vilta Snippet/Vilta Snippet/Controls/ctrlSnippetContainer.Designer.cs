namespace Vilta_Snippet.Controls
{
    partial class ctrlSnippetContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlSnippetContainer));
            this.txtTilte = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.TagsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.CodeEditor = new System.Windows.Forms.RichTextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CodeEditorContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.txtLanguage = new System.Windows.Forms.Label();
            this.LanguageImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnFavorite = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.btnMoveFromTrash = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlCopyBtn1 = new Vilta_Snippet.Controls.ctrlCopyBtn();
            this.CodeEditorContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTilte
            // 
            this.txtTilte.AutoSize = true;
            this.txtTilte.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtTilte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTilte.Location = new System.Drawing.Point(14, 26);
            this.txtTilte.Name = "txtTilte";
            this.txtTilte.Size = new System.Drawing.Size(137, 37);
            this.txtTilte.TabIndex = 12;
            this.txtTilte.Text = "Title Text";
            this.txtTilte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.txtDate.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDate.Location = new System.Drawing.Point(18, 79);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(37, 15);
            this.txtDate.TabIndex = 13;
            this.txtDate.Text = "Apr 2";
            this.txtDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TagsContainer
            // 
            this.TagsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TagsContainer.Location = new System.Drawing.Point(10, 97);
            this.TagsContainer.Name = "TagsContainer";
            this.TagsContainer.Size = new System.Drawing.Size(394, 61);
            this.TagsContainer.TabIndex = 14;
            // 
            // CodeEditor
            // 
            this.CodeEditor.AcceptsTab = true;
            this.CodeEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeEditor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CodeEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeEditor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CodeEditor.ForeColor = System.Drawing.Color.Silver;
            this.CodeEditor.Location = new System.Drawing.Point(8, 12);
            this.CodeEditor.Name = "CodeEditor";
            this.CodeEditor.ReadOnly = true;
            this.CodeEditor.Size = new System.Drawing.Size(378, 222);
            this.CodeEditor.TabIndex = 16;
            this.CodeEditor.Text = "";
            this.CodeEditor.WordWrap = false;
            this.CodeEditor.TextChanged += new System.EventHandler(this.CodeEditor_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.CodeEditorContainer;
            // 
            // CodeEditorContainer
            // 
            this.CodeEditorContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeEditorContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CodeEditorContainer.Controls.Add(this.CodeEditor);
            this.CodeEditorContainer.Location = new System.Drawing.Point(20, 357);
            this.CodeEditorContainer.Name = "CodeEditorContainer";
            this.CodeEditorContainer.ShadowDecoration.Parent = this.CodeEditorContainer;
            this.CodeEditorContainer.Size = new System.Drawing.Size(394, 237);
            this.CodeEditorContainer.TabIndex = 20;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLanguage.AutoSize = true;
            this.txtLanguage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtLanguage.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLanguage.Location = new System.Drawing.Point(56, 612);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(62, 20);
            this.txtLanguage.TabIndex = 17;
            this.txtLanguage.Text = "C Sharp";
            this.txtLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LanguageImage
            // 
            this.LanguageImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LanguageImage.Image = ((System.Drawing.Image)(resources.GetObject("LanguageImage.Image")));
            this.LanguageImage.Location = new System.Drawing.Point(21, 607);
            this.LanguageImage.Name = "LanguageImage";
            this.LanguageImage.ShadowDecoration.Parent = this.LanguageImage;
            this.LanguageImage.Size = new System.Drawing.Size(34, 32);
            this.LanguageImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LanguageImage.TabIndex = 18;
            this.LanguageImage.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Animated = true;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnDelete.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.CheckedState.Image")));
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.HoverState.Image")));
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(371, 600);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(43, 42);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFavorite.Animated = true;
            this.btnFavorite.BorderRadius = 20;
            this.btnFavorite.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnFavorite.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnFavorite.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnFavorite.CheckedState.Image")));
            this.btnFavorite.CheckedState.Parent = this.btnFavorite;
            this.btnFavorite.CustomImages.Parent = this.btnFavorite;
            this.btnFavorite.FillColor = System.Drawing.Color.White;
            this.btnFavorite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFavorite.ForeColor = System.Drawing.Color.White;
            this.btnFavorite.HoverState.FillColor = System.Drawing.Color.White;
            this.btnFavorite.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnFavorite.HoverState.Image")));
            this.btnFavorite.HoverState.Parent = this.btnFavorite;
            this.btnFavorite.Image = ((System.Drawing.Image)(resources.GetObject("btnFavorite.Image")));
            this.btnFavorite.Location = new System.Drawing.Point(375, 25);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.ShadowDecoration.Parent = this.btnFavorite;
            this.btnFavorite.Size = new System.Drawing.Size(43, 42);
            this.btnFavorite.TabIndex = 21;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Animated = true;
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnEdit.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEdit.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.CheckedState.Image")));
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.HoverState.Image")));
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(328, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(43, 42);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.AcceptsTab = true;
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.BackColor = System.Drawing.Color.White;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbDescription.Location = new System.Drawing.Point(21, 172);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbDescription.Size = new System.Drawing.Size(394, 126);
            this.tbDescription.TabIndex = 27;
            this.tbDescription.Tag = "";
            this.tbDescription.Text = "";
            // 
            // btnMoveFromTrash
            // 
            this.btnMoveFromTrash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveFromTrash.Animated = true;
            this.btnMoveFromTrash.BorderRadius = 20;
            this.btnMoveFromTrash.CheckedState.Parent = this.btnMoveFromTrash;
            this.btnMoveFromTrash.CustomImages.Parent = this.btnMoveFromTrash;
            this.btnMoveFromTrash.FillColor = System.Drawing.Color.White;
            this.btnMoveFromTrash.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMoveFromTrash.ForeColor = System.Drawing.Color.White;
            this.btnMoveFromTrash.HoverState.FillColor = System.Drawing.Color.White;
            this.btnMoveFromTrash.HoverState.Parent = this.btnMoveFromTrash;
            this.btnMoveFromTrash.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveFromTrash.Image")));
            this.btnMoveFromTrash.Location = new System.Drawing.Point(332, 600);
            this.btnMoveFromTrash.Name = "btnMoveFromTrash";
            this.btnMoveFromTrash.ShadowDecoration.Parent = this.btnMoveFromTrash;
            this.btnMoveFromTrash.Size = new System.Drawing.Size(43, 42);
            this.btnMoveFromTrash.TabIndex = 28;
            this.btnMoveFromTrash.Visible = false;
            this.btnMoveFromTrash.Click += new System.EventHandler(this.btnMoveFromTrash_Click);
            // 
            // ctrlCopyBtn1
            // 
            this.ctrlCopyBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCopyBtn1.Location = new System.Drawing.Point(363, 304);
            this.ctrlCopyBtn1.Name = "ctrlCopyBtn1";
            this.ctrlCopyBtn1.Size = new System.Drawing.Size(51, 47);
            this.ctrlCopyBtn1.TabIndex = 43;
            // 
            // ctrlSnippetContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlCopyBtn1);
            this.Controls.Add(this.btnMoveFromTrash);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.CodeEditorContainer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.LanguageImage);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.TagsContainer);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTilte);
            this.Name = "ctrlSnippetContainer";
            this.Size = new System.Drawing.Size(439, 651);
            this.Load += new System.EventHandler(this.ctrlSnippetContainer_Load);
            this.MouseEnter += new System.EventHandler(this.ctrlSnippetContainer_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ctrlSnippetContainer_MouseLeave);
            this.CodeEditorContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LanguageImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label txtTilte;
        private System.Windows.Forms.FlowLayoutPanel TagsContainer;
        private System.Windows.Forms.RichTextBox CodeEditor;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2PictureBox LanguageImage;
        private System.Windows.Forms.Label txtLanguage;
        private Guna.UI2.WinForms.Guna2Panel CodeEditorContainer;
        private Guna.UI2.WinForms.Guna2Button btnFavorite;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.RichTextBox tbDescription;
        private Guna.UI2.WinForms.Guna2Button btnMoveFromTrash;
        private ctrlCopyBtn ctrlCopyBtn1;
    }
}
