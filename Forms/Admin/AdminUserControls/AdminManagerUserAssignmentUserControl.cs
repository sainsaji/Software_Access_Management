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

namespace File_Acess_Management.Forms.Admin.AdminUserControls
{
    public partial class AdminManagerUserAssignmentUserControl : UserControl
    {
        int selectedUserId, selectedUserId2, selectedManagerId;
        bool ck = false;
        bool ck2 = false;
        public AdminManagerUserAssignmentUserControl()
        {
            InitializeComponent();
        }

        private void AdminManagerUserAssignmentUserControl_Load(object sender, EventArgs e)
        {
            GetAssignedUsersRecord();
            LoadNotAssignedUsers();
            notAssignedManagerDataGridView.SelectionChanged += notAssignedManagerDataGridView_SelectionChanged;
            assignedManagerDataGridView.SelectionChanged += assignedManagerDataGridView_SelectionChanged;
            PopulateComboBox();
        }



        private void assignedManagerDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            {
                if (assignedManagerDataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = assignedManagerDataGridView.SelectedRows[0];
                    // Assuming you have TextBox controls for updating data
                    selectedUserId2 = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    selectedManagerId = Convert.ToInt32(selectedRow.Cells["manager_id"].Value);
                    string manName = selectedRow.Cells["manager_name"].Value.ToString();
                    manager Item = selectManager.Items.OfType<manager>().FirstOrDefault(item => item.Name == manName);
                    if (Item != null)
                    {
                        selectManager.SelectedItem = Item;
                    }
                    ck2 = true;
                }
            }
        }

