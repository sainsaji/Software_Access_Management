using File_Acess_Management.Data.Repository;
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
    public partial class UserRequestStatusUserControl : UserControl
    {
        private int _id;
        IUserRaisedRequestRepository _userRaisedRequestRepository;
        private List<RequestList> requestList = new List<RequestList>();

        public UserRequestStatusUserControl(int id, IUserRaisedRequestRepository userRaisedRequestRepository)
        {
            _id = id;
            _userRaisedRequestRepository = userRaisedRequestRepository;
            InitializeComponent();
        }
        private void loadRequestStatusData()
        {
            var table = new DataTable();
            try
            {
                Console.WriteLine("Fetching Previous Requests");
                string selectQuery = "select r.request_id, r.user_id, s.soft_name, r.approval_manager, r.approval_admin, r.req_status " +
                    "from request_table r " +
                    "Inner join software s on r.software_id=s.soft_id;";
                dataGridView1.Rows.Clear();
                try
                {
                    DataTable dt = _userRaisedRequestRepository.getAll(selectQuery);
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
            loadRequestStatusData();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
