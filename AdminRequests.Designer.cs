namespace File_Acess_Management
{
    partial class AdminRequests
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabTitleLbl = new System.Windows.Forms.Label();
            this.adminRequestsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminRequestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.tabTitleLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1199, 43);
            this.panel3.TabIndex = 1;
            // 
            // tabTitleLbl
            // 
            this.tabTitleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTitleLbl.AutoSize = true;
            this.tabTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTitleLbl.Location = new System.Drawing.Point(517, 9);
            this.tabTitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tabTitleLbl.Name = "tabTitleLbl";
            this.tabTitleLbl.Size = new System.Drawing.Size(161, 26);
            this.tabTitleLbl.TabIndex = 0;
            this.tabTitleLbl.Text = "Tab Title Here";
            // 
            // adminRequestsDataGridView
            // 
            this.adminRequestsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.adminRequestsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.adminRequestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminRequestsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminRequestsDataGridView.Location = new System.Drawing.Point(0, 43);
            this.adminRequestsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminRequestsDataGridView.Name = "adminRequestsDataGridView";
            this.adminRequestsDataGridView.RowHeadersWidth = 51;
            this.adminRequestsDataGridView.RowTemplate.Height = 24;
            this.adminRequestsDataGridView.Size = new System.Drawing.Size(1199, 647);
            this.adminRequestsDataGridView.TabIndex = 2;
            this.adminRequestsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminRequestsDataGridView_CellClick);
            // 
            // AdminRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 690);
            this.Controls.Add(this.adminRequestsDataGridView);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminRequests";
            this.Text = "AdminRequests";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminRequestsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label tabTitleLbl;
        private System.Windows.Forms.DataGridView adminRequestsDataGridView;
    }
}