using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Aplicativo_de_Login
{
    internal class DbConnection
    {
        private static string connectionString =
            "Server=localhost; Database=db_app_login; Uid=root; pwd=R5U%kpidy#Zugp";

        public static MySqlConnection GetSqlConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
