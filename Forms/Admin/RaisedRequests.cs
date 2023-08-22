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

namespace File_Acess_Management
{
    public partial class RaisedRequests : Form
    {
        public RaisedRequests()
        {
            InitializeComponent();

            setButtonAction();
            loadAdminRequests();

        }
        private void setButtonAction()
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Approve/Deny";
            col.Name = "Action";
            adminRequestsDataGridView.Columns.Add(col);
            DataGridViewButtonColumn colInstall = new DataGridViewButtonColumn();
            colInstall.UseColumnTextForButtonValue = true;
            colInstall.Text = "Installaled";
            colInstall.Name = "Installation Status";
            adminRequestsDataGridView.Columns.Add(colInstall);
        }

        private void loadAdminRequests()
        {

            {

                {


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

                                    string selectQuery = "SELECT\r\n    u.user_name AS User_Name,\r\n    s.soft_name AS Software_Name,\r\n    um.user_name AS Manager_Name,\r\n    rt.approval_manager AS Manager_Approval,\r\n    rt.approval_admin AS Admin_Approval,\r\n    rt.request_id AS request_id\r\nFROM\r\n    users u\r\nJOIN\r\n    request_table rt ON u.id = rt.user_id\r\nJOIN\r\n    request_list_table rlt ON rt.request_list_id = rlt.req_id\r\nJOIN\r\n    software s ON rlt.software_id = s.soft_id\r\nJOIN\r\n    managerAssigned ma ON u.id = ma.users_id\r\nJOIN\r\n    users um ON ma.manager_id = um.id\r\nWHERE\r\n    rt.approval_manager = 'approved';\r\n";
                                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, con))
                                    {


                                        MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
                                        DataSet dataSet = new DataSet();
                                        adapter.Fill(dataSet);

                                        BindingSource bindingSource = new BindingSource();
                                        bindingSource.DataSource = dataSet.Tables[0];

                                        adminRequestsDataGridView.DataSource = bindingSource;


                                        adminRequestsDataGridView.Refresh();
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
        }


        private void updateAdminRequestApproval(int requestId)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE request_table SET approval_admin = CASE " +
                             "WHEN approval_admin = 'approved' THEN 'denied' " +
                             "ELSE 'approved' END " +
                             "WHERE request_id = @id";
                try
                {
                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", requestId);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine("Rows affected: " + rowsAffected);
                        Console.WriteLine("Update Complete /n Refreshing ");
                        loadAdminRequests();
                        adminRequestsDataGridView.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private void adminRequestsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                if (e.RowIndex >= 0 && e.ColumnIndex == adminRequestsDataGridView.Columns["Action"].Index)
                {
                    Console.WriteLine("Action button clicked");
                    DataGridViewRow row = adminRequestsDataGridView.Rows[e.RowIndex];

                    object requestIdValue = row.Cells["request_id"].Value;

                    try
                    {
                        if (requestIdValue != null)
                        {
                            // Print the request_id to the console
                            Console.WriteLine("Clicked Approve for request_id: " + requestIdValue.ToString());

                            // Update admin approval in the database
                            int requestId = int.Parse(requestIdValue.ToString());
                            updateAdminRequestApproval(requestId);
                        }
                        else
                        {
                            Console.WriteLine("Request ID value null");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}