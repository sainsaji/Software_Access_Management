using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Acess_Management
{
    public partial class userAssignedForm : Form
    {
        public userAssignedForm()
        {
            InitializeComponent();
        }

        private void userAssignedForm_Load(object sender, EventArgs e)
        {
            GetUsersRecord();
            LoadAssignedUsers();
        }

        private void GetUsersRecord()
        {

        }


        private void LoadAssignedUsers()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT u.user_name, r.role_name as role, u.name, u.email, u.phone_number, u.address FROM users AS u INNER JOIN roles AS r ON u.role_id = r.role_id WHERE r.role_name = 'User' AND u.manager_assigned = 'false';";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                        connection.Close();
                    }
                    notAssignedManagerDataGridView.DataSource = dt;
                    //studentRecordDataGridView.Columns["Password"].Visible = false;
                    notAssignedManagerDataGridView.Columns["user_name"].HeaderText = "User Name";
                    notAssignedManagerDataGridView.Columns["role"].HeaderText = "Role";
                    notAssignedManagerDataGridView.Columns["name"].HeaderText = "Full Name";
                    notAssignedManagerDataGridView.Columns["email"].HeaderText = "Email";
                    notAssignedManagerDataGridView.Columns["phone_number"].HeaderText = "Phone Number";
                    notAssignedManagerDataGridView.Columns["address"].HeaderText = "Address";
                }
            }
        }
    }
}
