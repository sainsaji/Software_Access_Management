using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Models;
using MySql.Data.MySqlClient;
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
    public partial class AdminSoftwareManagementUserControl : UserControl
    {
        bool ck;
        int software_id = 0;
        ISoftwareRepository _software;
        public AdminSoftwareManagementUserControl(ISoftwareRepository software)
        {
            _software = software;
            InitializeComponent();
        }

        private void AdminSoftwareManagementUserControl_Load(object sender, EventArgs e)
        {
            GetSoftwareRecords();
            softwareListDataGridView.SelectionChanged += softwareListDataGridView_SelectionChanged;
            ck = false;
        }

        private void softwareListDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (softwareListDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = softwareListDataGridView.SelectedRows[0];
                software_id = Convert.ToInt32(selectedRow.Cells["soft_id"].Value);
                softwareNametext.Text = selectedRow.Cells["soft_name"].Value.ToString();
                ck = true;
                addButton.Enabled = false;
            }
        }
        private void GetSoftwareRecords()
        {
            string query = "SELECT * from software;";
            DataTable dt = _software.getAll(query);
            softwareListDataGridView.DataSource = dt;
            softwareListDataGridView.Columns["soft_id"].HeaderText = "Software Id";
            softwareListDataGridView.Columns["soft_name"].HeaderText = "Software Name";
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            {
                Software softwares = new Software();
                softwares.SoftName = softwareNametext.Text;
                if (ck == true)
                {
                    MessageBox.Show("You can't add the same record agian");
                }
                else if (softwares.SoftName == "")
                {
                    MessageBox.Show("Enter the software name");
                }
                else
                {
                    string query = "Insert into software values(0,@SoftName);";
                    int rowsEffected = _software.add(softwares, query);
                    if (rowsEffected > 0)
                    {
                        MessageBox.Show("Software added successfully.");
                        GetSoftwareRecords();
                        reset();
                    }
                }
            }
        }
        private void reset()
        {
            softwareIdText.Text = "";
            softwareNametext.Text = "";
            softwareListDataGridView.ClearSelection();
            software_id = 0;
            ck = false;
            addButton.Enabled = true;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            {
                if (ck == true)
                {
                    Software softwares = new Software();
                    softwares.Id = software_id;
                    softwares.SoftName = softwareNametext.Text;
                    if (softwares.SoftName == "")
                    {
                        MessageBox.Show("Enter the software name");
                        return;
                    }
                    else if (software_id == 0)
                    {
                        MessageBox.Show("Some Error Occured");
                        return;
                    }
                    string query = "Update software set soft_name=@SoftName where soft_id=@Id;";
                    int rowsEffected = _software.add(softwares, query);
                    if (rowsEffected > 0)
                    {
                        MessageBox.Show("Software updated successfully.");
                        GetSoftwareRecords();
                        reset();
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            {
                if (ck == true)
                {
                    Software softwares = new Software();
                    softwares.Id = software_id;
                    if (software_id == 0)
                    {
                        MessageBox.Show("Some Error Occured");
                        return;
                    }
                    string query = "delete from software where soft_id=@Id;";
                    int rowsEffected = _software.remove(softwares, query);
                    if (rowsEffected > 0)
                    {
                        MessageBox.Show("Software deleted successfully.");
                        GetSoftwareRecords();
                        reset();
                    }
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
