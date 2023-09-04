namespace File_Acess_Management.Data.Repository
{
    public class UserRaisedRequestRepository : MainRepository<RequestList>, IUserRaisedRequestRepository
    {
        private readonly IDatabaseConnectionProvider _connectionProvider;
        private readonly ICommandFactory _commandFactory;

        public UserRaisedRequestRepository(IDatabaseConnectionProvider connectionProvider, ICommandFactory commandFactory) : base(connectionProvider, commandFactory)
        {
            _connectionProvider = connectionProvider;
            _commandFactory = commandFactory;
        }
    }
}