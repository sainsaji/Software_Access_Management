namespace File_Acess_Management.Forms.Admin.ManagerUserControls
{
    partial class AdminRaisedRequestsUserControl
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
            this.adminRequestsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.adminRequestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adminRequestsDataGridView
            // 
            this.adminRequestsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.adminRequestsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.adminRequestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminRequestsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminRequestsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.adminRequestsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminRequestsDataGridView.Name = "adminRequestsDataGridView";
            this.adminRequestsDataGridView.RowHeadersWidth = 51;
            this.adminRequestsDataGridView.RowTemplate.Height = 24;
            this.adminRequestsDataGridView.Size = new System.Drawing.Size(1357, 780);
            this.adminRequestsDataGridView.TabIndex = 3;
            // 
            // AdminRaisedRequestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminRequestsDataGridView);
            this.Name = "AdminRaisedRequestsUserControl";
            this.Size = new System.Drawing.Size(1357, 780);
            ((System.ComponentModel.ISupportInitialize)(this.adminRequestsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adminRequestsDataGridView;
    }
}
