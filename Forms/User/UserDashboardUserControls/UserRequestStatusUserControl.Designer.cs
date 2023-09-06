namespace File_Acess_Management.Forms.User.UserDashboardUserControls
{
    partial class UserRequestStatusUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRequestStatusUserControl));
            this.requestStatusPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.userRemarklbl = new System.Windows.Forms.Label();
            this.userCurrentRemarkLbl = new System.Windows.Forms.Label();
            this.managerRemarkLbl = new System.Windows.Forms.Label();
            this.managerRemarkTxt = new System.Windows.Forms.Label();
            this.adminRemarkLbl = new System.Windows.Forms.Label();
            this.AdminRemarkTxt = new System.Windows.Forms.Label();
            this.userCurrentRemarkTxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userRemarkTextBox = new System.Windows.Forms.MaskedTextBox();
            this.requestStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestStatusPanel
            // 
            this.requestStatusPanel.BackColor = System.Drawing.Color.White;
            this.requestStatusPanel.Controls.Add(this.userRemarkTextBox);
            this.requestStatusPanel.Controls.Add(this.textBox1);
            this.requestStatusPanel.Controls.Add(this.userCurrentRemarkTxt);
            this.requestStatusPanel.Controls.Add(this.AdminRemarkTxt);
            this.requestStatusPanel.Controls.Add(this.adminRemarkLbl);
            this.requestStatusPanel.Controls.Add(this.managerRemarkTxt);
            this.requestStatusPanel.Controls.Add(this.managerRemarkLbl);
            this.requestStatusPanel.Controls.Add(this.userCurrentRemarkLbl);
            this.requestStatusPanel.Controls.Add(this.userRemarklbl);
            this.requestStatusPanel.Controls.Add(this.dataGridView1);
            this.requestStatusPanel.Controls.Add(this.panel1);
            this.requestStatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestStatusPanel.Location = new System.Drawing.Point(0, 0);
            this.requestStatusPanel.Name = "requestStatusPanel";
            this.requestStatusPanel.Size = new System.Drawing.Size(846, 571);
            this.requestStatusPanel.TabIndex = 15;
            this.requestStatusPanel.Leave += new System.EventHandler(this.requestStatusPanel_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 49);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(840, 231);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(846, 48);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(406, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show Credentials";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(216, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit Request";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSalmon;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(5, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Withdraw Request";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userRemarklbl
            // 
            this.userRemarklbl.AutoSize = true;
            this.userRemarklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRemarklbl.Location = new System.Drawing.Point(36, 306);
            this.userRemarklbl.Name = "userRemarklbl";
            this.userRemarklbl.Size = new System.Drawing.Size(103, 20);
            this.userRemarklbl.TabIndex = 3;
            this.userRemarklbl.Text = "User Remark";
            // 
            // userCurrentRemarkLbl
            // 
            this.userCurrentRemarkLbl.AutoSize = true;
            this.userCurrentRemarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCurrentRemarkLbl.Location = new System.Drawing.Point(492, 306);
            this.userCurrentRemarkLbl.Name = "userCurrentRemarkLbl";
            this.userCurrentRemarkLbl.Size = new System.Drawing.Size(171, 20);
            this.userCurrentRemarkLbl.TabIndex = 4;
            this.userCurrentRemarkLbl.Text = "User\'s Current Remark";
            // 
            // managerRemarkLbl
            // 
            this.managerRemarkLbl.AutoSize = true;
            this.managerRemarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerRemarkLbl.Location = new System.Drawing.Point(36, 369);
            this.managerRemarkLbl.Name = "managerRemarkLbl";
            this.managerRemarkLbl.Size = new System.Drawing.Size(132, 20);
            this.managerRemarkLbl.TabIndex = 5;
            this.managerRemarkLbl.Text = "Manager Remark";
            // 
            // managerRemarkTxt
            // 
            this.managerRemarkTxt.AutoSize = true;
            this.managerRemarkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerRemarkTxt.Location = new System.Drawing.Point(36, 401);
            this.managerRemarkTxt.Name = "managerRemarkTxt";
            this.managerRemarkTxt.Size = new System.Drawing.Size(132, 20);
            this.managerRemarkTxt.TabIndex = 6;
            this.managerRemarkTxt.Text = "Manager Remark";
            // 
            // adminRemarkLbl
            // 
            this.adminRemarkLbl.AutoSize = true;
            this.adminRemarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRemarkLbl.Location = new System.Drawing.Point(36, 457);
            this.adminRemarkLbl.Name = "adminRemarkLbl";
            this.adminRemarkLbl.Size = new System.Drawing.Size(114, 20);
            this.adminRemarkLbl.TabIndex = 7;
            this.adminRemarkLbl.Text = "Admin Remark";
            // 
            // AdminRemarkTxt
            // 
            this.AdminRemarkTxt.AutoSize = true;
            this.AdminRemarkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRemarkTxt.Location = new System.Drawing.Point(36, 489);
            this.AdminRemarkTxt.Name = "AdminRemarkTxt";
            this.AdminRemarkTxt.Size = new System.Drawing.Size(114, 20);
            this.AdminRemarkTxt.TabIndex = 8;
            this.AdminRemarkTxt.Text = "Admin Remark";
            // 
            // userCurrentRemarkTxt
            // 
            this.userCurrentRemarkTxt.AutoSize = true;
            this.userCurrentRemarkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCurrentRemarkTxt.Location = new System.Drawing.Point(492, 339);
            this.userCurrentRemarkTxt.Name = "userCurrentRemarkTxt";
            this.userCurrentRemarkTxt.Size = new System.Drawing.Size(171, 20);
            this.userCurrentRemarkTxt.TabIndex = 9;
            this.userCurrentRemarkTxt.Text = "User\'s Current Remark";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-15, -15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // userRemarkTextBox
            // 
            this.userRemarkTextBox.Location = new System.Drawing.Point(39, 329);
            this.userRemarkTextBox.Name = "userRemarkTextBox";
            this.userRemarkTextBox.Size = new System.Drawing.Size(432, 20);
            this.userRemarkTextBox.TabIndex = 13;
            // 
            // UserRequestStatusUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.requestStatusPanel);
            this.Name = "UserRequestStatusUserControl";
            this.Size = new System.Drawing.Size(846, 571);
            this.Load += new System.EventHandler(this.UserRequestStatusUserControl_Load);
            this.VisibleChanged += new System.EventHandler(this.UserRequestStatusUserControl_VisibleChanged);
            this.requestStatusPanel.ResumeLayout(false);
            this.requestStatusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel requestStatusPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label userCurrentRemarkLbl;
        private System.Windows.Forms.Label userRemarklbl;
        private System.Windows.Forms.Label userCurrentRemarkTxt;
        private System.Windows.Forms.Label AdminRemarkTxt;
        private System.Windows.Forms.Label adminRemarkLbl;
        private System.Windows.Forms.Label managerRemarkTxt;
        private System.Windows.Forms.Label managerRemarkLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox userRemarkTextBox;
    }
}
