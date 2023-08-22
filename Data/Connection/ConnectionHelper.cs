using File_Acess_Management.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Acess_Management
{
    public class ConnectionHelper : IDatabaseConnectionProvider,ICommandFactory
    {
        public static string ConnectionString => "Server=localhost;Database=fms1;User=root;Password=root;";


        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public MySqlCommand CreateCommand(string query, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            return command;
        }

    }
}
