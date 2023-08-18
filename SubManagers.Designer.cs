namespace File_Acess_Management
{
    partial class SubManagers
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubManagers));
            this.tabTitleLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.logOutLbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.reqStatusLbl = new System.Windows.Forms.Label();
            this.reqIcoClick = new System.Windows.Forms.PictureBox();
            this.requestPanel = new System.Windows.Forms.Panel();
            this.requestLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.userInfoLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.requestGridView = new System.Windows.Forms.DataGridView();
            this.userListBx = new System.Windows.Forms.ListBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.assignedLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reqIcoClick)).BeginInit();
            this.requestPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.informationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTitleLbl
            // 
            this.tabTitleLbl.AutoSize = true;
            this.tabTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTitleLbl.Location = new System.Drawing.Point(612, 24);
            this.tabTitleLbl.Name = "tabTitleLbl";
            this.tabTitleLbl.Size = new System.Drawing.Size(108, 20);
            this.tabTitleLbl.TabIndex = 0;
            this.tabTitleLbl.Text = "Tab Title Here";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.leftPanel);
            this.panel1.Controls.Add(this.logoPicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 657);
            this.panel1.TabIndex = 2;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.leftPanel.Controls.Add(this.panel4);
            this.leftPanel.Controls.Add(this.statusPanel);
            this.leftPanel.Controls.Add(this.requestPanel);
            this.leftPanel.Controls.Add(this.informationPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 63);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(225, 594);
            this.leftPanel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.logOutLbl);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 531);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 63);
            this.panel4.TabIndex = 1;
            this.panel4.Click += new System.EventHandler(this.logOut);
            // 
            // logOutLbl
            // 
            this.logOutLbl.AutoSize = true;
            this.logOutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutLbl.Location = new System.Drawing.Point(72, 14);
            this.logOutLbl.Name = "logOutLbl";
            this.logOutLbl.Size = new System.Drawing.Size(52, 17);
            this.logOutLbl.TabIndex = 4;
            this.logOutLbl.Text = "Logout";
            this.logOutLbl.Click += new System.EventHandler(this.logOut);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.logOut);
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusPanel.Controls.Add(this.reqStatusLbl);
            this.statusPanel.Controls.Add(this.reqIcoClick);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusPanel.Location = new System.Drawing.Point(0, 124);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(225, 62);
            this.statusPanel.TabIndex = 2;
            this.statusPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.statusPanel_Paint);
            // 
            // reqStatusLbl
            // 
            this.reqStatusLbl.AutoSize = true;
            this.reqStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqStatusLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reqStatusLbl.Location = new System.Drawing.Point(48, 12);
            this.reqStatusLbl.Name = "reqStatusLbl";
            this.reqStatusLbl.Size = new System.Drawing.Size(64, 17);
            this.reqStatusLbl.TabIndex = 2;
            this.reqStatusLbl.Text = "User List";
            this.reqStatusLbl.Click += new System.EventHandler(this.reqStatusLbl_Click);
            // 
            // reqIcoClick
            // 
            this.reqIcoClick.Image = ((System.Drawing.Image)(resources.GetObject("reqIcoClick.Image")));
            this.reqIcoClick.Location = new System.Drawing.Point(3, 9);
            this.reqIcoClick.Name = "reqIcoClick";
            this.reqIcoClick.Size = new System.Drawing.Size(56, 37);
            this.reqIcoClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reqIcoClick.TabIndex = 2;
            this.reqIcoClick.TabStop = false;
            // 
            // requestPanel
            // 
            this.requestPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.requestPanel.Controls.Add(this.requestLbl);
            this.requestPanel.Controls.Add(this.pictureBox2);
            this.requestPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestPanel.Location = new System.Drawing.Point(0, 62);
            this.requestPanel.Name = "requestPanel";
            this.requestPanel.Size = new System.Drawing.Size(225, 62);
            this.requestPanel.TabIndex = 1;
            // 
            // requestLbl
            // 
            this.requestLbl.AutoSize = true;
            this.requestLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requestLbl.Location = new System.Drawing.Point(48, 12);
            this.requestLbl.Name = "requestLbl";
            this.requestLbl.Size = new System.Drawing.Size(121, 17);
            this.requestLbl.TabIndex = 2;
            this.requestLbl.Text = "Incoming Request";
            this.requestLbl.Click += new System.EventHandler(this.requestLbl_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // informationPanel
            // 
            this.informationPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.informationPanel.Controls.Add(this.userInfoLbl);
            this.informationPanel.Controls.Add(this.pictureBox1);
            this.informationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.informationPanel.Location = new System.Drawing.Point(0, 0);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(225, 62);
            this.informationPanel.TabIndex = 0;
            // 
            // userInfoLbl
            // 
            this.userInfoLbl.AutoSize = true;
            this.userInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userInfoLbl.Location = new System.Drawing.Point(48, 11);
            this.userInfoLbl.Name = "userInfoLbl";
            this.userInfoLbl.Size = new System.Drawing.Size(138, 17);
            this.userInfoLbl.TabIndex = 0;
            this.userInfoLbl.Text = "Manager Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // logoPicBox
            // 
            this.logoPicBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPicBox.Image")));
            this.logoPicBox.Location = new System.Drawing.Point(0, 0);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(225, 63);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicBox.TabIndex = 0;
            this.logoPicBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.tabTitleLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1120, 66);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.assignedLbl);
            this.panel2.Controls.Add(this.requestGridView);
            this.panel2.Controls.Add(this.userListBx);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 657);
            this.panel2.TabIndex = 3;
            // 
            // requestGridView
            // 
            this.requestGridView.AllowUserToAddRows = false;
            this.requestGridView.AllowUserToDeleteRows = false;
            this.requestGridView.AllowUserToOrderColumns = true;
            this.requestGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requestGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.requestGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestGridView.Location = new System.Drawing.Point(300, 117);
            this.requestGridView.Name = "requestGridView";
            this.requestGridView.RowHeadersWidth = 51;
            this.requestGridView.RowTemplate.Height = 24;
            this.requestGridView.Size = new System.Drawing.Size(783, 465);
            this.requestGridView.TabIndex = 2;
            this.requestGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestGridView_CellClick);
            // 
            // userListBx
            // 
            this.userListBx.FormattingEnabled = true;
            this.userListBx.ItemHeight = 20;
            this.userListBx.Location = new System.Drawing.Point(282, 117);
            this.userListBx.Name = "userListBx";
            this.userListBx.Size = new System.Drawing.Size(325, 464);
            this.userListBx.TabIndex = 1;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // assignedLbl
            // 
            this.assignedLbl.AutoSize = true;
            this.assignedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedLbl.Location = new System.Drawing.Point(278, 89);
            this.assignedLbl.Name = "assignedLbl";
            this.assignedLbl.Size = new System.Drawing.Size(121, 20);
            this.assignedLbl.TabIndex = 1;
            this.assignedLbl.Text = "Assigned Users";
            this.assignedLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // SubManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SubManagers";
            this.Text = "SubManagers";
            this.Load += new System.EventHandler(this.SubManagers_Load);
            this.panel1.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reqIcoClick)).EndInit();
            this.requestPanel.ResumeLayout(false);
            this.requestPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.informationPanel.ResumeLayout(false);
            this.informationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tabTitleLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label logOutLbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Label reqStatusLbl;
        private System.Windows.Forms.PictureBox reqIcoClick;
        private System.Windows.Forms.Panel requestPanel;
        private System.Windows.Forms.Label requestLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.Label userInfoLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox userListBx;
        private System.Windows.Forms.DataGridView requestGridView;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Label assignedLbl;
    }
}