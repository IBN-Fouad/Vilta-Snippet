namespace Vilta_Snippet.Controls
{
    partial class ctrlTag
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
            this.btnTag = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // btnTag
            // 
            this.btnTag.Animated = true;
            this.btnTag.BackColor = System.Drawing.Color.White;
            this.btnTag.BorderColor = System.Drawing.Color.White;
            this.btnTag.BorderRadius = 5;
            this.btnTag.BorderThickness = 1;
            this.btnTag.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTag.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnTag.CheckedState.FillColor = System.Drawing.Color.Crimson;
            this.btnTag.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTag.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTag.CheckedState.Parent = this.btnTag;
            this.btnTag.CustomImages.Parent = this.btnTag;
            this.btnTag.FillColor = System.Drawing.Color.White;
            this.btnTag.FillColor2 = System.Drawing.Color.White;
            this.btnTag.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTag.ForeColor = System.Drawing.Color.Gray;
            this.btnTag.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.btnTag.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTag.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btnTag.HoverState.ForeColor = System.Drawing.Color.Crimson;
            this.btnTag.HoverState.Parent = this.btnTag;
            this.btnTag.Location = new System.Drawing.Point(3, 6);
            this.btnTag.Margin = new System.Windows.Forms.Padding(0);
            this.btnTag.Name = "btnTag";
            this.btnTag.ShadowDecoration.Parent = this.btnTag;
            this.btnTag.Size = new System.Drawing.Size(99, 40);
            this.btnTag.TabIndex = 0;
            this.btnTag.Text = "Tag Name";
            // 
            // ctrlTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnTag);
            this.Name = "ctrlTag";
            this.Size = new System.Drawing.Size(111, 51);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2GradientButton btnTag;
    }
}
