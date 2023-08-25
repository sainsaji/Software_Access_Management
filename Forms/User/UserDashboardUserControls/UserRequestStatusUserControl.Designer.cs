namespace File_Acess_Management.Forms.User.UserDashboardUserControls
{
    partial class UserRequestStatusUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRequestStatusUserControl));
            this.requestStatusPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.withDrawBtn = new System.Windows.Forms.Button();
            this.editRequestBtn = new System.Windows.Forms.Button();
            this.showCredentialsBtn = new System.Windows.Forms.Button();
            this.requestStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestStatusPanel
            // 
            this.requestStatusPanel.BackColor = System.Drawing.Color.White;
            this.requestStatusPanel.Controls.Add(this.panel1);
            this.requestStatusPanel.Controls.Add(this.dataGridView1);
            this.requestStatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestStatusPanel.Location = new System.Drawing.Point(0, 0);
            this.requestStatusPanel.Name = "requestStatusPanel";
            this.requestStatusPanel.Size = new System.Drawing.Size(846, 571);
            this.requestStatusPanel.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 54);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 517);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.showCredentialsBtn);
            this.panel1.Controls.Add(this.editRequestBtn);
            this.panel1.Controls.Add(this.withDrawBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(846, 48);
            this.panel1.TabIndex = 2;
            // 
            // withDrawBtn
            // 
            this.withDrawBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.withDrawBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.withDrawBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.withDrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withDrawBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withDrawBtn.Image = ((System.Drawing.Image)(resources.GetObject("withDrawBtn.Image")));
            this.withDrawBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.withDrawBtn.Location = new System.Drawing.Point(5, 5);
            this.withDrawBtn.Name = "withDrawBtn";
            this.withDrawBtn.Size = new System.Drawing.Size(133, 38);
            this.withDrawBtn.TabIndex = 0;
            this.withDrawBtn.Text = "Withdraw Request";
            this.withDrawBtn.UseVisualStyleBackColor = false;
            // 
            // editRequestBtn
            // 
            this.editRequestBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.editRequestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editRequestBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.editRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editRequestBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRequestBtn.Image = ((System.Drawing.Image)(resources.GetObject("editRequestBtn.Image")));
            this.editRequestBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editRequestBtn.Location = new System.Drawing.Point(138, 5);
            this.editRequestBtn.Name = "editRequestBtn";
            this.editRequestBtn.Size = new System.Drawing.Size(133, 38);
            this.editRequestBtn.TabIndex = 1;
            this.editRequestBtn.Text = "Edit Request";
            this.editRequestBtn.UseVisualStyleBackColor = false;
            // 
            // showCredentialsBtn
            // 
            this.showCredentialsBtn.BackColor = System.Drawing.Color.SlateGray;
            this.showCredentialsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showCredentialsBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.showCredentialsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showCredentialsBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCredentialsBtn.Image = ((System.Drawing.Image)(resources.GetObject("showCredentialsBtn.Image")));
            this.showCredentialsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showCredentialsBtn.Location = new System.Drawing.Point(271, 5);
            this.showCredentialsBtn.Name = "showCredentialsBtn";
            this.showCredentialsBtn.Size = new System.Drawing.Size(133, 38);
            this.showCredentialsBtn.TabIndex = 2;
            this.showCredentialsBtn.Text = "Show Credentials";
            this.showCredentialsBtn.UseVisualStyleBackColor = false;
            // 
            // UserRequestStatusUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.requestStatusPanel);
            this.Name = "UserRequestStatusUserControl";
            this.Size = new System.Drawing.Size(846, 571);
            this.Load += new System.EventHandler(this.UserRequestStatusUserControl_Load);
            this.requestStatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel requestStatusPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button withDrawBtn;
        private System.Windows.Forms.Button showCredentialsBtn;
        private System.Windows.Forms.Button editRequestBtn;
    }
}
