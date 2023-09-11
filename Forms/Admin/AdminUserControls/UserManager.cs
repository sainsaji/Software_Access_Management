using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Models;
using File_Acess_Management.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Acess_Management.Forms.Admin.AdminUserControls
{
    public partial class UserManager : DevExpress.XtraEditors.XtraUserControl
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

        public UserManager(IUserManagementRepository userManagementRepository)
        {
            _userManagement = userManagementRepository;
            InitializeComponent();
            InitializeErrorProvider();
            addBtn.Enabled = false;
            barAddBtn.Enabled = false;
            passwordText.Properties.PasswordChar = '*';
            generateLabel.Text = "";
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
            if (control == usernameText)
            {
                Console.WriteLine("Checking Username Existence");
                bool check = _userManagement.CheckUser(usernameText.Text);
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
            bool isUserNameValid = ValidateRegexField(usernameText, usernameValid, userNamePattern, "Invalid User Name", "Username is required.");
            bool isPassValid = ValidateRegexField(passwordText, passValid, passwordPattern, "Invalid Pattern", "Password is required.");
            bool isNameValid = ValidateRegexField(nameText, nameValid, namePattern, "Invalid Name", "Name is required.");
            bool isEmailValid = ValidateRegexField(emailText, emailValid, emailRegex, "Invalid email address.", "Valid email address required.");
            bool isPhoneValid = ValidateRegexField(phoneNumberText, phoneValid, phoneRegex, "Invalid phone number.", "10-digit number required.");
            bool isAddressValid = ValidateRegexField(addressText, addressValid, namePattern, "Invalid Address", "Address is required.");
            bool isFormValid = isUserNameValid && isPassValid && isNameValid && isEmailValid && isPhoneValid && isAddressValid;
            addBtn.Enabled = isFormValid;
            barAddBtn.Enabled = isFormValid;
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
        private void setVisibilityFalse()
        {
            usernameValid.Visible = false;
            nameValid.Visible = false;
            passValid.Visible = false;
            emailValid.Visible = false;
            phoneValid.Visible = false;
            addressValid.Visible = false;
        }

        private void GetUsersRecord()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT u.id, u.user_name, r.role_name as role, u.name, u.email, u.phone_number, u.address FROM users AS u INNER JOIN roles AS r ON u.role_id = r.role_id WHERE r.role_name!='Admin';";
                DataTable dt = _userManagement.getAll(query);
                userGridControl.DataSource = dt;
                //studentRecordDataGridView.Columns["Password"].Visible = false;
                userGrid.Columns["user_name"].Caption = "User Name";
                userGrid.Columns["role"].Caption = "Role";
                userGrid.Columns["name"].Caption = "Full Name";
                userGrid.Columns["email"].Caption = "Email";
                userGrid.Columns["phone_number"].Caption = "Phone Number";
                userGrid.Columns["address"].Caption = "Address";
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
                roleCombo.Properties.Items.Add(new Role(roleId, roleName));
                roleCombo.SelectedIndex = 0;
            }
        }

        private void ClearFormFields()
        {
            //deleteButton.Enabled = false;
            //updateButton.Enabled = false;
            deleteBtn.Enabled = true;
            barDeleteBtn.Enabled = true;
            updateBtn.Enabled = true;
            barUpdateBtn.Enabled = true;

            usernameText.Enabled = true;
            passwordText.Enabled = true;
            setVisibilityFalse();
            userGrid.ClearSelection();
            // Clear the form fields
            usernameText.Text = "";
            passwordText.Text = "";
            roleCombo.SelectedIndex = -1;
            nameText.Text = "";
            emailText.Text = "";
            phoneNumberText.Text = "";
            addressText.Text = "";
            generateLabel.Text = "";
            setVisibilityFalse();
            errorProvider.SetError(passwordText, "");
            errorProvider.SetError(roleCombo, "");
            errorProvider.SetError(nameText, "");
            errorProvider.SetError(emailText, "");
            errorProvider.SetError(phoneNumberText, "");
            errorProvider.SetError(addressText, "");
        }
        private void Field_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void updateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            deleteBtn.Enabled = false;
            barDeleteBtn.Enabled = false;
            updateBtn.Enabled = false;
            barUpdateBtn.Enabled = false;
            userGrid.FocusedRowChanged += userGrid_FocusedRowChanged;
            PopulateRoleComboBox();
            GetUsersRecord();
            setVisibilityFalse();
            usernameText.TextChanged += Field_TextChanged;
            passwordText.TextChanged += Field_TextChanged;
            nameText.TextChanged += Field_TextChanged;
            phoneNumberText.TextChanged += Field_TextChanged;
            emailText.TextChanged += Field_TextChanged;
            addressText.TextChanged += Field_TextChanged;
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            {
                string password = passwordText.Text;
                string HashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                Role SelectedRole = (Role)roleCombo.SelectedItem;
                bool ck = false;
                Console.WriteLine(emailText.Text);

                if (SelectedRole == null)
                {
                    MessageBox.Show("Please select a role");
                    errorProvider.SetError(roleCombo, "Please Select a role");
                    return;
                }
                else if (ck == true)
                {
                    MessageBox.Show("Select a unique username");
                    return;
                }
                Users users = new Users(0, usernameText.Text, HashedPassword, SelectedRole.RoleId, nameText.Text, emailText.Text, phoneNumberText.Text, addressText.Text, false);

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
                string password = passwordText.Text;
                string HashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                Role SelectedRole = (Role)roleCombo.SelectedItem;
                Users users = new Users(0, usernameText.Text, HashedPassword, SelectedRole.RoleId, nameText.Text, emailText.Text, phoneNumberText.Text, addressText.Text, false);
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            {
                if (check == true)
                {
                    Users users = new Users(0, usernameText.Text, null, 0, null, null, null, null, false);
                    users.Username = usernameText.Text;

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
                        barDeleteBtn.Enabled = false;
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
            autoGenBtn.Enabled = true;
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

        private void autoGenBtn_Click(object sender, EventArgs e)
        {
            string generatedPass = generateStrongPass();
            passwordText.Text = generatedPass;
            generateLabel.Text = "Password Generated";
        }



        private void userGrid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (e.FocusedRowHandle >= 0)
            {
                check = true;
                usernameText.Enabled = false;
                passwordText.Enabled = false;
                errorProvider.SetError(usernameText, "");
                errorProvider.SetError(passwordText, "");
                autoGenBtn.Enabled = false;
                deleteBtn.Enabled = true;
                barDeleteBtn.Enabled = true;
                updateBtn.Enabled = true;
                barUpdateBtn.Enabled = true;

                // Assuming you have TextBox controls for updating data
                id = (int)userGrid.GetRowCellValue(e.FocusedRowHandle, "id");
                usernameText.Text = userGrid.GetRowCellValue(e.FocusedRowHandle, "user_name").ToString();
                emailText.Text = userGrid.GetRowCellValue(e.FocusedRowHandle, "email").ToString();
                nameText.Text = userGrid.GetRowCellValue(e.FocusedRowHandle, "name").ToString();
                phoneNumberText.Text = userGrid.GetRowCellValue(e.FocusedRowHandle, "phone_number").ToString();
                addressText.Text = userGrid.GetRowCellValue(e.FocusedRowHandle, "address").ToString();

                // Set the selected role in the ComboBox
                string role_name = userGrid.GetRowCellValue(e.FocusedRowHandle, "role").ToString();
                Role roleItem = roleCombo.Properties.Items.OfType<Role>().FirstOrDefault(item => item.RoleName == role_name);
                if (roleItem != null)
                {
                    roleCombo.SelectedItem = roleItem;
                }
            }

        }

        
    }
}
