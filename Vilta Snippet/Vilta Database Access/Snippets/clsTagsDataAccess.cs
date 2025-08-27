using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vilta_Database_Access.Snippets
{
    public class clsTagsDataAccess
    {
        public static List<string> LoadTags(int UserID)
        {
            List<string> SnippetsTags = new List<string>();
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select TagName From Tags Where UserID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    SnippetsTags.Add(reader["TagName"].ToString());
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return SnippetsTags;
        }
    
        public static int Find(string TagName, int UserID)
        {
            int TagID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select TagID From Tags Where TagName = @TagName and UserID = @UserID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TagName", TagName);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                    TagID = ID;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return TagID;
        }

        public static bool IsTagExist(string TagName, int UserID)
        {
            bool Found = false;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select Exist = 1 From Tags Where TagName = @TagName and UserID = @UserID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TagName", TagName);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                    Found = true;
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

        public static DataTable GetTagsSnippets(List<string> Tags, int UserID)
        {
            int TagsCounter = 0;
            DataTable TagsSnippets = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            StringBuilder StarterQuery = new StringBuilder(@"
                                      Select Tags.TagName as TagName, Snippets = Count(Snippets.SnippetID) From TagSnippets
                                      join Tags on Tags.TagID = TagSnippets.TagID
                                      join Snippets on Snippets.SnippetID = TagSnippets.SnippetID
                                      Where Tags.UserID = @UserID
                                      group by Tags.TagName, Tags.TagID
                                      having Tags.TagName in (
                                      ");

            foreach (string Tag in Tags)
            {
                TagsCounter++;
                StarterQuery.Append($"'{Tag}', ");

                if (TagsCounter == Tags.Count)
                {
                    StarterQuery.Remove(StarterQuery.Length - 2, 2);
                    StarterQuery.Append(");");
                }
            }

            string Query = StarterQuery.ToString();

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                    TagsSnippets.Load(reader);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return TagsSnippets;
        }
    
        public static bool AddNewTag(string TagName, int UserID)
        {
            int EffectedRows = -1;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Insert Into Tags (TagName, UserID) Values(@TagName, @UserID);";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TagName", TagName);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                EffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return (EffectedRows != -1);
        }
    
        public static bool _UpdateTag(string TagName, int TagID)
        {
            int TagUpdated = -1;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Update Tags Set TagName = @TagName where TagID = @TagID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TagName", TagName);
            command.Parameters.AddWithValue("@TagID", TagID);

            try
            {
                connection.Open();
                TagUpdated = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return (TagUpdated != -1);
        }

        public static List<string> GetSnippetTags(int SnippetID)
        {
            List<string> Tags = new List<string>();
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"
                             Select Tags.TagName as TagName From TagSnippets
                             join Tags On Tags.TagID = TagSnippets.TagID
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
    
        public static void DeleteTag(int TagID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Delete From Tags Where TagID = @TagID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TagID", TagID);

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
    }
}
