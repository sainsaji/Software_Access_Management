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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManagerUserAssignmentUserControl));
            this.selectManagerForNotAssigned = new System.Windows.Forms.ComboBox();
            this.notAssignedManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.notAssignedManagers = new System.Windows.Forms.Label();
            this.selectManager = new System.Windows.Forms.ComboBox();
            this.assignedManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.userAssigned = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rstBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.assignBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedManagerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedManagerDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectManagerForNotAssigned
            // 
            this.selectManagerForNotAssigned.FormattingEnabled = true;
            this.selectManagerForNotAssigned.Location = new System.Drawing.Point(101, 334);
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
            this.notAssignedManagerDataGridView.Location = new System.Drawing.Point(8, 366);
            this.notAssignedManagerDataGridView.MultiSelect = false;
            this.notAssignedManagerDataGridView.Name = "notAssignedManagerDataGridView";
            this.notAssignedManagerDataGridView.ReadOnly = true;
            this.notAssignedManagerDataGridView.RowHeadersWidth = 51;
            this.notAssignedManagerDataGridView.Size = new System.Drawing.Size(692, 150);
            this.notAssignedManagerDataGridView.TabIndex = 15;
            this.notAssignedManagerDataGridView.SelectionChanged += new System.EventHandler(this.notAssignedManagerDataGridView_SelectionChanged);
            // 
            // notAssignedManagers
            // 
            this.notAssignedManagers.AutoSize = true;
            this.notAssignedManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notAssignedManagers.Location = new System.Drawing.Point(4, 255);
            this.notAssignedManagers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notAssignedManagers.Name = "notAssignedManagers";
            this.notAssignedManagers.Size = new System.Drawing.Size(176, 24);
            this.notAssignedManagers.TabIndex = 14;
            this.notAssignedManagers.Text = "Not Assigned Users";
            // 
            // selectManager
            // 
            this.selectManager.FormattingEnabled = true;
            this.selectManager.Location = new System.Drawing.Point(101, 78);
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
            this.assignedManagerDataGridView.Location = new System.Drawing.Point(8, 109);
            this.assignedManagerDataGridView.MultiSelect = false;
            this.assignedManagerDataGridView.Name = "assignedManagerDataGridView";
            this.assignedManagerDataGridView.ReadOnly = true;
            this.assignedManagerDataGridView.RowHeadersWidth = 51;
            this.assignedManagerDataGridView.Size = new System.Drawing.Size(692, 140);
            this.assignedManagerDataGridView.TabIndex = 12;
            this.assignedManagerDataGridView.SelectionChanged += new System.EventHandler(this.assignedManagerDataGridView_SelectionChanged);
            // 
            // userAssigned
            // 
            this.userAssigned.AutoSize = true;
            this.userAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAssigned.Location = new System.Drawing.Point(4, 3);
            this.userAssigned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userAssigned.Name = "userAssigned";
            this.userAssigned.Size = new System.Drawing.Size(142, 24);
            this.userAssigned.TabIndex = 11;
            this.userAssigned.Text = "Assigned Users";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rstBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Location = new System.Drawing.Point(9, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 41);
            this.panel1.TabIndex = 21;
            // 
            // rstBtn
            // 
            this.rstBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.rstBtn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.rstBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.rstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rstBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rstBtn.Image = ((System.Drawing.Image)(resources.GetObject("rstBtn.Image")));
            this.rstBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rstBtn.Location = new System.Drawing.Point(266, 0);
            this.rstBtn.Name = "rstBtn";
            this.rstBtn.Size = new System.Drawing.Size(133, 41);
            this.rstBtn.TabIndex = 8;
            this.rstBtn.Text = "Reset";
            this.rstBtn.UseVisualStyleBackColor = false;
            this.rstBtn.Click += new System.EventHandler(this.rstBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Salmon;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(133, 0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 41);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.Image")));
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(0, 0);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(133, 41);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.assignBtn);
            this.panel2.Location = new System.Drawing.Point(9, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 41);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // assignBtn
            // 
            this.assignBtn.BackColor = System.Drawing.Color.LightGreen;
            this.assignBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assignBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.assignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.assignBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignBtn.Image = ((System.Drawing.Image)(resources.GetObject("assignBtn.Image")));
            this.assignBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assignBtn.Location = new System.Drawing.Point(0, 0);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(133, 41);
            this.assignBtn.TabIndex = 6;
            this.assignBtn.Text = "Assign";
            this.assignBtn.UseVisualStyleBackColor = false;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Select Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Select Manager";
            // 
            // AdminManagerUserAssignmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectManagerForNotAssigned);
            this.Controls.Add(this.notAssignedManagerDataGridView);
            this.Controls.Add(this.notAssignedManagers);
            this.Controls.Add(this.selectManager);
            this.Controls.Add(this.assignedManagerDataGridView);
            this.Controls.Add(this.userAssigned);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminManagerUserAssignmentUserControl";
            this.Size = new System.Drawing.Size(1357, 780);
            this.Load += new System.EventHandler(this.AdminManagerUserAssignmentUserControl_Load);
            this.VisibleChanged += new System.EventHandler(this.AdminManagerUserAssignmentUserControl_VisibleChanged);
            this.Enter += new System.EventHandler(this.AdminManagerUserAssignmentUserControl_Enter);
            this.Leave += new System.EventHandler(this.AdminManagerUserAssignmentUserControl_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedManagerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedManagerDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox selectManagerForNotAssigned;
        private System.Windows.Forms.DataGridView notAssignedManagerDataGridView;
        private System.Windows.Forms.Label notAssignedManagers;
        private System.Windows.Forms.ComboBox selectManager;
        private System.Windows.Forms.DataGridView assignedManagerDataGridView;
        private System.Windows.Forms.Label userAssigned;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rstBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
