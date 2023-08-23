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
            this.resetButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.softwareNametext = new System.Windows.Forms.TextBox();
            this.softwareNameLabel = new System.Windows.Forms.Label();
            this.softwareIdText = new System.Windows.Forms.TextBox();
            this.softwareIdlabel = new System.Windows.Forms.Label();
            this.softwareListDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.softwareListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(393, 142);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(63, 35);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(147, 142);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(63, 35);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(269, 142);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(63, 35);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(16, 142);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 35);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // softwareNametext
            // 
            this.softwareNametext.Location = new System.Drawing.Point(193, 85);
            this.softwareNametext.Name = "softwareNametext";
            this.softwareNametext.Size = new System.Drawing.Size(243, 20);
            this.softwareNametext.TabIndex = 14;
            // 
            // softwareNameLabel
            // 
            this.softwareNameLabel.AutoSize = true;
            this.softwareNameLabel.Location = new System.Drawing.Point(47, 88);
            this.softwareNameLabel.Name = "softwareNameLabel";
            this.softwareNameLabel.Size = new System.Drawing.Size(80, 13);
            this.softwareNameLabel.TabIndex = 13;
            this.softwareNameLabel.Text = "Software Name";
            // 
            // softwareIdText
            // 
            this.softwareIdText.Enabled = false;
            this.softwareIdText.Location = new System.Drawing.Point(193, 23);
            this.softwareIdText.Name = "softwareIdText";
            this.softwareIdText.Size = new System.Drawing.Size(243, 20);
            this.softwareIdText.TabIndex = 12;
            // 
            // softwareIdlabel
            // 
            this.softwareIdlabel.AutoSize = true;
            this.softwareIdlabel.Location = new System.Drawing.Point(47, 26);
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
            this.softwareListDataGridView.Location = new System.Drawing.Point(14, 183);
            this.softwareListDataGridView.MultiSelect = false;
            this.softwareListDataGridView.Name = "softwareListDataGridView";
            this.softwareListDataGridView.ReadOnly = true;
            this.softwareListDataGridView.Size = new System.Drawing.Size(442, 319);
            this.softwareListDataGridView.TabIndex = 10;
            this.softwareListDataGridView.SelectionChanged += new System.EventHandler(this.softwareListDataGridView_SelectionChanged);
            // 
            // AdminSoftwareManagementUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.softwareNametext);
            this.Controls.Add(this.softwareNameLabel);
            this.Controls.Add(this.softwareIdText);
            this.Controls.Add(this.softwareIdlabel);
            this.Controls.Add(this.softwareListDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminSoftwareManagementUserControl";
            this.Size = new System.Drawing.Size(1357, 780);
            this.Load += new System.EventHandler(this.AdminSoftwareManagementUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softwareListDataGridView)).EndInit();
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
    }
}
