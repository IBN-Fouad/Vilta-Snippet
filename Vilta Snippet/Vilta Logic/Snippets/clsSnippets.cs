using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vilta_Database_Access.Snippets;

namespace Vilta_Logic.Snippets
{
    public class clsSnippets
    {
        public enum enMode { eUpdate = 0, eAddNew = 1 };
        public enMode Mode;

        public int SnippetID {  get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int Deleted { get; set; }
        public int Favorited { get; set; }
        public string Language { get; set; }
        public int UserID { get; set; }

        public clsTags SnippetTags      = new clsTags();

        public clsSnippets()
        {
            SnippetID = -1;
            Title = "";
            Date = "";
            Description = "";
            Code = "";
            Deleted = 0;
            Favorited = 0;
            Language = "";
            UserID = -1;

            Mode = enMode.eAddNew;
        }

        public clsSnippets(int SnippetID, string Title, string Date, string Description, string Code, int Deleted, int Favorited, string Language, int UserID, List<string> Tags)
        {
            this.SnippetID = SnippetID;
            this.Title = Title;
            this.Date = Date;
            this.Description = Description;
            this.Code = Code;
            this.Deleted = Deleted;
            this.Favorited = Favorited;
            this.Language = Language;
            this.UserID = UserID;

            foreach (string Tag in Tags)
                SnippetTags.TagsNames.Add(Tag);

            Mode = enMode.eUpdate;
        }

        public static DataTable LoadSnippets(string TagName = "")
        {
            return clsSnippetsDataAccess.LoadSnippets(TagName, clsCurrentUser.CurrentUser.UserID);
        }
    
        public static List<string> GetSnippetTags(int SnippetID)
        {
            return clsSnippetsDataAccess.GetSnippetTags(SnippetID);
        }

        public static clsSnippets GetSnippetByID(int SnippetID)
        {
            string Title = "", Date = "", Description = "", Code = "", Language = "";
            int Deleted = -1, Favorited = -1;
            List<string> SnippetTags = new List<string>();

            if (clsSnippetsDataAccess.GetSnippetByID(SnippetID, clsCurrentUser.CurrentUser.UserID, ref Title, ref Date, ref Description, ref Code, ref Language, ref Deleted, ref Favorited, ref SnippetTags))
                return new clsSnippets(SnippetID, Title, Date, Description, Code, Deleted, Favorited, Language, clsCurrentUser.CurrentUser.UserID, SnippetTags);
            else
                return null;
        }

        private bool _AddNewSnippet()
        {
            return clsSnippetsDataAccess.AddNewSnippet(Title, Date, Description, Code, Deleted, Favorited, Language, UserID, SnippetTags.Tags);
        }

        private bool _UpdateSnippet()
        {
            return clsSnippetsDataAccess.UpdateSnippet(SnippetID, Title, Date, Description, Code, Language, clsTags.SelectedTagsIDs);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.eAddNew:
                    {
                        if (_AddNewSnippet())
                        {
                            Mode = enMode.eUpdate;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.eUpdate:
                    {
                        return _UpdateSnippet();
                    }
            }

            return false;
        }

        public static void DeleteSnippet(int SnippetID)
        {
            clsSnippetsDataAccess.DeleteSnippet(SnippetID);
        }

        public static void ManageFavorites(int SnippetID, bool IsAdded)
        {
            clsSnippetsDataAccess.ManageFavorites(SnippetID, IsAdded);
        }
        
        public static void ManageDeletions(int SnippetID, bool MoveToTrash)
        {
            clsSnippetsDataAccess.ManageDeletions(SnippetID, MoveToTrash);
        }
    
        public static DataTable GetSnippetsCount()
        {
            return clsSnippetsDataAccess.GetSnippetsCount(clsCurrentUser.CurrentUser.UserID);
        }
    
        public static void CheckUserTrashItems(ref List<int> SnippetsIDs)
        {
            clsSnippetsDataAccess.CheckUserTrashItems(clsCurrentUser.CurrentUser.UserID, ref SnippetsIDs);
        }

        public static void DeleteTrashItems(List<int> SnippetsIDs)
        {
            clsSnippetsDataAccess.DeleteTrashItems(clsCurrentUser.CurrentUser.UserID, SnippetsIDs);
        }
    }
}
