using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vilta_Snippet.General.General_Forms
{
    public partial class frmUndoAlert : Form
    {
        int AppearCounter = 0;

        public delegate void UndoEventHandler(bool Undo = false);
        public UndoEventHandler Undo;

        public frmUndoAlert(string Message)
        {
            InitializeComponent();
            txtMessage.Text = Message;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Undo?.Invoke(true);
            InnerTimer.Stop();
            CloserTimer.Start();

            frmAlert Alert = new frmAlert("The snippet has been retrieved successfully !", false);
            Alert.Show();
        }

        private void frmUndoAlert_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - ((Screen.PrimaryScreen.WorkingArea.Width / 2) + 150)), 50);
            this.TopMost = true;

            InnerTimer.Start();
        }

        private void InnerTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity != 1)
            {
                this.Opacity += 0.2;
            }
            else if (AppearCounter == 100)
            {
                InnerTimer.Stop();
                CloserTimer.Start();
            }

            AppearCounter++;
        }

        private void CloserTimer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.2;

            if (this.Opacity == 0)
            {
                CloserTimer.Stop();
                this.Close();
            }
        }
    }
}
