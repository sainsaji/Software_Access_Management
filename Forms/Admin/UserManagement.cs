using File_Acess_Management.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace File_Acess_Management
{
    public partial class UserManagement : Form
    {
        bool check = false;
        public UserManagement()
        {
            InitializeComponent();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            deleteButton.Enabled = false;
            updateButton.Enabled = false;

            // Attach the SelectionChanged event handler to the DataGridView
            userRecordDataGridView.SelectionChanged += userRecordDataGridView_SelectionChanged;
            PopulateRoleComboBox();
            GetUsersRecord();
            tickPicBox.Visible = false;
            namePicBox.Visible = false;
            passPicBox.Visible = false;
            emailPicBox.Visible = false;
            phonePicBox.Visible = false;
            addressPicBox.Visible = false;
        }

        private void userRecordDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // This event is triggered when the selection in DataGridView changes
            if (userRecordDataGridView.SelectedRows.Count > 0)
            {
                check = true;
                userNameText.Enabled = false;
                passwordText.Enabled = false;
                deleteButton.Enabled = true;
                updateButton.Enabled = true;
                DataGridViewRow selectedRow = userRecordDataGridView.SelectedRows[0];

                // Assuming you have TextBox controls for updating data
                userNameText.Text = selectedRow.Cells["user_name"].Value.ToString();
                emailText.Text = selectedRow.Cells["email"].Value.ToString();
                nameText.Text = selectedRow.Cells["name"].Value.ToString();
                phoneNumberText.Text = selectedRow.Cells["phone_number"].Value.ToString();
                addressText.Text = selectedRow.Cells["address"].Value.ToString();

                // Set the selected role in the ComboBox
                string role_name = selectedRow.Cells["role"].Value.ToString();
                // using linq expression here especially FirstOrDefault
                // FirstOrDefault(...) finds the first item that matches the specified condition. In this case, it's looking for an item with a RoleId equal to the roleId variable.
                Role roleItem = roleComboBox.Items.OfType<Role>().FirstOrDefault(item => item.RoleName == role_name);
                if (roleItem != null)
                {
                    roleComboBox.SelectedItem = roleItem;
                }
            }
        }

        private void GetUsersRecord()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT u.user_name, r.role_name as role, u.name, u.email, u.phone_number, u.address FROM users AS u INNER JOIN roles AS r ON u.role_id = r.role_id WHERE r.role_name!='Admin';";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                        connection.Close();
                    }
                    userRecordDataGridView.DataSource = dt;
                    //studentRecordDataGridView.Columns["Password"].Visible = false;
                    userRecordDataGridView.Columns["user_name"].HeaderText = "User Name";
                    userRecordDataGridView.Columns["role"].HeaderText = "Role";
                    userRecordDataGridView.Columns["name"].HeaderText = "Full Name";
                    userRecordDataGridView.Columns["email"].HeaderText = "Email";
                    userRecordDataGridView.Columns["phone_number"].HeaderText = "Phone Number";
                    userRecordDataGridView.Columns["address"].HeaderText = "Address";
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
            string name = nameText.Text;
            string email = emailText.Text;
            string phno = phoneNumberText.Text;
            string address = addressText.Text;
            bool check = false;

            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();
                string query = "Select * from users where user_name=@Username";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            check = true;
                        }
                    }
                }
            }

            if (username == "" && password == "" && name == "" && email == "" && phno == "" && address == "")
            {
                MessageBox.Show("Please don't submit blank fields");
                return;
            }
            else if (selectedRole == null)
            {
                MessageBox.Show("Please select a role");
                return;
            }
            else if (check == true)
            {
                MessageBox.Show("Select a unique username");
                return;
            }

            try
            {
                using (MailMessage mm = new MailMessage())
                {
                    using (SmtpClient sc = new SmtpClient("smtp.gmail.com"))
                    {
                        mm.From = new MailAddress("resumework2022@gmail.com");
                        mm.To.Add(email);
                        mm.Subject = "Credentials to the App";
                        mm.Body = "Hi There, \n" +
                            "\nWelcome to Software Access management System\n" +
                            "\n Username: "+username+
                            "\n Password: "+password;
                        sc.Port = 587;
                        sc.Credentials = new System.Net.NetworkCredential("resumework2022@gmail.com", "uqdbenfkuzuhvwfl");
                        sc.EnableSsl = true;
                        sc.Send(mm);
                        MessageBox.Show("Email has been sent.");
                        using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                        {
                            int roleId = selectedRole.RoleId;
                            connection.Open();

                            string query = "INSERT INTO users (id, user_name, password, role_id, name, email, phone_number, address, manager_assigned) VALUES (0,@Username, @Password, @RoleId, @Name, @Email, @PhoneNumber, @Address, @Assigned)";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Username", username);
                                command.Parameters.AddWithValue("@Password", hashedPassword);
                                command.Parameters.AddWithValue("@RoleId", roleId);
                                command.Parameters.AddWithValue("@Name", name);
                                command.Parameters.AddWithValue("@Email", email);
                                command.Parameters.AddWithValue("@PhoneNumber", phno);
                                command.Parameters.AddWithValue("@Address", address);
                                command.Parameters.AddWithValue("@Assigned", false);

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
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error in mail, enter correct email address" + ex);
            }
            

            
        }
        private void ClearFormFields()
        {
            deleteButton.Enabled = false;
            updateButton.Enabled = false;
            userNameText.Enabled = true;
            passwordText.Enabled = true;
            tickPicBox.Visible = false;
            passPicBox.Visible = false;
            namePicBox.Visible = false;
            emailPicBox.Visible = false;
            phonePicBox.Visible = false;
            addressPicBox.Visible = false;
            userRecordDataGridView.ClearSelection();
            // Clear the form fields
            userNameText.Text = "";
            passwordText.Text = "";
            roleComboBox.SelectedIndex = -1;
            nameText.Text = "";
            emailText.Text = "";
            phoneNumberText.Text = "";
            addressText.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string username = userNameText.Text;
            string password = passwordText.Text;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            Role selectedRole = (Role)roleComboBox.SelectedItem;
            string name = nameText.Text;
            string email = emailText.Text;
            string phno = phoneNumberText.Text;
            string address = addressText.Text;
            if (username == "" && password == "" && name == "" && email == "" && phno == "" && address == "")
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
                int roleId = selectedRole.RoleId;
                connection.Open();

                string query = "UPDATE users SET role_id = @RoleId, name = @Name, email = @Email, phone_number = @PhoneNumber, address = @Address WHERE user_name = @Username;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@RoleId", roleId);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phno);
                    command.Parameters.AddWithValue("@Address", address);

                    int rowsAffected = command.ExecuteNonQuery(); ;
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully.");
                        GetUsersRecord();
                        ClearFormFields();
                        updateButton.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error updating user.");
                    }
                }

                connection.Close();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                string username = userNameText.Text;
                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    connection.Open();

                    string query = "Delete from users where user_name=@Username";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = command.ExecuteNonQuery(); ;
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully.");
                            GetUsersRecord();
                            ClearFormFields();
                            check = false;
                            deleteButton.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Error deleting user.");
                        }
                    }

                    connection.Close();
                }
            }

        }

        private void userNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameText_Leave(object sender, EventArgs e)
        {
            string field = "user_name";
            bool valid = validateText(userNameText.Text, field);
            Console.WriteLine("Username validity is: " + valid);
        }

        private bool validateText(string fieldText, string field)
        {
            string userNamePattern = @"^[a-zA-Z0-9_]{3,20}$";
            string namePattern = @"^[a-zA-Z\s.]+$";
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$";
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string phonePattern = @"^\d{10}$";

            bool isValid = false;

            switch (field)
            {
                case "user_name":
                    isValid = Regex.IsMatch(fieldText, userNamePattern);
                    if (isValid)
                    {
                        // Perform duplication check
                        using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                        {
                            try
                            {
                                connection.Open();
                                string query = "SELECT user_name FROM users WHERE user_name = @fieldvalue";
                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@fieldvalue", fieldText);

                                    using (MySqlDataReader reader = command.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            Console.WriteLine("Already Exists in DB");
                                            userNameErrorProvider.SetError(userNameText, "Already Exists in DB");
                                            tickPicBox.Visible = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Username is available");
                                            userNameErrorProvider.SetError(userNameText, "");
                                            tickPicBox.Visible = true;
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }
                        }
                    }
                    break;

                case "name":
                    isValid = Regex.IsMatch(fieldText, namePattern);
                    if (isValid)
                    {
                        namePicBox.Visible = true;
                        nameErrorProvider.SetError(nameText, "");
                    }
                    else
                    {
                        namePicBox.Visible = false;
                        nameErrorProvider.SetError(nameText, "Invalid Name");
                    }
                    break;

                case "password":
                    isValid = Regex.IsMatch(fieldText, passwordPattern);
                    if (isValid)
                    {
                        passPicBox.Visible = true;
                        passErrorProvider.SetError(passwordText, "");
                    }
                    else
                    {
                        passErrorProvider.SetError(passwordText, "Invalid Password");
                        passPicBox.Visible = false;

                    }
                    break;

                case "email":
                    isValid = Regex.IsMatch(fieldText, emailPattern);
                    if (isValid)
                    {
                        using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                        {
                            try
                            {
                                connection.Open();
                                string query = "SELECT email FROM users WHERE email = @fieldvalue";
                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@fieldvalue", fieldText);

                                    using (MySqlDataReader reader = command.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            Console.WriteLine("Already Exists in DB");
                                            emailErrorProvider.SetError(emailText, "Email Already Exists in DB");
                                            emailPicBox.Visible = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Email is available");
                                            emailErrorProvider.SetError(emailText, "");
                                            emailPicBox.Visible = true;
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        emailErrorProvider.SetError(emailText, "Invalid Email");
                    }
                    break;

                case "phone_number":
                    isValid = Regex.IsMatch(fieldText, phonePattern);
                    if (isValid)
                    {
                        phonePicBox.Visible = true;
                        phoneErrorProvider.SetError(nameText, "");
                    }
                    else
                    {
                        phonePicBox.Visible = false;
                        phoneErrorProvider.SetError(nameText, "Invalid Phone Number");
                    }
                    break;
                case "address":
                    isValid = Regex.IsMatch(fieldText, namePattern);
                    if (isValid)
                    {
                        addressPicBox.Visible = true;
                        addressErrorProvider.SetError(nameText, "");
                    }
                    else
                    {
                        addressPicBox.Visible = false;
                        addressErrorProvider.SetError(nameText, "Invalid Address Given");
                    }
                    break;
            }

            return isValid;
        }

        private void nameText_Leave(object sender, EventArgs e)
        {
            string field = "name";
            bool valid = validateText(nameText.Text, field);
            Console.WriteLine("Name validity is: " + valid);
        }

        private void passwordText_Leave(object sender, EventArgs e)
        {
            string field = "password";
            bool valid = validateText(passwordText.Text, field);
            Console.WriteLine(field + " validity is: " + valid);
        }

        private void emailText_Leave(object sender, EventArgs e)
        {
            string field = "email";
            bool valid = validateText(emailText.Text, field);
            Console.WriteLine(field + " validity is: " + valid);
        }

        private void phoneNumberText_Leave(object sender, EventArgs e)
        {
            string field = "phone_number";
            bool valid = validateText(phoneNumberText.Text, field);
            Console.WriteLine(field + " validity is: " + valid);
        }

        private void addressText_Leave(object sender, EventArgs e)
        {
            string field = "address";
            bool valid = validateText(addressText.Text, field);
            Console.WriteLine(field + " validity is: " + valid);
        }
    }
}
