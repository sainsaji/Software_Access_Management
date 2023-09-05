using File_Acess_Management.Models;
using MySql.Data.MySqlClient;
using System;

namespace File_Acess_Management
{
    public class AuthManager
    {
        public static (Users, string) AuthenticateUser(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM users WHERE user_name = @username";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPasswordFromDatabase = reader["password"].ToString();
                            Console.WriteLine(hashedPasswordFromDatabase);
                            Users user = GetUserByUsername(username);

                            if (user != null && BCrypt.Net.BCrypt.Verify(password, hashedPasswordFromDatabase))
                            {
                                string RoleName = IsAuthorized(user.RoleId);
                                return (user, RoleName);
                            }
                        }
                    }
                }
            }

            return (null, null);
        }

        private static Users GetUserByUsername(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM users WHERE user_name = @username";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Users(Convert.ToInt32(reader["id"]), reader["user_name"].ToString(), null, Convert.ToInt32(reader["role_id"]), null, null, null, null,false);
                            
                        }
                    }
                }
            }

            return null;
        }

        private static String IsAuthorized(int roleID)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT role_name FROM roles WHERE role_id = @roleId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roleId", roleID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string userRole = reader["role_name"].ToString();
                            return (userRole);
                        }
                    }
                }
            }

            return null;
        }
    }
}