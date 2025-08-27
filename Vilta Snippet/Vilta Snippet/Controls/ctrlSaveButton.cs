using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Vilta_Snippet.Controls
{
    public partial class ctrlSaveButton : UserControl
    {
        public delegate void SaveEventHandler();
        public event SaveEventHandler SaveEvent;

        public delegate void ChackEventHandler();
        public event ChackEventHandler Check;

        public delegate void SendCloseEventHandler();
        public event SendCloseEventHandler SendClose;

        private byte _LoaderTime = 0;

        public ctrlSaveButton()
        {
            InitializeComponent();
        }

        public void SetNormalUi()
        {
            btnSave.ForeColor            = Color.White;
            btnSave.FillColor            = Color.Crimson;
            btnSave.HoverState.FillColor = Color.Crimson;
            btnSave.PressedColor         = Color.Crimson;

            Loader.BackColor     = Color.Crimson;
            Loader.ProgressColor = Color.White;

            btnClose.ForeColor   = Color.Crimson;
            btnClose.FillColor   = Color.White;
            btnClose.BorderColor = Color.Crimson;

            btnClose.HoverState.ForeColor   = Color.White;
            btnClose.HoverState.FillColor   = Color.Crimson;
            btnClose.HoverState.BorderColor = Color.White;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.TextOffset = new System.Drawing.Point(-3, 0);

            Loader.Start();
            Loader.Visible = true;
            LoaderTimer.Start();

            Check?.Invoke();
        }

        private void LoaderTimer_Tick(object sender, EventArgs e)
        {
            if (_LoaderTime > 1)
            {
                Loader.Visible = false;
                Loader.Stop();

                btnSave.TextOffset = new System.Drawing.Point(0, 0);
                btnSave.Text = "Saved !";
            }
            
            if(_LoaderTime > 2)
            {
                btnSave.Visible = false;
                btnClose.Visible = true;

                LoaderTimer.Stop();
            }

            _LoaderTime++;
        }

        public void IsWrongData(bool Value)
        {
            if (Value)
            {
                Loader.Visible = false;
                Loader.Stop();
                LoaderTimer.Stop();
                btnSave.TextOffset = new System.Drawing.Point(0, 0);
            }
            else
            {
                SaveEvent?.Invoke();
            }

        }

        public void Reset()
        {
            btnSave.TextOffset = new System.Drawing.Point(0, 0);
            btnSave.Text = "Save";
            btnClose.Visible = false;
            btnSave.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SendClose?.Invoke();
        }
    }
}
