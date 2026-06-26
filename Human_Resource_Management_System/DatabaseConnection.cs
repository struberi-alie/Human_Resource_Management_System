using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Human_Resource_Management_System 
{
    public class DatabaseConnection 
    {
        public static MySqlConnection GetConnection()
        {
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db_secret.txt");

            if (!System.IO.File.Exists(path))
            {
                throw new Exception("Error: Hindi mahanap ang file sa: " + path);
            }

            try
            {
                string pass = System.IO.File.ReadAllText(path).Trim();
                string host = "mysql-3579a049-marielligot859-19a6.l.aivencloud.com";
                string port = "23850";
                string db = "defaultdb";
                string user = "avnadmin";

                string connString = $"Server={host};Port={port};Database={db};Uid={user};Pwd={pass};SslMode=Required;";

                return new MySqlConnection(connString);
            }
            catch (Exception ex)
            {
                throw new Exception("Connection failed: " + ex.Message);
            }
        }
    }
}