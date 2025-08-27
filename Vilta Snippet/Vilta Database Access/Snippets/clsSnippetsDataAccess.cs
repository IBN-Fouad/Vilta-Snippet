using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Vilta_Database_Access.Snippets
{
    public class clsSnippetsDataAccess
    {
        private static string _SetSnippetsQuery(string Tag)
        {
            if (Tag == "")
            {
                return
                @"
                    Select Snippets.SnippetID as SnippetID, Snippets.Title as Title, Snippets.Date as Date, Snippets.Description as Description, Snippets.Code as Code,
                           Snippets.Deleted as Deleted, Snippets.Favorited as Favorited, Snippets.Language as Language
                           From Snippets 
                           Where UserID = @UserID
                           Order by Snippets.SnippetID desc;
                ";
            }
            else
            {
                return
                @"
                    Select Snippets.SnippetID as SnippetID, Snippets.Title as Title, Snippets.Date as Date, Snippets.Description as Description, Snippets.Code as Code,
                           Snippets.Deleted as Deleted, Snippets.Favorited as Favorited, Snippets.Language as Language
                           From TagSnippets join Snippets on Snippets.SnippetID = TagSnippets.SnippetID
						                    join Tags on Tags.TagID = TagSnippets.TagID
	                                        Where Tags.TagName = @TagName and Snippets.UserID = @UserID
                                            Order by Snippets.SnippetID desc;
                ";
            }
        }

        public static DataTable LoadSnippets(string TagName, int UserID)
        {
            DataTable Snippets = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = _SetSnippetsQuery(TagName);

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TagName", TagName);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                    Snippets.Load(reader);
                else
                    Snippets = null;
            }
            catch (Exception e)
            {
                Snippets = null;
            }
            finally
            {
                connection.Close();
            }

            return Snippets;
        }
     
        public static List<string> GetSnippetTags(int SnippetID)
        {
            List<string> Tags = new List<string>();
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"
                              Select Tags.TagName as TagName From TagSnippets
                              join Tags on Tags.TagID = TagSnippets.TagID
                              Where TagSnippets.SnippetID = @SnippetID;
                            ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@SnippetID", SnippetID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                    Tags.Add((string)reader["TagName"]);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return Tags;
        }

        private static int _SaveSnippet(string Title, string Date, string Description, string Code, int Deleted, int Favorited, string Language, int UserID)
        {
            int SnippetID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"
                              Insert Into Snippets (Title, Date, Description, Code, Deleted, Favorited, Language, UserID)
                              Values (@Title, @Date, @Description, @Code, @Deleted, @Favorited, @Language, @UserID);
                              Select SCOPE_IDENTITY();
                            ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@Deleted", Deleted);
            command.Parameters.AddWithValue("@Favorited", Favorited);
            command.Parameters.AddWithValue("@Language", Language);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                    SnippetID = ID;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return SnippetID;
        }

        public static bool AddNewSnippet(string Title, string Date, string Description, string Code, int Deleted, int Favorited, string Language, int UserID, List<int> Tags)
        {
            int SnippetSaved = -1;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            StringBuilder QueryBuilder = new StringBuilder(@"
                                                      insert into TagSnippets (TagID, SnippetID)
                                                      Values
                                                    ");

            for (int i = 0; i < Tags.Count; i++)
            {
                QueryBuilder.Append($"(@TagID{i + 1}, @SnippetID)");

                if(i < Tags.Count - 1 && (Tags.Count - i) != 1)
                    QueryBuilder.Append(",");
                else
                    QueryBuilder.Append(";");
            }

            string Query = QueryBuilder.ToString();

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@SnippetID", _SaveSnippet(Title, Date, Description, Code, Deleted, Favorited, Language, UserID));

            for (int i = 0; i < Tags.Count; i++)
                command.Parameters.AddWithValue($"@TagID{i + 1}", Tags[i]);

            try
            {
                connection.Open();
                SnippetSaved = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return (SnippetSaved != -1);
        }

        public static void DeleteSnippet(int SnippetID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Delete From Snippets Where SnippetID = @SnippetID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@SnippetID", SnippetID);

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

        public static void CheckUserTrashItems(int UserID, ref List<int> SnippetsIDs)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select SnippetID From Snippets Where UserID = @UserID and Deleted = 1;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    SnippetsIDs.Add((int)reader["SnippetID"]);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        private static void _GenerateTrashQuery(string Query, ref StringBuilder QueryBuilder, ref SqlCommand command, List<int> SnippetsIDs, string Column, SqlConnection connection, int UserID)
        {
            QueryBuilder = new StringBuilder($@"Delete From {Column} Where SnippetID in(");

            for (int i = 0; i < SnippetsIDs.Count; i++)
            {
                QueryBuilder.Append($"@SnippetID{i + 1}");

                if (i < (SnippetsIDs.Count - 1))
                    QueryBuilder.Append(",");
                else
                    QueryBuilder.Append(");");
            }

            Query = QueryBuilder.ToString();

            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            for (int i = 0; i < SnippetsIDs.Count; i++)
                command.Parameters.AddWithValue($"@SnippetID{i + 1}", SnippetsIDs[i]);
        }

        public static void DeleteTrashItems(int UserID, List<int> SnippetsIDs)
        {
            StringBuilder QueryBuilder = new StringBuilder();
            string Query = "";

            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);
            SqlCommand command = new SqlCommand();

            _GenerateTrashQuery(Query, ref QueryBuilder, ref command, SnippetsIDs, "Snippets", connection, UserID);

            //_GenerateTrashQuery(Query, ref QueryBuilder, ref command, SnippetsIDs, "TagSnippets", connection, UserID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                //_GenerateTrashQuery(Query, ref QueryBuilder, ref command, SnippetsIDs, "Snippets", connection, UserID);
                //command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        public static bool GetSnippetByID(int SnippetID, int UserID, ref string Title, ref string Date, ref string Description, ref string Code, ref string Language, ref int Deleted, ref int Favorited, ref List<string> Tags)
        {
            Tags = GetSnippetTags(SnippetID);
            bool Found = false;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"
                              Select Title, Date, Description, Code, Deleted, Favorited, Language From Snippets
                              Where SnippetID = @SnippetID and UserID = @UserID;
                            ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@SnippetID", SnippetID);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Title = (string)reader["Title"];
                    Date  = (string)reader["Date"];
                    Description = (string)reader["Description"];
                    Code = (string)reader["Code"];
                    Language = (string)reader["Language"];
                    Deleted = (int)reader["Deleted"];
                    Favorited = (int)reader["Favorited"];

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

        private static void _UpdateSnippetData(int SnippetID, string Title, string Date, string Description, string Code, string Language)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"
                             Update Snippets Set Title = @Title,
					                             Date = @Date,
					                             Description = @Description,
					                             Code = @Code,
					                             Language = @Language
					                             Where SnippetID = @SnippetID;
                             Delete from TagSnippets Where SnippetID = @SnippetID;
                            ";
        
            SqlCommand command = new SqlCommand(Query , connection);

            command.Parameters.AddWithValue("@SnippetID", SnippetID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@Language", Language);

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

        public static bool UpdateSnippet(int SnippetID, string Title, string Date, string Description, string Code, string Language, List<int> Tags)
        {
            int DataUpdated = -1;

            _UpdateSnippetData(SnippetID, Title, Date, Description, Code, Language);
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            StringBuilder QueryBuilder = new StringBuilder(@"
                                                      Insert into TagSnippets (TagID, SnippetID)
                                                      Values
                                                    ");

            for (int i = 0; i < Tags.Count; i++)
            {
                QueryBuilder.Append($"(@TagID{i + 1}, @SnippetID)");

                if (i < Tags.Count - 1 && (Tags.Count - i) != 1)
                    QueryBuilder.Append(",");
                else
                    QueryBuilder.Append(";");
            }

            string Query = QueryBuilder.ToString();

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@SnippetID", SnippetID);

            for (int i = 0; i < Tags.Count; i++)
                command.Parameters.AddWithValue($"@TagID{i + 1}", Tags[i]);

            try
            {
                connection.Open();
                DataUpdated = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return (DataUpdated != -1);
        }

        public static void ManageFavorites(int SnippetID, bool IsAdded)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Update Snippets Set Favorited = @Favorited Where SnippetID = @SnippetID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Favorited", IsAdded);
            command.Parameters.AddWithValue("@SnippetID", SnippetID);

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
        
        public static void ManageDeletions(int SnippetID, bool MoveToTrash)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Update Snippets Set Deleted = @Deleted Where SnippetID = @SnippetID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Deleted", MoveToTrash);
            command.Parameters.AddWithValue("@SnippetID", SnippetID);

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
    
        public static List<string> LoadSearchItems(int UserID)
        {
            List<string> SearchItems = new List<string>();
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select * From SnippetsSearchHistory Where UserID = @UserID Order By Date Desc;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    SearchItems.Add((string)reader["SearchItem"]);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return SearchItems;
        }

        private static void _CheckSearchItemsCount(int UserID)
        {
            int Count = 0;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select Count(*) As SearchCount from SnippetsSearchHistory where UserID = @UserID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int SearchItemsCount))
                    Count = SearchItemsCount;

                if (Count == 5)
                {
                    Query = @"
                                      Delete From SnippetsSearchHistory Where SearchItemID in
												       (
													      Select Top 1 SearchItemID From SnippetsSearchHistory
														  Where UserID = 2 Order By Date Asc
													   );
                                     ";

                    command = new SqlCommand(Query, connection);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        private static bool _IsItSaved(string SearchItem, int UserID)
        {
            _CheckSearchItemsCount(UserID);
            List<string> SearchItems = LoadSearchItems(UserID);

            foreach (string Item in SearchItems)
            {
                if (Item == SearchItem)
                    return true;
            }

            return false;
        }
        
        public static DataTable GetSnippetsCount(int UserID)
        {
            DataTable Languages = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select top 3 Count(Language) as SnippetsCount, Language From Snippets
                             Group By Language, UserID
                             Having UserID = @UserID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    Languages.Load(reader);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return Languages;
        }
    }
}
