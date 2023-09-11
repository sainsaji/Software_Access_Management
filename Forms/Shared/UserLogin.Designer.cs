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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userPasswordText = new System.Windows.Forms.TextBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminIcon = new System.Windows.Forms.PictureBox();
            this.managerIcon = new System.Windows.Forms.PictureBox();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.debugLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.userPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userPasswordLabel.Location = new System.Drawing.Point(79, 257);
            this.userPasswordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(92, 24);
            this.userPasswordLabel.TabIndex = 2;
            this.userPasswordLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userNameLabel.Location = new System.Drawing.Point(67, 175);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(105, 24);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name";
            // 
            // userPasswordText
            // 
            this.userPasswordText.Location = new System.Drawing.Point(195, 257);
            this.userPasswordText.Margin = new System.Windows.Forms.Padding(5);
            this.userPasswordText.Name = "userPasswordText";
            this.userPasswordText.PasswordChar = '*';
            this.userPasswordText.Size = new System.Drawing.Size(190, 28);
            this.userPasswordText.TabIndex = 3;
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(195, 175);
            this.userNameText.Margin = new System.Windows.Forms.Padding(5);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(190, 28);
            this.userNameText.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Location = new System.Drawing.Point(271, 356);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(113, 35);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // adminIcon
            // 
            this.adminIcon.BackColor = System.Drawing.Color.Transparent;
            this.adminIcon.Image = ((System.Drawing.Image)(resources.GetObject("adminIcon.Image")));
            this.adminIcon.Location = new System.Drawing.Point(43, 381);
            this.adminIcon.Margin = new System.Windows.Forms.Padding(2);
            this.adminIcon.Name = "adminIcon";
            this.adminIcon.Size = new System.Drawing.Size(35, 34);
            this.adminIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminIcon.TabIndex = 6;
            this.adminIcon.TabStop = false;
            this.adminIcon.Click += new System.EventHandler(this.adminIcon_Click);
            // 
            // managerIcon
            // 
            this.managerIcon.BackColor = System.Drawing.Color.Transparent;
            this.managerIcon.Image = ((System.Drawing.Image)(resources.GetObject("managerIcon.Image")));
            this.managerIcon.Location = new System.Drawing.Point(83, 375);
            this.managerIcon.Margin = new System.Windows.Forms.Padding(2);
            this.managerIcon.Name = "managerIcon";
            this.managerIcon.Size = new System.Drawing.Size(40, 44);
            this.managerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.managerIcon.TabIndex = 7;
            this.managerIcon.TabStop = false;
            this.managerIcon.Click += new System.EventHandler(this.managerIcon_Click);
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.Transparent;
            this.userIcon.Image = ((System.Drawing.Image)(resources.GetObject("userIcon.Image")));
            this.userIcon.Location = new System.Drawing.Point(130, 378);
            this.userIcon.Margin = new System.Windows.Forms.Padding(2);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(34, 38);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIcon.TabIndex = 8;
            this.userIcon.TabStop = false;
            this.userIcon.Click += new System.EventHandler(this.userIcon_Click);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.BackColor = System.Drawing.Color.Transparent;
            this.debugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.debugLabel.Location = new System.Drawing.Point(39, 349);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(126, 16);
            this.debugLabel.TabIndex = 9;
            this.debugLabel.Text = "Debug Mode Status";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.debugLabel);
            this.panel1.Controls.Add(this.userIcon);
            this.panel1.Controls.Add(this.managerIcon);
            this.panel1.Controls.Add(this.adminIcon);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.userNameText);
            this.panel1.Controls.Add(this.userPasswordText);
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.userPasswordLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(470, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 439);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Software Access Management";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(25, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 284);
            this.panel2.TabIndex = 6;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 507);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userPasswordText;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox adminIcon;
        private System.Windows.Forms.PictureBox managerIcon;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}