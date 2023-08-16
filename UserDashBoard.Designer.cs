namespace File_Acess_Management
{
    partial class UserDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashBoard));
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.requestRightPanel = new System.Windows.Forms.Panel();
            this.alertsLabel = new System.Windows.Forms.Label();
            this.requestStatusPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.softwareChkdLstBx = new System.Windows.Forms.CheckedListBox();
            this.selectedSoftwareListBox = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.proceedBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.repManagerTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabTitleLbl = new System.Windows.Forms.Label();
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
            this.panel2.SuspendLayout();
            this.requestRightPanel.SuspendLayout();
            this.requestStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.leftPanel);
            this.panel1.Controls.Add(this.logoPicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 417);
            this.panel1.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.leftPanel.Controls.Add(this.panel4);
            this.leftPanel.Controls.Add(this.statusPanel);
            this.leftPanel.Controls.Add(this.requestPanel);
            this.leftPanel.Controls.Add(this.informationPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 41);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(150, 376);
            this.leftPanel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.logOutLbl);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 335);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 41);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.logout);
            // 
            // logOutLbl
            // 
            this.logOutLbl.AutoSize = true;
            this.logOutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutLbl.Location = new System.Drawing.Point(48, 9);
            this.logOutLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logOutLbl.Name = "logOutLbl";
            this.logOutLbl.Size = new System.Drawing.Size(52, 17);
            this.logOutLbl.TabIndex = 4;
            this.logOutLbl.Text = "Logout";
            this.logOutLbl.Click += new System.EventHandler(this.logout);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.logout);
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusPanel.Controls.Add(this.reqStatusLbl);
            this.statusPanel.Controls.Add(this.reqIcoClick);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusPanel.Location = new System.Drawing.Point(0, 80);
            this.statusPanel.Margin = new System.Windows.Forms.Padding(2);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(150, 40);
            this.statusPanel.TabIndex = 2;
            this.statusPanel.Click += new System.EventHandler(this.statusPanel_Click);
            // 
            // reqStatusLbl
            // 
            this.reqStatusLbl.AutoSize = true;
            this.reqStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqStatusLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reqStatusLbl.Location = new System.Drawing.Point(32, 8);
            this.reqStatusLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reqStatusLbl.Name = "reqStatusLbl";
            this.reqStatusLbl.Size = new System.Drawing.Size(105, 17);
            this.reqStatusLbl.TabIndex = 2;
            this.reqStatusLbl.Text = "Request Status";
            this.reqStatusLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // reqIcoClick
            // 
            this.reqIcoClick.Image = ((System.Drawing.Image)(resources.GetObject("reqIcoClick.Image")));
            this.reqIcoClick.Location = new System.Drawing.Point(2, 6);
            this.reqIcoClick.Margin = new System.Windows.Forms.Padding(2);
            this.reqIcoClick.Name = "reqIcoClick";
            this.reqIcoClick.Size = new System.Drawing.Size(37, 24);
            this.reqIcoClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reqIcoClick.TabIndex = 2;
            this.reqIcoClick.TabStop = false;
            this.reqIcoClick.Click += new System.EventHandler(this.reqIcoClick_Click);
            // 
            // requestPanel
            // 
            this.requestPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.requestPanel.Controls.Add(this.requestLbl);
            this.requestPanel.Controls.Add(this.pictureBox2);
            this.requestPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestPanel.Location = new System.Drawing.Point(0, 40);
            this.requestPanel.Margin = new System.Windows.Forms.Padding(2);
            this.requestPanel.Name = "requestPanel";
            this.requestPanel.Size = new System.Drawing.Size(150, 40);
            this.requestPanel.TabIndex = 1;
            this.requestPanel.Click += new System.EventHandler(this.requestPanel_Click);
            this.requestPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.requestPanel_Paint);
            // 
            // requestLbl
            // 
            this.requestLbl.AutoSize = true;
            this.requestLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requestLbl.Location = new System.Drawing.Point(32, 8);
            this.requestLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.requestLbl.Name = "requestLbl";
            this.requestLbl.Size = new System.Drawing.Size(101, 17);
            this.requestLbl.TabIndex = 2;
            this.requestLbl.Text = "Raise Request";
            this.requestLbl.Click += new System.EventHandler(this.requestLbl_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 24);
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
            this.informationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(150, 40);
            this.informationPanel.TabIndex = 0;
            this.informationPanel.Click += new System.EventHandler(this.informationPanel_Click);
            // 
            // userInfoLbl
            // 
            this.userInfoLbl.AutoSize = true;
            this.userInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userInfoLbl.Location = new System.Drawing.Point(32, 7);
            this.userInfoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userInfoLbl.Name = "userInfoLbl";
            this.userInfoLbl.Size = new System.Drawing.Size(112, 17);
            this.userInfoLbl.TabIndex = 0;
            this.userInfoLbl.Text = "User Information";
            this.userInfoLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // logoPicBox
            // 
            this.logoPicBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPicBox.Image")));
            this.logoPicBox.Location = new System.Drawing.Point(0, 0);
            this.logoPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(150, 41);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicBox.TabIndex = 0;
            this.logoPicBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.requestRightPanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 417);
            this.panel2.TabIndex = 1;
            // 
            // requestRightPanel
            // 
            this.requestRightPanel.Controls.Add(this.alertsLabel);
            this.requestRightPanel.Controls.Add(this.requestStatusPanel);
            this.requestRightPanel.Controls.Add(this.addBtn);
            this.requestRightPanel.Controls.Add(this.softwareChkdLstBx);
            this.requestRightPanel.Controls.Add(this.selectedSoftwareListBox);
            this.requestRightPanel.Controls.Add(this.panel7);
            this.requestRightPanel.Controls.Add(this.label5);
            this.requestRightPanel.Controls.Add(this.label4);
            this.requestRightPanel.Controls.Add(this.repManagerTxtBox);
            this.requestRightPanel.Controls.Add(this.label3);
            this.requestRightPanel.Controls.Add(this.nameTxtBox);
            this.requestRightPanel.Controls.Add(this.label1);
            this.requestRightPanel.Location = new System.Drawing.Point(7, 48);
            this.requestRightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.requestRightPanel.Name = "requestRightPanel";
            this.requestRightPanel.Size = new System.Drawing.Size(553, 369);
            this.requestRightPanel.TabIndex = 1;
            // 
            // alertsLabel
            // 
            this.alertsLabel.AutoSize = true;
            this.alertsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertsLabel.Location = new System.Drawing.Point(11, 275);
            this.alertsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alertsLabel.Name = "alertsLabel";
            this.alertsLabel.Size = new System.Drawing.Size(0, 13);
            this.alertsLabel.TabIndex = 16;
            // 
            // requestStatusPanel
            // 
            this.requestStatusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.requestStatusPanel.BackColor = System.Drawing.Color.SeaShell;
            this.requestStatusPanel.Controls.Add(this.dataGridView1);
            this.requestStatusPanel.Location = new System.Drawing.Point(2, 2);
            this.requestStatusPanel.Margin = new System.Windows.Forms.Padding(2);
            this.requestStatusPanel.Name = "requestStatusPanel";
            this.requestStatusPanel.Size = new System.Drawing.Size(548, 360);
            this.requestStatusPanel.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(535, 355);
            this.dataGridView1.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(70, 245);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(56, 19);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // softwareChkdLstBx
            // 
            this.softwareChkdLstBx.FormattingEnabled = true;
            this.softwareChkdLstBx.Location = new System.Drawing.Point(11, 113);
            this.softwareChkdLstBx.Margin = new System.Windows.Forms.Padding(2);
            this.softwareChkdLstBx.Name = "softwareChkdLstBx";
            this.softwareChkdLstBx.Size = new System.Drawing.Size(182, 64);
            this.softwareChkdLstBx.TabIndex = 15;
            // 
            // selectedSoftwareListBox
            // 
            this.selectedSoftwareListBox.FormattingEnabled = true;
            this.selectedSoftwareListBox.Location = new System.Drawing.Point(216, 32);
            this.selectedSoftwareListBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectedSoftwareListBox.Name = "selectedSoftwareListBox";
            this.selectedSoftwareListBox.Size = new System.Drawing.Size(207, 212);
            this.selectedSoftwareListBox.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cancelBtn);
            this.panel7.Controls.Add(this.proceedBtn);
            this.panel7.Location = new System.Drawing.Point(216, 275);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(208, 32);
            this.panel7.TabIndex = 11;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(2, 7);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(56, 19);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // proceedBtn
            // 
            this.proceedBtn.Location = new System.Drawing.Point(150, 7);
            this.proceedBtn.Margin = new System.Windows.Forms.Padding(2);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(56, 19);
            this.proceedBtn.TabIndex = 12;
            this.proceedBtn.Text = "Proceed";
            this.proceedBtn.UseVisualStyleBackColor = true;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Selected Softwares:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Software for Installation:";
            // 
            // repManagerTxtBox
            // 
            this.repManagerTxtBox.Location = new System.Drawing.Point(11, 70);
            this.repManagerTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.repManagerTxtBox.Name = "repManagerTxtBox";
            this.repManagerTxtBox.Size = new System.Drawing.Size(182, 20);
            this.repManagerTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reporting Manager:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(11, 32);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(182, 20);
            this.nameTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.tabTitleLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 43);
            this.panel3.TabIndex = 0;
            // 
            // tabTitleLbl
            // 
            this.tabTitleLbl.AutoSize = true;
            this.tabTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTitleLbl.Location = new System.Drawing.Point(182, 7);
            this.tabTitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tabTitleLbl.Name = "tabTitleLbl";
            this.tabTitleLbl.Size = new System.Drawing.Size(84, 15);
            this.tabTitleLbl.TabIndex = 0;
            this.tabTitleLbl.Text = "Tab Title Here";
            // 
            // UserDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserDashBoard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            this.panel2.ResumeLayout(false);
            this.requestRightPanel.ResumeLayout(false);
            this.requestRightPanel.PerformLayout();
            this.requestStatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.Label userInfoLbl;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel requestPanel;
        private System.Windows.Forms.Label requestLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Label reqStatusLbl;
        private System.Windows.Forms.PictureBox reqIcoClick;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label tabTitleLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label logOutLbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel requestRightPanel;
        private System.Windows.Forms.TextBox repManagerTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button proceedBtn;
        private System.Windows.Forms.ListBox selectedSoftwareListBox;
        private System.Windows.Forms.Panel requestStatusPanel;
        private System.Windows.Forms.CheckedListBox softwareChkdLstBx;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label alertsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

