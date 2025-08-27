namespace Vilta_Snippet.Controls
{
    partial class ctrlLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlLanguage));
            this.Language = new Guna.UI2.WinForms.Guna2Button();
            this.txtSnippetsCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Language
            // 
            this.Language.CheckedState.BorderColor = System.Drawing.Color.White;
            this.Language.CheckedState.FillColor = System.Drawing.Color.White;
            this.Language.CheckedState.Parent = this.Language;
            this.Language.CustomImages.Parent = this.Language;
            this.Language.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Language.FillColor = System.Drawing.Color.White;
            this.Language.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Language.ForeColor = System.Drawing.Color.Silver;
            this.Language.HoverState.BorderColor = System.Drawing.Color.White;
            this.Language.HoverState.FillColor = System.Drawing.Color.White;
            this.Language.HoverState.Parent = this.Language;
            this.Language.Image = ((System.Drawing.Image)(resources.GetObject("Language.Image")));
            this.Language.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Language.ImageSize = new System.Drawing.Size(25, 25);
            this.Language.Location = new System.Drawing.Point(0, 0);
            this.Language.Name = "Language";
            this.Language.PressedDepth = 0;
            this.Language.ShadowDecoration.Parent = this.Language;
            this.Language.Size = new System.Drawing.Size(249, 45);
            this.Language.TabIndex = 0;
            this.Language.Text = "C#";
            this.Language.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Language.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // txtSnippetsCount
            // 
            this.txtSnippetsCount.AutoSize = true;
            this.txtSnippetsCount.BackColor = System.Drawing.Color.White;
            this.txtSnippetsCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtSnippetsCount.ForeColor = System.Drawing.Color.Silver;
            this.txtSnippetsCount.Location = new System.Drawing.Point(228, 13);
            this.txtSnippetsCount.Name = "txtSnippetsCount";
            this.txtSnippetsCount.Size = new System.Drawing.Size(18, 20);
            this.txtSnippetsCount.TabIndex = 21;
            this.txtSnippetsCount.Text = "0";
            // 
            // ctrlLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSnippetsCount);
            this.Controls.Add(this.Language);
            this.Name = "ctrlLanguage";
            this.Size = new System.Drawing.Size(249, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Language;
        private System.Windows.Forms.Label txtSnippetsCount;
    }
}
