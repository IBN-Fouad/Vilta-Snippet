namespace Vilta_Snippet.Controls
{
    partial class ctrlCopyBtn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlCopyBtn));
            this.btnCopy = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CopyAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Animated = true;
            this.btnCopy.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnCopy.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCopy.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.CheckedState.Image")));
            this.btnCopy.CheckedState.Parent = this.btnCopy;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.CustomImages.Parent = this.btnCopy;
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopy.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.HoverState.Parent = this.btnCopy;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCopy.Location = new System.Drawing.Point(0, 0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ShadowDecoration.Parent = this.btnCopy;
            this.btnCopy.Size = new System.Drawing.Size(51, 47);
            this.btnCopy.TabIndex = 41;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // CopyAnimationTimer
            // 
            this.CopyAnimationTimer.Tick += new System.EventHandler(this.CopyAnimationTimer_Tick);
            // 
            // ctrlCopyBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCopy);
            this.Name = "ctrlCopyBtn";
            this.Size = new System.Drawing.Size(51, 47);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCopy;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer CopyAnimationTimer;
    }
}
