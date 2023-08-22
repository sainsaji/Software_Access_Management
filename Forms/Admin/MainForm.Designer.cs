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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.usersMngBtn = new System.Windows.Forms.Button();
            this.userManagerBtn = new System.Windows.Forms.Button();
            this.softwareMngBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(209, 23);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1357, 833);
            this.panelContainer.TabIndex = 1;
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(189, 53);
            this.DashboardBtn.TabIndex = 0;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = false;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
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
            this.logOutBtn.TabIndex = 4;
            this.logOutBtn.Text = "Logout";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navigationPanel.Controls.Add(this.logOutBtn);
            this.navigationPanel.Controls.Add(this.softwareMngBtn);
            this.navigationPanel.Controls.Add(this.userManagerBtn);
            this.navigationPanel.Controls.Add(this.usersMngBtn);
            this.navigationPanel.Controls.Add(this.DashboardBtn);
            this.navigationPanel.Location = new System.Drawing.Point(13, 23);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(189, 833);
            this.navigationPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1578, 865);
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
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Button usersMngBtn;
        private System.Windows.Forms.Button userManagerBtn;
        private System.Windows.Forms.Button softwareMngBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Panel navigationPanel;
    }
}