        private void notAssignedManagerDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            {
                if (notAssignedManagerDataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = notAssignedManagerDataGridView.SelectedRows[0];
                    // Assuming you have TextBox controls for updating data
                    selectedUserId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    ck = true;
                }
            }
        }

        private void GetAssignedUsersRecord()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT u.id,u.user_name, m.manager_id, " +
                    "(SELECT name FROM users WHERE id = m.manager_id) AS manager_name, r.role_name as role, u.name, u.email, u.phone_number, u.address FROM users AS u " +
                    "INNER JOIN roles AS r ON u.role_id = r.role_id " +
                    "Inner join managerassigned as m ON u.id=m.users_id " +
                    "WHERE r.role_name = 'User' AND u.manager_assigned = true;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                        connection.Close();
                    }
                    assignedManagerDataGridView.DataSource = dt;
                    //studentRecordDataGridView.Columns["Password"].Visible = false;
                    assignedManagerDataGridView.Columns["id"].Visible = false;
                    assignedManagerDataGridView.Columns["user_name"].HeaderText = "User Name";
                    assignedManagerDataGridView.Columns["role"].HeaderText = "Role";
                    assignedManagerDataGridView.Columns["name"].HeaderText = "Full Name";
                    assignedManagerDataGridView.Columns["email"].HeaderText = "Email";
                    assignedManagerDataGridView.Columns["phone_number"].HeaderText = "Phone Number";
                    assignedManagerDataGridView.Columns["address"].HeaderText = "Address";
                }
            }
        }

        private void PopulateComboBox()
        {
            // Assuming you have a ComboBox named roleComboBox
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT u.id,u.name FROM users as u Inner join roles as r on u.role_id=r.role_id where r.role_name='Manager'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int manId = reader.GetInt32("id");
                            string manName = reader.GetString("name");
                            selectManagerForNotAssigned.Items.Add(new manager(manId, manName));
                            selectManager.Items.Add(new manager(manId, manName));
                        }
                    }
                }

                connection.Close();
            }
        }



        private void LoadNotAssignedUsers()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT u.id,u.user_name, r.role_name as role, u.name, u.email, u.phone_number, u.address FROM users AS u INNER JOIN roles AS r ON u.role_id = r.role_id WHERE r.role_name = 'User' AND u.manager_assigned = false;";

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
                    notAssignedManagerDataGridView.Columns["id"].Visible = false;
                    notAssignedManagerDataGridView.Columns["user_name"].HeaderText = "User Name";
                    notAssignedManagerDataGridView.Columns["role"].HeaderText = "Role";
                    notAssignedManagerDataGridView.Columns["name"].HeaderText = "Full Name";
                    notAssignedManagerDataGridView.Columns["email"].HeaderText = "Email";
                    notAssignedManagerDataGridView.Columns["phone_number"].HeaderText = "Phone Number";
                    notAssignedManagerDataGridView.Columns["address"].HeaderText = "Address";
                }
            }
        }

        private void ResetAll()
        {
            notAssignedManagerDataGridView.ClearSelection();
            selectManagerForNotAssigned.SelectedIndex = -1;
            assignedManagerDataGridView.ClearSelection();
            selectManager.SelectedIndex = -1;
            selectedUserId = 0;
            selectedUserId2 = 0;
            selectedManagerId = 0;

        }

        private void assignManagerBtn_Click(object sender, EventArgs e)
        {

            {
                manager selectedMan = (manager)selectManagerForNotAssigned.SelectedItem;

                if (ck == true && selectedUserId != 0 && selectedMan != null)
                {
                    int selectedId = selectedMan.Id;
                    using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                    {
                        connection.Open();

                        string query = "Insert into managerassigned values (null,@managerId,@userId)";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@managerId", selectedId);
                            command.Parameters.AddWithValue("@userId", selectedUserId);


                            int rowsAffected = command.ExecuteNonQuery(); ;
                            if (rowsAffected > 0)
                            {
                                string query2 = "update users set manager_assigned=true where id=@user";
                                using (MySqlCommand command2 = new MySqlCommand(query2, connection))
                                {
                                    command2.Parameters.AddWithValue("@user", selectedUserId);

                                    int rowsAffected2 = command2.ExecuteNonQuery(); ;
                                    if (rowsAffected2 > 0)
                                    {
                                        MessageBox.Show("User assigned successfully.");
                                        ck = false;
                                        LoadNotAssignedUsers();
                                        GetAssignedUsersRecord();
                                        ResetAll();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error assigning user.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error assigning user.");
                            }
                        }

                        connection.Close();
                    }


                }
            }
        }

        private void updateAssignedBtn_Click(object sender, EventArgs e)
        {

            {
                manager selectedMan = (manager)selectManager.SelectedItem;
                int selectedId = selectedMan.Id;
                if (ck2 == true && selectedMan != null && selectedUserId2 != 0)
                {
                    using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                    {
                        connection.Open();

                        string query = "update managerassigned set manager_id=@managerId where users_id=@userId";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@managerId", selectedId);
                            command.Parameters.AddWithValue("@userId", selectedUserId2);


                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Successfully updated the manager.");
                                ck = false;
                                LoadNotAssignedUsers();
                                GetAssignedUsersRecord();
                                ResetAll();
                            }
                            else
                            {
                                MessageBox.Show("Error assigning user.");

                            }
                        }

                        connection.Close();
                    }


                }
            }
        }

        private void deleteAssignedBtn_Click(object sender, EventArgs e)
        {

            {
                if (ck2 == true && selectedUserId2 != 0 && selectedManagerId != 0)
                {
                    using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                    {
                        connection.Open();
                        string query = "delete from managerassigned where manager_id=@manager and users_id=@userId";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@manager", selectedManagerId);
                            command.Parameters.AddWithValue("@userId", selectedUserId2);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                string query2 = "update users set manager_assigned=false where id=@userId";

                                using (MySqlCommand command2 = new MySqlCommand(query2, connection))
                                {
                                    command2.Parameters.AddWithValue("@userId", selectedUserId2);
                                    int rowsAffected2 = command2.ExecuteNonQuery();
                                    if (rowsAffected2 > 0)
                                    {
                                        MessageBox.Show("Successfully removed");
                                        ck2 = false;
                                        LoadNotAssignedUsers();
                                        GetAssignedUsersRecord();
                                        ResetAll();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error assigning user.");

                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Error assigning user.");

                            }
                        }
                    }
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetAll();
        }
    }
}
