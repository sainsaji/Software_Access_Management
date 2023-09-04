using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Models;
using MySql.Data.MySqlClient;

namespace File_Acess_Management.Data.Repository
{
    public class UserManagementRepository : MainRepository<Users>, IUserManagementRepository
    {
        private readonly IDatabaseConnectionProvider _connectionProvider;
        private readonly ICommandFactory _commandFactory;

        public UserManagementRepository(IDatabaseConnectionProvider connectionProvider, ICommandFactory commandFactory) : base(connectionProvider, commandFactory)
        {
            _connectionProvider = connectionProvider;
            _commandFactory = commandFactory;
        }

        public bool CheckUser(string username)
        {
            using (MySqlConnection connection = _connectionProvider.GetConnection())
            {
                string query = "Select * from users where user_name=@Username";
                using (MySqlCommand command = _commandFactory.CreateCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
    }
}