using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vilta_Logic
{
    public class clsCurrentUser
    {
        public enum enLoginMode { eStartPage = 0, eQuickAccounts = 1, eLogin = 2};
        public static enLoginMode Mode;

        public static clsUsers CurrentUser;
    }
}
