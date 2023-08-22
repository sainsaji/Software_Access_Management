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

namespace File_Acess_Management.Forms.Manager.ManagerUserControls
{
    public partial class ManagerUserListUserControl : UserControl
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public ManagerUserListUserControl()
        {
            InitializeComponent();
        }

        private void ManagerUserListUserControl_Load(object sender, EventArgs e)
        {
            
            loadUserList(Id);
        }

        private void loadUserList(int id)
        {

            {


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
                            Console.WriteLine("Loading User List");
                            int managerId = id;

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

                                assignedUserListBx.DataSource = bindingSource;
                                assignedUserListBx.DisplayMember = "name";
                                assignedUserListBx.ValueMember = "id";
                                assignedUserListBx.Refresh();
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
    }
}
