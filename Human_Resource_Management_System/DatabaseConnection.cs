    using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace infomanagement
{
    public static class DatabaseConnection
    {
        
        private static readonly string server = "localhost";
        private static readonly string database = "infomanagement";
        private static readonly string uid = "root";       
        private static readonly string password = "stormxoreo@0924";      

        
        private static readonly string connectionString = $"server={server};database={database};uid={uid};password={password};Convert Zero Datetime=True;";

       
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Connection Failed:\n" + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}