namespace File_Acess_Management
{
    partial class UserLogin
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.userPasswordText = new System.Windows.Forms.TextBox();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(376, 253);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(105, 24);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name";
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(596, 247);
            this.userNameText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(378, 29);
            this.userNameText.TabIndex = 1;
            // 
            // userPasswordText
            // 
            this.userPasswordText.Location = new System.Drawing.Point(596, 345);
            this.userPasswordText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userPasswordText.Name = "userPasswordText";
            this.userPasswordText.Size = new System.Drawing.Size(378, 29);
            this.userPasswordText.TabIndex = 3;
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Location = new System.Drawing.Point(376, 351);
            this.userPasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(92, 24);
            this.userPasswordLabel.TabIndex = 2;
            this.userPasswordLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(596, 452);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(138, 42);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userPasswordText);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.userNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox userPasswordText;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.Button loginButton;
    }
}