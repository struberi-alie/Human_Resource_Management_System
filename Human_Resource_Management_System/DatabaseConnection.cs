

using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace infomanagement
{
    
    public static class DatabaseConnection
    {   

        //change the password to the password  set in the connection
        private static readonly string connectionString = "server=mysql-pupacadportal-pupacadportal.h.aivencloud.com;port=15204;database=infomanagement;uid=avnadmin;password=\"YOUR_PASSWORD_HERE\"";

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