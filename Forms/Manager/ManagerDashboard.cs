using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Forms.Manager.ManagerUserControls;
using File_Acess_Management.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace File_Acess_Management
{
    public partial class ManagerDashboard : Form
    {
        private Users user;
        private ManagerUserListUserControl userListUC;
        private ManagerInformationUserConrol managerInformationUserControl;
        private ManagerIncomingRequestUserControl managerIncomingRequestUserControl;
        private readonly ServiceProvider _serviceProvider;

        public ManagerDashboard(Users user, ServiceProvider serviceProvider)
        {
            this.user = user;
            _serviceProvider = serviceProvider;
            managerInformationUserControl = new ManagerInformationUserConrol(this.user.Id, _serviceProvider.GetRequiredService<IManagerSideRepository>());
            managerIncomingRequestUserControl = new ManagerIncomingRequestUserControl(this.user.Id, _serviceProvider.GetRequiredService<IManagerSideRepository>());
            userListUC = new ManagerUserListUserControl(this.user.Id, _serviceProvider.GetRequiredService<IManagerSideRepository>());
            InitializeComponent();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            contentPanelManager.Controls.Clear();
            contentPanelManager.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void SubManagers_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Manager DB Loaded /n User ID:" + user.Id);
            userListBx.Visible = false;
            requestGridView.Visible = false;
            assignedLbl.Visible = false;
        }

        private void displayName_Click(object sender, EventArgs e)
        {
        }

        private void logOut(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin(_serviceProvider);
            userLogin.Show();
            this.Close();
        }

        private void TabPanelClicked(Panel panel, UserControl userControl, string tabTitle)
        {
            managerInformationPanel.BackColor = Color.White;
            incomingRequestPanel.BackColor = Color.White;
            userListPanel.BackColor = Color.White;
            panel.BackColor = Color.LightBlue;
            tabTitleLbl.Text = tabTitle;
            AddUserControl(userControl);
        }

        private void userInfoLbl_Click(object sender, EventArgs e)
        {
            TabPanelClicked(managerInformationPanel, managerInformationUserControl, "Manager Information");
        }

        private void reqStatusLbl_Click(object sender, EventArgs e)
        {
            TabPanelClicked(userListPanel, userListUC, "User List");
        }

        private void requestLbl_Click(object sender, EventArgs e)
        {
            TabPanelClicked(incomingRequestPanel, managerIncomingRequestUserControl, "Request List");
        }

        private void managerInformationIcon_Click(object sender, EventArgs e)
        {
            TabPanelClicked(managerInformationPanel, managerInformationUserControl, "Manager Information");
        }

        private void incomingURIcon_Click(object sender, EventArgs e)
        {
            TabPanelClicked(incomingRequestPanel, managerIncomingRequestUserControl, "Request List");
        }

        private void userListIcon_Click(object sender, EventArgs e)
        {
            TabPanelClicked(userListPanel, userListUC, "User List");
        }

        private void managerInformationPanel_Click(object sender, EventArgs e)
        {
            TabPanelClicked(managerInformationPanel, managerInformationUserControl, "Manager Information");
        }

        private void incomingRequestPanel_Click(object sender, EventArgs e)
        {
            TabPanelClicked(incomingRequestPanel, managerIncomingRequestUserControl, "Request List");
        }

        private void userListPanel_Click(object sender, EventArgs e)
        {
            TabPanelClicked(userListPanel, userListUC, "User List");
        }
    }
}