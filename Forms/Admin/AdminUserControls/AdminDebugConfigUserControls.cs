using File_Acess_Management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Acess_Management.Forms.Admin.AdminUserControls
{
    public partial class AdminDebugConfigUserControls : UserControl
    {
        private string debugEmail;
        private string debugAdmin;
        private string debugAdminPass;
        private string debugManager;
        private string debugManagerPass;
        private string debugUser;
        private string debugUserPass;

        public AdminDebugConfigUserControls()
        {
            InitializeComponent();
        }

        private void DebugEmailLbl_Click(object sender, EventArgs e)
        {

        }

        private void AdminDebugConfigUserControls_Load(object sender, EventArgs e)
        {
            updateLbl.Text = "";
            updateLbl.BackColor = Color.White;
            debugEmail = Settings.Default.DebugEmail;
            debugAdmin = Settings.Default.DebugAdminID;
            debugAdminPass = Settings.Default.DebugAdminPass;
            debugManager = Settings.Default.DebugManagerID;
            debugManagerPass = Settings.Default.DebugManagerPass;
            debugUser = Settings.Default.DebugUserID;
            debugUserPass = Settings.Default.DebugUserPass;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            StringBuilder updateInfo = new StringBuilder("Updating settings: ");
            if (!string.IsNullOrEmpty(emailTxtBox.Text))
            {
                updateInfo.Append("DebugEmail, ");
                Settings.Default.DebugEmail = emailTxtBox.Text;
            }


            if (!string.IsNullOrEmpty(adminIDTxtBox.Text))
            {
                updateInfo.Append("DebugAdminID, ");
                Settings.Default.DebugAdminID = adminIDTxtBox.Text;
            }


            if (!string.IsNullOrEmpty(adminPassTxtBox.Text))
            {
                updateInfo.Append("DebugAdminPass, ");
                Settings.Default.DebugAdminPass = adminPassTxtBox.Text;
            }


            if (!string.IsNullOrEmpty(managerTxtBox.Text))
            {
                updateInfo.Append("DebugManagerID, ");
                Settings.Default.DebugManagerID = managerTxtBox.Text;
            }


            if (!string.IsNullOrEmpty(managerPassTxtBox.Text))
            {
                updateInfo.Append("DebugManagerPass, ");
                Settings.Default.DebugManagerPass = managerPassTxtBox.Text;
            }


            if (!string.IsNullOrEmpty(userIdTxtBox.Text))
            {
                updateInfo.Append("DebugUserID, ");
                Settings.Default.DebugUserID = userIdTxtBox.Text;
            }


            if (!string.IsNullOrEmpty(userPassTxtBox.Text))
            {
                updateInfo.Append("DebugUserPass, ");
                Settings.Default.DebugUserPass = userPassTxtBox.Text;
            }

            if (updateInfo.Length > "Updating settings: ".Length)
            {
                updateInfo.Remove(updateInfo.Length - 2, 2);
                Console.WriteLine(updateInfo);
                updateLbl.Text = updateInfo.ToString();
            }
            else
            {
                string noUpd = "No settings were updated.";
                Console.WriteLine(noUpd);
                updateLbl.Text = noUpd;
            }


            Settings.Default.Save();
        }

        private void rstBtn_Click(object sender, EventArgs e)
        {
            emailTxtBox.Text = "";
            adminIDTxtBox.Text = "";
            adminPassTxtBox.Text = "";
            managerTxtBox.Text = "";
            managerPassTxtBox.Text = "";
            userIdTxtBox.Text = "";
            userPassTxtBox.Text = "";
            updateLbl.Text = "";
        }
    }
}
