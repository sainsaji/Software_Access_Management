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
            depTxtBox.Text = departmentName;
            depTxtBox.ReadOnly = true;
            repManagerTxtBox.Text = managerName;
            repManagerTxtBox.ReadOnly = true;
            Console.WriteLine("Loading Available Software List");
            loadSoftwareList();
        }

        private string GetData(string requiredData)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Smith.Cd\\Downloads\\fileAccessMgmtDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("DB Connection Established");
                }
                if (requiredData == "userName")
                {
                    string userName = "";
                    Console.WriteLine("Fetching UserName");
                    string selectQuery = "SELECT USER_NAME FROM USER_TABLE WHERE USER_ID=@id";
                    SqlCommand sqlCommand = new SqlCommand(selectQuery, con);
                    sqlCommand.Parameters.AddWithValue("@id", 1);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine("User Name Fetched:");
                            Console.WriteLine(String.Format("{0}", reader["USER_NAME"]));
                            userName = reader["USER_NAME"].ToString();
                        }
                    }
                    return userName;
                }
                else if (requiredData == "userDepartment")
                {
                    string deptName = "";
                    Console.WriteLine("Fetching UserDepartment");
                    string selectQuery = "SELECT USER_DEPARTMENT FROM USER_TABLE WHERE USER_ID=@id";
                    SqlCommand sqlCommand = new SqlCommand(selectQuery, con);
                    sqlCommand.Parameters.AddWithValue("@id", 1);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine("DEPARTMENT Name Fetched:");
                            Console.WriteLine(String.Format("{0}", reader["USER_DEPARTMENT"]));
                            deptName = reader["USER_DEPARTMENT"].ToString();
                        }
                    }
                    return deptName;
                }
                else
                {
                    string userManager = "";
                    Console.WriteLine("Fetching UserManager");
                    string selectQuery = "SELECT MANAGER_ID FROM USER_TABLE WHERE USER_ID=@id";
                    SqlCommand sqlCommand = new SqlCommand(selectQuery, con);
                    sqlCommand.Parameters.AddWithValue("@id", 1);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine("User Manager Fetched:");
                            Console.WriteLine(String.Format("{0}", reader["MANAGER_ID"]));
                            userManager = reader["MANAGER_ID"].ToString();
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

        private void loadSoftwareList()
        {
            var table = new DataTable();

            var connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Smith.Cd\\Downloads\\fileAccessMgmtDB.mdf;Integrated Security=True;Connect Timeout=30";

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
                        string selectQuery = "SELECT * FROM SOFTWARE_TABLE";
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

            var connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Smith.Cd\\Downloads\\fileAccessMgmtDB.mdf;Integrated Security=True;Connect Timeout=30";

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
                        string selectQuery = "SELECT * FROM REQUEST_TABLE";
                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        BindingSource bindingSource = new BindingSource();
                        bindingSource.DataSource = dataTable;
                        requestTableGridView.DataSource = bindingSource;

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
                string softwareName = row["SOFTWARE_NAME"].ToString();

                int softwareID = int.Parse(row["SOFTWARE_ID"].ToString());
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
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Smith.Cd\\Downloads\\fileAccessMgmtDB.mdf;Integrated Security=True;Connect Timeout=30");
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
                    SqlCommand RequestSQLcmd = new SqlCommand("insert into REQUEST_TABLE(USER_ID,APPROVAL_ID,SOFTWARE_REQUEST_ID) values('" + 1 + "','" + 1 + "','" + softwareIdList.First() + "') ", con);
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

        private void informationPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
