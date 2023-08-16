namespace File_Acess_Management
{
    partial class MainForm
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
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.softwareMngBtn = new System.Windows.Forms.Button();
            this.userManagerBtn = new System.Windows.Forms.Button();
            this.usersMngBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.logOutBtn);
            this.navigationPanel.Controls.Add(this.softwareMngBtn);
            this.navigationPanel.Controls.Add(this.userManagerBtn);
            this.navigationPanel.Controls.Add(this.usersMngBtn);
            this.navigationPanel.Controls.Add(this.DashboardBtn);
            this.navigationPanel.Location = new System.Drawing.Point(13, 23);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(189, 766);
            this.navigationPanel.TabIndex = 0;
            // 
            // softwareMngBtn
            // 
            this.softwareMngBtn.Location = new System.Drawing.Point(0, 177);
            this.softwareMngBtn.Name = "softwareMngBtn";
            this.softwareMngBtn.Size = new System.Drawing.Size(189, 53);
            this.softwareMngBtn.TabIndex = 3;
            this.softwareMngBtn.Text = "Software";
            this.softwareMngBtn.UseVisualStyleBackColor = true;
            this.softwareMngBtn.Click += new System.EventHandler(this.softwareMngBtn_Click);
            // 
            // userManagerBtn
            // 
            this.userManagerBtn.Location = new System.Drawing.Point(0, 118);
            this.userManagerBtn.Name = "userManagerBtn";
            this.userManagerBtn.Size = new System.Drawing.Size(189, 53);
            this.userManagerBtn.TabIndex = 2;
            this.userManagerBtn.Text = "Manager - User";
            this.userManagerBtn.UseVisualStyleBackColor = true;
            this.userManagerBtn.Click += new System.EventHandler(this.userManagerBtn_Click);
            // 
            // usersMngBtn
            // 
            this.usersMngBtn.Location = new System.Drawing.Point(0, 59);
            this.usersMngBtn.Name = "usersMngBtn";
            this.usersMngBtn.Size = new System.Drawing.Size(189, 53);
            this.usersMngBtn.TabIndex = 1;
            this.usersMngBtn.Text = "Users Management";
            this.usersMngBtn.UseVisualStyleBackColor = true;
            this.usersMngBtn.Click += new System.EventHandler(this.usersMngBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(189, 53);
            this.DashboardBtn.TabIndex = 0;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(209, 23);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1183, 766);
            this.panelContainer.TabIndex = 1;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(0, 710);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(189, 53);
            this.logOutBtn.TabIndex = 4;
            this.logOutBtn.Text = "Logout";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 801);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.navigationPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Button usersMngBtn;
        private System.Windows.Forms.Button softwareMngBtn;
        private System.Windows.Forms.Button userManagerBtn;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button logOutBtn;
    }
}