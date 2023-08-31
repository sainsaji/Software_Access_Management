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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRaisedRequestsUserControl));
            this.adminRequestsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.Button();
            this.denyBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminRequestsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminRequestsDataGridView
            // 
            this.adminRequestsDataGridView.AllowUserToAddRows = false;
            this.adminRequestsDataGridView.AllowUserToDeleteRows = false;
            this.adminRequestsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminRequestsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.adminRequestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminRequestsDataGridView.Location = new System.Drawing.Point(0, 62);
            this.adminRequestsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.adminRequestsDataGridView.MultiSelect = false;
            this.adminRequestsDataGridView.Name = "adminRequestsDataGridView";
            this.adminRequestsDataGridView.ReadOnly = true;
            this.adminRequestsDataGridView.RowHeadersWidth = 51;
            this.adminRequestsDataGridView.RowTemplate.Height = 24;
            this.adminRequestsDataGridView.Size = new System.Drawing.Size(1018, 572);
            this.adminRequestsDataGridView.TabIndex = 3;
            this.adminRequestsDataGridView.SelectionChanged += new System.EventHandler(this.adminRequestsDataGridView_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.denyBtn);
            this.panel1.Controls.Add(this.acceptBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 41);
            this.panel1.TabIndex = 5;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetBtn.Image")));
            this.resetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetBtn.Location = new System.Drawing.Point(266, 0);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(133, 41);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // denyBtn
            // 
            this.denyBtn.BackColor = System.Drawing.Color.Salmon;
            this.denyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.denyBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.denyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.denyBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denyBtn.Image = ((System.Drawing.Image)(resources.GetObject("denyBtn.Image")));
            this.denyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.denyBtn.Location = new System.Drawing.Point(133, 0);
            this.denyBtn.Name = "denyBtn";
            this.denyBtn.Size = new System.Drawing.Size(133, 41);
            this.denyBtn.TabIndex = 7;
            this.denyBtn.Text = "Deny";
            this.denyBtn.UseVisualStyleBackColor = false;
            this.denyBtn.Click += new System.EventHandler(this.denyBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.LightGreen;
            this.acceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acceptBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBtn.Image = ((System.Drawing.Image)(resources.GetObject("acceptBtn.Image")));
            this.acceptBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acceptBtn.Location = new System.Drawing.Point(0, 0);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(133, 41);
            this.acceptBtn.TabIndex = 6;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminRaisedRequestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminRequestsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminRaisedRequestsUserControl";
            this.Size = new System.Drawing.Size(1018, 634);
            ((System.ComponentModel.ISupportInitialize)(this.adminRequestsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adminRequestsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button denyBtn;
        private System.Windows.Forms.Button acceptBtn;
    }
}
