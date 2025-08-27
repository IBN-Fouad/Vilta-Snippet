using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vilta_Snippet.Controls
{
    public partial class ctrlEmptyMessage : UserControl
    {
        public ctrlEmptyMessage()
        {
            InitializeComponent();
        }

        public void ActiveMiniMode()
        {
            this.Size = new System.Drawing.Size(357, 332);

            EmptyMegImg.Size       = new System.Drawing.Size(145, 90);
            txtSecondText.Location = new Point(-80, (EmptyMegImg.Bottom + 25));
            txtSecondText.BringToFront();
        }
    }
}
