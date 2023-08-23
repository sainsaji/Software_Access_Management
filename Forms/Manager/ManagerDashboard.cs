using File_Acess_Management.Forms.Manager.ManagerUserControls;
using File_Acess_Management.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Acess_Management
{

    public partial class ManagerDashboard : Form
    {

        User user;
        ManagerUserListUserControl userListUC = new ManagerUserListUserControl();
        ManagerInformationUserConrol managerInformationUserControl = new ManagerInformationUserConrol();
        ManagerIncomingRequestUserControl managerIncomingRequestUserControl = new ManagerIncomingRequestUserControl();
        public ManagerDashboard(User user)
        {
            InitializeComponent();
            setButtonAction();
            this.user = user;
            userListUC.Id = user.Id;
            Console.WriteLine("Setting Manager ID: " + user.Id);
            managerIncomingRequestUserControl.Id = user.Id;

        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            contentPanelManager.Controls.Clear();
            contentPanelManager.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void SubManagers_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Manager DB Loaded /n User ID:" + user.Id);
            userListBx.Visible = false;
            requestGridView.Visible = false;
            assignedLbl.Visible = false;

        }

        private void displayName_Click(object sender, EventArgs e)
        {

        }





        private void loadIncomingRequest(int id)
        {

            {
                userListBx.Visible = false;

                {
                    var table = new DataTable();

                    var connection = ConnectionHelper.ConnectionString;

                    using (var con = new MySqlConnection { ConnectionString = connection })
                    {
                        using (var command = new MySqlCommand { Connection = con })
                        {

                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }

                            con.Open();
                            if (con.State == ConnectionState.Open)
                            {
                                Console.WriteLine("DB Connection Established");
                            }
                            else
                            {
                                Console.WriteLine("DB Connection Failed");
                            }


                            try
                            {
                                int managerId = user.Id;

                                string selectQuery = "SELECT\r\n    u.user_name,\r\n    s.soft_name AS software_name,\r\n    rt.approval_manager, rt.request_id\r\nFROM\r\n    users u\r\nJOIN\r\n    managerAssigned ma ON u.id = ma.users_id\r\nJOIN\r\n    request_list_table rlt ON u.id = rlt.user_id\r\nJOIN\r\n    software s ON rlt.software_id = s.soft_id\r\nJOIN\r\n    request_table rt ON rlt.req_id = rt.request_list_id\r\nWHERE\r\n    ma.manager_id = @id;";
                                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, con))
                                {
                                    selectCommand.Parameters.AddWithValue("@id", managerId);

                                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
                                    DataSet dataSet = new DataSet();
                                    adapter.Fill(dataSet);

                                    BindingSource bindingSource = new BindingSource();
                                    bindingSource.DataSource = dataSet.Tables[0];

                                    requestGridView.DataSource = bindingSource;


                                    requestGridView.Refresh();
                                }
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.Message + " sql query error.");

                            }

                        }
                    }

                }
            }
        }

        private void setButtonAction()
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Approve/Deny";
            col.Name = "Action";
            requestGridView.Columns.Add(col);
        }

        private void requestGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == requestGridView.Columns["Action"].Index)
            {
                DataGridViewRow row = requestGridView.Rows[e.RowIndex];

                object requestIdValue = row.Cells["request_id"].Value;

                try
                {
                    if (requestIdValue != null)
                    {
                        // Print the request_id to the console
                        Console.WriteLine("Clicked Approve for request_id: " + requestIdValue.ToString());

                        // Update manager approval in the database
                        int requestId = int.Parse(requestIdValue.ToString());
                        updateManagerRequestApproval(requestId);



                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }



        private void updateManagerRequestApproval(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE request_table SET approval_manager = CASE " +
                             "WHEN approval_manager = 'approved' THEN 'denied' " +
                             "ELSE 'approved' END " +
                             "WHERE request_id = @id";
                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Rows affected: " + rowsAffected);
                    Console.WriteLine("Update Complete /n Refreshing ");
                    loadIncomingRequest(user.Id);
                    requestGridView.Refresh();
                }
            }
        }





        private void logOut(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();
        }





        private void TabPanelClicked(Panel panel, UserControl userControl, string tabTitle)
        {
            managerInformationPanel.BackColor = Color.White;
            incomingRequestPanel.BackColor = Color.White;
            userListPanel.BackColor = Color.White;
            panel.BackColor = Color.LightBlue;
            tabTitleLbl.Text = tabTitle;
            AddUserControl(userControl);
        }

        private void userInfoLbl_Click(object sender, EventArgs e)
        {
            TabPanelClicked(managerInformationPanel, managerInformationUserControl, "Manager Information");
        }

        private void reqStatusLbl_Click(object sender, EventArgs e)
        {
            TabPanelClicked(userListPanel, userListUC, "User List");
        }

        private void requestLbl_Click(object sender, EventArgs e)
        {
            TabPanelClicked(incomingRequestPanel, managerIncomingRequestUserControl, "Request List");
        }

        private void managerInformationIcon_Click(object sender, EventArgs e)
        {
            TabPanelClicked(managerInformationPanel, managerInformationUserControl, "Manager Information");
        }

        private void incomingURIcon_Click(object sender, EventArgs e)
        {
            TabPanelClicked(incomingRequestPanel, managerIncomingRequestUserControl, "Request List");
        }

        private void userListIcon_Click(object sender, EventArgs e)
        {
            TabPanelClicked(userListPanel, userListUC, "User List");
        }

    }
}
