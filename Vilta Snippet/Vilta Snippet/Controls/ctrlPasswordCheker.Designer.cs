namespace Vilta_Snippet
{
    partial class ctrlPasswordCheker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPasswordCheker));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtSymbols = new System.Windows.Forms.Label();
            this.SymbolsImg = new System.Windows.Forms.PictureBox();
            this.txtLowLetter = new System.Windows.Forms.Label();
            this.LowLetterImg = new System.Windows.Forms.PictureBox();
            this.txtCapLetter = new System.Windows.Forms.Label();
            this.CapLetterImg = new System.Windows.Forms.PictureBox();
            this.txtNumbers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumbersImg = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SymbolsImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowLetterImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapLetterImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumbersImg)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2Separator1);
            this.guna2GradientPanel1.Controls.Add(this.txtSymbols);
            this.guna2GradientPanel1.Controls.Add(this.SymbolsImg);
            this.guna2GradientPanel1.Controls.Add(this.txtLowLetter);
            this.guna2GradientPanel1.Controls.Add(this.LowLetterImg);
            this.guna2GradientPanel1.Controls.Add(this.txtCapLetter);
            this.guna2GradientPanel1.Controls.Add(this.CapLetterImg);
            this.guna2GradientPanel1.Controls.Add(this.txtNumbers);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.NumbersImg);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightGray;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Enabled = true;
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.guna2GradientPanel1.Size = new System.Drawing.Size(302, 323);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.Crimson;
            this.guna2Separator1.Location = new System.Drawing.Point(-9, 45);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(357, 10);
            this.guna2Separator1.TabIndex = 27;
            // 
            // txtSymbols
            // 
            this.txtSymbols.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSymbols.AutoSize = true;
            this.txtSymbols.BackColor = System.Drawing.Color.Transparent;
            this.txtSymbols.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtSymbols.ForeColor = System.Drawing.Color.Crimson;
            this.txtSymbols.Location = new System.Drawing.Point(54, 225);
            this.txtSymbols.Name = "txtSymbols";
            this.txtSymbols.Size = new System.Drawing.Size(138, 20);
            this.txtSymbols.TabIndex = 26;
            this.txtSymbols.Text = "At least 3 symbols";
            this.txtSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SymbolsImg
            // 
            this.SymbolsImg.BackColor = System.Drawing.Color.Transparent;
            this.SymbolsImg.Image = ((System.Drawing.Image)(resources.GetObject("SymbolsImg.Image")));
            this.SymbolsImg.Location = new System.Drawing.Point(25, 219);
            this.SymbolsImg.Name = "SymbolsImg";
            this.SymbolsImg.Size = new System.Drawing.Size(23, 36);
            this.SymbolsImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SymbolsImg.TabIndex = 25;
            this.SymbolsImg.TabStop = false;
            // 
            // txtLowLetter
            // 
            this.txtLowLetter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLowLetter.AutoSize = true;
            this.txtLowLetter.BackColor = System.Drawing.Color.Transparent;
            this.txtLowLetter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtLowLetter.ForeColor = System.Drawing.Color.Crimson;
            this.txtLowLetter.Location = new System.Drawing.Point(54, 180);
            this.txtLowLetter.Name = "txtLowLetter";
            this.txtLowLetter.Size = new System.Drawing.Size(208, 20);
            this.txtLowLetter.TabIndex = 24;
            this.txtLowLetter.Text = "At least one lowercase letter";
            this.txtLowLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LowLetterImg
            // 
            this.LowLetterImg.BackColor = System.Drawing.Color.Transparent;
            this.LowLetterImg.Image = ((System.Drawing.Image)(resources.GetObject("LowLetterImg.Image")));
            this.LowLetterImg.Location = new System.Drawing.Point(25, 174);
            this.LowLetterImg.Name = "LowLetterImg";
            this.LowLetterImg.Size = new System.Drawing.Size(23, 36);
            this.LowLetterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LowLetterImg.TabIndex = 23;
            this.LowLetterImg.TabStop = false;
            // 
            // txtCapLetter
            // 
            this.txtCapLetter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCapLetter.AutoSize = true;
            this.txtCapLetter.BackColor = System.Drawing.Color.Transparent;
            this.txtCapLetter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtCapLetter.ForeColor = System.Drawing.Color.Crimson;
            this.txtCapLetter.Location = new System.Drawing.Point(54, 135);
            this.txtCapLetter.Name = "txtCapLetter";
            this.txtCapLetter.Size = new System.Drawing.Size(185, 20);
            this.txtCapLetter.TabIndex = 22;
            this.txtCapLetter.Text = "At least one capital letter";
            this.txtCapLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CapLetterImg
            // 
            this.CapLetterImg.BackColor = System.Drawing.Color.Transparent;
            this.CapLetterImg.Image = ((System.Drawing.Image)(resources.GetObject("CapLetterImg.Image")));
            this.CapLetterImg.Location = new System.Drawing.Point(25, 129);
            this.CapLetterImg.Name = "CapLetterImg";
            this.CapLetterImg.Size = new System.Drawing.Size(23, 36);
            this.CapLetterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CapLetterImg.TabIndex = 21;
            this.CapLetterImg.TabStop = false;
            // 
            // txtNumbers
            // 
            this.txtNumbers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumbers.AutoSize = true;
            this.txtNumbers.BackColor = System.Drawing.Color.Transparent;
            this.txtNumbers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtNumbers.ForeColor = System.Drawing.Color.Crimson;
            this.txtNumbers.Location = new System.Drawing.Point(54, 90);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(142, 20);
            this.txtNumbers.TabIndex = 20;
            this.txtNumbers.Text = "At least 8 numbers";
            this.txtNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(19, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "You must follow the conditions";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumbersImg
            // 
            this.NumbersImg.BackColor = System.Drawing.Color.Transparent;
            this.NumbersImg.Image = ((System.Drawing.Image)(resources.GetObject("NumbersImg.Image")));
            this.NumbersImg.Location = new System.Drawing.Point(25, 84);
            this.NumbersImg.Name = "NumbersImg";
            this.NumbersImg.Size = new System.Drawing.Size(23, 36);
            this.NumbersImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NumbersImg.TabIndex = 18;
            this.NumbersImg.TabStop = false;
            // 
            // ctrlPasswordCheker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "ctrlPasswordCheker";
            this.Size = new System.Drawing.Size(302, 323);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SymbolsImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowLetterImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapLetterImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumbersImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label txtNumbers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox NumbersImg;
        private System.Windows.Forms.Label txtSymbols;
        private System.Windows.Forms.PictureBox SymbolsImg;
        private System.Windows.Forms.Label txtLowLetter;
        private System.Windows.Forms.PictureBox LowLetterImg;
        private System.Windows.Forms.Label txtCapLetter;
        private System.Windows.Forms.PictureBox CapLetterImg;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
