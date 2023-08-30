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
    public partial class UserRaiseRequestUserControl : UserControl
    {
        private int _id;
        List<int> softwareIdList = new List<int>();

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public UserRaiseRequestUserControl()
        {
            InitializeComponent();
        }

        private void loadUserInfo()
        {

            Console.WriteLine("Request Form Loaded");
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

                MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString);
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    Console.WriteLine("DB Connection Established");
                }
                if (requiredData == "userName")
                {
                    string userName = "";
                    Console.WriteLine("Fetching UserName");
                    string selectQuery = "SELECT user_name FROM users WHERE id=@id";
                    MySqlCommand MySqlCommand = new MySqlCommand(selectQuery, connection);
                    MySqlCommand.Parameters.AddWithValue("@id", Id);
                    using (MySqlDataReader reader = MySqlCommand.ExecuteReader())
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
                    MySqlCommand MySqlCommand = new MySqlCommand(selectQuery, connection);
                    MySqlCommand.Parameters.AddWithValue("@id", Id);
                    using (MySqlDataReader reader = MySqlCommand.ExecuteReader())
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
            MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString);
            string managerName = "";
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                Console.WriteLine("DB Connection Established");
            }
            Console.WriteLine("Fetching Manager Name");
            string selectQuery = "SELECT user_name FROM users WHERE id=@id";
            MySqlCommand MySqlCommand = new MySqlCommand(selectQuery, connection);
            MySqlCommand.Parameters.AddWithValue("@id", id);
            using (MySqlDataReader reader = MySqlCommand.ExecuteReader())
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

        private int getSoftwareListId()
        {
            Console.WriteLine("Fetching Request List IDs:");
            int reqId = -1;
            try
            {
                MySqlConnection con = new MySqlConnection(ConnectionHelper.ConnectionString);
                con.Open();
                string selectQuery = "SELECT REQ_ID FROM request_list_table WHERE user_id = @id AND req_id = (SELECT MAX(req_id) FROM request_list_table)";
                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("DB Connection Established");
                    MySqlCommand MySqlCommand = new MySqlCommand(selectQuery, con);
                    MySqlCommand.Parameters.AddWithValue("@id", Id);
                    using (MySqlDataReader reader = MySqlCommand.ExecuteReader())
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

        private void loadSoftwareList()
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
                        string selectQuery = "SELECT * FROM SOFTWARE";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
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
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message + " sql query error.");

                    }

                }
            }

        }
        private void selectedSoftwareListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
                    validIcoPicBox.Visible = true;
                    alertLabelErrorProvider.SetError(alertsLabel, "");
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

            {
                try
                {
                    MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString);
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        Console.WriteLine("DB Connection Established");
                    }
                    Console.WriteLine("Software ID List:" + softwareIdList);
                    if (softwareIdList.Count > 0)
                    {
                        foreach (var item in selectedSoftwareListBox.Items)
                        {
                            Console.WriteLine("Requesting software:" + item.ToString());
                            MySqlCommand setRequestList = new MySqlCommand("insert into REQUEST_LIST_TABLE(SOFTWARE_ID,USER_ID) values('" + softwareIdList.First() + "','" + Id + "') ", connection);
                            Console.WriteLine("Added Item to Request List with ID:" + softwareIdList.First());
                            Console.WriteLine("Creating Request Row in SQL");
                            int rowsAffected = setRequestList.ExecuteNonQuery();
                            Console.WriteLine("Rows Affected for SoftwareList Query:" + rowsAffected.ToString());
                            int requestListId = getSoftwareListId();
                            Console.WriteLine("Recieved Request ID:" + requestListId);
                            string pending = "Pending";
                            MySqlCommand RequestSQLcmd = new MySqlCommand("insert into REQUEST_TABLE(USER_ID,APPROVAL_MANAGER,APPROVAL_ADMIN,REQ_STATUS,REQUEST_LIST_ID) values('" + Id + "','" + pending + "','" + pending + "','" + pending + "','" + requestListId + "') ", connection);
                            int rowsAffectedReq = RequestSQLcmd.ExecuteNonQuery();
                            Console.WriteLine("Rows Affected for SoftwareList Query:" + rowsAffectedReq.ToString());
                            Console.WriteLine("Removing from Local List:");
                            alertsLabel.Text = "Software Request Send";
                            validIcoPicBox.Visible = true;
                            softwareIdList.RemoveAt(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Items to Request");
                        alertsLabel.Text = "No Items to Request";
                        alertLabelErrorProvider.SetError(alertsLabel, "No Items Selected to List");
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
                    validIcoPicBox.Visible = false;
                }

            }
        }

        private void UserRaiseRequestUserControl_Load(object sender, EventArgs e)
        {
            alertsLabel.Text = "";
            validIcoPicBox.Visible = false;
            if (Id != 0)
            {
                loadUserInfo();
            }
            else
            {
                MessageBox.Show("Invalid Id Recived");
                throw new Exception();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            alertsLabel.Text = "Software List Removed";
            validIcoPicBox.Visible = false;
            selectedSoftwareListBox.Items.Clear();
            softwareIdList.Clear();
        }
    }
}
