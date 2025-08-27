using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vilta_Database_Access.Settings;

namespace Vilta_Logic
{
    public class clsSettings
    {
        public int SettingID { get; set; }
        public bool Trash {  get; set; }
        public bool QuickAccounts {  get; set; }
        public bool CaseSensitive {  get; set; }
        public bool SnippetsOrder {  get; set; }
        public bool UndoFeature {  get; set; }

        public clsSettings()
        {
            Trash         = true;
            QuickAccounts = true;
            CaseSensitive = false;
            SnippetsOrder = false;
            UndoFeature   = true;
        }

        public clsSettings(bool Trash, bool QuickAccounts, bool CaseSensitive, bool UndoFeature)
        {
            this.Trash         = Trash;
            this.QuickAccounts = QuickAccounts;
            this.CaseSensitive = CaseSensitive;
            this.UndoFeature   = UndoFeature;
        }

        public static clsSettings SetAppSettings()
        {
            bool Trash = true, QuickAccounts = true, CaseSensitive = true, UndoFeature = true;

            if (clsSettingsDataAccess.GetAppSettings(clsCurrentUser.CurrentUser.UserID, ref Trash, ref QuickAccounts, ref CaseSensitive, ref UndoFeature))
                return new clsSettings(Trash, QuickAccounts, CaseSensitive, UndoFeature);
            else
                return null;
        }
    
        public static void SaveDefaultAppSettings(int UserID)
        {
            clsSettingsDataAccess.SaveDefaultAppSettings(UserID);
        }
    
        public static void UpdateFeatureState(bool IsOn, string Feature)
        {
            clsSettingsDataAccess.UpdateFeatureState(clsCurrentUser.CurrentUser.UserID, IsOn, Feature);
        }
    }
}
