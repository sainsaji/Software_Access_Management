namespace File_Acess_Management.Forms.Manager.ManagerUserControls
{
    partial class ManagerInformationUserConrol
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
            this.managerInfomationLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // managerInfomationLbl
            // 
            this.managerInfomationLbl.AutoSize = true;
            this.managerInfomationLbl.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerInfomationLbl.Location = new System.Drawing.Point(315, 277);
            this.managerInfomationLbl.Name = "managerInfomationLbl";
            this.managerInfomationLbl.Size = new System.Drawing.Size(266, 40);
            this.managerInfomationLbl.TabIndex = 0;
            this.managerInfomationLbl.Text = "Manager Information";
            // 
            // ManagerInformationUserConrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.managerInfomationLbl);
            this.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManagerInformationUserConrol";
            this.Size = new System.Drawing.Size(896, 594);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label managerInfomationLbl;
    }
}
