namespace File_Acess_Management.Forms.Admin.AdminUserControls
{
    partial class AdminSoftwareManagementUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSoftwareManagementUserControl));
            this.resetButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.softwareNametext = new System.Windows.Forms.TextBox();
            this.softwareNameLabel = new System.Windows.Forms.Label();
            this.softwareIdText = new System.Windows.Forms.TextBox();
            this.softwareIdlabel = new System.Windows.Forms.Label();
            this.softwareListDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rstBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.softwareListDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(393, 167);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(63, 35);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(147, 167);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(63, 35);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(269, 167);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(63, 35);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(16, 167);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 35);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // softwareNametext
            // 
            this.softwareNametext.Location = new System.Drawing.Point(193, 99);
            this.softwareNametext.Name = "softwareNametext";
            this.softwareNametext.Size = new System.Drawing.Size(243, 20);
            this.softwareNametext.TabIndex = 14;
            // 
            // softwareNameLabel
            // 
            this.softwareNameLabel.AutoSize = true;
            this.softwareNameLabel.Location = new System.Drawing.Point(47, 102);
            this.softwareNameLabel.Name = "softwareNameLabel";
            this.softwareNameLabel.Size = new System.Drawing.Size(80, 13);
            this.softwareNameLabel.TabIndex = 13;
            this.softwareNameLabel.Text = "Software Name";
            // 
            // softwareIdText
            // 
            this.softwareIdText.Enabled = false;
            this.softwareIdText.Location = new System.Drawing.Point(193, 48);
            this.softwareIdText.Name = "softwareIdText";
            this.softwareIdText.Size = new System.Drawing.Size(243, 20);
            this.softwareIdText.TabIndex = 12;
            // 
            // softwareIdlabel
            // 
            this.softwareIdlabel.AutoSize = true;
            this.softwareIdlabel.Location = new System.Drawing.Point(47, 51);
            this.softwareIdlabel.Name = "softwareIdlabel";
            this.softwareIdlabel.Size = new System.Drawing.Size(61, 13);
            this.softwareIdlabel.TabIndex = 11;
            this.softwareIdlabel.Text = "Software Id";
            // 
            // softwareListDataGridView
            // 
            this.softwareListDataGridView.AllowUserToAddRows = false;
            this.softwareListDataGridView.AllowUserToDeleteRows = false;
            this.softwareListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.softwareListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.softwareListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.softwareListDataGridView.Location = new System.Drawing.Point(14, 208);
            this.softwareListDataGridView.MultiSelect = false;
            this.softwareListDataGridView.Name = "softwareListDataGridView";
            this.softwareListDataGridView.ReadOnly = true;
            this.softwareListDataGridView.Size = new System.Drawing.Size(442, 319);
            this.softwareListDataGridView.TabIndex = 10;
            this.softwareListDataGridView.SelectionChanged += new System.EventHandler(this.softwareListDataGridView_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rstBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 41);
            this.panel1.TabIndex = 22;
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
            this.rstBtn.Location = new System.Drawing.Point(399, 0);
            this.rstBtn.Name = "rstBtn";
            this.rstBtn.Size = new System.Drawing.Size(133, 41);
            this.rstBtn.TabIndex = 10;
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
            this.deleteBtn.Location = new System.Drawing.Point(266, 0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 41);
            this.deleteBtn.TabIndex = 9;
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
            this.updateBtn.Location = new System.Drawing.Point(133, 0);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(133, 41);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(0, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(133, 41);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminSoftwareManagementUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.softwareNametext);
            this.Controls.Add(this.softwareNameLabel);
            this.Controls.Add(this.softwareIdText);
            this.Controls.Add(this.softwareIdlabel);
            this.Controls.Add(this.softwareListDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminSoftwareManagementUserControl";
            this.Size = new System.Drawing.Size(1357, 780);
            this.Load += new System.EventHandler(this.AdminSoftwareManagementUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softwareListDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox softwareNametext;
        private System.Windows.Forms.Label softwareNameLabel;
        private System.Windows.Forms.TextBox softwareIdText;
        private System.Windows.Forms.Label softwareIdlabel;
        private System.Windows.Forms.DataGridView softwareListDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button rstBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}
