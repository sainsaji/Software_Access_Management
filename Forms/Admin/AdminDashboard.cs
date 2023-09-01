using File_Acess_Management.Forms.Admin.AdminUserControls;
using File_Acess_Management.Forms.Admin.ManagerUserControls;
using File_Acess_Management.Data;
using File_Acess_Management.Data.Repository;
using File_Acess_Management.Data.Repository.IRepository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Acess_Management
{
    public partial class AdminDashboard : Form
    {
        public readonly ServiceProvider _serviceProvider;
        AdminUserManagementUserControl adminUserManagementUCl;
        AdminSoftwareManagementUserControl softwareUC;
        AdminManagerUserAssignmentUserControl managerUC;
        AdminRaisedRequestsUserControl raisedRequestsUC;
        AdminDebugConfigUserControls debugConfigUserControlsUC;
        public AdminDashboard(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            adminUserManagementUCl = new AdminUserManagementUserControl(_serviceProvider.GetRequiredService<IUserManagementRepository>());
            softwareUC = new AdminSoftwareManagementUserControl(_serviceProvider.GetRequiredService<ISoftwareRepository>());
            managerUC = new AdminManagerUserAssignmentUserControl(_serviceProvider.GetRequiredService<IUserManagerAssignmentRepository>());
            raisedRequestsUC = new AdminRaisedRequestsUserControl(_serviceProvider.GetRequiredService<IAdminRaisedRequest>());
            debugConfigUserControlsUC = new AdminDebugConfigUserControls();
            InitializeComponent();
        }
        private Form currentForm;
        //AdminUserManagementUserControl adminUserManagementUCl = new AdminUserManagementUserControl(_serviceProvider);




        private void AddUserControl(UserControl userControl)
        {
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
            AddUserControl(raisedRequestsUC);

        }
        private void ShowForm(Form formToShow)
        {
            if (currentForm != null)
            {
                currentForm.Hide(); // Hide the currently displayed form
            }

            currentForm = formToShow;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            AdminContentPanelManager.Controls.Add(currentForm);
            currentForm.Show();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            IncomingRequestsButton.BackColor = Color.Aqua;
            userManagerBtn.BackColor = Color.White;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.White;
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
            AddUserControl(adminUserManagementUCl);

        }

        private void userManagerBtn_Click(object sender, EventArgs e)
        {
            IncomingRequestsButton.BackColor = Color.White;
            userManagerBtn.BackColor = Color.Aqua;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.White;
            tabTitleLbl.Text = "Manager - User Assignment";
            AddUserControl(managerUC);
        }

        private void softwareMngBtn_Click(object sender, EventArgs e)
        {
            IncomingRequestsButton.BackColor = Color.White;
            userManagerBtn.BackColor = Color.White;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.Aqua;
            tabTitleLbl.Text = "Software Management";
            AddUserControl(softwareUC);
        }


        private void logOutBtn_Click(object sender, EventArgs e)
        {
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
            AddUserControl(debugConfigUserControlsUC);
        }
    }
}
