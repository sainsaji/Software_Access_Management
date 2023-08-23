namespace File_Acess_Management.Forms.Admin.AdminUserControls
{
    partial class AdminManagerUserAssignmentUserControl
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
            this.resetBtn = new System.Windows.Forms.Button();
            this.deleteAssignedBtn = new System.Windows.Forms.Button();
            this.updateAssignedBtn = new System.Windows.Forms.Button();
            this.assignManagerBtn = new System.Windows.Forms.Button();
            this.selectManagerForNotAssigned = new System.Windows.Forms.ComboBox();
            this.notAssignedManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.notAssignedManagers = new System.Windows.Forms.Label();
            this.selectManager = new System.Windows.Forms.ComboBox();
            this.assignedManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.userAssigned = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedManagerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedManagerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(510, 20);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(106, 42);
            this.resetBtn.TabIndex = 20;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // deleteAssignedBtn
            // 
            this.deleteAssignedBtn.Location = new System.Drawing.Point(398, 20);
            this.deleteAssignedBtn.Name = "deleteAssignedBtn";
            this.deleteAssignedBtn.Size = new System.Drawing.Size(106, 42);
            this.deleteAssignedBtn.TabIndex = 19;
            this.deleteAssignedBtn.Text = "Delete";
            this.deleteAssignedBtn.UseVisualStyleBackColor = true;
            this.deleteAssignedBtn.Click += new System.EventHandler(this.deleteAssignedBtn_Click);
            // 
            // updateAssignedBtn
            // 
            this.updateAssignedBtn.Location = new System.Drawing.Point(284, 20);
            this.updateAssignedBtn.Name = "updateAssignedBtn";
            this.updateAssignedBtn.Size = new System.Drawing.Size(106, 42);
            this.updateAssignedBtn.TabIndex = 18;
            this.updateAssignedBtn.Text = "Update";
            this.updateAssignedBtn.UseVisualStyleBackColor = true;
            this.updateAssignedBtn.Click += new System.EventHandler(this.updateAssignedBtn_Click);
            // 
            // assignManagerBtn
            // 
            this.assignManagerBtn.Location = new System.Drawing.Point(284, 270);
            this.assignManagerBtn.Name = "assignManagerBtn";
            this.assignManagerBtn.Size = new System.Drawing.Size(106, 42);
            this.assignManagerBtn.TabIndex = 17;
            this.assignManagerBtn.Text = "Assign";
            this.assignManagerBtn.UseVisualStyleBackColor = true;
            this.assignManagerBtn.Click += new System.EventHandler(this.assignManagerBtn_Click);
            // 
            // selectManagerForNotAssigned
            // 
            this.selectManagerForNotAssigned.FormattingEnabled = true;
            this.selectManagerForNotAssigned.Location = new System.Drawing.Point(8, 281);
            this.selectManagerForNotAssigned.Name = "selectManagerForNotAssigned";
            this.selectManagerForNotAssigned.Size = new System.Drawing.Size(250, 21);
            this.selectManagerForNotAssigned.TabIndex = 16;
            // 
            // notAssignedManagerDataGridView
            // 
            this.notAssignedManagerDataGridView.AllowUserToAddRows = false;
            this.notAssignedManagerDataGridView.AllowUserToDeleteRows = false;
            this.notAssignedManagerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notAssignedManagerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.notAssignedManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notAssignedManagerDataGridView.Location = new System.Drawing.Point(8, 318);
            this.notAssignedManagerDataGridView.MultiSelect = false;
            this.notAssignedManagerDataGridView.Name = "notAssignedManagerDataGridView";
            this.notAssignedManagerDataGridView.ReadOnly = true;
            this.notAssignedManagerDataGridView.RowHeadersWidth = 51;
            this.notAssignedManagerDataGridView.Size = new System.Drawing.Size(692, 183);
            this.notAssignedManagerDataGridView.TabIndex = 15;
            this.notAssignedManagerDataGridView.SelectionChanged += new System.EventHandler(this.notAssignedManagerDataGridView_SelectionChanged);
            // 
            // notAssignedManagers
            // 
            this.notAssignedManagers.AutoSize = true;
            this.notAssignedManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notAssignedManagers.Location = new System.Drawing.Point(4, 254);
            this.notAssignedManagers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notAssignedManagers.Name = "notAssignedManagers";
            this.notAssignedManagers.Size = new System.Drawing.Size(176, 24);
            this.notAssignedManagers.TabIndex = 14;
            this.notAssignedManagers.Text = "Not Assigned Users";
            // 
            // selectManager
            // 
            this.selectManager.FormattingEnabled = true;
            this.selectManager.Location = new System.Drawing.Point(8, 34);
            this.selectManager.Name = "selectManager";
            this.selectManager.Size = new System.Drawing.Size(250, 21);
            this.selectManager.TabIndex = 13;
            // 
            // assignedManagerDataGridView
            // 
            this.assignedManagerDataGridView.AllowUserToAddRows = false;
            this.assignedManagerDataGridView.AllowUserToDeleteRows = false;
            this.assignedManagerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.assignedManagerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.assignedManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignedManagerDataGridView.Location = new System.Drawing.Point(8, 68);
            this.assignedManagerDataGridView.MultiSelect = false;
            this.assignedManagerDataGridView.Name = "assignedManagerDataGridView";
            this.assignedManagerDataGridView.ReadOnly = true;
            this.assignedManagerDataGridView.RowHeadersWidth = 51;
            this.assignedManagerDataGridView.Size = new System.Drawing.Size(692, 168);
            this.assignedManagerDataGridView.TabIndex = 12;
            this.assignedManagerDataGridView.SelectionChanged += new System.EventHandler(this.assignedManagerDataGridView_SelectionChanged);
            // 
            // userAssigned
            // 
            this.userAssigned.AutoSize = true;
            this.userAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAssigned.Location = new System.Drawing.Point(4, 7);
            this.userAssigned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userAssigned.Name = "userAssigned";
            this.userAssigned.Size = new System.Drawing.Size(142, 24);
            this.userAssigned.TabIndex = 11;
            this.userAssigned.Text = "Assigned Users";
            // 
            // AdminManagerUserAssignmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminManagerUserAssignmentUserControl";
            this.Size = new System.Drawing.Size(1357, 780);
            this.Load += new System.EventHandler(this.AdminManagerUserAssignmentUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedManagerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedManagerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button deleteAssignedBtn;
        private System.Windows.Forms.Button updateAssignedBtn;
        private System.Windows.Forms.Button assignManagerBtn;
        private System.Windows.Forms.ComboBox selectManagerForNotAssigned;
        private System.Windows.Forms.DataGridView notAssignedManagerDataGridView;
        private System.Windows.Forms.Label notAssignedManagers;
        private System.Windows.Forms.ComboBox selectManager;
        private System.Windows.Forms.DataGridView assignedManagerDataGridView;
        private System.Windows.Forms.Label userAssigned;
    }
}
