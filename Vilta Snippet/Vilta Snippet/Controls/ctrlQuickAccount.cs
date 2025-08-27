using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Logic;

namespace Vilta_Snippet.Controls
{
    public partial class ctrlQuickAccount : UserControl
    {
        public delegate void SendUserIDEventHandler(int UserID);
        public SendUserIDEventHandler SendUserID;

        public ctrlQuickAccount(int UserID, string UserName, string ImgPath)
        {
            InitializeComponent();

            this.Tag = UserID;
            txtUserName.Text = UserName;
            ProfileImg.Image = Image.FromFile(ImgPath);
        }

        private void ctrlQuickAccount_Load(object sender, EventArgs e)
        {
            ProfileImg.Image = clsViltaUiFunctions.ReszieImage(0.3, 0.3, ProfileImg.Image);
        }

        private void SendID(object sender, EventArgs e)
        {
            if (int.TryParse(this.Tag.ToString(), out int ID)) SendUserID?.Invoke(ID);
        }
    }
}
