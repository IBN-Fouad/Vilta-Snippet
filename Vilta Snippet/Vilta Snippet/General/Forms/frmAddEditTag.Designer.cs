namespace Vilta_Snippet.General_Forms
{
    partial class frmAddEditTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditTag));
            this.txtTilte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTagName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ctrlSaveButton = new Vilta_Snippet.Controls.ctrlSaveButton();
            this.SuspendLayout();
            // 
            // txtTilte
            // 
            this.txtTilte.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtTilte.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtTilte.Location = new System.Drawing.Point(23, 20);
            this.txtTilte.Name = "txtTilte";
            this.txtTilte.Size = new System.Drawing.Size(273, 37);
            this.txtTilte.TabIndex = 23;
            this.txtTilte.Text = "Add New Tag";
            this.txtTilte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(35, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tag Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTagName
            // 
            this.tbTagName.Animated = true;
            this.tbTagName.BorderRadius = 10;
            this.tbTagName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTagName.DefaultText = "";
            this.tbTagName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTagName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTagName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTagName.DisabledState.Parent = this.tbTagName;
            this.tbTagName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTagName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTagName.FocusedState.Parent = this.tbTagName;
            this.tbTagName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tbTagName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbTagName.HoverState.Parent = this.tbTagName;
            this.tbTagName.Location = new System.Drawing.Point(40, 129);
            this.tbTagName.Margin = new System.Windows.Forms.Padding(4);
            this.tbTagName.Name = "tbTagName";
            this.tbTagName.PasswordChar = '\0';
            this.tbTagName.PlaceholderText = "e.g : Loops";
            this.tbTagName.SelectedText = "";
            this.tbTagName.ShadowDecoration.Parent = this.tbTagName;
            this.tbTagName.Size = new System.Drawing.Size(491, 53);
            this.tbTagName.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 20;
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(498, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(43, 42);
            this.btnClose.TabIndex = 33;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 13;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ctrlSaveButton
            // 
            this.ctrlSaveButton.BackColor = System.Drawing.Color.White;
            this.ctrlSaveButton.Location = new System.Drawing.Point(387, 207);
            this.ctrlSaveButton.Name = "ctrlSaveButton";
            this.ctrlSaveButton.Size = new System.Drawing.Size(154, 56);
            this.ctrlSaveButton.TabIndex = 26;
            // 
            // frmAddEditTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 275);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlSaveButton);
            this.Controls.Add(this.tbTagName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTilte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEditTag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewTag";
            this.Load += new System.EventHandler(this.frmAddNewTag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tbTagName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTilte;
        private Controls.ctrlSaveButton ctrlSaveButton;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}