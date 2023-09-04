using System.Data;

namespace File_Acess_Management.Data.Repository.IRepository
{
    public interface IAdminRaisedRequest : IMainRepository<RequestList>
    {
        DataTable getTables();
    }
}