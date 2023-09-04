using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Models;
using System.Data;
using System.Windows.Forms;

namespace File_Acess_Management.Forms.Manager.ManagerUserControls
{
    public partial class ManagerInformationUserConrol : UserControl
    {
        int _id;
        IManagerSideRepository _managerSideRepository;
        public ManagerInformationUserConrol(int id,IManagerSideRepository managerSideRepository)
        {
            _id=id;
            _managerSideRepository=managerSideRepository;
            InitializeComponent();
        }

        private void ManagerInformationUserConrol_Load(object sender, System.EventArgs e)
        {
            string query = "Select * from users where id="+_id;
            DataTable dt = _managerSideRepository.getAll(query);
            userName.Text = dt.Rows[0]["user_name"].ToString();
            name.Text = dt.Rows[0]["name"].ToString();
            email.Text = dt.Rows[0]["email"].ToString();
            phoneNumber.Text = dt.Rows[0]["phone_number"].ToString();
            Address.Text = dt.Rows[0]["address"].ToString();
        }
    }
}