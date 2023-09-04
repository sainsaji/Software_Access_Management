using MySql.Data.MySqlClient;

namespace File_Acess_Management.Data
{
    public interface ICommandFactory
    {
        MySqlCommand CreateCommand(string query, MySqlConnection connection);
    }
}