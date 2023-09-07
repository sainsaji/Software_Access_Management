namespace File_Acess_Management.Forms.Manager.ManagerUserControls
{
    partial class ManagerIncomingRequestUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerIncomingRequestUserControl));
            this.userRequestGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditBtn = new System.Windows.Forms.Button();
            this.denyBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.remarksPannel = new System.Windows.Forms.Panel();
            this.managerRemarkTextBox = new System.Windows.Forms.MaskedTextBox();
            this.managerCurrentRemarkTxt = new System.Windows.Forms.Label();
            this.AdminRemarkTxt = new System.Windows.Forms.Label();
            this.adminRemarkLbl = new System.Windows.Forms.Label();
            this.userRemarkTxt = new System.Windows.Forms.Label();
            this.userRemarkLbl = new System.Windows.Forms.Label();
            this.managerCurrentRemarkLbl = new System.Windows.Forms.Label();
            this.managerRemarklbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userRequestGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.remarksPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userRequestGridView
            // 
            this.userRequestGridView.AllowUserToAddRows = false;
            this.userRequestGridView.AllowUserToDeleteRows = false;
            this.userRequestGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userRequestGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userRequestGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userRequestGridView.Location = new System.Drawing.Point(3, 46);
            this.userRequestGridView.Margin = new System.Windows.Forms.Padding(2);
            this.userRequestGridView.MultiSelect = false;
            this.userRequestGridView.Name = "userRequestGridView";
            this.userRequestGridView.ReadOnly = true;
            this.userRequestGridView.RowHeadersWidth = 51;
            this.userRequestGridView.RowTemplate.Height = 24;
            this.userRequestGridView.Size = new System.Drawing.Size(884, 243);
            this.userRequestGridView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.denyBtn);
            this.panel1.Controls.Add(this.acceptBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 41);
            this.panel1.TabIndex = 4;
            this.panel1.VisibleChanged += new System.EventHandler(this.panel1_VisibleChanged);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditBtn.Image")));
            this.EditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditBtn.Location = new System.Drawing.Point(266, 0);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(158, 41);
            this.EditBtn.TabIndex = 8;
            this.EditBtn.Text = "Update Remark";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
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
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.remarksPannel);
            this.panel2.Controls.Add(this.userRequestGridView);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 591);
            this.panel2.TabIndex = 5;
            // 
            // remarksPannel
            // 
            this.remarksPannel.Controls.Add(this.managerRemarkTextBox);
            this.remarksPannel.Controls.Add(this.managerCurrentRemarkTxt);
            this.remarksPannel.Controls.Add(this.AdminRemarkTxt);
            this.remarksPannel.Controls.Add(this.adminRemarkLbl);
            this.remarksPannel.Controls.Add(this.userRemarkTxt);
            this.remarksPannel.Controls.Add(this.userRemarkLbl);
            this.remarksPannel.Controls.Add(this.managerCurrentRemarkLbl);
            this.remarksPannel.Controls.Add(this.managerRemarklbl);
            this.remarksPannel.Location = new System.Drawing.Point(3, 294);
            this.remarksPannel.Name = "remarksPannel";
            this.remarksPannel.Size = new System.Drawing.Size(884, 294);
            this.remarksPannel.TabIndex = 15;
            this.remarksPannel.Visible = false;
            // 
            // managerRemarkTextBox
            // 
            this.managerRemarkTextBox.Location = new System.Drawing.Point(165, 14);
            this.managerRemarkTextBox.Name = "managerRemarkTextBox";
            this.managerRemarkTextBox.Size = new System.Drawing.Size(432, 20);
            this.managerRemarkTextBox.TabIndex = 13;
            // 
            // managerCurrentRemarkTxt
            // 
            this.managerCurrentRemarkTxt.AutoSize = true;
            this.managerCurrentRemarkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerCurrentRemarkTxt.Location = new System.Drawing.Point(487, 109);
            this.managerCurrentRemarkTxt.Name = "managerCurrentRemarkTxt";
            this.managerCurrentRemarkTxt.Size = new System.Drawing.Size(208, 20);
            this.managerCurrentRemarkTxt.TabIndex = 9;
            this.managerCurrentRemarkTxt.Text = "Managers\'s Current Remark";
            // 
            // AdminRemarkTxt
            // 
            this.AdminRemarkTxt.AutoSize = true;
            this.AdminRemarkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRemarkTxt.Location = new System.Drawing.Point(27, 215);
            this.AdminRemarkTxt.Name = "AdminRemarkTxt";
            this.AdminRemarkTxt.Size = new System.Drawing.Size(114, 20);
            this.AdminRemarkTxt.TabIndex = 8;
            this.AdminRemarkTxt.Text = "Admin Remark";
            // 
            // adminRemarkLbl
            // 
            this.adminRemarkLbl.AutoSize = true;
            this.adminRemarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRemarkLbl.Location = new System.Drawing.Point(27, 182);
            this.adminRemarkLbl.Name = "adminRemarkLbl";
            this.adminRemarkLbl.Size = new System.Drawing.Size(114, 20);
            this.adminRemarkLbl.TabIndex = 7;
            this.adminRemarkLbl.Text = "Admin Remark";
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
            // managerCurrentRemarkLbl
            // 
            this.managerCurrentRemarkLbl.AutoSize = true;
            this.managerCurrentRemarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerCurrentRemarkLbl.Location = new System.Drawing.Point(487, 79);
            this.managerCurrentRemarkLbl.Name = "managerCurrentRemarkLbl";
            this.managerCurrentRemarkLbl.Size = new System.Drawing.Size(200, 20);
            this.managerCurrentRemarkLbl.TabIndex = 4;
            this.managerCurrentRemarkLbl.Text = "Manager\'s Current Remark";
            // 
            // managerRemarklbl
            // 
            this.managerRemarklbl.AutoSize = true;
            this.managerRemarklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerRemarklbl.Location = new System.Drawing.Point(27, 14);
            this.managerRemarklbl.Name = "managerRemarklbl";
            this.managerRemarklbl.Size = new System.Drawing.Size(132, 20);
            this.managerRemarklbl.TabIndex = 3;
            this.managerRemarklbl.Text = "Manager Remark";
            // 
            // ManagerIncomingRequestUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerIncomingRequestUserControl";
            this.Size = new System.Drawing.Size(896, 594);
            this.Load += new System.EventHandler(this.ManagerIncomingRequestUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userRequestGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.remarksPannel.ResumeLayout(false);
            this.remarksPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userRequestGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button denyBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Panel remarksPannel;
        private System.Windows.Forms.MaskedTextBox managerRemarkTextBox;
        private System.Windows.Forms.Label managerCurrentRemarkTxt;
        private System.Windows.Forms.Label AdminRemarkTxt;
        private System.Windows.Forms.Label adminRemarkLbl;
        private System.Windows.Forms.Label userRemarkTxt;
        private System.Windows.Forms.Label userRemarkLbl;
        private System.Windows.Forms.Label managerCurrentRemarkLbl;
        private System.Windows.Forms.Label managerRemarklbl;
    }
}
