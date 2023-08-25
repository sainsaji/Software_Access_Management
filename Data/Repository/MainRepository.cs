using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Models;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Acess_Management.Data.Repository
{
    public class MainRepository<T> : IMainRepository<T> where T : class
    {
        IServiceProvider _serviceProvider;
        IDatabaseConnectionProvider _connectionProvider;
        ICommandFactory _commandFactory;
        public MainRepository(IDatabaseConnectionProvider connectionProvider, ICommandFactory commandFactory)
        {
            //_serviceProvider = serviceProvider;
            //_connectionProvider=_serviceProvider.GetRequiredService<IDatabaseConnectionProvider>();
            //_commandFactory=_serviceProvider.GetRequiredService<ICommandFactory>();
            _connectionProvider = connectionProvider;
            _commandFactory = commandFactory;
        }
        public int add(T entity, string query)
        {
            int rowsAffected = 0;
            Type dataType = typeof(T);
            if (dataType == typeof(Users))
            {
                Users user = entity as Users;
                if (user != null)
                {
                    using (MySqlConnection connection = _connectionProvider.GetConnection())
                    {


                        using (MySqlCommand command = _commandFactory.CreateCommand(query, connection))
                        {
                            foreach (var property in dataType.GetProperties())
                            {
                                Console.WriteLine("I am innnnnnnnn");
                                var propertyName = property.Name;
                                var propertyValue = property.GetValue(user);
                                command.Parameters.AddWithValue($"@{propertyName}", propertyValue);

                            }
                            rowsAffected = command.ExecuteNonQuery();
                        }


                    }
                    return rowsAffected;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public DataTable getAll()
        {
            throw new NotImplementedException();
        }

        public int remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
