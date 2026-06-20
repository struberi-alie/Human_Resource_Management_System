using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Resource_Management_System
{
    public class DatabaseHelper
    {
        // Try this exact string to see if the error changes or disappears
        public static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=infomanagement;Integrated Security=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
