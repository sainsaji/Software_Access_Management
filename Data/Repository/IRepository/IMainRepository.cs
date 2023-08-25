using File_Acess_Management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Acess_Management.Data.Repository.IRepository
{
    public interface IMainRepository<T> where T : class
    {
        int add(T entity, string query);
        DataTable getAll(string query);
        int remove(T entity, string query);

    }
}
