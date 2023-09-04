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

        public ManagerIncomingRequestUserControl(int Id, IManagerSideRepository managerSideRepository)
        {
            _id = Id;
            _managerSideRepository = managerSideRepository;
            InitializeComponent();
        }

        private void setButtonAction()
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Approve/Deny";
            col.Name = "Action";
            userRequestGridView.Columns.Add(col);
        }

        private void updateManagerRequestApproval(int id)
        {
            RequestList requesList = new RequestList();
            requesList.requestId = id;
            string updateQuery = "UPDATE request_table SET approval_manager = CASE " +
                         "WHEN approval_manager = 'Pending' THEN 'denied' " +
                         "ELSE 'approved' END " +
                         "WHERE request_id = @requestId";
            int rowsAffected = _managerSideRepository.add(requesList, updateQuery);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Request updated successfully");
            }
            loadIncomingRequest(_id);
            userRequestGridView.Refresh();
        }

        private void loadIncomingRequest(int id)
        {
            try
            {
                RequestList requesList = new RequestList();
                requesList.userId = id;
                string selectQuery = "SELECT\r\n    " +
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
                userRequestGridView.Refresh();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " sql query error.");
            }
        }



        private void ManagerIncomingRequestUserControl_Load(object sender, EventArgs e)
        {
            if (_id != 0)
            {
                loadIncomingRequest(_id);
                setButtonAction();
            }
            else
            {
                Console.WriteLine("Invalid Manger ID:" + _id);
                MessageBox.Show("Invalid Manger ID:" + _id);
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
            loadIncomingRequest(_id);
            userRequestGridView.Refresh();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            actionManagerApproval(selectedRequestId, "approved");
        }

        private void userRequestGridView_SelectionChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Selection Change Triggered");
            if (userRequestGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = userRequestGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = userRequestGridView.Rows[selectedRowIndex];
                object requestIdValue = selectedRow.Cells["request_id"].Value;
                object requestState = selectedRow.Cells["Manager_Approval"].Value;
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

        private void denyBtn_Click(object sender, EventArgs e)
        {
            actionManagerApproval(selectedRequestId, "denied");
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            loadIncomingRequest(_id);
        }
    }
}