using File_Acess_Management.Data.Repository.IRepository;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Acess_Management.Forms.Admin.ManagerUserControls
{
    public partial class AdminRaisedRequestsUserControl : UserControl
    {
        IAdminRaisedRequest _adminRaisedRequest;
        int selectedRequestId = -1;
        public AdminRaisedRequestsUserControl(IAdminRaisedRequest adminRaisedRequest)
        {
            _adminRaisedRequest = adminRaisedRequest;
            InitializeComponent();
            loadAdminRequests();
        }

        private void loadAdminRequests()
        {
            string query = "SELECT\r\n    " +
                "u.user_name AS User_Name,\r\n    " +
                "s.soft_name AS Software_Name,\r\n    " +
                "um.user_name AS Manager_Name,\r\n    " +
                "rt.approval_manager AS Manager_Approval,\r\n    " +
                "rt.approval_admin AS Admin_Approval,\r\n    " +
                "rt.request_id AS request_id\r\nFROM\r\n    " +
                "users u\r\nJOIN\r\n    " +
                "request_table rt ON u.id = rt.user_id\r\nJOIN\r\n    " +
                "request_list_table rlt ON rt.request_list_id = rlt.req_id\r\nJOIN\r\n    " +
                "software s ON rlt.software_id = s.soft_id\r\nJOIN\r\n    " +
                "managerAssigned ma ON u.id = ma.users_id\r\nJOIN\r\n    " +
                "users um ON ma.manager_id = um.id\r\nWHERE\r\n    " +
                "rt.approval_manager = 'approved';\r\n";
            DataTable dt = _adminRaisedRequest.getAll(query);
            adminRequestsDataGridView.DataSource = dt;
            adminRequestsDataGridView.Refresh();
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
            adminRequestsDataGridView.Refresh();
        }




        private void adminRequestsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (adminRequestsDataGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = adminRequestsDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = adminRequestsDataGridView.Rows[selectedRowIndex];

                object requestIdValue = selectedRow.Cells["request_id"].Value;
                object requestState = selectedRow.Cells["Admin_Approval"].Value;
                if (requestState != null)
                {
                    if (requestState.ToString() == "denied")
                    {
                        denyBtn.Enabled = false;
                        acceptBtn.Enabled = true;
                    }
                    else
                    {
                        denyBtn.Enabled = true;
                        acceptBtn.Enabled = false;
                    }
                }
                else
                {

                }
                if (requestIdValue != null)
                {
                    selectedRequestId = Convert.ToInt32(requestIdValue);
                    Console.WriteLine("Selected Request ID: " + selectedRequestId);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void denyBtn_Click(object sender, EventArgs e)
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
            adminRequestsDataGridView.Refresh();
        }
    }
}
