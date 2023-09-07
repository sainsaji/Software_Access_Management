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
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.denyBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.remarksPannel = new System.Windows.Forms.Panel();
            this.adminRemarkTextBox = new System.Windows.Forms.MaskedTextBox();
            this.adminCurrentRemarkTxt = new System.Windows.Forms.Label();
            this.ManagerRemarkTxt = new System.Windows.Forms.Label();
            this.managerRemarkLbl = new System.Windows.Forms.Label();
            this.userRemarkTxt = new System.Windows.Forms.Label();
            this.userRemarkLbl = new System.Windows.Forms.Label();
            this.adminCurrentRemarkLbl = new System.Windows.Forms.Label();
            this.adminRemarklbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adminRequestsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.remarksPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminRequestsDataGridView
            // 
            this.adminRequestsDataGridView.AllowUserToAddRows = false;
            this.adminRequestsDataGridView.AllowUserToDeleteRows = false;
            this.adminRequestsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminRequestsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.adminRequestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminRequestsDataGridView.Location = new System.Drawing.Point(22, 46);
            this.adminRequestsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.adminRequestsDataGridView.MultiSelect = false;
            this.adminRequestsDataGridView.Name = "adminRequestsDataGridView";
            this.adminRequestsDataGridView.RowHeadersWidth = 51;
            this.adminRequestsDataGridView.RowTemplate.Height = 24;
            this.adminRequestsDataGridView.Size = new System.Drawing.Size(1051, 308);
            this.adminRequestsDataGridView.TabIndex = 3;
            this.adminRequestsDataGridView.SelectionChanged += new System.EventHandler(this.adminRequestsDataGridView_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.denyBtn);
            this.panel1.Controls.Add(this.acceptBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 41);
            this.panel1.TabIndex = 5;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Image = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.Image")));
            this.UpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtn.Location = new System.Drawing.Point(399, 0);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(133, 41);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.denyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.acceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // remarksPannel
            // 
            this.remarksPannel.Controls.Add(this.adminRemarkTextBox);
            this.remarksPannel.Controls.Add(this.adminCurrentRemarkTxt);
            this.remarksPannel.Controls.Add(this.ManagerRemarkTxt);
            this.remarksPannel.Controls.Add(this.managerRemarkLbl);
            this.remarksPannel.Controls.Add(this.userRemarkTxt);
            this.remarksPannel.Controls.Add(this.userRemarkLbl);
            this.remarksPannel.Controls.Add(this.adminCurrentRemarkLbl);
            this.remarksPannel.Controls.Add(this.adminRemarklbl);
            this.remarksPannel.Location = new System.Drawing.Point(32, 409);
            this.remarksPannel.Name = "remarksPannel";
            this.remarksPannel.Size = new System.Drawing.Size(1041, 282);
            this.remarksPannel.TabIndex = 16;
            this.remarksPannel.Visible = false;
            // 
            // adminRemarkTextBox
            // 
            this.adminRemarkTextBox.Location = new System.Drawing.Point(165, 14);
            this.adminRemarkTextBox.Name = "adminRemarkTextBox";
            this.adminRemarkTextBox.Size = new System.Drawing.Size(432, 20);
            this.adminRemarkTextBox.TabIndex = 13;
            // 
            // adminCurrentRemarkTxt
            // 
            this.adminCurrentRemarkTxt.AutoSize = true;
            this.adminCurrentRemarkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCurrentRemarkTxt.Location = new System.Drawing.Point(562, 109);
            this.adminCurrentRemarkTxt.Name = "adminCurrentRemarkTxt";
            this.adminCurrentRemarkTxt.Size = new System.Drawing.Size(182, 20);
            this.adminCurrentRemarkTxt.TabIndex = 9;
            this.adminCurrentRemarkTxt.Text = "Admin\'s Current Remark";
            // 
            // ManagerRemarkTxt
            // 
            this.ManagerRemarkTxt.AutoSize = true;
            this.ManagerRemarkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerRemarkTxt.Location = new System.Drawing.Point(27, 215);
            this.ManagerRemarkTxt.Name = "ManagerRemarkTxt";
            this.ManagerRemarkTxt.Size = new System.Drawing.Size(132, 20);
            this.ManagerRemarkTxt.TabIndex = 8;
            this.ManagerRemarkTxt.Text = "Manager Remark";
            // 
            // managerRemarkLbl
            // 
            this.managerRemarkLbl.AutoSize = true;
            this.managerRemarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerRemarkLbl.Location = new System.Drawing.Point(27, 182);
            this.managerRemarkLbl.Name = "managerRemarkLbl";
            this.managerRemarkLbl.Size = new System.Drawing.Size(132, 20);
            this.managerRemarkLbl.TabIndex = 7;
            this.managerRemarkLbl.Text = "Manager Remark";
            // 
            // userRemarkTxt
            // 
            this.userRemarkTxt.AutoSize = true;
            this.userRemarkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRemarkTxt.Location = new System.Drawing.Point(27, 109);
            this.userRemarkTxt.Name = "userRemarkTxt";
            this.userRemarkTxt.Size = new System.Drawing.Size(103, 20);
            this.userRemarkTxt.TabIndex = 6;
            this.userRemarkTxt.Text = "User Remark";
            // 
            // userRemarkLbl
            // 
            this.userRemarkLbl.AutoSize = true;
            this.userRemarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRemarkLbl.Location = new System.Drawing.Point(27, 79);
            this.userRemarkLbl.Name = "userRemarkLbl";
            this.userRemarkLbl.Size = new System.Drawing.Size(103, 20);
            this.userRemarkLbl.TabIndex = 5;
            this.userRemarkLbl.Text = "User Remark";
            // 
            // adminCurrentRemarkLbl
            // 
            this.adminCurrentRemarkLbl.AutoSize = true;
            this.adminCurrentRemarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCurrentRemarkLbl.Location = new System.Drawing.Point(562, 79);
            this.adminCurrentRemarkLbl.Name = "adminCurrentRemarkLbl";
            this.adminCurrentRemarkLbl.Size = new System.Drawing.Size(182, 20);
            this.adminCurrentRemarkLbl.TabIndex = 4;
            this.adminCurrentRemarkLbl.Text = "Admin\'s Current Remark";
            // 
            // adminRemarklbl
            // 
            this.adminRemarklbl.AutoSize = true;
            this.adminRemarklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRemarklbl.Location = new System.Drawing.Point(27, 14);
            this.adminRemarklbl.Name = "adminRemarklbl";
            this.adminRemarklbl.Size = new System.Drawing.Size(114, 20);
            this.adminRemarklbl.TabIndex = 3;
            this.adminRemarklbl.Text = "Admin Remark";
            // 
            // AdminRaisedRequestsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.remarksPannel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminRequestsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminRaisedRequestsUserControl";
            this.Size = new System.Drawing.Size(1357, 780);
            ((System.ComponentModel.ISupportInitialize)(this.adminRequestsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.remarksPannel.ResumeLayout(false);
            this.remarksPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adminRequestsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button denyBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Panel remarksPannel;
        private System.Windows.Forms.MaskedTextBox adminRemarkTextBox;
        private System.Windows.Forms.Label adminCurrentRemarkTxt;
        private System.Windows.Forms.Label ManagerRemarkTxt;
        private System.Windows.Forms.Label managerRemarkLbl;
        private System.Windows.Forms.Label userRemarkTxt;
        private System.Windows.Forms.Label userRemarkLbl;
        private System.Windows.Forms.Label adminCurrentRemarkLbl;
        private System.Windows.Forms.Label adminRemarklbl;
        private System.Windows.Forms.Button UpdateBtn;
    }
}
