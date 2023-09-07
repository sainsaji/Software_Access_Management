using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace File_Acess_Management.Forms.Admin.AdminUserControls
{
    public partial class AdminSoftwareManagementUserControl : UserControl
    {
        private bool ck;
        private int software_id = 0;
        private ISoftwareRepository _software;
        private ErrorProvider errorProvider = new ErrorProvider();

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
                softwareIdText.Text = Convert.ToString(software_id);
                softwareNametext.Text = selectedRow.Cells["soft_name"].Value.ToString();
                ck = true;
                addBtn.Enabled = false;
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



        private void reset()
        {
            softwareIdText.Text = "";
            softwareNametext.Text = "";
            softwareListDataGridView.ClearSelection();
            software_id = 0;
            ck = false;
            addBtn.Enabled = true;
            errorProvider.SetError(softwareNametext, "");
        }



        private void button3_Click(object sender, EventArgs e)
        {
            {
                Software softwares = new Software(0, softwareNametext.Text);
                string query1 = "Select * from software where soft_name=@SoftName;";
                DataTable dt2 = _software.get(softwares, query1);
                if (dt2.Rows.Count > 0)
                {
                    ck = true;
                }
                else { ck = false; }

                if (ck == true)
                {
                    errorProvider.SetError(softwareNametext, "You can't add the same record again");
                }
                else if (softwares.SoftName == "")
                {
                    errorProvider.SetError(softwareNametext, "Enter a name");
                }
                else
                {
                    errorProvider.SetError(softwareNametext, "");
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            {
                Software softwares2 = new Software(0, softwareNametext.Text);
                string query1 = "Select * from software where soft_name=@SoftName;";
                DataTable dt2 = _software.get(softwares2, query1);
                if (dt2.Rows.Count > 0)
                {
                    ck = true;
                }
                else { ck = false; }

                if (ck == false)
                {
                    Software softwares = new Software(software_id, softwareNametext.Text);
                    if (softwares.SoftName == "")
                    {
                        errorProvider.SetError(softwareNametext, "Enter a software name");
                        return;
                    }
                    else if (software_id == 0)
                    {
                        errorProvider.SetError(softwareNametext, "Error Occured");
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
                else
                {
                    errorProvider.SetError(softwareNametext, "Software Already Exist");
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            {
                if (ck == true)
                {
                    Software softwares = new Software(software_id, null);
                    if (software_id == 0)
                    {
                        errorProvider.SetError(softwareNametext, "Some Error Occured");
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
                else
                {
                    errorProvider.SetError(softwareNametext, "Nothing Selected to Delete");
                }
            }
        }

        private void rstBtn_Click(object sender, EventArgs e)
        {
            reset();
        }


    }
}