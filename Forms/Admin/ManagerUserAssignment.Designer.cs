namespace File_Acess_Management
{
    partial class ManagerUserAssignment
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
            this.assignManagerBtn = new System.Windows.Forms.Button();
            this.updateAssignedBtn = new System.Windows.Forms.Button();
            this.deleteAssignedBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.assignedManagerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedManagerDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // managerUser
            // 
            this.managerUser.AutoSize = true;
            this.managerUser.BackColor = System.Drawing.Color.White;
            this.managerUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.managerUser.Location = new System.Drawing.Point(440, 8);
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
            this.userAssigned.Location = new System.Drawing.Point(53, 54);
            this.userAssigned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userAssigned.Name = "userAssigned";
            this.userAssigned.Size = new System.Drawing.Size(142, 24);
            this.userAssigned.TabIndex = 1;
            this.userAssigned.Text = "Assigned Users";
            // 
            // assignedManagerDataGridView
            // 
            this.assignedManagerDataGridView.AllowUserToAddRows = false;
            this.assignedManagerDataGridView.AllowUserToDeleteRows = false;
            this.assignedManagerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.assignedManagerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.assignedManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignedManagerDataGridView.Location = new System.Drawing.Point(57, 122);
            this.assignedManagerDataGridView.MultiSelect = false;
            this.assignedManagerDataGridView.Name = "assignedManagerDataGridView";
            this.assignedManagerDataGridView.ReadOnly = true;
            this.assignedManagerDataGridView.RowHeadersWidth = 51;
            this.assignedManagerDataGridView.Size = new System.Drawing.Size(1131, 281);
            this.assignedManagerDataGridView.TabIndex = 2;
            // 
            // selectManager
            // 
            this.selectManager.FormattingEnabled = true;
            this.selectManager.Location = new System.Drawing.Point(57, 88);
            this.selectManager.Name = "selectManager";
            this.selectManager.Size = new System.Drawing.Size(250, 28);
            this.selectManager.TabIndex = 3;
            // 
            // selectManagerForNotAssigned
            // 
            this.selectManagerForNotAssigned.FormattingEnabled = true;
            this.selectManagerForNotAssigned.Location = new System.Drawing.Point(57, 440);
            this.selectManagerForNotAssigned.Name = "selectManagerForNotAssigned";
            this.selectManagerForNotAssigned.Size = new System.Drawing.Size(250, 28);
            this.selectManagerForNotAssigned.TabIndex = 6;
            // 
            // notAssignedManagerDataGridView
            // 
            this.notAssignedManagerDataGridView.AllowUserToAddRows = false;
            this.notAssignedManagerDataGridView.AllowUserToDeleteRows = false;
            this.notAssignedManagerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notAssignedManagerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.notAssignedManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notAssignedManagerDataGridView.Location = new System.Drawing.Point(57, 477);
            this.notAssignedManagerDataGridView.MultiSelect = false;
            this.notAssignedManagerDataGridView.Name = "notAssignedManagerDataGridView";
            this.notAssignedManagerDataGridView.ReadOnly = true;
            this.notAssignedManagerDataGridView.RowHeadersWidth = 51;
            this.notAssignedManagerDataGridView.Size = new System.Drawing.Size(1131, 294);
            this.notAssignedManagerDataGridView.TabIndex = 5;
            // 
            // notAssignedManagers
            // 
            this.notAssignedManagers.AutoSize = true;
            this.notAssignedManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notAssignedManagers.Location = new System.Drawing.Point(53, 406);
            this.notAssignedManagers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notAssignedManagers.Name = "notAssignedManagers";
            this.notAssignedManagers.Size = new System.Drawing.Size(176, 24);
            this.notAssignedManagers.TabIndex = 4;
            this.notAssignedManagers.Text = "Not Assigned Users";
            // 
            // assignManagerBtn
            // 
            this.assignManagerBtn.Location = new System.Drawing.Point(333, 429);
            this.assignManagerBtn.Name = "assignManagerBtn";
            this.assignManagerBtn.Size = new System.Drawing.Size(106, 42);
            this.assignManagerBtn.TabIndex = 7;
            this.assignManagerBtn.Text = "Assign";
            this.assignManagerBtn.UseVisualStyleBackColor = true;
            this.assignManagerBtn.Click += new System.EventHandler(this.assignManagerBtn_Click);
            // 
            // updateAssignedBtn
            // 
            this.updateAssignedBtn.Location = new System.Drawing.Point(333, 74);
            this.updateAssignedBtn.Name = "updateAssignedBtn";
            this.updateAssignedBtn.Size = new System.Drawing.Size(106, 42);
            this.updateAssignedBtn.TabIndex = 8;
            this.updateAssignedBtn.Text = "Update";
            this.updateAssignedBtn.UseVisualStyleBackColor = true;
            this.updateAssignedBtn.Click += new System.EventHandler(this.updateAssignedBtn_Click);
            // 
            // deleteAssignedBtn
            // 
            this.deleteAssignedBtn.Location = new System.Drawing.Point(447, 74);
            this.deleteAssignedBtn.Name = "deleteAssignedBtn";
            this.deleteAssignedBtn.Size = new System.Drawing.Size(106, 42);
            this.deleteAssignedBtn.TabIndex = 9;
            this.deleteAssignedBtn.Text = "Delete";
            this.deleteAssignedBtn.UseVisualStyleBackColor = true;
            this.deleteAssignedBtn.Click += new System.EventHandler(this.deleteAssignedBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(1082, 74);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(106, 42);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.managerUser);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 49);
            this.panel1.TabIndex = 11;
            // 
            // ManagerUserAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 783);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.deleteAssignedBtn);
            this.Controls.Add(this.updateAssignedBtn);
            this.Controls.Add(this.assignManagerBtn);
            this.Controls.Add(this.selectManagerForNotAssigned);
            this.Controls.Add(this.notAssignedManagerDataGridView);
            this.Controls.Add(this.notAssignedManagers);
            this.Controls.Add(this.selectManager);
            this.Controls.Add(this.assignedManagerDataGridView);
            this.Controls.Add(this.userAssigned);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerUserAssignment";
            this.Text = "Manager User Assignment";
            this.Load += new System.EventHandler(this.userAssignedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignedManagerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedManagerDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button assignManagerBtn;
        private System.Windows.Forms.Button updateAssignedBtn;
        private System.Windows.Forms.Button deleteAssignedBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Panel panel1;
    }
}