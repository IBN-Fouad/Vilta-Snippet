using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Logic;
using Vilta_Snippet.General.Forms;
using Vilta_Snippet.Login_Page;

namespace Vilta_Snippet
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (clsUsers.IsQuickAccountsActive() && clsUsers.CheckQuickAccounts())
            {
                clsCurrentUser.Mode = clsCurrentUser.enLoginMode.eQuickAccounts;

                clsViltaUiFunctions.QuickAccountsPage = new frmQuickAccounts();
                Application.Run(clsViltaUiFunctions.QuickAccountsPage);
            }
            else
            {
                clsCurrentUser.Mode = clsCurrentUser.enLoginMode.eStartPage;
                Application.Run(new frmStartPage());
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
