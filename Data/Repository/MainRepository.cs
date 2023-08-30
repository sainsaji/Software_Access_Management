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
        IDatabaseConnectionProvider _connectionProvider;
        ICommandFactory _commandFactory;
        public MainRepository(IDatabaseConnectionProvider connectionProvider, ICommandFactory commandFactory)
        {
            _connectionProvider = connectionProvider;
            _commandFactory = commandFactory;
        }
        public int add(T entity, string query)
        {
            int rowsAffected = 0;
            Type dataType = typeof(T);
            //Users user = entity as Users;
            using (MySqlConnection connection = _connectionProvider.GetConnection())
            {
                using (MySqlCommand command = _commandFactory.CreateCommand(query, connection))
                {
                    foreach (var property in dataType.GetProperties())
                    {
                        var propertyName = property.Name;
                        var propertyValue = property.GetValue(entity);
                        command.Parameters.AddWithValue($"@{propertyName}", propertyValue);

                    }
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        public DataTable getAll(string query)
        {
            using (MySqlConnection connection = _connectionProvider.GetConnection())
            {
                using (MySqlCommand command = _commandFactory.CreateCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    return dt;
                }
            }

        }

        public int remove(T entity, string query)
        {
            Type dataType = typeof(T);
            using (MySqlConnection connection = _connectionProvider.GetConnection())
            {
                using (MySqlCommand command = _commandFactory.CreateCommand(query, connection))
                {
                    foreach (var property in dataType.GetProperties())
                    {
                        var propertyName = property.Name;
                        var propertyValue = property.GetValue(entity);
                        command.Parameters.AddWithValue($"@{propertyName}", propertyValue);

                    }
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
    }
}
