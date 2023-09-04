using File_Acess_Management.Models;

namespace File_Acess_Management.Data.Repository.IRepository
{
    public interface IUserManagementRepository : IMainRepository<Users>
    {
        bool CheckUser(string username);
    }
}