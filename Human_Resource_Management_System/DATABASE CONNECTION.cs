using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Human_Resource_Management_System
{
    public class DatabaseConnection
    {
        private string connectionString =
            "Server=your_server;Database=infomanagement;Uid=your_username;Pwd=your_password;";

        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
    }
}