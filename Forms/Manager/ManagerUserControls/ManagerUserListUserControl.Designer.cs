namespace File_Acess_Management.Forms.Manager.ManagerUserControls
{
    partial class ManagerUserListUserControl
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
            this.assignedLbl = new System.Windows.Forms.Label();
            this.assignedUserListBx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // assignedLbl
            // 
            this.assignedLbl.AutoSize = true;
            this.assignedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedLbl.Location = new System.Drawing.Point(282, 46);
            this.assignedLbl.Name = "assignedLbl";
            this.assignedLbl.Size = new System.Drawing.Size(150, 25);
            this.assignedLbl.TabIndex = 2;
            this.assignedLbl.Text = "Assigned Users";
            // 
            // assignedUserListBx
            // 
            this.assignedUserListBx.FormattingEnabled = true;
            this.assignedUserListBx.ItemHeight = 16;
            this.assignedUserListBx.Location = new System.Drawing.Point(286, 74);
            this.assignedUserListBx.Name = "assignedUserListBx";
            this.assignedUserListBx.Size = new System.Drawing.Size(325, 260);
            this.assignedUserListBx.TabIndex = 3;
            // 
            // ManagerUserListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignedLbl);
            this.Controls.Add(this.assignedUserListBx);
            this.Name = "ManagerUserListUserControl";
            this.Size = new System.Drawing.Size(896, 594);
            this.Load += new System.EventHandler(this.ManagerUserListUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label assignedLbl;
        private System.Windows.Forms.ListBox assignedUserListBx;
    }
}
