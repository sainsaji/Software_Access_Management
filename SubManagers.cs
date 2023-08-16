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
            displayName.Text = this.user.Username;
        }

        private void displayName_Click(object sender, EventArgs e)
        {
            
        }
    }
}
