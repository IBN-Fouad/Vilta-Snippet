namespace Vilta_Snippet.General.Popup
{
    partial class frmSettingsItemPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingsItemPopup));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtExplainMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtExplainMessage
            // 
            this.txtExplainMessage.BackColor = System.Drawing.Color.Transparent;
            this.txtExplainMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExplainMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtExplainMessage.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtExplainMessage.Location = new System.Drawing.Point(0, 0);
            this.txtExplainMessage.Name = "txtExplainMessage";
            this.txtExplainMessage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.txtExplainMessage.Size = new System.Drawing.Size(474, 74);
            this.txtExplainMessage.TabIndex = 6;
            this.txtExplainMessage.Text = "Explain Message";
            // 
            // frmSettingsItemPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(474, 74);
            this.Controls.Add(this.txtExplainMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettingsItemPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmPeakPopup";
            this.Load += new System.EventHandler(this.frmSettingsItemPopup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label txtExplainMessage;
    }
}