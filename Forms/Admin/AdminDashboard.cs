using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Forms.Admin.AdminUserControls;
using File_Acess_Management.Forms.Admin.ManagerUserControls;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace File_Acess_Management
{
    public partial class AdminDashboard : Form
    {
        public readonly ServiceProvider _serviceProvider;
        //private AdminUserManagementUserControl adminUserManagementUCl;
        private UserManager userManager;
        //private AdminSoftwareManagementUserControl softwareUC;
        private AdminManagerUserAssignmentUserControl managerUC;
        private AdminRaisedRequestsUserControl raisedRequestsUC;
        private AdminDebugConfigUserControls debugConfigUserControlsUC;
        private SoftwareManager softwareManagerUC;
        private Form currentForm;

        public AdminDashboard(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            userManager = new UserManager(_serviceProvider.GetRequiredService<IUserManagementRepository>());
            //softwareUC = new AdminSoftwareManagementUserControl(_serviceProvider.GetRequiredService<ISoftwareRepository>());
            softwareManagerUC = new SoftwareManager(_serviceProvider.GetRequiredService<ISoftwareRepository>());
            managerUC = new AdminManagerUserAssignmentUserControl(_serviceProvider.GetRequiredService<IUserManagerAssignmentRepository>());
            raisedRequestsUC = new AdminRaisedRequestsUserControl(_serviceProvider.GetRequiredService<IAdminRaisedRequest>());
            debugConfigUserControlsUC = new AdminDebugConfigUserControls(_serviceProvider.GetRequiredService<IAdminRaisedRequest>());
            InitializeComponent();
        }


        //AdminUserManagementUserControl adminUserManagementUCl = new AdminUserManagementUserControl(_serviceProvider);
        private void DisposeCurrentControl()
        {
            if (currentForm != null)
            {
                currentForm.Dispose();
                currentForm = null;
            }
        }

        private void AddUserControl(UserControl userControl)
        {
            DisposeCurrentControl();
            userControl.Dock = DockStyle.Fill;
            AdminContentPanelManager.Controls.Clear();
            AdminContentPanelManager.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IncomingRequestsButton.BackColor = Color.Aqua;
            userManagerBtn.BackColor = Color.White;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.White;
            debugBtn.BackColor = Color.White;
            AddUserControl(raisedRequestsUC);
        }


        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            IncomingRequestsButton.BackColor = Color.Aqua;
            userManagerBtn.BackColor = Color.White;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.White;
            debugBtn.BackColor = Color.White;
            tabTitleLbl.Text = "Incoming Requests";
            AddUserControl(raisedRequestsUC);
        }

        private void usersMngBtn_Click(object sender, EventArgs e)
        {
            IncomingRequestsButton.BackColor = Color.White;
            userManagerBtn.BackColor = Color.White;
            usersMngBtn.BackColor = Color.Aqua;
            softwareMngBtn.BackColor = Color.White;
            tabTitleLbl.Text = "User Management";
            debugBtn.BackColor = Color.White;
            AddUserControl(userManager);
        }

        private void userManagerBtn_Click(object sender, EventArgs e)
        {
            IncomingRequestsButton.BackColor = Color.White;
            userManagerBtn.BackColor = Color.Aqua;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.White;
            debugBtn.BackColor = Color.White;
            tabTitleLbl.Text = "Manager - User Assignment";
            AddUserControl(managerUC);
        }

        private void softwareMngBtn_Click(object sender, EventArgs e)
        {
            IncomingRequestsButton.BackColor = Color.White;
            userManagerBtn.BackColor = Color.White;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.Aqua;
            debugBtn.BackColor = Color.White;
            tabTitleLbl.Text = "Software Management";
            //AddUserControl(softwareUC);
            AddUserControl(softwareManagerUC);
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UserLogin userLogin = new UserLogin(_serviceProvider);
            userLogin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IncomingRequestsButton.BackColor = Color.White;
            userManagerBtn.BackColor = Color.White;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.White;
            debugBtn.BackColor = Color.Aqua;
            tabTitleLbl.Text = "Debug Settings";
            AddUserControl(debugConfigUserControlsUC);
        }
    }
}