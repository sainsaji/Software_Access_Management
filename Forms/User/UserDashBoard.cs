using File_Acess_Management.Forms.User.UserDashboardUserControls;
using File_Acess_Management.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Acess_Management
{

    public partial class UserDashboard : Form
    {
        public int userId;
        private List<RequestList> requestList = new List<RequestList>();
        private readonly User user;
        UserRaiseRequestUserControl raiseRequestUserControl = new UserRaiseRequestUserControl();
        UserRequestStatusUserControl userRequestStatusUserControl = new UserRequestStatusUserControl();

        public UserDashboard(User user)
        {
            InitializeComponent();
            this.user = user;
            this.userId = user.Id;
            userRequestStatusUserControl.Id = this.userId;
            raiseRequestUserControl.Id = this.userId;
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
            tabTitleLbl.Text = "User Information";

        }








        private void requestLbl_Click(object sender, EventArgs e)
        {
            //requestClickAction();
            AddUserControl(raiseRequestUserControl);


        }









        private void requestPanel_Click(object sender, EventArgs e)
        {
            AddUserControl(raiseRequestUserControl);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //statusClickAction();
            AddUserControl(userRequestStatusUserControl);

        }







        private void statusPanel_Click(object sender, EventArgs e)
        {
            //statusClickAction();
            AddUserControl(userRequestStatusUserControl);

        }

        private void reqIcoClick_Click(object sender, EventArgs e)
        {
            //statusClickAction();
            AddUserControl(userRequestStatusUserControl);
        }








        private void logout(object sender, MouseEventArgs e)
        {
            UserLogin logout = new UserLogin();
            logout.Show();
            this.Close();
        }

        private void logout(object sender, EventArgs e)
        {
            UserLogin logout = new UserLogin();
            logout.Show();
            this.Close();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddUserControl(raiseRequestUserControl);
        }
    }
}
