using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Acess_Management.Data
{
    public interface ICommandFactory
    {
        MySqlCommand CreateCommand(string query, MySqlConnection connection);
    }
}
