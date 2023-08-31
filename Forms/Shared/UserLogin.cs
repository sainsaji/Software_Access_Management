using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using File_Acess_Management.Models;
using File_Acess_Management.Properties;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            (User user, string RoleName) = AuthManager.AuthenticateUser("A01", "Admin");
            AdminDashboard admin = new AdminDashboard(_serviceProvider);
            admin.Show();
            this.Hide();
        }

        private void managerIcon_Click(object sender, EventArgs e)
        {
            (User user, string RoleName) = AuthManager.AuthenticateUser("M002", "Manager");
            ManagerDashboard subManagers = new ManagerDashboard(user, _serviceProvider);
            subManagers.Show();
            this.Hide();
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            (User user, string RoleName) = AuthManager.AuthenticateUser("U002", "User");
            UserDashboard userDashBoard = new UserDashboard(user, _serviceProvider);
            userDashBoard.Show();
            this.Hide();
        }
    }
}

