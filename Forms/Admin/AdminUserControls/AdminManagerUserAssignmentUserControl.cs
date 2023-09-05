using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace File_Acess_Management.Forms.Admin.AdminUserControls
{
    public partial class AdminManagerUserAssignmentUserControl : UserControl
    {
        private int selectedUserId, selectedUserId2, selectedManagerId;
        private bool ck = false;
        private bool ck2 = false;
        private DataTable dt = new DataTable();
        private IUserManagerAssignmentRepository _userManagerAssignment;
        private ErrorProvider errorProvider = new ErrorProvider();

        public AdminManagerUserAssignmentUserControl(IUserManagerAssignmentRepository userManagerAssignment)
        {
            _userManagerAssignment = userManagerAssignment;
            InitializeComponent();
        }

        private void AdminManagerUserAssignmentUserControl_Load(object sender, EventArgs e)
        {
            GetAssignedUsersRecord();
            LoadNotAssignedUsers();
            PopulateComboBox();
            notAssignedManagerDataGridView.SelectionChanged += notAssignedManagerDataGridView_SelectionChanged;
            assignedManagerDataGridView.SelectionChanged += assignedManagerDataGridView_SelectionChanged;
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
            string query = "SELECT u.id,u.user_name, m.manager_id, " +
                "(SELECT name FROM users WHERE id = m.manager_id) AS manager_name, r.role_name as role, u.name, u.email, u.phone_number, u.address FROM users AS u " +
                "INNER JOIN roles AS r ON u.role_id = r.role_id " +
                "Inner join managerassigned as m ON u.id=m.users_id " +
                "WHERE r.role_name = 'User' AND u.manager_assigned = true;";
            dt = _userManagerAssignment.getAll(query);
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

        private void PopulateComboBox()
        {
            string query = "SELECT u.id,u.name FROM users as u Inner join roles as r on u.role_id=r.role_id where r.role_name='Manager'";
            dt = _userManagerAssignment.getAll(query);
            foreach (DataRow row in dt.Rows)
            {
                int manId = Convert.ToInt32(row["id"]);
                string manName = row["name"].ToString();
                selectManagerForNotAssigned.Items.Add(new manager(manId, manName));
                selectManager.Items.Add(new manager(manId, manName));
            }
        }

        private void LoadNotAssignedUsers()
        {
            string query = "SELECT u.id,u.user_name, r.role_name as role, u.name, u.email, u.phone_number, u.address FROM users AS u INNER JOIN roles AS r ON u.role_id = r.role_id WHERE r.role_name = 'User' AND u.manager_assigned = false;";
            dt = _userManagerAssignment.getAll(query);
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

        private void AdminManagerUserAssignmentUserControl_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("Assignment Form Left");
            selectManager.Items.Clear();
            selectManagerForNotAssigned.Items.Clear();
        }

        private void AdminManagerUserAssignmentUserControl_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Entered Form");
        }

        private void AdminManagerUserAssignmentUserControl_VisibleChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Form Shown");

            Console.WriteLine("Clearing DataTable");
            selectManager.Items.Clear();
            selectManagerForNotAssigned.Items.Clear();
            Console.WriteLine("Loading Manager List");
            LoadNotAssignedUsers();
            PopulateComboBox();
            GetAssignedUsersRecord();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            {
                {
                    errorProvider.SetError(selectManagerForNotAssigned, "");
                    manager selectedMan = (manager)selectManagerForNotAssigned.SelectedItem;
                    if (selectManager == null)
                    {
                        errorProvider.SetError(selectManagerForNotAssigned, "Please Select a Manger");
                    }
                    else
                    {
                        errorProvider.SetError(selectManagerForNotAssigned, "");
                    }
                    if (ck == true && selectedUserId != 0 && selectedMan != null)
                    {
                        Assignment assign = new Assignment(selectedMan.Id, selectedUserId);
                        string query = "Insert into managerassigned values (0,@ManagerId,@UserId)";
                        int rowsAffected = _userManagerAssignment.add(assign, query);
                        if (rowsAffected > 0)
                        {
                            string query2 = "update users set manager_assigned=true where id=@UserId";
                            int rowsAffected2 = _userManagerAssignment.add(assign, query2);
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
                        //MessageBox.Show("Error assigning user.");
                        errorProvider.SetError(selectManagerForNotAssigned, "Please Select a User");
                    }
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            {
                {
                    errorProvider.SetError(selectManager, "");
                    manager selectedMan = (manager)selectManager.SelectedItem;
                    if (ck2 == true && selectedMan != null && selectedUserId2 != 0)
                    {
                        Assignment assign = new Assignment(selectedMan.Id, selectedUserId2);
                        string query = "update managerassigned set manager_id=@ManagerId where users_id=@UserId";
                        int rowsAffected = _userManagerAssignment.add(assign, query);
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
                            //MessageBox.Show("Error assigning user.");
                            errorProvider.SetError(selectManager, "Please Select a User");
                        }
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            {
                if (ck2 == true && selectedUserId2 != 0 && selectedManagerId != 0)
                {
                    Assignment assign = new Assignment(selectedManagerId, selectedUserId2);

                    string query = "delete from managerassigned where manager_id=@ManagerId and users_id=@UserId";
                    int rowsAffected = _userManagerAssignment.remove(assign, query);
                    if (rowsAffected > 0)
                    {
                        string query2 = "update users set manager_assigned=false where id=@UserId";
                        int rowsAffected2 = _userManagerAssignment.add(assign, query2);
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

        private void rstBtn_Click(object sender, EventArgs e)
        {
            ResetAll();
        }
    }
}