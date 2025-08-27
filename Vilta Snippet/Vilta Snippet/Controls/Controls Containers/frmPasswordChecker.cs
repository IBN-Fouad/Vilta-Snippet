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
    public partial class frmPasswordChecker : Form
    {
        private int _CloseTime = 70;
        private bool NormalMode;

        public frmPasswordChecker(string Password, bool IsNormalMode = true)
        {
            InitializeComponent();
            ctrlPasswordCheker.CheckPasswordConditions(Password);
            NormalMode = IsNormalMode;
        }

        private void frmPasswordCheker_Load(object sender, EventArgs e)
        {
            if(NormalMode)
                this.Location = new Point(1026, 409);
            else
                this.Location = new Point(1046, 479);

            this.TopMost = true;
            AnimationTimer_Inner.Start();
        }

        private void AnimationTimer_Inner_Tick(object sender, EventArgs e)
        {
            _CloseTime--;

            if (this.Opacity != 1.0)
                this.Opacity += 0.05;
            else
                AnimationTimer_Inner.Stop();
        }

        private void AnimationTimer_Closer_Tick(object sender, EventArgs e)
        {
            if (_CloseTime != 0)
            {
                this.Opacity -= 0.05;
                _CloseTime--;
            }
            else
            {
                AnimationTimer_Closer.Stop();
                this.Close();
            }
        }
    }
}
