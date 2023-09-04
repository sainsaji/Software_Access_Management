using File_Acess_Management.Data.Repository.IRepository;
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

namespace File_Acess_Management.Forms.Manager.ManagerUserControls
{
    public partial class ManagerIncomingRequestUserControl : UserControl
    {
        private int _id;
        IManagerSideRepository _managerSideRepository;
        object requestIdValue;

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

        private void userRequestGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == userRequestGridView.Columns["Action"].Index)
            {
                DataGridViewRow row = userRequestGridView.Rows[e.RowIndex];

                requestIdValue = row.Cells["request_id"].Value;

                try
                {
                    if (requestIdValue != null)
                    {
                        // Print the request_id to the console
                        Console.WriteLine("Clicked Approve for request_id: " + requestIdValue.ToString());

                        // Update manager approval in the database
                        int requestId = int.Parse(requestIdValue.ToString());
                        updateManagerRequestApproval(requestId);
                        loadIncomingRequest(_id);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
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

        private void button3_Click(object sender, EventArgs e)
        {
            updateManagerRequestApproval(int.Parse(requestIdValue.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
