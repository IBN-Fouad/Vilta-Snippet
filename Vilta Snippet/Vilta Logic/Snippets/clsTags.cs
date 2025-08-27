using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Logic;

namespace Vilta_Database_Access.Snippets
{
    public class clsTags
    {
        public string TagName { get; set; }
        public int TagID { get; set; }

        public DataTable TagSnippets = new DataTable();
        public static List<string> SelectedTagsNames = new List<string>();
        public static List<int> SelectedTagsIDs = new List<int>();
        public List<string> TagsNames = new List<string>();
        public List<int> Tags = new List<int>();

        public enum enMode { eAddNew = 0, eUpdate = 1};
        public enMode Mode;

        public clsTags()
        {
            TagName = "";
            Mode = enMode.eAddNew;
        }

        public clsTags(string TagName)
        {
            this.TagName = TagName;
            Mode = enMode.eUpdate;
        }

        public static List<string> LoadTags()
        {
            return clsTagsDataAccess.LoadTags(clsCurrentUser.CurrentUser.UserID);
        }

        public static int Find(string TagName)
        {
            return clsTagsDataAccess.Find(TagName, clsCurrentUser.CurrentUser.UserID);
        }

        public static bool IsTagExist(string TagName)
        {
            return clsTagsDataAccess.IsTagExist(TagName, clsCurrentUser.CurrentUser.UserID);
        }

        public static DataTable GetTagsSnippets(List<string> Tags)
        {
            return clsTagsDataAccess.GetTagsSnippets(Tags, clsCurrentUser.CurrentUser.UserID);
        }

        public static List<string> GetSnippetTags(int SnippetID)
        {
            return clsTagsDataAccess.GetSnippetTags(SnippetID);
        }

        private bool _AddNewTag()
        {
            return clsTagsDataAccess.AddNewTag(TagName, clsCurrentUser.CurrentUser.UserID);
        }

        private bool _UpdateTag()
        {
            return clsTagsDataAccess._UpdateTag(TagName, TagID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.eAddNew:
                    {
                        if (_AddNewTag())
                        {
                            Mode = enMode.eUpdate;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.eUpdate:
                    {
                        return _UpdateTag();
                    }
            }

            return false;
        }

        public static void DeleteTag(int TagID)
        {
            clsTagsDataAccess.DeleteTag(TagID);
        }
    }
}
