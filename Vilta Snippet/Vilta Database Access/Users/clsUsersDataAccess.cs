using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Vilta_Database_Access
{
    public class clsUsersDataAccess
    {
        public static int Login(string Username, string Password)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select Password From Users Where UserName = @UserName";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", Username);

            try
            {
                connection.Open();
                object dbPassword = command.ExecuteScalar();

                if (dbPassword == null)
                    return -1;
                else if (Password == dbPassword.ToString())
                    return 1;
                else
                    return 0;
            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        private static int _SavePersonData(string Name, string Email, string Phone)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Insert Into People (Name, Email, Phone)
                             Values (@Name, @Email, @Phone);
                             Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                    PersonID = ID;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return PersonID;
        }

        public static bool Signup(ref int UserID, string UserName, string Name, string Email, string Phone, string Password, string Image)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Insert Into Users (UserName, Password, PersonID, Image)
                             Values (@UserName, @Password, @PersonID, @Image);
                             Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@PersonID", _SavePersonData(Name, Email, Phone));
            command.Parameters.AddWithValue("@Image", Image);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                    UserID = ID;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return (UserID != -1);
        }

        private static bool _UpdatePersonData(int PersonID, string Name, string Email, string Phone)
        {
            int DataSaved = -1;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Update People Set Name  = @Name,
                                               Email = @Email,
                                               Phone = @Phone
                             Where PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);

            try
            {
                connection.Open();
                DataSaved = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return (DataSaved != -1);
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Name, string Email, string Phone, string Password, string Image)
        {
            if (!_UpdatePersonData(PersonID, Name, Email, Phone)) return false;

            int DataSaved = -1;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Update Users Set UserName = @UserName,
                                              Password = @Password,
                                              Image    = @Image
                             Where UserID = @UserID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Image", Image);

            try
            {
                connection.Open();
                DataSaved = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return (DataSaved != -1);
        }

        public static bool Find(string UserName, ref int UserID, ref string Name, ref string Email, ref string Phone, ref string Password, ref int PersonID, ref string Image)
        {
            bool Found = false;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select Users.*, People.Name as Name, People.Email as Email, People.Phone as Phone from Users
                             join People on People.PersonID = Users.PersonID Where UserName = @UserName;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserID     = (int)reader["UserID"];
                    Name       = (string)reader["Name"];
                    Email      = (string)reader["Email"];
                    Phone      = (string)reader["Phone"];
                    Password   = (string)reader["Password"];
                    PersonID = (int)reader["PersonID"];
                    Image      = (string)reader["Image"];

                    Found = true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return Found;
        }

        public static bool Find(int UserID, ref string UserName, ref string Name, ref string Email, ref string Phone, ref string Password, ref int PersonID, ref string Image)
        {
            bool Found = false;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select Users.*, People.Name as Name, People.Email as Email, People.Phone as Phone from Users
                             join People on People.PersonID = Users.PersonID Where UserID = @UserID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserName   = (string)reader["UserName"];
                    Name       = (string)reader["Name"];
                    Email      = (string)reader["Email"];
                    Phone      = (string)reader["Phone"];
                    Password   = (string)reader["Password"];
                    PersonID   = (int)reader["PersonID"];
                    Image      = (string)reader["Image"];

                    Found = true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return Found;
        }

        private static void _DeleteAccountSnippets(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Delete From Snippets Where UserID = @UserID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        private static void _DeleteAccountTags(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Delete From Tags Where UserID = @UserID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        public static void Delete(int UserID, int PersonID)
        {
            _DeleteAccountSnippets(UserID);
            _DeleteAccountTags(UserID);

            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Delete From Users  Where UserID   = @UserID;
                             Delete From People Where PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        public static bool IsUserNameExist(string UserName)
        {
            bool IsExist = false;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select Found = 1 From Users Where UserName = @UserName;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if(result != null)
                    IsExist = true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return IsExist;
        }

        public static void SaveAccountAsQuickAccount(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Insert Into [Quick Accounts] (UserID) Values(@UserID);";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        public static bool CheckQuickAccounts()
        {
            int Found = -1;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select Count(UserID) From [Quick Accounts];";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Count))
                    Found = Count;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return (Found > 0);
        }

        public static DataTable LoadQuickAccounts()
        {
            DataTable Accounts = new DataTable();
            List<int> UsersID = new List<int>();
            StringBuilder QueryBuilder = new StringBuilder(@"Select UserID, UserName, Image From Users Where UserID in(");

            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select * From [Quick Accounts];";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    UsersID.Add((int)reader["UserID"]);

                reader.Close();
                for (int i = 0; i < UsersID.Count; i++)
                {
                    QueryBuilder.Append(UsersID[i]);

                    if(i ==  (UsersID.Count - 1))
                        QueryBuilder.Append(");");
                    else
                        QueryBuilder.Append(",");
                }

                Query = QueryBuilder.ToString();
                command = new SqlCommand(Query, connection);

                reader = command.ExecuteReader();
                if (reader.HasRows)
                    Accounts.Load(reader);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return Accounts;
        }

        public static void QuickAccountsState(bool State)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Update QuickAccountsPageState Set QuickAccountsPage = @State;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@State", State);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        public static bool IsQuickAccountsActive()
        {
            bool Active = false;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select * From QuickAccountsPageState;";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if(result != null)
                    Active = (bool)result;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return Active;
        }
    }
}
