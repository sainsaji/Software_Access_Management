using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Models;

namespace File_Acess_Management.Data.Repository
{
    public class UserManagerAssignmentRepository : MainRepository<Assignment>, IUserManagerAssignmentRepository
    {
        private readonly IDatabaseConnectionProvider _connectionProvider;
        private readonly ICommandFactory _commandFactory;

        public UserManagerAssignmentRepository(IDatabaseConnectionProvider connectionProvider, ICommandFactory commandFactory) : base(connectionProvider, commandFactory)
        {
            _connectionProvider = connectionProvider;
            _commandFactory = commandFactory;
        }
    }
}