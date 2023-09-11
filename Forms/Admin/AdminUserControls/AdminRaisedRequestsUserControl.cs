using DevExpress.XtraGrid.Views.Base;
using File_Acess_Management.Data.Repository;
using File_Acess_Management.Data.Repository.IRepository;
using Org.BouncyCastle.Ocsp;
using System;
using System.Data;
using System.Windows.Forms;

namespace File_Acess_Management.Forms.Admin.ManagerUserControls
{
    public partial class AdminRaisedRequestsUserControl : UserControl
    {
        private IAdminRaisedRequest _adminRaisedRequest;
        private int selectedRequestId = -1;
        int req_Id = 0;
        bool ck = false;

        public AdminRaisedRequestsUserControl(IAdminRaisedRequest adminRaisedRequest)
        {
            _adminRaisedRequest = adminRaisedRequest;
            InitializeComponent();
            loadAdminRequests();
            Remarks.Visible = false;
        }
        private void AdminRaisedRequestsUserControl_Load(object sender, EventArgs e)
        {
            userGrid.FocusedRowChanged += userGrid_FocusedRowChanged;
        }

        private void userGrid_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            Console.WriteLine("Selection Change Triggered");
            if (e.FocusedRowHandle >= 0)
            {
                
                ck = true;
                req_Id= (int)userGrid.GetRowCellValue(e.FocusedRowHandle, "Request_Id");
                adminRemarkTextBox.Text = "";
                displayRemark();
                string requestState = userGrid.GetRowCellValue(e.FocusedRowHandle, "Admin_Approval").ToString();
                if (requestState != null)
                {
                    if (requestState.ToString() == "Pending")
                    {
                        denyBtn1.Enabled = true;
                        acceptBtn.Enabled = true;
                    }
                    else if (requestState.ToString() == "denied")
                    {
                        denyBtn1.Enabled = false;
                        acceptBtn.Enabled = true;
                    }
                    else
                    {
                        denyBtn1.Enabled = true;
                        acceptBtn.Enabled = false;
                    }
                }
                else
                {
                }
                if (req_Id != 0)
                {
                    selectedRequestId = Convert.ToInt32(req_Id);
                    Console.WriteLine("Selected Request ID: " + selectedRequestId);
                }
            }
        }

        private void loadAdminRequests()
        {
            string query = "SELECT\r\n    " +
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
                "rt.approval_manager = 'approved';\r\n";
            DataTable dt = _adminRaisedRequest.getAll(query);
            userGridControl.DataSource = dt;
            userGridControl.Refresh();
        }

        private void acceptAdminRequestApproval(int requestId)
        {
            string query = "UPDATE request_table SET approval_admin = CASE " +
                         "WHEN approval_admin = 'denied' THEN 'accepted' " +
                         "ELSE 'accepted' END " +
                         "WHERE request_id = @requestId";
            RequestList request = new RequestList();
            request.requestId = requestId;
            int rowsAffected = _adminRaisedRequest.add(request, query);
            loadAdminRequests();
            userGridControl.Refresh();
        }


        


        private void displayRemark()
        {
            if (ck == true)
            {
                RequestList requestList = new RequestList();
                requestList.requestId = req_Id;
                string query = "select user_remark,manager_remark,admin_remark from request_table where request_id=@requestId";
                DataTable dt = _adminRaisedRequest.get(requestList, query);
                adminCurrentRemarkTxt.Text = dt.Rows[0]["admin_remark"].ToString();
                userRemarkTxt.Text = dt.Rows[0]["user_remark"].ToString();
                ManagerRemarkTxt.Text = dt.Rows[0]["manager_remark"].ToString();
                Remarks.Visible = true;
            }

        }

       

        

        private void denyAdminRequestApproval(int selectedRequestId)
        {
            string query = "UPDATE request_table SET approval_admin = CASE " +
                         "WHEN approval_admin = 'accepted' THEN 'denied' " +
                         "ELSE 'denied' END " +
                         "WHERE request_id = @requestId";
            RequestList request = new RequestList();
            request.requestId = selectedRequestId;
            int rowsAffected = _adminRaisedRequest.add(request, query);
            loadAdminRequests();
            userGridControl.Refresh();
        }

        


        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            if (ck == true)
            {
                if (adminRemarkTextBox.Text == "")
                {
                    MessageBox.Show("please enter the remark to update");
                }
                else
                {
                    RequestList request = new RequestList();
                    request.requestId = req_Id;
                    request.adminRemark = adminRemarkTextBox.Text;
                    string query = "update request_table set admin_remark=@adminRemark where request_id=@requestId";
                    int RowsAffected = _adminRaisedRequest.add(request, query);
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

        private void acceptBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selectedRequestId > 0)
            {
                acceptAdminRequestApproval(selectedRequestId);
            }
            else
            {
                Console.WriteLine("No Request Selected");
            }
        }

        private void denyBtn1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selectedRequestId > 0)
            {
                denyAdminRequestApproval(selectedRequestId);
            }
            else
            {
                Console.WriteLine("No Request Selected");
            }
        }

        private void resetBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadAdminRequests();
        }
    }
}