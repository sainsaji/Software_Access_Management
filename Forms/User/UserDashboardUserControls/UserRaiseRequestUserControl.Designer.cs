namespace File_Acess_Management.Forms.User.UserDashboardUserControls
{
    partial class UserRaiseRequestUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRaiseRequestUserControl));
            this.requestRightPanel = new System.Windows.Forms.Panel();
            this.validIcoPicBox = new System.Windows.Forms.PictureBox();
            this.alertsLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.softwareChkdLstBx = new System.Windows.Forms.CheckedListBox();
            this.selectedSoftwareListBox = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.proceedBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.repManagerTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alertLabelErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.requestRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validIcoPicBox)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertLabelErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // requestRightPanel
            // 
            this.requestRightPanel.Controls.Add(this.validIcoPicBox);
            this.requestRightPanel.Controls.Add(this.alertsLabel);
            this.requestRightPanel.Controls.Add(this.addBtn);
            this.requestRightPanel.Controls.Add(this.softwareChkdLstBx);
            this.requestRightPanel.Controls.Add(this.selectedSoftwareListBox);
            this.requestRightPanel.Controls.Add(this.panel7);
            this.requestRightPanel.Controls.Add(this.label5);
            this.requestRightPanel.Controls.Add(this.label4);
            this.requestRightPanel.Controls.Add(this.repManagerTxtBox);
            this.requestRightPanel.Controls.Add(this.label3);
            this.requestRightPanel.Controls.Add(this.nameTxtBox);
            this.requestRightPanel.Controls.Add(this.label1);
            this.requestRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestRightPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestRightPanel.Location = new System.Drawing.Point(0, 0);
            this.requestRightPanel.Name = "requestRightPanel";
            this.requestRightPanel.Size = new System.Drawing.Size(846, 571);
            this.requestRightPanel.TabIndex = 3;
            // 
            // validIcoPicBox
            // 
            this.validIcoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("validIcoPicBox.Image")));
            this.validIcoPicBox.Location = new System.Drawing.Point(236, 246);
            this.validIcoPicBox.Name = "validIcoPicBox";
            this.validIcoPicBox.Size = new System.Drawing.Size(31, 15);
            this.validIcoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.validIcoPicBox.TabIndex = 17;
            this.validIcoPicBox.TabStop = false;
            // 
            // alertsLabel
            // 
            this.alertsLabel.AutoSize = true;
            this.alertsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertsLabel.Location = new System.Drawing.Point(273, 246);
            this.alertsLabel.Name = "alertsLabel";
            this.alertsLabel.Size = new System.Drawing.Size(105, 13);
            this.alertsLabel.TabIndex = 16;
            this.alertsLabel.Text = "This is an Alert Label";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(53, 278);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(84, 29);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // softwareChkdLstBx
            // 
            this.softwareChkdLstBx.FormattingEnabled = true;
            this.softwareChkdLstBx.Location = new System.Drawing.Point(16, 174);
            this.softwareChkdLstBx.Name = "softwareChkdLstBx";
            this.softwareChkdLstBx.Size = new System.Drawing.Size(173, 49);
            this.softwareChkdLstBx.TabIndex = 15;
            // 
            // selectedSoftwareListBox
            // 
            this.selectedSoftwareListBox.FormattingEnabled = true;
            this.selectedSoftwareListBox.Location = new System.Drawing.Point(207, 49);
            this.selectedSoftwareListBox.Name = "selectedSoftwareListBox";
            this.selectedSoftwareListBox.Size = new System.Drawing.Size(228, 186);
            this.selectedSoftwareListBox.TabIndex = 13;
            this.selectedSoftwareListBox.SelectedIndexChanged += new System.EventHandler(this.selectedSoftwareListBox_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.proceedBtn);
            this.panel7.Controls.Add(this.cancelBtn);
            this.panel7.Location = new System.Drawing.Point(207, 276);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(228, 31);
            this.panel7.TabIndex = 11;
            // 
            // proceedBtn
            // 
            this.proceedBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.proceedBtn.Location = new System.Drawing.Point(144, 0);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(84, 31);
            this.proceedBtn.TabIndex = 12;
            this.proceedBtn.Text = "Proceed";
            this.proceedBtn.UseVisualStyleBackColor = true;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancelBtn.Location = new System.Drawing.Point(0, 0);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(84, 31);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Selected Softwares:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Software for Installation:";
            // 
            // repManagerTxtBox
            // 
            this.repManagerTxtBox.Location = new System.Drawing.Point(16, 108);
            this.repManagerTxtBox.Name = "repManagerTxtBox";
            this.repManagerTxtBox.Size = new System.Drawing.Size(173, 20);
            this.repManagerTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reporting Manager:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(16, 49);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(173, 20);
            this.nameTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // alertLabelErrorProvider
            // 
            this.alertLabelErrorProvider.ContainerControl = this;
            // 
            // UserRaiseRequestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.requestRightPanel);
            this.Name = "UserRaiseRequestUserControl";
            this.Size = new System.Drawing.Size(846, 571);
            this.Load += new System.EventHandler(this.UserRaiseRequestUserControl_Load);
            this.VisibleChanged += new System.EventHandler(this.UserRaiseRequestUserControl_VisibleChanged);
            this.requestRightPanel.ResumeLayout(false);
            this.requestRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validIcoPicBox)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alertLabelErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel requestRightPanel;
        private System.Windows.Forms.Label alertsLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.CheckedListBox softwareChkdLstBx;
        private System.Windows.Forms.ListBox selectedSoftwareListBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button proceedBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox repManagerTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider alertLabelErrorProvider;
        private System.Windows.Forms.PictureBox validIcoPicBox;
    }
}
