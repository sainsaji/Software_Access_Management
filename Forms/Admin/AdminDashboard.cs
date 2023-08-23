using File_Acess_Management.Forms.Admin.AdminUserControls;
using File_Acess_Management.Forms.Admin.ManagerUserControls;
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
        private Form currentForm;
        AdminUserManagementUserControl adminUserManagementUCl = new AdminUserManagementUserControl();
        AdminRaisedRequestsUserControl raisedRequestsUC = new AdminRaisedRequestsUserControl();
        AdminSoftwareManagementUserControl softwareUC = new AdminSoftwareManagementUserControl();
        AdminManagerUserAssignmentUserControl managerUC = new AdminManagerUserAssignmentUserControl();


        public AdminDashboard()
        {
            InitializeComponent();
        }

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
            ShowForm(new RaisedRequests());
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
            ShowForm(new RaisedRequests());
            AddUserControl(raisedRequestsUC);
        }

        private void usersMngBtn_Click(object sender, EventArgs e)
        {
            IncomingRequestsButton.BackColor = Color.White;
            userManagerBtn.BackColor = Color.White;
            usersMngBtn.BackColor = Color.Aqua;
            softwareMngBtn.BackColor = Color.White;
            tabTitleLbl.Text = "User Management";
            ShowForm(new UserManagement());
            AddUserControl(adminUserManagementUCl);

        }

        private void userManagerBtn_Click(object sender, EventArgs e)
        {
            IncomingRequestsButton.BackColor = Color.White;
            userManagerBtn.BackColor = Color.Aqua;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.White;
            tabTitleLbl.Text = "Manager - User Assignment";
            ShowForm(new ManagerUserAssignment());
            AddUserControl(managerUC);
        }

        private void softwareMngBtn_Click(object sender, EventArgs e)
        {
            IncomingRequestsButton.BackColor = Color.White;
            userManagerBtn.BackColor = Color.White;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.Aqua;
            tabTitleLbl.Text = "Software Management";
            ShowForm(new SoftwareManagement());
            AddUserControl(softwareUC);
        }


        private void logOutBtn_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();
        }
    }
}
