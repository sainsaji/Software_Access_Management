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

namespace File_Acess_Management.Forms.User.UserDashboardUserControls
{
    public partial class UserRequestStatusUserControl : UserControl
    {
        private int _id;
        private List<RequestList> requestList = new List<RequestList>();

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public UserRequestStatusUserControl()
        {
            InitializeComponent();
        }
        private string FetchAppName(int userId, int requestId)
        {
            string appName = "ERR";
            Console.WriteLine("Fetching App Name");
            try
            {
                MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString);
                connection.Open();
                string selectQuery = "SELECT SOFT_NAME FROM SOFTWARE S INNER JOIN REQUEST_LIST_TABLE R ON S.SOFT_ID = R.SOFTWARE_ID   WHERE R.USER_ID = @id and R.REQ_ID = @requestID";
                if (connection.State == ConnectionState.Open)
                {
                    Console.WriteLine("DB Connection Established");
                    Console.WriteLine("Fetching RequestID:" + requestId);
                    MySqlCommand MySqlCommand = new MySqlCommand(selectQuery, connection);
                    MySqlCommand.Parameters.AddWithValue("@id", userId);
                    MySqlCommand.Parameters.AddWithValue("@requestID", requestId);
                    //Console.WriteLine("Getting types:" + requestId.GetType() + userId.GetType());
                    using (MySqlDataReader reader = MySqlCommand.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            Console.WriteLine(String.Format("Fetching Request ID"));
                            Console.WriteLine(String.Format("Request App:{0}", reader["SOFT_NAME"]));
                            appName = reader["SOFT_NAME"].ToString();
                        }
                        else
                        {
                            Console.WriteLine(String.Format("Reader Failed"));
                        }

                    }
                }
                return appName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorrrrr" + ex.ToString());
                return appName;
            }
        }
        private void loadRequestStatusData()
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

                        Console.WriteLine("Fetching Previous Requests");
                        string selectQuery = "SELECT REQUEST_ID,APPROVAL_MANAGER,APPROVAL_ADMIN,REQ_STATUS,REQUEST_LIST_ID FROM REQUEST_TABLE WHERE USER_ID=@id";
                        MySqlCommand MySqlCommand = new MySqlCommand(selectQuery, con);
                        MySqlCommand.Parameters.AddWithValue("@id", Id);
                        dataGridView1.Rows.Clear();
                        using (MySqlDataReader reader = MySqlCommand.ExecuteReader())
                        {
                            int count = 1;
                            try
                            {
                                while (reader.Read())
                                {
                                    count += 1;
                                    int requestId = int.Parse(reader["REQUEST_LIST_ID"].ToString());
                                    string appName = FetchAppName(Id, requestId);
                                    string manApproval = reader["APPROVAL_MANAGER"].ToString();
                                    string admApproval = reader["APPROVAL_ADMIN"].ToString();
                                    string status = reader["REQ_STATUS"].ToString();
                                    Console.WriteLine(String.Format("Request ID:#{0} Fetched:", count));
                                    Console.WriteLine(String.Format("Request ID:{0}", requestId));
                                    Console.WriteLine(String.Format("APPROVAL ID:{0}", manApproval));
                                    Console.WriteLine(String.Format("APPROVAL ID:{0}", admApproval));
                                    Console.WriteLine(String.Format("APPROVAL ID:{0}", status));
                                    Console.WriteLine(String.Format("SOFTWARE_REQUEST_ID:{0}", reader["REQUEST_LIST_ID"]));
                                    requestList.Add(new RequestList { requestId = requestId, appName = appName, manApproval = manApproval, admApproval = admApproval, status = status });
                                    BindingSource binding = new BindingSource();
                                    binding.DataSource = requestList;
                                    dataGridView1.DataSource = binding;


                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                            finally
                            {
                                con.Close();
                            }

                        }




                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message + " sql query error.");
                    }

                }
            }
        }

        private void UserRequestStatusUserControl_Load(object sender, EventArgs e)
        {
            loadRequestStatusData();
            showCredentialsBtn.Enabled = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
