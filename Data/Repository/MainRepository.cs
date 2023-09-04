using File_Acess_Management.Data.Repository.IRepository;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace File_Acess_Management.Data.Repository
{
    public class MainRepository<T> : IMainRepository<T> where T : class
    {
        private IDatabaseConnectionProvider _connectionProvider;
        private ICommandFactory _commandFactory;

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

        public DataTable get(T entity, string query)
        {
            Type dataType = typeof(T);
            using (MySqlConnection connection = _connectionProvider.GetConnection())
            {
                using (MySqlCommand command = _commandFactory.CreateCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    foreach (var property in dataType.GetProperties())
                    {
                        var propertyName = property.Name;
                        var propertyValue = property.GetValue(entity);
                        command.Parameters.AddWithValue($"@{propertyName}", propertyValue);
                    }
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