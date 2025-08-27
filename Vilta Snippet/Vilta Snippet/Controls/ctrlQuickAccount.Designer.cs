namespace Vilta_Snippet.Controls
{
    partial class ctrlQuickAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlQuickAccount));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtUserName = new System.Windows.Forms.Label();
            this.ProfileImg = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.txtUserName);
            this.guna2GradientPanel1.Controls.Add(this.ProfileImg);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Gainsboro;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(18, 18);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(188, 180);
            this.guna2GradientPanel1.TabIndex = 3;
            this.guna2GradientPanel1.Click += new System.EventHandler(this.SendID);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13F, System.Drawing.FontStyle.Bold);
            this.txtUserName.ForeColor = System.Drawing.Color.Silver;
            this.txtUserName.Location = new System.Drawing.Point(3, 111);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(182, 23);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.Text = "Ahmed";
            this.txtUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtUserName.Click += new System.EventHandler(this.SendID);
            // 
            // ProfileImg
            // 
            this.ProfileImg.BackColor = System.Drawing.Color.Transparent;
            this.ProfileImg.Image = ((System.Drawing.Image)(resources.GetObject("ProfileImg.Image")));
            this.ProfileImg.Location = new System.Drawing.Point(49, 3);
            this.ProfileImg.Name = "ProfileImg";
            this.ProfileImg.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProfileImg.ShadowDecoration.Parent = this.ProfileImg;
            this.ProfileImg.Size = new System.Drawing.Size(87, 88);
            this.ProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ProfileImg.TabIndex = 6;
            this.ProfileImg.TabStop = false;
            this.ProfileImg.Click += new System.EventHandler(this.SendID);
            // 
            // ctrlQuickAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "ctrlQuickAccount";
            this.Size = new System.Drawing.Size(226, 215);
            this.Load += new System.EventHandler(this.ctrlQuickAccount_Load);
            this.Click += new System.EventHandler(this.SendID);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label txtUserName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ProfileImg;
    }
}
