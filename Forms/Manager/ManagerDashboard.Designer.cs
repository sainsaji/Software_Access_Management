namespace File_Acess_Management
{
    partial class ManagerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDashboard));
            this.tabTitleLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.logOutLbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.userListPanel = new System.Windows.Forms.Panel();
            this.reqStatusLbl = new System.Windows.Forms.Label();
            this.userListIcon = new System.Windows.Forms.PictureBox();
            this.incomingRequestPanel = new System.Windows.Forms.Panel();
            this.requestLbl = new System.Windows.Forms.Label();
            this.incomingURIcon = new System.Windows.Forms.PictureBox();
            this.managerInformationPanel = new System.Windows.Forms.Panel();
            this.managerInfoLabel = new System.Windows.Forms.Label();
            this.managerInformationIcon = new System.Windows.Forms.PictureBox();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contentPanelManager = new System.Windows.Forms.Panel();
            this.assignedLbl = new System.Windows.Forms.Label();
            this.requestGridView = new System.Windows.Forms.DataGridView();
            this.userListBx = new System.Windows.Forms.ListBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.panel1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.userListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userListIcon)).BeginInit();
            this.incomingRequestPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomingURIcon)).BeginInit();
            this.managerInformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerInformationIcon)).BeginInit();
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
            this.tabTitleLbl.Location = new System.Drawing.Point(538, 21);
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
            this.leftPanel.Controls.Add(this.userListPanel);
            this.leftPanel.Controls.Add(this.incomingRequestPanel);
            this.leftPanel.Controls.Add(this.managerInformationPanel);
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
            this.logOutLbl.Location = new System.Drawing.Point(74, 21);
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
            // userListPanel
            // 
            this.userListPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userListPanel.Controls.Add(this.reqStatusLbl);
            this.userListPanel.Controls.Add(this.userListIcon);
            this.userListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userListPanel.Location = new System.Drawing.Point(0, 124);
            this.userListPanel.Name = "userListPanel";
            this.userListPanel.Size = new System.Drawing.Size(225, 62);
            this.userListPanel.TabIndex = 2;
            // 
            // reqStatusLbl
            // 
            this.reqStatusLbl.AutoSize = true;
            this.reqStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqStatusLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reqStatusLbl.Location = new System.Drawing.Point(56, 26);
            this.reqStatusLbl.Name = "reqStatusLbl";
            this.reqStatusLbl.Size = new System.Drawing.Size(64, 17);
            this.reqStatusLbl.TabIndex = 2;
            this.reqStatusLbl.Text = "User List";
            this.reqStatusLbl.Click += new System.EventHandler(this.reqStatusLbl_Click);
            // 
            // userListIcon
            // 
            this.userListIcon.Image = ((System.Drawing.Image)(resources.GetObject("userListIcon.Image")));
            this.userListIcon.Location = new System.Drawing.Point(3, 9);
            this.userListIcon.Name = "userListIcon";
            this.userListIcon.Size = new System.Drawing.Size(56, 37);
            this.userListIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userListIcon.TabIndex = 2;
            this.userListIcon.TabStop = false;
            this.userListIcon.Click += new System.EventHandler(this.userListIcon_Click);
            // 
            // incomingRequestPanel
            // 
            this.incomingRequestPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.incomingRequestPanel.Controls.Add(this.requestLbl);
            this.incomingRequestPanel.Controls.Add(this.incomingURIcon);
            this.incomingRequestPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.incomingRequestPanel.Location = new System.Drawing.Point(0, 62);
            this.incomingRequestPanel.Name = "incomingRequestPanel";
            this.incomingRequestPanel.Size = new System.Drawing.Size(225, 62);
            this.incomingRequestPanel.TabIndex = 1;
            // 
            // requestLbl
            // 
            this.requestLbl.AutoSize = true;
            this.requestLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requestLbl.Location = new System.Drawing.Point(56, 26);
            this.requestLbl.Name = "requestLbl";
            this.requestLbl.Size = new System.Drawing.Size(121, 17);
            this.requestLbl.TabIndex = 2;
            this.requestLbl.Text = "Incoming Request";
            this.requestLbl.Click += new System.EventHandler(this.requestLbl_Click);
            // 
            // incomingURIcon
            // 
            this.incomingURIcon.Image = ((System.Drawing.Image)(resources.GetObject("incomingURIcon.Image")));
            this.incomingURIcon.Location = new System.Drawing.Point(3, 9);
            this.incomingURIcon.Name = "incomingURIcon";
            this.incomingURIcon.Size = new System.Drawing.Size(56, 37);
            this.incomingURIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.incomingURIcon.TabIndex = 2;
            this.incomingURIcon.TabStop = false;
            this.incomingURIcon.Click += new System.EventHandler(this.incomingURIcon_Click);
            // 
            // managerInformationPanel
            // 
            this.managerInformationPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.managerInformationPanel.Controls.Add(this.managerInfoLabel);
            this.managerInformationPanel.Controls.Add(this.managerInformationIcon);
            this.managerInformationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.managerInformationPanel.Location = new System.Drawing.Point(0, 0);
            this.managerInformationPanel.Name = "managerInformationPanel";
            this.managerInformationPanel.Size = new System.Drawing.Size(225, 62);
            this.managerInformationPanel.TabIndex = 0;
            // 
            // managerInfoLabel
            // 
            this.managerInfoLabel.AutoSize = true;
            this.managerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerInfoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managerInfoLabel.Location = new System.Drawing.Point(56, 26);
            this.managerInfoLabel.Name = "managerInfoLabel";
            this.managerInfoLabel.Size = new System.Drawing.Size(138, 17);
            this.managerInfoLabel.TabIndex = 0;
            this.managerInfoLabel.Text = "Manager Information";
            this.managerInfoLabel.Click += new System.EventHandler(this.userInfoLbl_Click);
            // 
            // managerInformationIcon
            // 
            this.managerInformationIcon.Image = ((System.Drawing.Image)(resources.GetObject("managerInformationIcon.Image")));
            this.managerInformationIcon.Location = new System.Drawing.Point(9, 17);
            this.managerInformationIcon.Name = "managerInformationIcon";
            this.managerInformationIcon.Size = new System.Drawing.Size(47, 29);
            this.managerInformationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.managerInformationIcon.TabIndex = 1;
            this.managerInformationIcon.TabStop = false;
            this.managerInformationIcon.Click += new System.EventHandler(this.managerInformationIcon_Click);
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
            this.panel3.Size = new System.Drawing.Size(1120, 63);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.contentPanelManager);
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
            // contentPanelManager
            // 
            this.contentPanelManager.BackColor = System.Drawing.Color.White;
            this.contentPanelManager.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentPanelManager.Location = new System.Drawing.Point(224, 63);
            this.contentPanelManager.Name = "contentPanelManager";
            this.contentPanelManager.Size = new System.Drawing.Size(896, 594);
            this.contentPanelManager.TabIndex = 3;
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
            
            // 
            // userListBx
            // 
            this.userListBx.FormattingEnabled = true;
            this.userListBx.ItemHeight = 20;
            this.userListBx.Location = new System.Drawing.Point(282, 117);
            this.userListBx.Name = "userListBx";
            this.userListBx.Size = new System.Drawing.Size(325, 444);
            this.userListBx.TabIndex = 1;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerDashboard";
            this.Text = "Manager Dashboard";
            this.Load += new System.EventHandler(this.SubManagers_Load);
            this.panel1.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.userListPanel.ResumeLayout(false);
            this.userListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userListIcon)).EndInit();
            this.incomingRequestPanel.ResumeLayout(false);
            this.incomingRequestPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomingURIcon)).EndInit();
            this.managerInformationPanel.ResumeLayout(false);
            this.managerInformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerInformationIcon)).EndInit();
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
        private System.Windows.Forms.Panel userListPanel;
        private System.Windows.Forms.Label reqStatusLbl;
        private System.Windows.Forms.PictureBox userListIcon;
        private System.Windows.Forms.Panel incomingRequestPanel;
        private System.Windows.Forms.Label requestLbl;
        private System.Windows.Forms.PictureBox incomingURIcon;
        private System.Windows.Forms.Panel managerInformationPanel;
        private System.Windows.Forms.Label managerInfoLabel;
        private System.Windows.Forms.PictureBox managerInformationIcon;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView requestGridView;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Label assignedLbl;
        private System.Windows.Forms.ListBox userListBx;
        private System.Windows.Forms.Panel contentPanelManager;
    }
}