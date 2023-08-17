using File_Acess_Management.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Acess_Management
{
    public partial class SubManagers : Form
    {
        User user;
        public SubManagers(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void SubManagers_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Manager DB Loaded /n User ID:" + user.Id);
            userListBx.Visible = false;
        }

        private void displayName_Click(object sender, EventArgs e)
        {

        }

        private void reqStatusLbl_Click(object sender, EventArgs e)
        {
            tabTitleLbl.Text = "User List";
            loadUserList(user.Id);
        }

        private void loadUserList(int id)
        {
            userListBx.Visible = true;

            {
                var table = new DataTable();

                var connection = ConnectionHelper.ConnectionString;

                using (var con = new MySqlConnection { ConnectionString = connection })
                {
                    using (var command = new MySqlCommand { Connection = con })
                    {

                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }

                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            Console.WriteLine("DB Connection Established");
                        }
                        else
                        {
                            Console.WriteLine("DB Connection Failed");
                        }


                        try
                        {
                            int managerId = user.Id;

                            string selectQuery = "SELECT name, id FROM users " +
                                                 "INNER JOIN managerassigned ON managerassigned.users_id = users.id " +
                                                 "WHERE managerassigned.manager_id = @id";
                            using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, con))
                            {
                                selectCommand.Parameters.AddWithValue("@id", managerId);

                                MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
                                DataSet dataSet = new DataSet();
                                adapter.Fill(dataSet);

                                BindingSource bindingSource = new BindingSource();
                                bindingSource.DataSource = dataSet.Tables[0];

                                userListBx.DataSource = bindingSource;
                                userListBx.DisplayMember = "name";
                                userListBx.ValueMember = "id";

                                userListBx.Refresh();
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message + " sql query error.");

                        }

                    }
                }

            }
        }

        private void requestLbl_Click(object sender, EventArgs e)
        {
            loadIncomingRequest();
        }

        private void loadIncomingRequest()
        {
            throw new NotImplementedException();
        }
    }
}
