using File_Acess_Management.Data.Repository;
using File_Acess_Management.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace File_Acess_Management.Forms.User.UserDashboardUserControls
{
    public partial class UserRequestStatusUserControl : UserControl
    {
        private int _id;
        private IUserRaisedRequestRepository _userRaisedRequestRepository;
        private List<RequestList> requestList = new List<RequestList>();
        int req_Id = 0;
        bool ck = false;

        public UserRequestStatusUserControl(int id, IUserRaisedRequestRepository userRaisedRequestRepository)
        {
            _id = id;
            _userRaisedRequestRepository = userRaisedRequestRepository;
            InitializeComponent();
            remarksPannel.Visible = false;
        }

        private void loadRequestStatusData()
        {
            var table = new DataTable();
            try
            {
                RequestList requestList = new RequestList();
                requestList.userId = _id;
                Console.WriteLine("Fetching Previous Requests");
                string selectQuery = "select r.request_id, s.soft_name, r.approval_manager, r.approval_admin, r.req_status " +
                    "from request_table r " +
                    "Inner join software s on r.software_id=s.soft_id " +
                    "where r.user_id=@userId;";

                try
                {
                    DataTable dt = _userRaisedRequestRepository.get(requestList, selectQuery);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " sql query error.");
            }
        }

        private void UserRequestStatusUserControl_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            loadRequestStatusData();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Console.WriteLine("got trigggggrrreeeddd");
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                ck = true;
                req_Id = (int)selectedRow.Cells["request_id"].Value;
                userRemarkTextBox.Text = "";
                displayRemark();
            }
        }
        private void displayRemark()
        {
            if (ck == true)
            {
                RequestList requestList = new RequestList();
                requestList.requestId = req_Id;
                string query = "select user_remark,manager_remark,admin_remark from request_table where request_id=@requestId";
                DataTable dt = _userRaisedRequestRepository.get(requestList, query);
                userCurrentRemarkTxt.Text = dt.Rows[0]["user_remark"].ToString();
                managerRemarkTxt.Text = dt.Rows[0]["manager_remark"].ToString();
                AdminRemarkTxt.Text = dt.Rows[0]["admin_remark"].ToString();
                remarksPannel.Visible = true;
            }   

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void requestStatusPanel_Leave(object sender, EventArgs e)
        {
        }

        private void UserRequestStatusUserControl_VisibleChanged(object sender, EventArgs e)
        {
            
            loadRequestStatusData();
            remarksPannel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ck == true)
            {
                ck = false;
                RequestList request = new RequestList();
                request.requestId = req_Id;
                string query = "Delete from request_table where request_id=@requestId";
                int rowsAffected = _userRaisedRequestRepository.remove(request, query);
                if (rowsAffected > 0)
                {
                    loadRequestStatusData();
                    MessageBox.Show("request withdrawn successfully");
                }
                else
                {
                    MessageBox.Show("Error occured, try agian later");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ck == true)
            {
                if (userRemarkTextBox.Text == "")
                {
                    MessageBox.Show("please enter the remark to update");
                }
                else
                {
                    RequestList request = new RequestList();
                    request.requestId = req_Id;
                    request.userRemark = userRemarkTextBox.Text;
                    string query = "update request_table set user_remark=@userRemark where request_id=@requestId";
                    int RowsAffected = _userRaisedRequestRepository.add(request, query);
                    if (RowsAffected > 0)
                    {
                        displayRemark();
                        
                        MessageBox.Show("Updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error while updating");
                    }
                }
            }
            else
            {
                MessageBox.Show("please select a request to edit");
            }
        }
    }
}