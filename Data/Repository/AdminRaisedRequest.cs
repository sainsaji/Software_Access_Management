using File_Acess_Management.Data.Repository.IRepository;
using MySql.Data.MySqlClient;
using System.Data;

namespace File_Acess_Management.Data.Repository
{
    public class AdminRaisedRequest : MainRepository<RequestList>, IAdminRaisedRequest
    {
        private readonly IDatabaseConnectionProvider _connectionProvider;
        private readonly ICommandFactory _commandFactory;

        public AdminRaisedRequest(IDatabaseConnectionProvider connectionProvider, ICommandFactory commandFactory) : base(connectionProvider, commandFactory)
        {
            _connectionProvider = connectionProvider;
            _commandFactory = commandFactory;
        }

        public DataTable getTables()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=fms1;User=root;Password=root;"))
            {
                connection.Open();
                DataTable tables = connection.GetSchema("Tables");

                return tables;
            }
        }
    }
}