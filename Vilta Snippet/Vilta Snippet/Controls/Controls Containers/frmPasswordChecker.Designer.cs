namespace Vilta_Snippet.Controls
{
    partial class frmPasswordChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordChecker));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.AnimationTimer_Inner = new System.Windows.Forms.Timer(this.components);
            this.AnimationTimer_Closer = new System.Windows.Forms.Timer(this.components);
            this.ctrlPasswordCheker = new Vilta_Snippet.ctrlPasswordCheker();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // AnimationTimer_Inner
            // 
            this.AnimationTimer_Inner.Interval = 10;
            this.AnimationTimer_Inner.Tick += new System.EventHandler(this.AnimationTimer_Inner_Tick);
            // 
            // AnimationTimer_Closer
            // 
            this.AnimationTimer_Closer.Interval = 10;
            this.AnimationTimer_Closer.Tick += new System.EventHandler(this.AnimationTimer_Closer_Tick);
            // 
            // ctrlPasswordCheker
            // 
            this.ctrlPasswordCheker.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlPasswordCheker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPasswordCheker.Location = new System.Drawing.Point(0, 0);
            this.ctrlPasswordCheker.Name = "ctrlPasswordCheker";
            this.ctrlPasswordCheker.Size = new System.Drawing.Size(302, 323);
            this.ctrlPasswordCheker.TabIndex = 1;
            // 
            // frmPasswordChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(302, 323);
            this.Controls.Add(this.ctrlPasswordCheker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPasswordChecker";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmPasswordCheker_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer AnimationTimer_Inner;
        public System.Windows.Forms.Timer AnimationTimer_Closer;
        public ctrlPasswordCheker ctrlPasswordCheker;
    }
}