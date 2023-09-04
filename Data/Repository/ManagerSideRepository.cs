using File_Acess_Management.Data.Repository.IRepository;

namespace File_Acess_Management.Data.Repository
{
    public class ManagerSideRepository : MainRepository<RequestList>, IManagerSideRepository
    {
        private readonly IDatabaseConnectionProvider _connectionProvider;
        private readonly ICommandFactory _commandFactory;

        public ManagerSideRepository(IDatabaseConnectionProvider connectionProvider, ICommandFactory commandFactory) : base(connectionProvider, commandFactory)
        {
            _connectionProvider = connectionProvider;
            _commandFactory = commandFactory;
        }
    }
}