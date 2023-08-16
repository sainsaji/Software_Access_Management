namespace File_Acess_Management
{
    partial class userAssignedForm
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
            this.managerUser = new System.Windows.Forms.Label();
            this.userAssigned = new System.Windows.Forms.Label();
            this.assignedManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.selectManager = new System.Windows.Forms.ComboBox();
            this.selectManagerForNotAssigned = new System.Windows.Forms.ComboBox();
            this.notAssignedManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.notAssignedManagers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assignedManagerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedManagerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // managerUser
            // 
            this.managerUser.AutoSize = true;
            this.managerUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerUser.Location = new System.Drawing.Point(442, 36);
            this.managerUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.managerUser.Name = "managerUser";
            this.managerUser.Size = new System.Drawing.Size(266, 25);
            this.managerUser.TabIndex = 0;
            this.managerUser.Text = "Manager User Assignment";
            // 
            // userAssigned
            // 
            this.userAssigned.AutoSize = true;
            this.userAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAssigned.Location = new System.Drawing.Point(53, 107);
            this.userAssigned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userAssigned.Name = "userAssigned";
            this.userAssigned.Size = new System.Drawing.Size(142, 24);
            this.userAssigned.TabIndex = 1;
            this.userAssigned.Text = "Assigned Users";
            // 
            // assignedManagerDataGridView
            // 
            this.assignedManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignedManagerDataGridView.Location = new System.Drawing.Point(57, 175);
            this.assignedManagerDataGridView.Name = "assignedManagerDataGridView";
            this.assignedManagerDataGridView.Size = new System.Drawing.Size(1096, 254);
            this.assignedManagerDataGridView.TabIndex = 2;
            // 
            // selectManager
            // 
            this.selectManager.FormattingEnabled = true;
            this.selectManager.Location = new System.Drawing.Point(57, 141);
            this.selectManager.Name = "selectManager";
            this.selectManager.Size = new System.Drawing.Size(250, 28);
            this.selectManager.TabIndex = 3;
            // 
            // selectManagerForNotAssigned
            // 
            this.selectManagerForNotAssigned.FormattingEnabled = true;
            this.selectManagerForNotAssigned.Location = new System.Drawing.Point(57, 473);
            this.selectManagerForNotAssigned.Name = "selectManagerForNotAssigned";
            this.selectManagerForNotAssigned.Size = new System.Drawing.Size(250, 28);
            this.selectManagerForNotAssigned.TabIndex = 6;
            // 
            // notAssignedManagerDataGridView
            // 
            this.notAssignedManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notAssignedManagerDataGridView.Location = new System.Drawing.Point(57, 507);
            this.notAssignedManagerDataGridView.Name = "notAssignedManagerDataGridView";
            this.notAssignedManagerDataGridView.Size = new System.Drawing.Size(1096, 254);
            this.notAssignedManagerDataGridView.TabIndex = 5;
            // 
            // notAssignedManagers
            // 
            this.notAssignedManagers.AutoSize = true;
            this.notAssignedManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notAssignedManagers.Location = new System.Drawing.Point(53, 439);
            this.notAssignedManagers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notAssignedManagers.Name = "notAssignedManagers";
            this.notAssignedManagers.Size = new System.Drawing.Size(176, 24);
            this.notAssignedManagers.TabIndex = 4;
            this.notAssignedManagers.Text = "Not Assigned Users";
            // 
            // userAssignedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 783);
            this.Controls.Add(this.selectManagerForNotAssigned);
            this.Controls.Add(this.notAssignedManagerDataGridView);
            this.Controls.Add(this.notAssignedManagers);
            this.Controls.Add(this.selectManager);
            this.Controls.Add(this.assignedManagerDataGridView);
            this.Controls.Add(this.userAssigned);
            this.Controls.Add(this.managerUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "userAssignedForm";
            this.Text = "userAssignedForm";
            this.Load += new System.EventHandler(this.userAssignedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignedManagerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedManagerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label managerUser;
        private System.Windows.Forms.Label userAssigned;
        private System.Windows.Forms.DataGridView assignedManagerDataGridView;
        private System.Windows.Forms.ComboBox selectManager;
        private System.Windows.Forms.ComboBox selectManagerForNotAssigned;
        private System.Windows.Forms.DataGridView notAssignedManagerDataGridView;
        private System.Windows.Forms.Label notAssignedManagers;
    }
}