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
    public partial class ctrlCopyBtn : UserControl
    {
        public delegate void CopyEventHandler();
        public CopyEventHandler Copy;

        private int _CopyTime = 10;

        public void SetText(string Text)
        {
            Clipboard.SetText(Text);
        }

        public ctrlCopyBtn()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Copy?.Invoke();
            CopyAnimationTimer.Start();
        }

        private void CopyAnimationTimer_Tick(object sender, EventArgs e)
        {
            if (_CopyTime == 0)
            {
                btnCopy.Checked = false;
                CopyAnimationTimer.Stop();
                _CopyTime = 10;
            }

            _CopyTime--;
        }
    }
}
