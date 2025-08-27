namespace Vilta_Snippet
{
    partial class ProfileImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileImage));
            this.btnDeleteImage = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ProfileImg = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Animated = true;
            this.btnDeleteImage.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteImage.CheckedState.Parent = this.btnDeleteImage;
            this.btnDeleteImage.CustomImages.Parent = this.btnDeleteImage;
            this.btnDeleteImage.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteImage.ForeColor = System.Drawing.Color.White;
            this.btnDeleteImage.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteImage.HoverState.Parent = this.btnDeleteImage;
            this.btnDeleteImage.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteImage.Image")));
            this.btnDeleteImage.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteImage.Location = new System.Drawing.Point(128, 21);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteImage.ShadowDecoration.Color = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDeleteImage.ShadowDecoration.Parent = this.btnDeleteImage;
            this.btnDeleteImage.Size = new System.Drawing.Size(39, 38);
            this.btnDeleteImage.TabIndex = 25;
            this.btnDeleteImage.Click += new System.EventHandler(this.DeleteImage);
            // 
            // ProfileImg
            // 
            this.ProfileImg.Image = ((System.Drawing.Image)(resources.GetObject("ProfileImg.Image")));
            this.ProfileImg.Location = new System.Drawing.Point(23, 12);
            this.ProfileImg.Name = "ProfileImg";
            this.ProfileImg.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProfileImg.ShadowDecoration.Parent = this.ProfileImg;
            this.ProfileImg.Size = new System.Drawing.Size(125, 127);
            this.ProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ProfileImg.TabIndex = 24;
            this.ProfileImg.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 100;
            this.guna2Elipse1.TargetControl = this.btnDeleteImage;
            // 
            // ProfileImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.ProfileImg);
            this.Name = "ProfileImage";
            this.Size = new System.Drawing.Size(173, 164);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnDeleteImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ProfileImg;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
