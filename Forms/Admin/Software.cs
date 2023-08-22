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

namespace File_Acess_Management
{
    public partial class Software : Form
    {
        bool ck;
        int software_id=0;
        public Software()
        {
            InitializeComponent();
        }
        private void Software_Load(object sender, EventArgs e)
        {
            GetSoftwareRecords();
            softwareListDataGridView.SelectionChanged += SoftwareListDataGridView_SelectionChanged;
            ck=false;
        }

        private void SoftwareListDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (softwareListDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = softwareListDataGridView.SelectedRows[0];
                software_id =Convert.ToInt32(selectedRow.Cells["soft_id"].Value);
                softwareNametext.Text = selectedRow.Cells["soft_name"].Value.ToString();
                ck = true;
                addButton.Enabled = false;
            }
        }

        private void GetSoftwareRecords()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * from software;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                        connection.Close();
                    }
                    softwareListDataGridView.DataSource = dt;
                    //studentRecordDataGridView.Columns["Password"].Visible = false;
                    softwareListDataGridView.Columns["soft_id"].HeaderText = "Software Id";
                    softwareListDataGridView.Columns["soft_name"].HeaderText = "Software Name";
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string software_name= softwareNametext.Text;
            if (ck == true)
            {
                MessageBox.Show("You can't add the same record agian");
            }
            else if(software_name == "")
            {
                MessageBox.Show("Enter the software name");
            }
            else
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    connection.Open();

                    string query = "Insert into software values(0,@softwareName);";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@softwareName", software_name);
                        int rowsEffected=command.ExecuteNonQuery();
                        if(rowsEffected > 0)
                        {
                            MessageBox.Show("Software added successfully.");
                            GetSoftwareRecords();
                            reset();
                        }
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
            if (ck == true)
            {
                string software_name = softwareNametext.Text;
                if (software_name == "")
                {
                    MessageBox.Show("Enter the software name");
                    return;
                }
                else if (software_id == 0)
                {
                    MessageBox.Show("Some Error Occured");
                    return;
                }
                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    connection.Open();

                    string query = "Update software set soft_name=@softwareName where soft_id=@softwareId;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@softwareName", software_name);
                        command.Parameters.AddWithValue("@softwareId", software_id);
                        int rowsEffected = command.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            MessageBox.Show("Software updated successfully.");
                            GetSoftwareRecords();
                            reset();
                        }
                    }
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ck == true)
            {
                
                if (software_id == 0)
                {
                    MessageBox.Show("Some Error Occured");
                    return;
                }
                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    connection.Open();

                    string query = "delete from software where soft_id=@softwareId;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@softwareId", software_id);
                        int rowsEffected = command.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            MessageBox.Show("Software deleted successfully.");
                            GetSoftwareRecords();
                            reset();
                        }
                    }
                }
            }
        }

        private void managerUser_Click(object sender, EventArgs e)
        {

        }
    }
}
