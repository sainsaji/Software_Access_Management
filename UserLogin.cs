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
using MySql.Data.MySqlClient;

namespace File_Acess_Management
{
    public partial class UserLogin : Form
    {
        private const string ConnectionString = "Server=localhost;Database=fms;User=root;Password=root;";
        public UserLogin()
        {
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
                if (RoleName=="Admin")
                {
                    MessageBox.Show("Login successful as Admin!");
                    // Proceed to admin dashboard or functionality
                }
                else if (RoleName == "User")
                {
                    MessageBox.Show("Login successful as User!");
                    // Proceed to user dashboard or functionality
                }
                else if (RoleName == "ITHead")
                {
                    MessageBox.Show("Login successful as ITHead!");
                    // Proceed to user dashboard or functionality
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
        
    }
}

