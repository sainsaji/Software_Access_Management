using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Models;

namespace File_Acess_Management.Data.Repository
{
    public class SoftwareRepository : MainRepository<Software>, ISoftwareRepository
    {
        private readonly IDatabaseConnectionProvider _connectionProvider;
        private readonly ICommandFactory _commandFactory;

        public SoftwareRepository(IDatabaseConnectionProvider connectionProvider, ICommandFactory commandFactory) : base(connectionProvider, commandFactory)
        {
            _connectionProvider = connectionProvider;
            _commandFactory = commandFactory;
        }
    }
}