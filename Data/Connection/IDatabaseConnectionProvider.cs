using MySql.Data.MySqlClient;

namespace File_Acess_Management.Data
{
    public interface IDatabaseConnectionProvider
    {
        MySqlConnection GetConnection();
    }
}