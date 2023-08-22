using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using File_Acess_Management.Models;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;

namespace File_Acess_Management
{
    public partial class UserLogin : Form
    {
        private const string ConnectionString = "Server=localhost;Database=fms;User=root;Password=root;";
        private readonly ServiceProvider _serviceProvider;
        public UserLogin(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameText.Text;
            string password = userPasswordText.Text;
            //Console.WriteLine(username);
            //Console.WriteLine(password);
            (User user, string RoleName) = AuthManager.AuthenticateUser(username, password);
            if (user!=null)
            {
                //Console.WriteLine(user.RoleId);
                Console.WriteLine(RoleName);
                if (RoleName=="Manager")
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
                    AdminDashboard admin  =new AdminDashboard(_serviceProvider);
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
    }
}

