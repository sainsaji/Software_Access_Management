namespace File_Acess_Management
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.AdminContentPanelManager = new System.Windows.Forms.Panel();
            this.IncomingRequestsButton = new System.Windows.Forms.Button();
            this.usersMngBtn = new System.Windows.Forms.Button();
            this.userManagerBtn = new System.Windows.Forms.Button();
            this.softwareMngBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.debugBtn = new System.Windows.Forms.Button();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabTitleLbl = new System.Windows.Forms.Label();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminContentPanelManager
            // 
            this.AdminContentPanelManager.Location = new System.Drawing.Point(209, 76);
            this.AdminContentPanelManager.Name = "AdminContentPanelManager";
            this.AdminContentPanelManager.Size = new System.Drawing.Size(1357, 780);
            this.AdminContentPanelManager.TabIndex = 1;
            // 
            // IncomingRequestsButton
            // 
            this.IncomingRequestsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IncomingRequestsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.IncomingRequestsButton.Location = new System.Drawing.Point(0, 0);
            this.IncomingRequestsButton.Name = "IncomingRequestsButton";
            this.IncomingRequestsButton.Size = new System.Drawing.Size(189, 53);
            this.IncomingRequestsButton.TabIndex = 0;
            this.IncomingRequestsButton.Text = "Incoming Requests";
            this.IncomingRequestsButton.UseVisualStyleBackColor = false;
            this.IncomingRequestsButton.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // usersMngBtn
            // 
            this.usersMngBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usersMngBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersMngBtn.Location = new System.Drawing.Point(0, 53);
            this.usersMngBtn.Name = "usersMngBtn";
            this.usersMngBtn.Size = new System.Drawing.Size(189, 53);
            this.usersMngBtn.TabIndex = 1;
            this.usersMngBtn.Text = "Users Management";
            this.usersMngBtn.UseVisualStyleBackColor = false;
            this.usersMngBtn.Click += new System.EventHandler(this.usersMngBtn_Click);
            // 
            // userManagerBtn
            // 
            this.userManagerBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userManagerBtn.Location = new System.Drawing.Point(0, 106);
            this.userManagerBtn.Name = "userManagerBtn";
            this.userManagerBtn.Size = new System.Drawing.Size(189, 53);
            this.userManagerBtn.TabIndex = 2;
            this.userManagerBtn.Text = "Manager - User";
            this.userManagerBtn.UseVisualStyleBackColor = false;
            this.userManagerBtn.Click += new System.EventHandler(this.userManagerBtn_Click);
            // 
            // softwareMngBtn
            // 
            this.softwareMngBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.softwareMngBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.softwareMngBtn.Location = new System.Drawing.Point(0, 159);
            this.softwareMngBtn.Name = "softwareMngBtn";
            this.softwareMngBtn.Size = new System.Drawing.Size(189, 53);
            this.softwareMngBtn.TabIndex = 3;
            this.softwareMngBtn.Text = "Software";
            this.softwareMngBtn.UseVisualStyleBackColor = false;
            this.softwareMngBtn.Click += new System.EventHandler(this.softwareMngBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutBtn.Location = new System.Drawing.Point(0, 780);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(189, 53);
            this.logOutBtn.TabIndex = 5;
            this.logOutBtn.Text = "Logout";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navigationPanel.Controls.Add(this.debugBtn);
            this.navigationPanel.Controls.Add(this.logoPicBox);
            this.navigationPanel.Controls.Add(this.logOutBtn);
            this.navigationPanel.Controls.Add(this.softwareMngBtn);
            this.navigationPanel.Controls.Add(this.userManagerBtn);
            this.navigationPanel.Controls.Add(this.usersMngBtn);
            this.navigationPanel.Controls.Add(this.IncomingRequestsButton);
            this.navigationPanel.Location = new System.Drawing.Point(13, 23);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(189, 833);
            this.navigationPanel.TabIndex = 0;
            // 
            // debugBtn
            // 
            this.debugBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.debugBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.debugBtn.Location = new System.Drawing.Point(0, 212);
            this.debugBtn.Name = "debugBtn";
            this.debugBtn.Size = new System.Drawing.Size(189, 53);
            this.debugBtn.TabIndex = 4;
            this.debugBtn.Text = "Debug Config";
            this.debugBtn.UseVisualStyleBackColor = false;
            this.debugBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoPicBox
            // 
            this.logoPicBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPicBox.Image")));
            this.logoPicBox.Location = new System.Drawing.Point(0, 717);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(189, 63);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicBox.TabIndex = 5;
            this.logoPicBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.tabTitleLbl);
            this.panel2.Location = new System.Drawing.Point(209, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1357, 49);
            this.panel2.TabIndex = 27;
            // 
            // tabTitleLbl
            // 
            this.tabTitleLbl.AutoSize = true;
            this.tabTitleLbl.BackColor = System.Drawing.Color.White;
            this.tabTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTitleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabTitleLbl.Location = new System.Drawing.Point(564, 5);
            this.tabTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tabTitleLbl.Name = "tabTitleLbl";
            this.tabTitleLbl.Size = new System.Drawing.Size(148, 25);
            this.tabTitleLbl.TabIndex = 0;
            this.tabTitleLbl.Text = "Tab Title Here";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1578, 865);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AdminContentPanelManager);
            this.Controls.Add(this.navigationPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel AdminContentPanelManager;
        private System.Windows.Forms.Button IncomingRequestsButton;
        private System.Windows.Forms.Button usersMngBtn;
        private System.Windows.Forms.Button userManagerBtn;
        private System.Windows.Forms.Button softwareMngBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label tabTitleLbl;
        private System.Windows.Forms.Button debugBtn;
    }
}