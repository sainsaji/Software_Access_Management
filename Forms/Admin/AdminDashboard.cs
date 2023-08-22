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
        private Form currentForm;// Store the currently displayed form
        //private readonly IUserManagement _userManagement;
        //private readonly IDatabaseConnectionProvider databaseConnectionProvider;
        //private readonly ICommandFactory commandFactory;
        private readonly ServiceProvider _serviceProvider;
        public AdminDashboard(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DashboardBtn.BackColor = Color.Aqua;
            userManagerBtn.BackColor = Color.White;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.White;
            ShowForm(new RaisedRequests());

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
            panelContainer.Controls.Add(currentForm);
            currentForm.Show();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            DashboardBtn.BackColor = Color.Aqua;
            userManagerBtn.BackColor = Color.White;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.White;
            ShowForm(new RaisedRequests());
        }

        private void usersMngBtn_Click(object sender, EventArgs e)
        {

            DashboardBtn.BackColor = Color.White;
            userManagerBtn.BackColor = Color.White;
            usersMngBtn.BackColor = Color.Aqua;
            softwareMngBtn.BackColor = Color.White;
            
            ShowForm(new UserManagement(_serviceProvider));

        }

        private void userManagerBtn_Click(object sender, EventArgs e)
        {
            DashboardBtn.BackColor = Color.White;
            userManagerBtn.BackColor = Color.Aqua;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.White;
            ShowForm(new ManagerUserAssignment());
        }

        private void softwareMngBtn_Click(object sender, EventArgs e)
        {
            DashboardBtn.BackColor = Color.White;
            userManagerBtn.BackColor = Color.White;
            usersMngBtn.BackColor = Color.White;
            softwareMngBtn.BackColor = Color.Aqua;
            ShowForm(new SoftwareManagement());
        }


        private void logOutBtn_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin(_serviceProvider);
            userLogin.Show();
            this.Close();
        }
    }
}
