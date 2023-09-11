using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Models;
using Org.BouncyCastle.Ocsp;
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
            gridView2.SelectionChanged += notAssignedManagerDataGridView_SelectionChanged;
            
            gridView1.SelectionChanged += GridView1_SelectionChanged;

            gridView1.OptionsSelection.MultiSelect = true;
            gridView2.OptionsSelection.MultiSelect = true;

        }

        private void GridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int[] selectedRows = gridView1.GetSelectedRows();
                if (selectedRows.Length > 0)
                {
                    int selectedRowHandle = selectedRows[0];

                    // Assuming you have TextBox controls for updating data
                    selectedUserId2 = (int)gridView1.GetRowCellValue(selectedRowHandle, "id");
                    selectedManagerId = (int)gridView1.GetRowCellValue(selectedRowHandle, "manager_id");
                    string manName = gridView1.GetRowCellValue(selectedRowHandle, "manager_name").ToString();
                    manager Item = selectManager.Properties.Items.OfType<manager>().FirstOrDefault(item => item.Name == manName);
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
            if (gridView2.SelectedRowsCount > 0)
            {
                int[] selectedRows = gridView2.GetSelectedRows();
                if (selectedRows.Length > 0)
                {
                    int selectedRowHandle = selectedRows[0];
                    selectedUserId = (int)gridView2.GetRowCellValue(selectedRowHandle, "id");
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
            gridView1.Columns["id"].Visible = false;
            gridView1.Columns["user_name"].Caption = "User Name";
            gridView1.Columns["role"].Caption = "Role";
            gridView1.Columns["name"].Caption = "Full Name";
            gridView1.Columns["email"].Caption = "Email";
            gridView1.Columns["phone_number"].Caption = "Phone Number";
            gridView1.Columns["address"].Caption = "Address";
        }

        private void PopulateComboBox()
        {
            string query = "SELECT u.id,u.name FROM users as u Inner join roles as r on u.role_id=r.role_id where r.role_name='Manager'";
            dt = _userManagerAssignment.getAll(query);
            foreach (DataRow row in dt.Rows)
            {
                int manId = Convert.ToInt32(row["id"]);
                string manName = row["name"].ToString();
                selectManagerForNotAssigned.Properties.Items.Add(new manager(manId, manName));
                selectManager.Properties.Items.Add(new manager(manId, manName));
            }
        }

        private void LoadNotAssignedUsers()
        {
            string query = "SELECT u.id,u.user_name, r.role_name as role, u.name, u.email, u.phone_number, u.address FROM users AS u INNER JOIN roles AS r ON u.role_id = r.role_id WHERE r.role_name = 'User' AND u.manager_assigned = false;";
            dt = _userManagerAssignment.getAll(query);
            notAssignedManagerDataGridView.DataSource = dt;
            //studentRecordDataGridView.Columns["Password"].Visible = false;
            gridView2.Columns["id"].Visible = false;
            gridView2.Columns["user_name"].Caption = "User Name";
            gridView2.Columns["role"].Caption = "Role";
            gridView2.Columns["name"].Caption = "Full Name";
            gridView2.Columns["email"].Caption = "Email";
            gridView2.Columns["phone_number"].Caption = "Phone Number";
            gridView2.Columns["address"].Caption = "Address";
        }

        private void ResetAll()
        {
            gridView2.ClearSelection();
            selectManagerForNotAssigned.SelectedIndex = -1;
            gridView1.ClearSelection();
            selectManager.SelectedIndex = -1;
            selectedUserId = 0;
            selectedUserId2 = 0;
            selectedManagerId = 0;
        }

        private void AdminManagerUserAssignmentUserControl_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("Assignment Form Left");
            selectManager.Properties.Items.Clear();
            selectManagerForNotAssigned.Properties.Items.Clear();
        }

        private void AdminManagerUserAssignmentUserControl_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Entered Form");
        }

        private void AdminManagerUserAssignmentUserControl_VisibleChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Form Shown");

            Console.WriteLine("Clearing DataTable");
            selectManager.Properties.Items.Clear();
            selectManagerForNotAssigned.Properties.Items.Clear();
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

        private void assignedManagerDataGridView_Click(object sender, EventArgs e)
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
                            MessageBox.Show("Error removing user.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error removing user.");
                }
            }
        }

        private void rstBtn_Click(object sender, EventArgs e)
        {
            ResetAll();
        }
    }
}