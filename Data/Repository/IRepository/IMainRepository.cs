using System.Data;

namespace File_Acess_Management.Data.Repository.IRepository
{
    public interface IMainRepository<T> where T : class
    {
        int add(T entity, string query);

        DataTable getAll(string query);

        int remove(T entity, string query);

        DataTable get(T entity, string query);
    }
}