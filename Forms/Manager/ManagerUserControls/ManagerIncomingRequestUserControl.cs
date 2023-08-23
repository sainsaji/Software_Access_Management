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

namespace File_Acess_Management.Forms.Manager.ManagerUserControls
{
    public partial class ManagerIncomingRequestUserControl : UserControl
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public ManagerIncomingRequestUserControl()
        {
            InitializeComponent();


        }
        private void setButtonAction()
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Approve/Deny";
            col.Name = "Action";
            userRequestGridView.Columns.Add(col);
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
                    loadIncomingRequest(id);
                    userRequestGridView.Refresh();
                }
            }
        }
        private void loadIncomingRequest(int id)
        {
            {
                {

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
                                int managerId = id;
                                Console.WriteLine("Fetching Requests from manager side of id:" + managerId + " Id:" + id);
                                string selectQuery = "SELECT\r\n    u.user_name,\r\n    s.soft_name AS software_name,\r\n    rt.approval_manager, rt.request_id\r\nFROM\r\n    users u\r\nJOIN\r\n    managerAssigned ma ON u.id = ma.users_id\r\nJOIN\r\n    request_list_table rlt ON u.id = rlt.user_id\r\nJOIN\r\n    software s ON rlt.software_id = s.soft_id\r\nJOIN\r\n    request_table rt ON rlt.req_id = rt.request_list_id\r\nWHERE\r\n    ma.manager_id = @id;";
                                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, con))
                                {
                                    selectCommand.Parameters.AddWithValue("@id", managerId);

                                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
                                    DataSet dataSet = new DataSet();
                                    adapter.Fill(dataSet);

                                    BindingSource bindingSource = new BindingSource();
                                    bindingSource.DataSource = dataSet.Tables[0];
                                    userRequestGridView.DataSource = bindingSource;
                                    userRequestGridView.Refresh();
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

        private void userRequestGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == userRequestGridView.Columns["Action"].Index)
            {
                DataGridViewRow row = userRequestGridView.Rows[e.RowIndex];

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
                        loadIncomingRequest(Id);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void ManagerIncomingRequestUserControl_Load(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                loadIncomingRequest(Id);
                setButtonAction();
            }
            else
            {
                Console.WriteLine("Invalid Manger ID:" + Id);
                MessageBox.Show("Invalid Manger ID:" + Id);
            }

        }
    }
}
