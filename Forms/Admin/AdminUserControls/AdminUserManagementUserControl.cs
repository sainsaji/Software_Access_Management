﻿using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Models;
using File_Acess_Management.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace File_Acess_Management.Forms.Admin.ManagerUserControls
{
    public partial class AdminUserManagementUserControl : UserControl
    {
        private bool check = false;
        private Regex emailRegex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
        private Regex phoneRegex = new Regex(@"^\d{10}$");
        private Regex userNamePattern = new Regex(@"^[a-zA-Z0-9_]{3,20}$");
        private Regex namePattern = new Regex(@"^[a-zA-Z\s.]+$");
        private Regex passwordPattern = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");
        private int id = 0;

        private readonly IUserManagementRepository _userManagement;
        private ErrorProvider errorProvider = new ErrorProvider();

        public AdminUserManagementUserControl(IUserManagementRepository userManagementRepository)
        {
            _userManagement = userManagementRepository;
            InitializeComponent();
            InitializeErrorProvider();
            addBtn.Enabled = false;
            passwordText.PasswordChar = '*';
            generateLbl.Text = "";
        }

        private void InitializeErrorProvider()
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private bool ValidateRegexField(Control control, PictureBox tickPictureBox, Regex regex, string errorMessage, string requiredMessage)
        {
            bool isValid = !string.IsNullOrWhiteSpace(control.Text) && regex.IsMatch(control.Text);
            string message = isValid ? "" : (string.IsNullOrWhiteSpace(control.Text) ? requiredMessage : errorMessage);
            SetError(control, isValid, message);
            SetValidationIcon(tickPictureBox, isValid);
            if (control == userNameText)
            {
                Console.WriteLine("Checking Username Existence");
                bool check = _userManagement.CheckUser(userNameText.Text);
                isValid = !check;
                if (isValid == false)
                {
                    errorProvider.SetError(control, "User Already Exists");
                    SetValidationIcon(tickPictureBox, isValid);
                }
                else
                {
                    errorProvider.SetError(control, "");
                }

                Console.WriteLine("Username Existence" + isValid);
            }
            return isValid;
        }

        private void ValidateFields()
        {
            bool isUserNameValid = ValidateRegexField(userNameText, tickPicBox, userNamePattern, "Invalid User Name", "Username is required.");
            bool isPassValid = ValidateRegexField(passwordText, passPicBox, passwordPattern, "Invalid Pattern", "Password is required.");
            bool isNameValid = ValidateRegexField(nameText, namePicBox, namePattern, "Invalid Name", "Name is required.");
            bool isEmailValid = ValidateRegexField(emailText, emailPicBox, emailRegex, "Invalid email address.", "Valid email address required.");
            bool isPhoneValid = ValidateRegexField(phoneNumberText, phonePicBox, phoneRegex, "Invalid phone number.", "10-digit number required.");
            bool isAddressValid = ValidateRegexField(addressText, addressPicBox, namePattern, "Invalid Address", "Address is required.");
            bool isFormValid = isUserNameValid && isPassValid && isNameValid && isEmailValid && isPhoneValid && isAddressValid;
            addBtn.Enabled = isFormValid;
        }

        private void SetError(Control control, bool isValid, string errorMessage)
        {
            if (!isValid)
                errorProvider.SetError(control, errorMessage);
            else
                errorProvider.SetError(control, "");
        }

        private void SetValidationIcon(PictureBox tickPictureBox, bool isValid)
        {
            tickPictureBox.Visible = isValid;
        }

        private void Field_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void AdminUserManagementUserControl_Load(object sender, EventArgs e)
        {
            //deleteButton.Enabled = false;
            //updateButton.Enabled = false;
            deleteBtn.Enabled = false;
            updateBtn.Enabled = false;
            userRecordDataGridView.SelectionChanged += userRecordDataGridView_SelectionChanged_1;
            PopulateRoleComboBox();
            GetUsersRecord();
            setVisibilityFalse();
            userNameText.TextChanged += Field_TextChanged;
            passwordText.TextChanged += Field_TextChanged;
            nameText.TextChanged += Field_TextChanged;
            phoneNumberText.TextChanged += Field_TextChanged;
            emailText.TextChanged += Field_TextChanged;
            addressText.TextChanged += Field_TextChanged;
        }

        private void setVisibilityFalse()
        {
            tickPicBox.Visible = false;
            namePicBox.Visible = false;
            passPicBox.Visible = false;
            emailPicBox.Visible = false;
            phonePicBox.Visible = false;
            addressPicBox.Visible = false;
        }

        private void GetUsersRecord()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT u.id, u.user_name, r.role_name as role, u.name, u.email, u.phone_number, u.address FROM users AS u INNER JOIN roles AS r ON u.role_id = r.role_id WHERE r.role_name!='Admin';";
                DataTable dt = _userManagement.getAll(query);
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

        private void PopulateRoleComboBox()
        {
            string query = "SELECT role_id, role_name FROM roles where role_name!='Admin'";
            DataTable dt = _userManagement.getAll(query);
            foreach (DataRow row in dt.Rows)
            {
                int roleId = Convert.ToInt32(row["role_id"]);
                string roleName = row["role_name"].ToString();
                roleComboBox.Items.Add(new Role(roleId, roleName));
                roleComboBox.SelectedIndex = 0;
            }
        }

        private void ClearFormFields()
        {
            //deleteButton.Enabled = false;
            //updateButton.Enabled = false;
            deleteBtn.Enabled = true;
            updateBtn.Enabled = true;

            userNameText.Enabled = true;
            passwordText.Enabled = true;
            setVisibilityFalse();
            userRecordDataGridView.ClearSelection();
            // Clear the form fields
            userNameText.Text = "";
            passwordText.Text = "";
            roleComboBox.SelectedIndex = -1;
            nameText.Text = "";
            emailText.Text = "";
            phoneNumberText.Text = "";
            addressText.Text = "";
            generateLbl.Text = "";
            setVisibilityFalse();
            errorProvider.SetError(passwordText, "");
            errorProvider.SetError(roleComboBox, "");
            errorProvider.SetError(nameText, "");
            errorProvider.SetError(emailText, "");
            errorProvider.SetError(phoneNumberText, "");
            errorProvider.SetError(addressText, "");
        }

        private void userRecordDataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            {
                // This event is triggered when the selection in DataGridView changes
                if (userRecordDataGridView.SelectedRows.Count > 0)
                {
                    check = true;
                    userNameText.Enabled = false;
                    passwordText.Enabled = false;
                    errorProvider.SetError(userNameText, "");
                    errorProvider.SetError(passwordText, "");
                    autoGenPassBtn.Enabled = false;
                    deleteBtn.Enabled = true;
                    updateBtn.Enabled = true;
                    DataGridViewRow selectedRow = userRecordDataGridView.SelectedRows[0];

                    // Assuming you have TextBox controls for updating data
                    id = (int)selectedRow.Cells["id"].Value;
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
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            {
                string password = passwordText.Text;
                string HashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                Role SelectedRole = (Role)roleComboBox.SelectedItem;
                bool ck = false;
                Console.WriteLine(emailText.Text);

                if (SelectedRole == null)
                {
                    MessageBox.Show("Please select a role");
                    errorProvider.SetError(roleComboBox, "Please Select a role");
                    return;
                }
                else if (ck == true)
                {
                    MessageBox.Show("Select a unique username");
                    return;
                }
                Users users = new Users(0, userNameText.Text, HashedPassword, SelectedRole.RoleId, nameText.Text, emailText.Text, phoneNumberText.Text, addressText.Text, false);

                try
                {
                    Console.WriteLine(users.Email);
                    using (MailMessage mm = new MailMessage())
                    {
                        using (SmtpClient sc = new SmtpClient("smtp.gmail.com"))
                        {
                            string query = "INSERT INTO users (id, user_name, password, role_id, name, email, phone_number, address, manager_assigned) VALUES (@Id,@Username, @HashedPassword, @RoleId, @Name, @Email, @PhoneNumber, @Address, @Assigned)";
                            int rowsAffected = _userManagement.add(users, query);
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

                            mm.From = new MailAddress("resumework2022@gmail.com");
                            if (Settings.Default.DebugMode)
                            {
                                mm.To.Add(Settings.Default.DebugEmail);
                            }
                            else
                            {
                                mm.To.Add(users.Email);
                            }
                            mm.Subject = "Credentials to the App";
                            mm.Body = "Hi There, \n" +
                                "\nWelcome to Software Access management System\n" +
                                "\n Username: " + users.Username +
                                "\n Password: " + password;
                            sc.Port = 587;
                            sc.Credentials = new System.Net.NetworkCredential("resumework2022@gmail.com", "uqdbenfkuzuhvwfl");
                            sc.EnableSsl = true;
                            await sc.SendMailAsync(mm);
                            MessageBox.Show("Email has been sent.");
                            //int rowsAffected = _userManagement.InsertUser(users);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error in mail, enter correct email address" + ex);
                    string query = "delete from users where user_name=@Username";
                    int rowsAffected = _userManagement.remove(users, query);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            {

                {
                    string password = passwordText.Text;
                    string HashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                    Role SelectedRole = (Role)roleComboBox.SelectedItem;
                    Users users = new Users(0, userNameText.Text, HashedPassword, SelectedRole.RoleId, nameText.Text, emailText.Text, phoneNumberText.Text, addressText.Text, false);
                    if (users.Username == "" && password == "" && users.Name == "" && users.Email == "" && users.PhoneNumber == "" && users.Address == "")
                    {
                        MessageBox.Show("Please don't submit blank fields");
                        return;
                    }
                    else if (SelectedRole == null)
                    {
                        MessageBox.Show("Please select a role");
                        return;
                    }
                    string query = "UPDATE users SET role_id = @RoleId, name = @Name, email = @Email, phone_number = @PhoneNumber, address = @Address WHERE user_name = @Username;";
                    int rowsAffected = _userManagement.add(users, query);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully.");
                        GetUsersRecord();
                        ClearFormFields();
                        //updateButton.Enabled = false;
                        updateBtn.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error updating user.");
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            {
                if (check == true)
                {
                    Users users = new Users(0, userNameText.Text, null, 0, null, null, null, null, false);
                    users.Username = userNameText.Text;

                    string query = "Delete from users where user_name=@Username";
                    int rowsAffected = _userManagement.remove(users, query);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully.");
                        GetUsersRecord();
                        ClearFormFields();
                        check = false;
                        //deleteButton.Enabled = false;
                        deleteBtn.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error Updating User.");
                    }
                }
                else
                {
                    MessageBox.Show("No User Selected.");
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string generatedPass = generateStrongPass();
            passwordText.Text = generatedPass;
            generateLbl.Text = "Password Generated";
        }

        private string generateStrongPass()
        {
            // Define character sets for each password requirement
            string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digitChars = "0123456789";
            string specialChars = "!@#$%^&*()_+-=[]{}|;:'\"<>,.?/";

            // Combine all character sets
            string allChars = lowercaseChars + uppercaseChars + digitChars + specialChars;

            // Create a secure random number generator
            using (var rng = new RNGCryptoServiceProvider())
            {
                StringBuilder password = new StringBuilder();

                // Add at least one character from each required set
                password.Append(GetRandomCharacter(lowercaseChars, rng));
                password.Append(GetRandomCharacter(uppercaseChars, rng));
                password.Append(GetRandomCharacter(digitChars, rng));
                password.Append(GetRandomCharacter(specialChars, rng));

                // Add random characters to meet the length requirement
                int requiredLength = 8;
                while (password.Length < requiredLength)
                {
                    password.Append(GetRandomCharacter(allChars, rng));
                }

                return password.ToString();
            }

        }

        static char GetRandomCharacter(string characterSet, RNGCryptoServiceProvider rng)
        {
            byte[] randomBytes = new byte[1];
            rng.GetBytes(randomBytes);
            int index = randomBytes[0] % characterSet.Length;
            return characterSet[index];
        }
    }
}