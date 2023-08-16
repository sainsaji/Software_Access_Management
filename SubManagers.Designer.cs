namespace File_Acess_Management
{
    partial class SubManagers
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
            this.displayName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayName
            // 
            this.displayName.AutoSize = true;
            this.displayName.Location = new System.Drawing.Point(360, 182);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(35, 13);
            this.displayName.TabIndex = 0;
            this.displayName.Text = "label1";
            this.displayName.Click += new System.EventHandler(this.displayName_Click);
            // 
            // SubManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayName);
            this.Name = "SubManagers";
            this.Text = "SubManagers";
            this.Load += new System.EventHandler(this.SubManagers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayName;
    }
}