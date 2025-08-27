using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vilta_Snippet
{
    public partial class ProfileImage : UserControl
    {
        public delegate void DeleteEventHandler(bool IsDeleted);
        public DeleteEventHandler DeleteEvent;
        public string ImgPath = "";

        public string GetImage
        {
            get { return ImgPath; }
        }

        public string SetImage
        {
            set { ImgPath = value; }
        }

        public ProfileImage(string Path)
        {
            InitializeComponent();
            ImgPath = Path;
            ProfileImg.Image = clsViltaUiFunctions.ReszieImage(0.3, 0.3, Image.FromFile(Path));
        }

        private void DeleteImage(object sender, EventArgs e)
        {
            Form parentform = this.FindForm();

            if (parentform != null)
            {
                DeleteEvent?.Invoke(true);
                parentform.Controls.Remove(this);
                this.Dispose();
            }
        }

        public void DisabledDeleting(bool value)
        {
            btnDeleteImage.Enabled = !value;
        }
    }
}
