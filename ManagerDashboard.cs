using File_Acess_Management.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace File_Acess_Management
{
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {

            studentRecordDataGridView.AllowUserToAddRows = false;
            studentRecordDataGridView.ReadOnly = true;
            PopulateRoleComboBox();
            GetUsersRecord();
        }

        private void GetUsersRecord()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT u.user_name, r.role_name as role, u.name, u.email, u.phone_number, u.address FROM users AS u INNER JOIN roles AS r ON u.role_id = r.role_id WHERE r.role_name!='Admin';";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable dt= new DataTable();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load (reader);
                        connection.Close ();
                    }
                    studentRecordDataGridView.DataSource = dt;
                    //studentRecordDataGridView.Columns["Password"].Visible = false;
                }
            }
        }
        private void PopulateRoleComboBox()
        {
            // Assuming you have a ComboBox named roleComboBox
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT role_id, role_name FROM roles where role_name!='Admin'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int roleId = reader.GetInt32("role_id");
                            string roleName = reader.GetString("role_name");
                            roleComboBox.Items.Add(new Role(roleId, roleName));
                        }
                    }
                }

                connection.Close();
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string username = userNameText.Text;
            string password = passwordText.Text;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            Role selectedRole = (Role)roleComboBox.SelectedItem;
            int roleId = selectedRole.RoleId;
            string name = nameText.Text;
            string email = emailText.Text;
            string phno = phoneNumberText.Text;
            string address = addressText.Text;

            if (username == null && password == null && name == null && email == null && phno == null && address == null)
            {
                MessageBox.Show("Please don't submit blank fields");
                return;
            }
            else if (selectedRole == null)
            {
                MessageBox.Show("Please select a role");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO users (id, user_name, password, role_id, name, email, phone_number, address) VALUES (0,@Username, @Password, @RoleId, @Name, @Email, @PhoneNumber, @Address)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@RoleId", roleId);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phno);
                    command.Parameters.AddWithValue("@Address", address);

                    int rowsAffected = command.ExecuteNonQuery(); ;
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User added successfully.");
                        GetUsersRecord(); 
                        ClearFormFields(); 
                    }
                    else
                    {
                        MessageBox.Show("Error adding user.");
                    }
                }

                connection.Close();
            }
        }
        private void ClearFormFields()
        {
            // Clear the form fields
            userNameText.Text = "";
            passwordText.Text = "";
            roleComboBox.SelectedIndex = -1;
            nameText.Text = "";
            emailText.Text = "";
            phoneNumberText.Text = "";
            addressText.Text = "";
        }
    }
}
