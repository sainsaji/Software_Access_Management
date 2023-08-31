using File_Acess_Management.Data.Repository;
using File_Acess_Management.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
        IUserRaisedRequestRepository _userRaisedRequestRepository;

        public UserRaiseRequestUserControl(int id, IUserRaisedRequestRepository userRaisedRequestRepository)
        {
            _id = id;
            _userRaisedRequestRepository = userRaisedRequestRepository;
            InitializeComponent();
        }

        private void loadUserInfo()
        {
            string userName = GetData("userName");
            string managerName = GetData("userManager");
            nameTxtBox.Text = userName;
            nameTxtBox.ReadOnly = true;
            repManagerTxtBox.Text = managerName;
            repManagerTxtBox.ReadOnly = true;
            loadSoftwareList();
        }
        private string GetData(string requiredData)
        {
            try
            {
                RequestList requestList = new RequestList();
                requestList.userId = _id;
                if (requiredData == "userName")
                {
                    string query = "SELECT user_name FROM users WHERE id=@userId";
                    DataTable dt = _userRaisedRequestRepository.get(requestList, query);
                    return dt.Rows[0]["user_name"].ToString();
                }
                else
                {
                    string query = "SELECT u.name AS manager_name " +
                        "FROM users u WHERE u.id = (SELECT ma.manager_id FROM managerAssigned ma WHERE ma.users_id = @userId)";
                    DataTable dt = _userRaisedRequestRepository.get(requestList, query);
                    return dt.Rows[0]["manager_name"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred");
                Console.WriteLine(ex.Message);
                return "ERROR";
            }

        }
        private void loadSoftwareList()
        {
            var table = new DataTable();
            try
            {
                string selectQuery = "SELECT * FROM SOFTWARE";
                DataTable dt = _userRaisedRequestRepository.getAll(selectQuery);
                softwareChkdLstBx.DataSource = dt;
                softwareChkdLstBx.DisplayMember = "soft_name";
                softwareChkdLstBx.ValueMember = "soft_name";
                softwareChkdLstBx.Refresh();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " sql query error.");

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
                    if (softwareIdList.Count > 0)
                    {
                        foreach (var item in selectedSoftwareListBox.Items)
                        {
                            RequestList requestList = new RequestList();
                            requestList.userId = _id;
                            requestList.manApproval = "Pending";
                            requestList.admApproval = "Pending";
                            requestList.status = "Pending";
                            requestList.softId = softwareIdList.First();
                            string query = "insert into REQUEST_TABLE values(0,@userId,@manApproval,@admApproval,@status,@softId);";
                            int rowsAffectedReq = _userRaisedRequestRepository.add(requestList, query);
                            alertsLabel.Text = "Software Request Sent";
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
            if (_id != 0)
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
