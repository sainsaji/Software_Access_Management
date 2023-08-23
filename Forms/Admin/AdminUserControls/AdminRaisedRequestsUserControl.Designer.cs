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
            this.adminRequestsDataGridView.AllowUserToAddRows = false;
            this.adminRequestsDataGridView.AllowUserToDeleteRows = false;
            this.adminRequestsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminRequestsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.adminRequestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminRequestsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminRequestsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.adminRequestsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminRequestsDataGridView.MultiSelect = false;
            this.adminRequestsDataGridView.Name = "adminRequestsDataGridView";
            this.adminRequestsDataGridView.ReadOnly = true;
            this.adminRequestsDataGridView.RowHeadersWidth = 51;
            this.adminRequestsDataGridView.RowTemplate.Height = 24;
            this.adminRequestsDataGridView.Size = new System.Drawing.Size(1018, 634);
            this.adminRequestsDataGridView.TabIndex = 3;
            this.adminRequestsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminRequestsDataGridView_CellClick);
            // 
            // AdminRaisedRequestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminRequestsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminRaisedRequestsUserControl";
            this.Size = new System.Drawing.Size(1018, 634);
            ((System.ComponentModel.ISupportInitialize)(this.adminRequestsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adminRequestsDataGridView;
    }
}
