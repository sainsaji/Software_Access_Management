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
    public partial class UserDashBoard : Form
    {
        private int currentSelected = 0;
        public UserDashBoard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            requestPanel.BackColor = Color.White;
            informationPanel.BackColor = Color.Aqua;
            statusPanel.BackColor = Color.White;
        }



        private void label1_Click(object sender, EventArgs e)
        {
            requestPanel.BackColor = Color.White;
            informationPanel.BackColor = Color.Aqua;
            statusPanel.BackColor = Color.White;

        }

        private void informationPanel_Click(object sender, EventArgs e)
        {
            requestPanel.BackColor = Color.White;
            informationPanel.BackColor = Color.Aqua;
            statusPanel.BackColor = Color.White;
        }

        private void requestLbl_Click(object sender, EventArgs e)
        {
            requestPanel.BackColor = Color.Aqua;
            informationPanel.BackColor = Color.White;
            statusPanel.BackColor = Color.White;

        }

        private void requestPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void requestPanel_Click(object sender, EventArgs e)
        {
            requestPanel.BackColor = Color.Aqua;
            informationPanel.BackColor = Color.White;
            statusPanel.BackColor = Color.White;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            requestPanel.BackColor = Color.White;
            informationPanel.BackColor = Color.White;
            statusPanel.BackColor = Color.Aqua;
        }
    }
}
