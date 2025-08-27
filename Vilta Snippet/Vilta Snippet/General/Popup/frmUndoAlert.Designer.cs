namespace Vilta_Snippet.General.General_Forms
{
    partial class frmUndoAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUndoAlert));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtMessage = new System.Windows.Forms.Label();
            this.btnUndo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.InnerTimer = new System.Windows.Forms.Timer(this.components);
            this.CloserTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMessage.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtMessage.Location = new System.Drawing.Point(12, 8);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(371, 39);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "Do you want to undo the deletion ?";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.Animated = true;
            this.btnUndo.BorderColor = System.Drawing.Color.White;
            this.btnUndo.BorderRadius = 5;
            this.btnUndo.BorderThickness = 1;
            this.btnUndo.CheckedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnUndo.CheckedState.FillColor = System.Drawing.Color.MistyRose;
            this.btnUndo.CheckedState.FillColor2 = System.Drawing.Color.MistyRose;
            this.btnUndo.CheckedState.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnUndo.CheckedState.Parent = this.btnUndo;
            this.btnUndo.CustomImages.Parent = this.btnUndo;
            this.btnUndo.FillColor = System.Drawing.Color.MistyRose;
            this.btnUndo.FillColor2 = System.Drawing.Color.MistyRose;
            this.btnUndo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUndo.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnUndo.HoverState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnUndo.HoverState.FillColor = System.Drawing.Color.MistyRose;
            this.btnUndo.HoverState.FillColor2 = System.Drawing.Color.MistyRose;
            this.btnUndo.HoverState.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnUndo.HoverState.Parent = this.btnUndo;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnUndo.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUndo.Location = new System.Drawing.Point(389, 10);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ShadowDecoration.Parent = this.btnUndo;
            this.btnUndo.Size = new System.Drawing.Size(105, 39);
            this.btnUndo.TabIndex = 35;
            this.btnUndo.Text = "Undo";
            this.btnUndo.TextOffset = new System.Drawing.Point(-1, 0);
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // InnerTimer
            // 
            this.InnerTimer.Interval = 50;
            this.InnerTimer.Tick += new System.EventHandler(this.InnerTimer_Tick);
            // 
            // CloserTimer
            // 
            this.CloserTimer.Interval = 50;
            this.CloserTimer.Tick += new System.EventHandler(this.CloserTimer_Tick);
            // 
            // frmUndoAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(506, 60);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.txtMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUndoAlert";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmUndoAlert";
            this.Load += new System.EventHandler(this.frmUndoAlert_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label txtMessage;
        private Guna.UI2.WinForms.Guna2GradientButton btnUndo;
        private System.Windows.Forms.Timer InnerTimer;
        private System.Windows.Forms.Timer CloserTimer;
    }
}