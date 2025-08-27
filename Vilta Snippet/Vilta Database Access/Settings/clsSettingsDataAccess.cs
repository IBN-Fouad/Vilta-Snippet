using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vilta_Database_Access.Settings
{
    public class clsSettingsDataAccess
    {
        public static void SaveDefaultAppSettings(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);
            
            string Query = @"Insert Into Settings (Trash, QuickAccounts, CaseSensitive, UndoFeature, UserID)
                             Values(@Trash, @QuickAccounts, @CaseSensitive, @UndoFeature, @UserID);";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Trash", 1);
            command.Parameters.AddWithValue("@QuickAccounts", 1);
            command.Parameters.AddWithValue("@CaseSensitive", 0);
            command.Parameters.AddWithValue("@UndoFeature", 1);
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
    
        public static bool GetAppSettings(int UserID, ref bool Trash, ref bool QuickAccounts, ref bool CaseSensitive, ref bool UndoFeature)
        {
            bool SettingsData = false;
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"Select * From Settings Where UserID = @UserID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Trash         = (bool)reader["Trash"];
                    QuickAccounts = (bool)reader["QuickAccounts"];
                    CaseSensitive = (bool)reader["CaseSensitive"];
                    UndoFeature   = (bool)reader["UndoFeature"];

                    SettingsData = true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return SettingsData;
        }

        public static void UpdateFeatureState(int UserID, bool IsOn, string Feature)
        {
            SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = $@"Update Settings Set {Feature} = @{IsOn} Where UserID = @UserID;";

            if (Feature == "QuickAccounts" && !IsOn)
                Query += @"delete from [Quick Accounts] Where UserID = @UserID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue($"@{Feature}", Feature);
            command.Parameters.AddWithValue($"@{IsOn}", IsOn);
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

    }
}
