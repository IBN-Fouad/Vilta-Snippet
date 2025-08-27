using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Database_Access.Snippets;
using Vilta_Logic;
using Vilta_Snippet.Controls;
using Vilta_Snippet.General.Forms;
using static Guna.UI2.Native.WinApi;

namespace Vilta_Snippet
{
    public class clsViltaUiFunctions
    {
        public static frmQuickAccounts QuickAccountsPage;

        public static void TagUi(ref ctrlTag Tag)
        {
            Tag.btnTag.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            Tag.btnTag.ForeColor = Color.RosyBrown;
            Tag.btnTag.FillColor = Color.LavenderBlush;
            Tag.btnTag.FillColor2 = Color.MistyRose;

            Tag.btnTag.HoverState.FillColor = Color.MistyRose;
            Tag.btnTag.HoverState.FillColor2 = Color.Snow;
            Tag.btnTag.HoverState.BorderColor = Color.White;
            Tag.btnTag.HoverState.ForeColor = Color.RosyBrown;
        }

        public static void ShowQuickAccountsPage()
        {
            clsViltaUiFunctions.QuickAccountsPage.AccountsContainer.Controls.Clear();
            clsViltaUiFunctions.QuickAccountsPage.LoadQuickAccounts();

            clsViltaUiFunctions.QuickAccountsPage.Show();
        }

        public static Image LoadImage(string Path)
        {
            FileStream ImgFile = new FileStream(Path, FileMode.Open, FileAccess.Read);
            return Image.FromStream(ImgFile);
        }

        public static Bitmap ReszieImage(double Width, double Height, Image Img)
        {
            Image NewImg = Img;
            Size NewSize = new Size((int)(Img.Width * Width), (int)(Img.Height * Height));

            return new Bitmap(NewImg, NewSize);
        }

        public static void ShowMain(frmMain MainPage, int UserID = -1, Form LocatedForm = null)
        { 
            if (UserID != -1)
                clsCurrentUser.CurrentUser = clsUsers.Find(UserID);

            MainPage.Show();
        }

        public static void LoadTags(List<string> Tags, ref FlowLayoutPanel TagsContainer)
        {
            foreach (string Tag in Tags)
            {
                if (Tag == "All")
                    continue;

                ctrlTag SnippetTag = new ctrlTag(Tag);
                TagUi(ref SnippetTag);

                TagsContainer.Controls.Add(SnippetTag);
            }
        }

        public static void ShowAlert(string Message, bool IsErrorMode = true)
        {
            frmAlert frm = new frmAlert(Message, IsErrorMode);
            frm.Show();
        }

        public static Image GetLanguageImg(string LangName)
        {
            Image Img;
            Img = Image.FromFile($@"D:\Vilta Snippet\Images\Icons\Languages\{LangName}.png");

            return Img;
        }
    }
}
