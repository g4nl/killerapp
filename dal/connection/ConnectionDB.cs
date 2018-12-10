using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class ConnectionDB
    {
        private static string database = "";
        private static string password = "";
        private static string server = "";
        private static string uid = "";

        public MySqlConnection GetConnection() {
            return new MySqlConnection(createConnectionString());
        }

        string createConnectionString() {
            return $"SERVER={server}; DATABASE={database}; UID={uid}; PASSWORD={password}; SslMode=none";
        }
    }
}
