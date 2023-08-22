namespace File_Acess_Management
{
    partial class Software
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
            this.softwareListLbl = new System.Windows.Forms.Label();
            this.softwareListDataGridView = new System.Windows.Forms.DataGridView();
            this.softwareIdlabel = new System.Windows.Forms.Label();
            this.softwareIdText = new System.Windows.Forms.TextBox();
            this.softwareNametext = new System.Windows.Forms.TextBox();
            this.softwareNameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.softwareListDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // softwareListLbl
            // 
            this.softwareListLbl.AutoSize = true;
            this.softwareListLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.softwareListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softwareListLbl.Location = new System.Drawing.Point(456, 9);
            this.softwareListLbl.Name = "softwareListLbl";
            this.softwareListLbl.Size = new System.Drawing.Size(143, 24);
            this.softwareListLbl.TabIndex = 0;
            this.softwareListLbl.Text = "List of Softwares";
            // 
            // softwareListDataGridView
            // 
            this.softwareListDataGridView.AllowUserToAddRows = false;
            this.softwareListDataGridView.AllowUserToDeleteRows = false;
            this.softwareListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.softwareListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.softwareListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.softwareListDataGridView.Location = new System.Drawing.Point(571, 112);
            this.softwareListDataGridView.MultiSelect = false;
            this.softwareListDataGridView.Name = "softwareListDataGridView";
            this.softwareListDataGridView.ReadOnly = true;
            this.softwareListDataGridView.Size = new System.Drawing.Size(617, 568);
            this.softwareListDataGridView.TabIndex = 1;
            // 
            // softwareIdlabel
            // 
            this.softwareIdlabel.AutoSize = true;
            this.softwareIdlabel.Location = new System.Drawing.Point(85, 169);
            this.softwareIdlabel.Name = "softwareIdlabel";
            this.softwareIdlabel.Size = new System.Drawing.Size(91, 20);
            this.softwareIdlabel.TabIndex = 2;
            this.softwareIdlabel.Text = "Software Id";
            // 
            // softwareIdText
            // 
            this.softwareIdText.Enabled = false;
            this.softwareIdText.Location = new System.Drawing.Point(231, 166);
            this.softwareIdText.Name = "softwareIdText";
            this.softwareIdText.Size = new System.Drawing.Size(279, 26);
            this.softwareIdText.TabIndex = 3;
            // 
            // softwareNametext
            // 
            this.softwareNametext.Location = new System.Drawing.Point(231, 228);
            this.softwareNametext.Name = "softwareNametext";
            this.softwareNametext.Size = new System.Drawing.Size(279, 26);
            this.softwareNametext.TabIndex = 5;
            // 
            // softwareNameLabel
            // 
            this.softwareNameLabel.AutoSize = true;
            this.softwareNameLabel.Location = new System.Drawing.Point(85, 231);
            this.softwareNameLabel.Name = "softwareNameLabel";
            this.softwareNameLabel.Size = new System.Drawing.Size(119, 20);
            this.softwareNameLabel.TabIndex = 4;
            this.softwareNameLabel.Text = "Software Name";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(89, 317);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 35);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(299, 317);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 35);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(194, 317);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(99, 35);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(404, 317);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(99, 35);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.softwareListLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 49);
            this.panel2.TabIndex = 27;
            // 
            // Software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.softwareNametext);
            this.Controls.Add(this.softwareNameLabel);
            this.Controls.Add(this.softwareIdText);
            this.Controls.Add(this.softwareIdlabel);
            this.Controls.Add(this.softwareListDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Software";
            this.Text = "Software";
            this.Load += new System.EventHandler(this.Software_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softwareListDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label softwareListLbl;
        private System.Windows.Forms.DataGridView softwareListDataGridView;
        private System.Windows.Forms.Label softwareIdlabel;
        private System.Windows.Forms.TextBox softwareIdText;
        private System.Windows.Forms.TextBox softwareNametext;
        private System.Windows.Forms.Label softwareNameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel panel2;
    }
}