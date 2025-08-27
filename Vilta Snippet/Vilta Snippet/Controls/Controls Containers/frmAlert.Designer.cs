namespace Vilta_Snippet
{
    partial class frmAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlert));
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.AnimationTimer_Inner = new System.Windows.Forms.Timer(this.components);
            this.AnimationTimer_Closer = new System.Windows.Forms.Timer(this.components);
            this.txtMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this;
            // 
            // AnimationTimer_Inner
            // 
            this.AnimationTimer_Inner.Interval = 10;
            this.AnimationTimer_Inner.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // AnimationTimer_Closer
            // 
            this.AnimationTimer_Closer.Tick += new System.EventHandler(this.AnimationTimer_Closer_Tick);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.txtMessage.Location = new System.Drawing.Point(12, 0);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(541, 47);
            this.txtMessage.TabIndex = 23;
            this.txtMessage.Text = "The Message";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(552, 47);
            this.Controls.Add(this.txtMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlert";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmAlert";
            this.Load += new System.EventHandler(this.frmAlert_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Timer AnimationTimer_Inner;
        private System.Windows.Forms.Timer AnimationTimer_Closer;
        private System.Windows.Forms.Label txtMessage;
    }
}