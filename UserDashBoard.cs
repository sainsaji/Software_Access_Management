using File_Acess_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Acess_Management
{

    public partial class UserDashBoard : Form
    {
        public int userId = 5;
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
            string departmentName = GetData("userDepartment");
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
                Console.WriteLine("Exception Occured");
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
                        softwareChkdLstBx.DisplayMember = "SOFTWARE_NAME";
                        softwareChkdLstBx.ValueMember = "SOFTWARE_NAME";
                        softwareChkdLstBx.DataSource = dataSet.Tables[0];
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
                        string selectQuery = "SELECT REQUEST_ID,APPROVAL_ID,SOFTWARE_REQUEST_ID FROM REQUEST_TABLE WHERE USER_ID=@id";
                        SqlCommand sqlCommand = new SqlCommand(selectQuery, con);
                        sqlCommand.Parameters.AddWithValue("@id", 1);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            int count = 1;
                            while (reader.Read())
                            {
                                count += 1;
                                Console.WriteLine(String.Format("Request ID:#{0} Fetched:", count));
                                Console.WriteLine(String.Format("Request ID:{0}", reader["REQUEST_ID"]));
                                Console.WriteLine(String.Format("APPROVAL ID:{0}", reader["APPROVAL_ID"]));
                                Console.WriteLine(String.Format("SOFTWARE_REQUEST_ID:{0}", reader["SOFTWARE_REQUEST_ID"]));
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
                    alertsLabel.Text = "Added Softwares";
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
                    SqlCommand sqcmd = new SqlCommand("insert into REQUEST_LIST_TABLE(SOFTWARE_ID) values('" + softwareIdList.First() + "') ", con);
                    Console.WriteLine("Added Item to Request List with ID:" + softwareIdList.First());
                    Console.WriteLine("Creating Request Row in SQL");
                    SqlCommand RequestSQLcmd = new SqlCommand("insert into REQUEST_TABLE(USER_ID,APPROVAL_MANAGER,APPROVAL_ADMIN,REQ_STATUS) values('" + 1 + "','" + 1 + "','" + softwareIdList.First() + "') ", con);
                    Console.WriteLine("Removing from Local List:");

                    softwareIdList.RemoveAt(0);
                    int rowsAffected = sqcmd.ExecuteNonQuery();
                    Console.WriteLine("Rows Affected for SoftwareList Query:" + rowsAffected.ToString());
                    int rowsAffectedReq = RequestSQLcmd.ExecuteNonQuery();
                    Console.WriteLine("Rows Affected for SoftwareList Query:" + rowsAffectedReq.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }

        }
    }
}
