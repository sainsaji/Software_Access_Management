using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace File_Acess_Management.Data.Repository
{
    public class UserManagementRepository : IUserManagementRepository
    {
        private readonly IDatabaseConnectionProvider _connectionProvider;
        private readonly ICommandFactory _commandFactory;
        public UserManagementRepository(IDatabaseConnectionProvider connectionProvider, ICommandFactory commandProvider) { 
            _connectionProvider = connectionProvider;
            _commandFactory = commandProvider;
        }

        public bool CheckUser(string username)
        {
            using (MySqlConnection connection = _connectionProvider.GetConnection())
            {
                string query = "Select * from users where user_name=@Username";
                using (MySqlCommand command = _commandFactory.CreateCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        public int InsertUser(Users user)
        {
            using (MySqlConnection connection = _connectionProvider.GetConnection())
            {
                    int roleId = user.SelectedRole.RoleId;  

                    string query = "INSERT INTO users (id, user_name, password, role_id, name, email, phone_number, address, manager_assigned) VALUES (0,@Username, @Password, @RoleId, @Name, @Email, @PhoneNumber, @Address, @Assigned)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@Password", user.HashedPassword);
                        command.Parameters.AddWithValue("@RoleId", roleId);
                        command.Parameters.AddWithValue("@Name", user.Name);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                        command.Parameters.AddWithValue("@Address", user.Address);
                        command.Parameters.AddWithValue("@Assigned", false);

                        int rowsAffected = command.ExecuteNonQuery(); ;
                        return rowsAffected;
                    }
            }
        }
    }
}
