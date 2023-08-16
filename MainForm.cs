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
    public partial class MainForm : Form
    {
        private Form currentForm; // Store the currently displayed form
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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

        }

        private void usersMngBtn_Click(object sender, EventArgs e)
        {
            ShowForm(new ManagerDashboard());

        }

        private void userManagerBtn_Click(object sender, EventArgs e)
        {
            ShowForm(new userAssignedForm());
        }

        private void softwareMngBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
