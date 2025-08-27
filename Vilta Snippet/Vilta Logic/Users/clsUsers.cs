using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Vilta_Database_Access;
using static System.Net.Mime.MediaTypeNames;

namespace Vilta_Logic
{
    public class clsUsers
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 };
        enMode Mode;

        public clsPeople Person = new clsPeople();

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }

        public clsUsers()
        {
            this.UserID     = -2;
            this.UserName   = "";
            Person.Name     = "";
            Person.Email    = "";
            Person.Phone    = "";
            Person.PersonID = -2;
            this.Password   = "";
            this.Image      = "";

            Mode = enMode.eAddNew;
        }

        public clsUsers(int UserID, string UserName, string Name, string Email, string Phone, string Password, int PersonID, string Image)
        {
            this.UserID     = UserID;
            this.UserName   = UserName;
            Person.Name     = Name;
            Person.Email    = Email;
            Person.Phone    = Phone;
            Person.PersonID = PersonID;
            this.Password   = Password;
            this.Image      = Image;

            Mode = enMode.eUpdate;
        }

        public static clsUsers Find(int UserID)
        {
            int PersonID = -2;
            string UserName = "", Name = "", Email = "", Phone = "", Password = "", Image = "";

            if (clsUsersDataAccess.Find(UserID, ref UserName, ref Name, ref Email, ref Phone, ref Password, ref PersonID, ref Image))
                return new clsUsers(UserID, UserName, Name, Email, Phone, Password, PersonID, Image);
            else
                return null;
        }

        public static clsUsers Find(string UserName)
        {
            int UserID = -2, PersonID = -2;
            string Name = "", Email = "", Phone = "", Password = "", Image = "";

            if (clsUsersDataAccess.Find(UserName, ref UserID, ref Name, ref Email, ref Phone, ref Password, ref PersonID, ref Image))
                return new clsUsers(UserID, UserName, Name, Email, Phone, Password, PersonID, Image);
            else
                return null;
        }

        public static bool IsUserNameExist(string UserName)
        {
            return clsUsersDataAccess.IsUserNameExist(UserName);
        }

        public static int Login(string UserName, string Password)
        {
            switch (clsUsersDataAccess.Login(UserName, Password))
            {
                case -1:
                    {
                        return -1;
                    }
                case 0:
                    {
                        return 0;
                    }
                default:
                    {
                        clsCurrentUser.CurrentUser = Find(UserName);
                        return 3;
                    }

            }
        }

        public int _AddNewUser()
        {
            int ID = -1;
            clsUsersDataAccess.Signup(ref ID, UserName, Person.Name, Person.Email, Person.Phone, Password, Image);

            return ID;
        }

        private bool _UpdateUser()
        {
            bool UpdateResult = clsUsersDataAccess.UpdateUser(UserID, Person.PersonID, UserName, Person.Name, Person.Email, Person.Phone, Password, Image);

            if(UpdateResult)
                clsCurrentUser.CurrentUser = Find(UserName);

            return UpdateResult;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.eAddNew:
                    {
                        UserID = _AddNewUser();
                        if (UserID != -1)
                            return true;
                        else
                            return false;
                    }
                case enMode.eUpdate:
                    {
                        return _UpdateUser();
                    }
            }

            return false;
        }

        public static void Delete()
        {
            clsUsersDataAccess.Delete(clsCurrentUser.CurrentUser.UserID, clsCurrentUser.CurrentUser.Person.PersonID);
        }

        public static void SaveAccountAsQuickAccount()
        {
            clsUsersDataAccess.SaveAccountAsQuickAccount(clsCurrentUser.CurrentUser.UserID);
        }

        public static bool CheckQuickAccounts()
        {
            return clsUsersDataAccess.CheckQuickAccounts();
        }

        public static DataTable LoadQuickAccounts()
        {
            return clsUsersDataAccess.LoadQuickAccounts();
        }

        public static void QuickAccountsState(bool State)
        {
            clsUsersDataAccess.QuickAccountsState(State);
        }

        public static bool IsQuickAccountsActive()
        {
            return clsUsersDataAccess.IsQuickAccountsActive();
        }
    }
}
