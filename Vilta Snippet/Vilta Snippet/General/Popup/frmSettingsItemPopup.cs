using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vilta_Snippet.General.Popup
{
    public partial class frmSettingsItemPopup : Form
    {
        public frmSettingsItemPopup(string ExplainMessage)
        {
            InitializeComponent();
            txtExplainMessage.Text = ExplainMessage;
        }

        private void frmSettingsItemPopup_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Control.MousePosition.X + 10, Control.MousePosition.Y + 15);
        }
    }
}
