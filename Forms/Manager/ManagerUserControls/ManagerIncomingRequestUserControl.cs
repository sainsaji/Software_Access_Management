using File_Acess_Management.Data.Repository;
using File_Acess_Management.Data.Repository.IRepository;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Data;
using System.Windows.Forms;

namespace File_Acess_Management.Forms.Manager.ManagerUserControls
{
    public partial class ManagerIncomingRequestUserControl : UserControl
    {
        private int _id;
        private IManagerSideRepository _managerSideRepository;
        private int selectedRequestId = -1;
        int req_Id = 0;
        bool ck = false;

        public ManagerIncomingRequestUserControl(int Id, IManagerSideRepository managerSideRepository)
        {
            _id = Id;
            _managerSideRepository = managerSideRepository;
            InitializeComponent();
            remarksPannel.Visible = false;

        }

        private void loadIncomingRequest()
        {
            try
            {
                RequestList requesList = new RequestList();
                requesList.userId = _id;
                string selectQuery = "SELECT\r\n    " +
                "rt.raised_time as Requested_Time, " +
                "rt.request_id As Request_Id, " +
                "u.user_name AS User_Name,\r\n    " +
                "s.soft_name AS Software_Name,\r\n    " +
                "um.user_name AS Manager_Name,\r\n    " +
                "rt.approval_manager AS Manager_Approval,\r\n    " +
                "rt.approval_admin AS Admin_Approval\r\nFROM\r\n    " +
                "users u\r\nINNER JOIN\r\n    " +
                "request_table rt ON u.id = rt.user_id\r\nINNER JOIN\r\n    " +
                "software s ON rt.software_id = s.soft_id\r\nINNER JOIN\r\n    " +
                "managerAssigned ma ON u.id = ma.users_id\r\nINNER JOIN\r\n    " +
                "users um ON ma.manager_id = um.id\r\nWHERE\r\n    " +
                "ma.manager_id = @userId;\r\n";
                DataTable dt = _managerSideRepository.get(requesList, selectQuery);
                userRequestGridView.DataSource = dt;
                //userRequestGridView.Refresh();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " sql query error.");
            }
        }
        private void ManagerIncomingRequestUserControl_Load(object sender, EventArgs e)
        {
            userRequestGridView.SelectionChanged += UserRequestGridView_SelectionChanged;
            loadIncomingRequest();

        }

        private void UserRequestGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (userRequestGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = userRequestGridView.SelectedRows[0];

                ck = true;
                req_Id = (int)selectedRow.Cells["request_id"].Value;
                managerRemarkTextBox.Text = "";
                displayRemark();
                string requestState = selectedRow.Cells["Manager_Approval"].Value.ToString();
                if (requestState != null)
                {
                    if (requestState.ToString() == "denied")
                    {
                        denyBtn.Enabled = false;
                        acceptBtn.Enabled = true;
                    }
                    else if (requestState.ToString() == "approved")
                    {
                        denyBtn.Enabled = true;
                        acceptBtn.Enabled = false;
                    }
                    else
                    {
                        denyBtn.Enabled = true;
                        acceptBtn.Enabled = true;
                    }
                }
                if (req_Id != 0)
                {
                    selectedRequestId = Convert.ToInt32(req_Id);
                    Console.WriteLine("Selected Request ID: " + selectedRequestId);
                }
            }
            Console.WriteLine("Selection Change Triggered");
        }

        private void displayRemark()
        {
            if (ck == true)
            {
                RequestList requestList = new RequestList();
                requestList.requestId = req_Id;
                string query = "select user_remark,manager_remark,admin_remark from request_table where request_id=@requestId";
                DataTable dt = _managerSideRepository.get(requestList, query);
                managerCurrentRemarkTxt.Text = dt.Rows[0]["manager_remark"].ToString();
                userRemarkTxt.Text = dt.Rows[0]["user_remark"].ToString();
                AdminRemarkTxt.Text = dt.Rows[0]["admin_remark"].ToString();
                remarksPannel.Visible = true;
            }

        }




        private void actionManagerApproval(int requestId, string btn)
        {
            RequestList request = new RequestList();
            request.requestId = requestId;
            request.manApproval = btn;
            Console.WriteLine("Received Request ID:" + requestId);
            string query = "UPDATE request_table SET approval_manager = @manApproval WHERE request_id = @requestId";

            int rowsaffected = _managerSideRepository.add(request, query);
            if (rowsaffected > 0)
            {
                MessageBox.Show("updated successfully");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
            loadIncomingRequest();
            userRequestGridView.Refresh();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            actionManagerApproval(selectedRequestId, "approved");
        }



        private void denyBtn_Click(object sender, EventArgs e)
        {
            actionManagerApproval(selectedRequestId, "denied");
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            loadIncomingRequest();
            remarksPannel.Visible = false;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ck == true)
            {
                if (managerRemarkTextBox.Text == "")
                {
                    MessageBox.Show("please enter the remark to update");
                }
                else
                {
                    RequestList request = new RequestList();
                    request.requestId = req_Id;
                    request.managerRemark = managerRemarkTextBox.Text;
                    string query = "update request_table set manager_remark=@managerRemark where request_id=@requestId";
                    int RowsAffected = _managerSideRepository.add(request, query);
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