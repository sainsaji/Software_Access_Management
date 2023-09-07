using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using File_Acess_Management.Data.Repository.IRepository;
using File_Acess_Management.Models;
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
    public partial class SoftwareManager : DevExpress.XtraEditors.XtraUserControl
    {
        private bool ck;
        private int software_id = 0;
        private ISoftwareRepository _software;
        private ErrorProvider errorProvider = new ErrorProvider();

        public SoftwareManager(ISoftwareRepository software)
        {
            InitializeComponent();
            _software = software;
        }



        private void SoftwareManager_Load(object sender, EventArgs e)
        {
            GetSoftwareRecords();
            SoftwareGrid.SelectionChanged += gridView1_SelectionChanged;
            ck = false;
            reset();
        }

        private void GetSoftwareRecords()
        {
            string query = "SELECT * from software;";
            DataTable dt = _software.getAll(query);
            SoftwareGridControl.DataSource = dt;
            SoftwareGrid.Columns["soft_id"].Caption = "Software Id";
            SoftwareGrid.Columns["soft_name"].Caption = "Software Name";
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (SoftwareGrid.SelectedRowsCount > 0)
            {
                int selectedRowHandle = SoftwareGrid.GetSelectedRows()[0];
                software_id = Convert.ToInt32(SoftwareGrid.GetRowCellValue(selectedRowHandle, "soft_id"));
                softwareIDTxt.Text = Convert.ToString(software_id);
                softwareNameTxt.Text = SoftwareGrid.GetRowCellValue(selectedRowHandle, "soft_name").ToString();
                ck = true;
                addBtn.Enabled = false;
                barAddBtn.Enabled = false;
            }
        }
        private void reset()
        {
            softwareIDTxt.Text = "";
            softwareNameTxt.Text = "";
            SoftwareGrid.ClearSelection();
            software_id = 0;
            ck = false;
            addBtn.Enabled = true;
            barAddBtn.Enabled = true;
            errorProvider.SetError(softwareNameTxt, "");
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            Software softwares = new Software(0, softwareNameTxt.Text);
            string query1 = "Select * from software where soft_name=@SoftName;";
            DataTable dt2 = _software.get(softwares, query1);
            if (dt2.Rows.Count > 0)
            {
                ck = true;
            }
            else { ck = false; }

            if (ck == true)
            {
                errorProvider.SetError(softwareNameTxt, "You can't add the same record again");
            }
            else if (softwares.SoftName == "")
            {
                errorProvider.SetError(softwareNameTxt, "Enter a name");
            }
            else
            {
                errorProvider.SetError(softwareNameTxt, "");
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

        private void updateBtn_Click(object sender, EventArgs e)
        {

            {
                {
                    Software softwares2 = new Software(0, softwareNameTxt.Text);
                    string query1 = "Select * from software where soft_name=@SoftName;";
                    DataTable dt2 = _software.get(softwares2, query1);
                    if (dt2.Rows.Count > 0)
                    {
                        ck = true;
                    }
                    else { ck = false; }

                    if (ck == false)
                    {
                        Software softwares = new Software(software_id, softwareNameTxt.Text);
                        if (softwares.SoftName == "")
                        {
                            errorProvider.SetError(softwareNameTxt, "Enter a software name");
                            return;
                        }
                        else if (software_id == 0)
                        {
                            errorProvider.SetError(softwareNameTxt, "Error Occured");
                            return;
                        }
                        string query = "Update software set soft_name=@SoftName where soft_id=@Id;";
                        int rowsEffected = _software.add(softwares, query);
                        if (rowsEffected > 0)
                        {
                            XtraMessageBox.Show("Software updated successfully.");
                            GetSoftwareRecords();
                            reset();
                        }
                    }
                    else
                    {
                        errorProvider.SetError(softwareNameTxt, "Software Already Exist");
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            {
                {
                    if (ck == true)
                    {
                        Software softwares = new Software(software_id, null);
                        if (software_id == 0)
                        {
                            errorProvider.SetError(softwareNameTxt, "Some Error Occured");
                            return;
                        }
                        string query = "delete from software where soft_id=@Id;";
                        int rowsEffected = _software.remove(softwares, query);
                        if (rowsEffected > 0)
                        {

                            XtraMessageBox.Show("Software deleted successfully.");
                            GetSoftwareRecords();
                            reset();
                        }
                    }
                    else
                    {
                        errorProvider.SetError(softwareNameTxt, "Nothing Selected to Delete");
                    }
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }


    }
}
