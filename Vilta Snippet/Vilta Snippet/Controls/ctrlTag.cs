using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vilta_Snippet.Controls
{
    public partial class ctrlTag : UserControl
    {
        public string TagName
        {
            get { return btnTag.Text; }
        }

        public bool CheckedTag
        {
            set { btnTag.Checked = value; }
        }

        public ctrlTag(string TagName)
        {
            InitializeComponent();
            btnTag.Text = TagName;
            ResizeTagButton();
        }

        private void ResizeTagButton()
        {
            using (Graphics graphics = btnTag.CreateGraphics())
            {
                SizeF TextSize = graphics.MeasureString(btnTag.Text, btnTag.Font);

                btnTag.Width = (int)TextSize.Width + 10 * 2;
                btnTag.Height = (int)TextSize.Height + 10 * 2;
                this.Size = new Size((btnTag.Width + 12), (btnTag.Height + 11));
            }
        }
    }
}
