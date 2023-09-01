using File_Acess_Management.Data.Repository;
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
    public partial class ManagerUserListUserControl : UserControl
    {
        private int _id;
        IManagerSideRepository _managerSideRepository;

        public ManagerUserListUserControl(int id, IManagerSideRepository managerSideRepository)
        {
            _id = id;
            _managerSideRepository = managerSideRepository;
            InitializeComponent();
        }

        private void ManagerUserListUserControl_Load(object sender, EventArgs e)
        {

            loadUserList(_id);
        }

        private void loadUserList(int id)
        {
            try
            {
                RequestList requestList = new RequestList();
                requestList.userId = id;
                string selectQuery = "SELECT name, id FROM users " +
                                     "INNER JOIN managerassigned ON managerassigned.users_id = users.id " +
                                     "WHERE managerassigned.manager_id = @userId";
                DataTable dt = _managerSideRepository.get(requestList, selectQuery);
                assignedUserListBx.DataSource = dt;
                assignedUserListBx.DisplayMember = "name";
                assignedUserListBx.ValueMember = "id";
                assignedUserListBx.Refresh();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " sql query error.");
            }
        }
    }

}
