using File_Acess_Management.Data.Repository;
using File_Acess_Management.Forms.User.UserDashboardUserControls;
using File_Acess_Management.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace File_Acess_Management
{
    public partial class UserDashboard : Form
    {
        public int userId;

        private readonly User user;
        private UserRaiseRequestUserControl raiseRequestUserControl;
        private UserRequestStatusUserControl userRequestStatusUserControl;

        private readonly ServiceProvider _serviceProvider;

        public UserDashboard(User user, ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.user = user;
            this.userId = user.Id;
            raiseRequestUserControl = new UserRaiseRequestUserControl(this.userId, _serviceProvider.GetRequiredService<IUserRaisedRequestRepository>());
            userRequestStatusUserControl = new UserRequestStatusUserControl(this.userId, _serviceProvider.GetRequiredService<IUserRaisedRequestRepository>());
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContentManager.Controls.Clear();
            panelContentManager.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            requestPanel.BackColor = Color.White;
            statusPanel.BackColor = Color.White;
            tabTitleLbl.Text = "";
        }

        private void requestLbl_Click(object sender, EventArgs e)
        {
            //requestClickAction();
            AddUserControl(raiseRequestUserControl);
            tabTitleLbl.Text = "Send Request";
        }

        private void requestPanel_Click(object sender, EventArgs e)
        {
            AddUserControl(raiseRequestUserControl);
            tabTitleLbl.Text = "Send Request";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //statusClickAction();
            AddUserControl(userRequestStatusUserControl);
            tabTitleLbl.Text = "Request Status";
        }

        private void statusPanel_Click(object sender, EventArgs e)
        {
            //statusClickAction();
            AddUserControl(userRequestStatusUserControl);
            tabTitleLbl.Text = "Request Status";
        }

        private void reqIcoClick_Click(object sender, EventArgs e)
        {
            //statusClickAction();
            AddUserControl(userRequestStatusUserControl);
            tabTitleLbl.Text = "Request Status";
        }

        private void logout(object sender, MouseEventArgs e)
        {
            UserLogin logout = new UserLogin(_serviceProvider);
            logout.Show();
            this.Close();
        }

        private void logout(object sender, EventArgs e)
        {
            UserLogin logout = new UserLogin(_serviceProvider);
            logout.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddUserControl(raiseRequestUserControl);
            tabTitleLbl.Text = "Raise Request";
        }
    }
}