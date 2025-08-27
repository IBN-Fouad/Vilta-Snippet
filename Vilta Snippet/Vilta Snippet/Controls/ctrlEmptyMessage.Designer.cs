namespace Vilta_Snippet.Controls
{
    partial class ctrlEmptyMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlEmptyMessage));
            this.EmptyMegImg = new System.Windows.Forms.PictureBox();
            this.txtMainText = new System.Windows.Forms.Label();
            this.txtSecondText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmptyMegImg)).BeginInit();
            this.SuspendLayout();
            // 
            // EmptyMegImg
            // 
            this.EmptyMegImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmptyMegImg.Image = ((System.Drawing.Image)(resources.GetObject("EmptyMegImg.Image")));
            this.EmptyMegImg.Location = new System.Drawing.Point(100, 27);
            this.EmptyMegImg.Name = "EmptyMegImg";
            this.EmptyMegImg.Size = new System.Drawing.Size(337, 248);
            this.EmptyMegImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmptyMegImg.TabIndex = 0;
            this.EmptyMegImg.TabStop = false;
            // 
            // txtMainText
            // 
            this.txtMainText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMainText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtMainText.ForeColor = System.Drawing.Color.Gray;
            this.txtMainText.Location = new System.Drawing.Point(10, 297);
            this.txtMainText.Name = "txtMainText";
            this.txtMainText.Size = new System.Drawing.Size(522, 37);
            this.txtMainText.TabIndex = 23;
            this.txtMainText.Text = "Main Text";
            this.txtMainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSecondText
            // 
            this.txtSecondText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtSecondText.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSecondText.Location = new System.Drawing.Point(11, 334);
            this.txtSecondText.Name = "txtSecondText";
            this.txtSecondText.Size = new System.Drawing.Size(520, 49);
            this.txtSecondText.TabIndex = 24;
            this.txtSecondText.Text = "Mini Text";
            this.txtSecondText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ctrlEmptyMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSecondText);
            this.Controls.Add(this.txtMainText);
            this.Controls.Add(this.EmptyMegImg);
            this.Name = "ctrlEmptyMessage";
            this.Size = new System.Drawing.Size(542, 421);
            ((System.ComponentModel.ISupportInitialize)(this.EmptyMegImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox EmptyMegImg;
        public System.Windows.Forms.Label txtMainText;
        public System.Windows.Forms.Label txtSecondText;
    }
}
