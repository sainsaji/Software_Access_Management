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
            this.reviewReqBtn = new System.Windows.Forms.Button();
            this.denyBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.userRequestGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userRequestGridView
            // 
            this.userRequestGridView.AllowUserToAddRows = false;
            this.userRequestGridView.AllowUserToDeleteRows = false;
            this.userRequestGridView.AllowUserToOrderColumns = true;
            this.userRequestGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.userRequestGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.userRequestGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userRequestGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.userRequestGridView.Location = new System.Drawing.Point(0, 0);
            this.userRequestGridView.Margin = new System.Windows.Forms.Padding(2);
            this.userRequestGridView.Name = "userRequestGridView";
            this.userRequestGridView.RowHeadersWidth = 51;
            this.userRequestGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userRequestGridView.RowTemplate.Height = 24;
            this.userRequestGridView.Size = new System.Drawing.Size(672, 442);
            this.userRequestGridView.TabIndex = 3;
            this.userRequestGridView.SelectionChanged += new System.EventHandler(this.userRequestGridView_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reviewReqBtn);
            this.panel1.Controls.Add(this.denyBtn);
            this.panel1.Controls.Add(this.acceptBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 41);
            this.panel1.TabIndex = 4;
            this.panel1.VisibleChanged += new System.EventHandler(this.panel1_VisibleChanged);
            // 
            // reviewReqBtn
            // 
            this.reviewReqBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.reviewReqBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reviewReqBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.reviewReqBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reviewReqBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewReqBtn.Image = ((System.Drawing.Image)(resources.GetObject("reviewReqBtn.Image")));
            this.reviewReqBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reviewReqBtn.Location = new System.Drawing.Point(266, 0);
            this.reviewReqBtn.Name = "reviewReqBtn";
            this.reviewReqBtn.Size = new System.Drawing.Size(133, 41);
            this.reviewReqBtn.TabIndex = 8;
            this.reviewReqBtn.Text = "Review Required";
            this.reviewReqBtn.UseVisualStyleBackColor = false;
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
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userRequestGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 442);
            this.panel2.TabIndex = 5;
            // 
            // ManagerIncomingRequestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerIncomingRequestUserControl";
            this.Size = new System.Drawing.Size(672, 483);
            this.Load += new System.EventHandler(this.ManagerIncomingRequestUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userRequestGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userRequestGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button reviewReqBtn;
        private System.Windows.Forms.Button denyBtn;
        private System.Windows.Forms.Button acceptBtn;
    }
}
