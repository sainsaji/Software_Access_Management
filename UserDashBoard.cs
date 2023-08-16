using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace File_Acess_Management
{

    public partial class UserDashBoard : Form
    {
        public int userId = 5;
        private List<RequestList> requestList = new List<RequestList>();
        public UserDashBoard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            requestPanel.BackColor = Color.White;
            informationPanel.BackColor = Color.Aqua;
            statusPanel.BackColor = Color.White;
            tabTitleLbl.Text = "User Information";
            requestRightPanel.Visible = false;
            requestStatusPanel.Visible = false;
        }



        private void label1_Click(object sender, EventArgs e)
        {
            informationClickAction();
        }

        private void informationClickAction()
        {
            requestRightPanel.Visible = false;
            requestStatusPanel.Visible = false;
            requestPanel.BackColor = Color.White;
            informationPanel.BackColor = Color.Aqua;
            statusPanel.BackColor = Color.White;
            tabTitleLbl.Text = "User Information";
            alertsLabel.Visible = false;
        }

        private void informationPanel_Click(object sender, EventArgs e)
        {
            informationClickAction();
        }

        private void requestLbl_Click(object sender, EventArgs e)
        {
            requestClickAction();


        }

        private void requestClickAction()
        {
            requestRightPanel.Visible = true;
            requestStatusPanel.Visible = false;
            Console.WriteLine("Request Form Loaded");
            requestPanel.BackColor = Color.Aqua;
            informationPanel.BackColor = Color.White;
            statusPanel.BackColor = Color.White;
            tabTitleLbl.Text = "Raise Request";
            Console.WriteLine("Auto Filling Data");
            string userName = GetData("userName");
            string managerName = GetData("userManager");
            nameTxtBox.Text = userName;
            nameTxtBox.ReadOnly = true;
            repManagerTxtBox.Text = managerName;
            repManagerTxtBox.ReadOnly = true;
            Console.WriteLine("Loading Available Software List");
            loadSoftwareList();
        }

        private string GetData(string requiredData)
        {
            try
            {

                SqlConnection con = new SqlConnection(Properties.Settings.Default.connection);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("DB Connection Established");
                }
                if (requiredData == "userName")
                {
                    string userName = "";
                    Console.WriteLine("Fetching UserName");
                    string selectQuery = "SELECT user_name FROM users WHERE id=@id";
                    SqlCommand sqlCommand = new SqlCommand(selectQuery, con);
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine("User Name Fetched:");
                            Console.WriteLine(String.Format("{0}", reader["user_name"]));
                            userName = reader["user_name"].ToString();
                        }
                        else
                        {
                            Console.WriteLine("Reader Failed");
                        }
                    }
                    return userName;
                }
                else
                {
                    string userManager = "";
                    Console.WriteLine("Fetching UserManager");
                    string selectQuery = "SELECT manager_id FROM managerAssigned WHERE users_id=@id";
                    SqlCommand sqlCommand = new SqlCommand(selectQuery, con);
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string managerName = fetchManagerName(reader["manager_id"]);
                            Console.WriteLine("User Manager Fetched:");
                            Console.WriteLine(String.Format("{0}", managerName));
                            userManager = managerName;
                        }
                        else
                        {
                            Console.WriteLine("Reader Failed");
                        }
                    }
                    return userManager;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred");
                Console.WriteLine(ex.Message);
                return "ERROR";
            }

        }

        private string fetchManagerName(object id)
        {
            Console.WriteLine("From FetchManagerName");
            Console.WriteLine("ManagerID:" + id.ToString());
            SqlConnection con = new SqlConnection(Properties.Settings.Default.connection);
            string managerName = "";
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                Console.WriteLine("DB Connection Established");
            }
            Console.WriteLine("Fetching Manager Name");
            string selectQuery = "SELECT user_name FROM users WHERE id=@id";
            SqlCommand sqlCommand = new SqlCommand(selectQuery, con);
            sqlCommand.Parameters.AddWithValue("@id", id);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine("User Name Fetched:");
                    Console.WriteLine(String.Format("{0}", reader["user_name"]));
                    managerName = reader["user_name"].ToString();
                }
                else
                {
                    Console.WriteLine("Reader Failed");
                }
            }
            return managerName;

        }

        private void loadSoftwareList()
        {
            var table = new DataTable();

            var connection = Properties.Settings.Default.connection;

            using (var con = new SqlConnection { ConnectionString = connection })
            {
                using (var command = new SqlCommand { Connection = con })
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
                        string selectQuery = "SELECT * FROM SOFTWARE";
                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        BindingSource bindingSource = new BindingSource();
                        bindingSource.DataSource = dataSet;
                        DataTable dataTable = dataSet.Tables[0];
                        foreach (DataRow row in dataTable.Rows)
                        {
                            Console.WriteLine("soft_name: " + row["soft_name"]);
                        }
                        softwareChkdLstBx.DataSource = dataSet.Tables[0];
                        softwareChkdLstBx.DisplayMember = "soft_name";
                        softwareChkdLstBx.ValueMember = "soft_name";

                        softwareChkdLstBx.Refresh();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message + " sql query error.");

                    }

                }
            }

        }

        private void requestPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void requestPanel_Click(object sender, EventArgs e)
        {
            requestClickAction();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            statusClickAction();

        }

        private void statusClickAction()
        {
            Console.WriteLine("Status Clicked");
            alertsLabel.Visible = false;
            requestStatusPanel.Visible = true;
            requestRightPanel.Visible = true;
            requestPanel.BackColor = Color.White;
            informationPanel.BackColor = Color.White;
            statusPanel.BackColor = Color.Aqua;
            tabTitleLbl.Text = "Request Status";
            Console.WriteLine("Loading Status Data");
            loadRequestStatusData();
        }

        private void loadRequestStatusData()
        {
            var table = new DataTable();

            var connection = Properties.Settings.Default.connection;

            using (var con = new SqlConnection { ConnectionString = connection })
            {
                using (var command = new SqlCommand { Connection = con })
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
                        SqlCommand sqlCommand = new SqlCommand(selectQuery, con);
                        sqlCommand.Parameters.AddWithValue("@id", userId);
                        dataGridView1.Rows.Clear();
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            int count = 1;
                            try
                            {
                                while (reader.Read())
                                {
                                    count += 1;
                                    int requestId = int.Parse(reader["REQUEST_LIST_ID"].ToString());
                                    string appName = FetchAppName(userId, requestId);
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
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message + " sql query error.");
                    }

                }
            }
        }

        private string FetchAppName(int userId, int requestId)
        {
            string appName = "ERR";
            Console.WriteLine("Fetching App Name");
            try
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.connection);
                con.Open();
                string selectQuery = "SELECT SOFT_NAME FROM SOFTWARE S INNER JOIN REQUEST_LIST_TABLE R ON S.SOFT_ID = R.SOFTWARE_ID   WHERE R.USER_ID = @id and R.REQ_ID = @requestID";
                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("DB Connection Established");
                    Console.WriteLine("Fetching RequestID:" + requestId);
                    SqlCommand sqlCommand = new SqlCommand(selectQuery, con);
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Parameters.AddWithValue("@requestID", requestId);
                    //Console.WriteLine("Getting types:" + requestId.GetType() + userId.GetType());
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
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
                MessageBox.Show(ex.ToString());
                return appName;
            }
        }

        private void statusPanel_Click(object sender, EventArgs e)
        {
            statusClickAction();

        }

        private void reqIcoClick_Click(object sender, EventArgs e)
        {
            statusClickAction();
        }

        private void requestTableGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        List<int> softwareIdList = new List<int>();
        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in softwareChkdLstBx.CheckedItems)
            {
                var row = (item as DataRowView).Row;
                string softwareName = row["soft_name"].ToString();

                int softwareID = int.Parse(row["soft_id"].ToString());
                Console.WriteLine("User Selected s/w ID: " + softwareID);
                Console.WriteLine("User Selected s/w Name: " + softwareName);
                softwareIdList.Add(softwareID);
                if (!selectedSoftwareListBox.Items.Contains(softwareName))
                {
                    alertsLabel.Text = "Added Software";
                    selectedSoftwareListBox.Items.Add(softwareName);
                }
                else
                {
                    alertsLabel.Text = "Selected Software already exists";
                    Console.WriteLine("Already Exists in Selected List");
                }

            }
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.connection);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("DB Connection Established");
                }
                Console.WriteLine("Software ID List:" + softwareIdList);
                foreach (var item in selectedSoftwareListBox.Items)
                {
                    Console.WriteLine("Requesting software:" + item.ToString());
                    SqlCommand setRequestList = new SqlCommand("insert into REQUEST_LIST_TABLE(SOFTWARE_ID,USER_ID) values('" + softwareIdList.First() + "','" + userId + "') ", con);
                    Console.WriteLine("Added Item to Request List with ID:" + softwareIdList.First());
                    Console.WriteLine("Creating Request Row in SQL");
                    int rowsAffected = setRequestList.ExecuteNonQuery();
                    Console.WriteLine("Rows Affected for SoftwareList Query:" + rowsAffected.ToString());
                    int requestListId = getSoftwareListId();
                    Console.WriteLine("Received Request ID:" + requestListId);
                    string pending = "Pending";
                    SqlCommand RequestSQLcmd = new SqlCommand("insert into REQUEST_TABLE(USER_ID,APPROVAL_MANAGER,APPROVAL_ADMIN,REQ_STATUS,REQUEST_LIST_ID) values('" + userId + "','" + pending + "','" + pending + "','" + pending + "','" + requestListId + "') ", con);
                    int rowsAffectedReq = RequestSQLcmd.ExecuteNonQuery();
                    Console.WriteLine("Rows Affected for SoftwareList Query:" + rowsAffectedReq.ToString());
                    Console.WriteLine("Removing from Local List:");
                    softwareIdList.RemoveAt(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("From Proceed Button:" + ex.Message);
            }
            finally
            {
                softwareIdList.Clear();
                selectedSoftwareListBox.Items.Clear();
            }

        }

        private int getSoftwareListId()
        {
            Console.WriteLine("Fetching Request List IDs:");
            int reqId = -1;
            try
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.connection);
                con.Open();
                string selectQuery = "SELECT REQ_ID FROM request_list_table WHERE user_id = @id AND req_id = (SELECT MAX(req_id) FROM request_list_table)";
                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("DB Connection Established");
                    SqlCommand sqlCommand = new SqlCommand(selectQuery, con);
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            Console.WriteLine(String.Format("Fetching Request ID"));
                            Console.WriteLine(String.Format("Request ID:{0}", reader["REQ_ID"]));
                            reqId = int.Parse(reader["REQ_ID"].ToString());
                        }
                        else
                        {
                            Console.WriteLine("Reader Failed");
                        }
                    }
                }
                return reqId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("From getSoftwareListID:" + ex.Message);
                return -1;
            }
        }
    }
}
