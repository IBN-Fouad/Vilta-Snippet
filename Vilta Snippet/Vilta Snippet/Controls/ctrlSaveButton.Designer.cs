namespace Vilta_Snippet.Controls
{
    partial class ctrlSaveButton
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
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.LoaderTimer = new System.Windows.Forms.Timer(this.components);
            this.Loader = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Animated = true;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 1;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.MistyRose;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.MistyRose;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(30, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedColor = System.Drawing.Color.FloralWhite;
            this.btnSave.PressedDepth = 10;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(130, 48);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Animated = true;
            this.btnClose.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnClose.BorderRadius = 10;
            this.btnClose.BorderThickness = 1;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnClose.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.RosyBrown;
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(30, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(130, 48);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LoaderTimer
            // 
            this.LoaderTimer.Interval = 1000;
            this.LoaderTimer.Tick += new System.EventHandler(this.LoaderTimer_Tick);
            // 
            // Loader
            // 
            this.Loader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Loader.BackColor = System.Drawing.Color.MistyRose;
            this.Loader.CircleSize = 1F;
            this.Loader.Location = new System.Drawing.Point(115, 21);
            this.Loader.Name = "Loader";
            this.Loader.ProgressColor = System.Drawing.Color.RosyBrown;
            this.Loader.Size = new System.Drawing.Size(30, 30);
            this.Loader.TabIndex = 26;
            this.Loader.Visible = false;
            // 
            // ctrlSaveButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Loader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Name = "ctrlSaveButton";
            this.Size = new System.Drawing.Size(195, 75);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer LoaderTimer;
        private Guna.UI2.WinForms.Guna2ProgressIndicator Loader;
        public Guna.UI2.WinForms.Guna2Button btnClose;
        public Guna.UI2.WinForms.Guna2Button btnSave;
    }
}
