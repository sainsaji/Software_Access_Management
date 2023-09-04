using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Text;
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
        private IAdminRaisedRequest _adminRaisedRequest;

        public AdminDebugConfigUserControls(IAdminRaisedRequest adminRaisedRequest)
        {
            _adminRaisedRequest = adminRaisedRequest;
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
            debugUserPass = Settings.Default.DebugUserPass;
            DataTable dt = _adminRaisedRequest.getTables();

            foreach (DataRow row in dt.Rows)
            {
                string tableName = row["TABLE_NAME"].ToString();
                tableCheckedLstBx.Items.Add(tableName);
            }
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.connection))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                try
                {
                    foreach (string tableName in tableCheckedLstBx.CheckedItems)
                    {
                        // WARNING: Be cautious when executing DELETE queries
                        string deleteQuery = $"DELETE FROM {tableName}";
                        command.CommandText = deleteQuery;
                        command.Connection = connection;
                        command.ExecuteNonQuery();
                    }
                    updateLbl.Text = "Entries deleted successfully.";
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
    }
}