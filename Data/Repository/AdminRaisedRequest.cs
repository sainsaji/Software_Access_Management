using File_Acess_Management.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Acess_Management.Data.Repository
{
    public class AdminRaisedRequest:MainRepository<RequestList>, IAdminRaisedRequest
    {
        private readonly IDatabaseConnectionProvider _connectionProvider;
        private readonly ICommandFactory _commandFactory;
        public AdminRaisedRequest(IDatabaseConnectionProvider connectionProvider, ICommandFactory commandFactory) : base(connectionProvider, commandFactory)
        {
            _connectionProvider = connectionProvider;
            _commandFactory = commandFactory;
        }
    }
}
