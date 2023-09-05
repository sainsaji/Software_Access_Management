using File_Acess_Management.Models;
using File_Acess_Management.Properties;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace File_Acess_Management
{
    public partial class UserLogin : Form
    {
        private readonly ServiceProvider _serviceProvider;

        public UserLogin(ServiceProvider serviceProvider)
        {

            _serviceProvider = serviceProvider;
            InitializeComponent();
            checkDebug();
            DoubleBuffered = true;

        }

        private void checkDebug()
        {
            bool debugSetting = Settings.Default.DebugMode;
            if (debugSetting)
            {
                debugLabel.Visible = true;
                debugLabel.Text = "Debug Mode is On";
                adminIcon.Visible = true;
                managerIcon.Visible = true;
                userIcon.Visible = true;
            }
            else
            {
                debugLabel.Visible = false;
                adminIcon.Visible = false;
                managerIcon.Visible = false;
                userIcon.Visible = false;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameText.Text;
            string password = userPasswordText.Text;
            //Console.WriteLine(username);
            //Console.WriteLine(password);
            (User user, string RoleName) = AuthManager.AuthenticateUser(username, password);
            if (user != null)
            {
                //Console.WriteLine(user.RoleId);
                Console.WriteLine(RoleName);
                if (RoleName == "Manager")
                {
                    //MessageBox.Show("Login successful as Manager!");
                    ManagerDashboard subManagers = new ManagerDashboard(user, _serviceProvider);
                    subManagers.Show();
                    this.Hide();
                }
                else if (RoleName == "User")
                {
                    //MessageBox.Show("Login successful as User!");
                    // Proceed to user dashboard or functionality
                    UserDashboard userDashBoard = new UserDashboard(user, _serviceProvider);
                    userDashBoard.Show();
                    this.Hide();
                }
                else if (RoleName == "Admin")
                {
                    //MessageBox.Show("Login successful as Admin!");
                    AdminDashboard admin = new AdminDashboard(_serviceProvider);
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You do not have the required role to log in.");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void adminIcon_Click(object sender, EventArgs e)
        {
            string adminId = Settings.Default.DebugAdminID;
            string adminPass = Settings.Default.DebugAdminPass;
            (User user, string RoleName) = AuthManager.AuthenticateUser(adminId, adminPass);
            AdminDashboard admin = new AdminDashboard(_serviceProvider);
            admin.Show();
            this.Hide();
        }

        private void managerIcon_Click(object sender, EventArgs e)
        {
            string managerId = Settings.Default.DebugManagerID;
            string managerPass = Settings.Default.DebugManagerPass;
            (User user, string RoleName) = AuthManager.AuthenticateUser(managerId, managerPass);
            ManagerDashboard subManagers = new ManagerDashboard(user, _serviceProvider);
            subManagers.Show();
            this.Hide();
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            string userId = Settings.Default.DebugUserID;
            string userPass = Settings.Default.DebugUserPass;
            (User user, string RoleName) = AuthManager.AuthenticateUser(userId, userPass);
            UserDashboard userDashBoard = new UserDashboard(user, _serviceProvider);
            userDashBoard.Show();
            this.Hide();
        }
    }
}