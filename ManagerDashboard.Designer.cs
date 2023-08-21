namespace File_Acess_Management
{
    partial class ManagerDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDashboard));
            this.userNameText = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberText = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.userRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.addUserButton = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.roleLabel = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.managerUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tickPicBox = new System.Windows.Forms.PictureBox();
            this.passErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passPicBox = new System.Windows.Forms.PictureBox();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.namePicBox = new System.Windows.Forms.PictureBox();
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailPicBox = new System.Windows.Forms.PictureBox();
            this.phonePicBox = new System.Windows.Forms.PictureBox();
            this.addressPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userRecordDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameText
            // 
            this.userNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameText.Location = new System.Drawing.Point(215, 77);
            this.userNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(235, 30);
            this.userNameText.TabIndex = 3;
            this.userNameText.TextChanged += new System.EventHandler(this.userNameText_TextChanged);
            this.userNameText.Leave += new System.EventHandler(this.userNameText_Leave);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(35, 82);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(110, 25);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "User Name";
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(215, 118);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(235, 30);
            this.passwordText.TabIndex = 5;
            this.passwordText.Leave += new System.EventHandler(this.passwordText_Leave);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(35, 123);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(743, 5);
            this.emailText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(232, 30);
            this.emailText.TabIndex = 7;
            this.emailText.Leave += new System.EventHandler(this.emailText_Leave);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(563, 10);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(60, 25);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // phoneNumberText
            // 
            this.phoneNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberText.Location = new System.Drawing.Point(743, 46);
            this.phoneNumberText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneNumberText.Name = "phoneNumberText";
            this.phoneNumberText.Size = new System.Drawing.Size(232, 30);
            this.phoneNumberText.TabIndex = 9;
            this.phoneNumberText.Leave += new System.EventHandler(this.phoneNumberText_Leave);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(563, 51);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(143, 25);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // addressText
            // 
            this.addressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(743, 90);
            this.addressText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(232, 30);
            this.addressText.TabIndex = 11;
            this.addressText.Leave += new System.EventHandler(this.addressText_Leave);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(563, 95);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(85, 25);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address";
            // 
            // userRecordDataGridView
            // 
            this.userRecordDataGridView.AllowUserToAddRows = false;
            this.userRecordDataGridView.AllowUserToDeleteRows = false;
            this.userRecordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userRecordDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.userRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userRecordDataGridView.Location = new System.Drawing.Point(4, 235);
            this.userRecordDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userRecordDataGridView.MultiSelect = false;
            this.userRecordDataGridView.Name = "userRecordDataGridView";
            this.userRecordDataGridView.ReadOnly = true;
            this.userRecordDataGridView.RowHeadersWidth = 51;
            this.userRecordDataGridView.Size = new System.Drawing.Size(1168, 347);
            this.userRecordDataGridView.TabIndex = 16;
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.Location = new System.Drawing.Point(41, 249);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(128, 46);
            this.addUserButton.TabIndex = 17;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(215, 206);
            this.nameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(235, 30);
            this.nameText.TabIndex = 19;
            this.nameText.Leave += new System.EventHandler(this.nameText_Leave);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(35, 211);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 25);
            this.nameLabel.TabIndex = 18;
            this.nameLabel.Text = "Name";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(215, 249);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(128, 46);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(402, 249);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(128, 46);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(580, 249);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(128, 46);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(35, 166);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(108, 25);
            this.roleLabel.TabIndex = 23;
            this.roleLabel.Text = "Role Name";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(215, 162);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(235, 33);
            this.roleComboBox.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addressPicBox);
            this.panel1.Controls.Add(this.phonePicBox);
            this.panel1.Controls.Add(this.emailPicBox);
            this.panel1.Controls.Add(this.namePicBox);
            this.panel1.Controls.Add(this.passPicBox);
            this.panel1.Controls.Add(this.tickPicBox);
            this.panel1.Controls.Add(this.userRecordDataGridView);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.emailText);
            this.panel1.Controls.Add(this.phoneNumberLabel);
            this.panel1.Controls.Add(this.phoneNumberText);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.addressText);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 587);
            this.panel1.TabIndex = 25;
            // 
            // managerUser
            // 
            this.managerUser.AutoSize = true;
            this.managerUser.BackColor = System.Drawing.Color.White;
            this.managerUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.managerUser.Location = new System.Drawing.Point(440, 8);
            this.managerUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.managerUser.Name = "managerUser";
            this.managerUser.Size = new System.Drawing.Size(236, 31);
            this.managerUser.TabIndex = 0;
            this.managerUser.Text = "User Management";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.managerUser);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 49);
            this.panel2.TabIndex = 26;
            // 
            // userNameErrorProvider
            // 
            this.userNameErrorProvider.ContainerControl = this;
            // 
            // tickPicBox
            // 
            this.tickPicBox.Image = ((System.Drawing.Image)(resources.GetObject("tickPicBox.Image")));
            this.tickPicBox.Location = new System.Drawing.Point(445, 7);
            this.tickPicBox.Name = "tickPicBox";
            this.tickPicBox.Size = new System.Drawing.Size(34, 28);
            this.tickPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tickPicBox.TabIndex = 17;
            this.tickPicBox.TabStop = false;
            // 
            // passErrorProvider
            // 
            this.passErrorProvider.ContainerControl = this;
            // 
            // passPicBox
            // 
            this.passPicBox.Image = ((System.Drawing.Image)(resources.GetObject("passPicBox.Image")));
            this.passPicBox.Location = new System.Drawing.Point(445, 48);
            this.passPicBox.Name = "passPicBox";
            this.passPicBox.Size = new System.Drawing.Size(34, 28);
            this.passPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passPicBox.TabIndex = 18;
            this.passPicBox.TabStop = false;
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // namePicBox
            // 
            this.namePicBox.Image = ((System.Drawing.Image)(resources.GetObject("namePicBox.Image")));
            this.namePicBox.Location = new System.Drawing.Point(445, 136);
            this.namePicBox.Name = "namePicBox";
            this.namePicBox.Size = new System.Drawing.Size(34, 28);
            this.namePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.namePicBox.TabIndex = 19;
            this.namePicBox.TabStop = false;
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            // 
            // phoneErrorProvider
            // 
            this.phoneErrorProvider.ContainerControl = this;
            // 
            // addressErrorProvider
            // 
            this.addressErrorProvider.ContainerControl = this;
            // 
            // emailPicBox
            // 
            this.emailPicBox.Image = ((System.Drawing.Image)(resources.GetObject("emailPicBox.Image")));
            this.emailPicBox.Location = new System.Drawing.Point(982, 5);
            this.emailPicBox.Name = "emailPicBox";
            this.emailPicBox.Size = new System.Drawing.Size(34, 28);
            this.emailPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emailPicBox.TabIndex = 20;
            this.emailPicBox.TabStop = false;
            // 
            // phonePicBox
            // 
            this.phonePicBox.Image = ((System.Drawing.Image)(resources.GetObject("phonePicBox.Image")));
            this.phonePicBox.Location = new System.Drawing.Point(982, 46);
            this.phonePicBox.Name = "phonePicBox";
            this.phonePicBox.Size = new System.Drawing.Size(34, 28);
            this.phonePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phonePicBox.TabIndex = 21;
            this.phonePicBox.TabStop = false;
            // 
            // addressPicBox
            // 
            this.addressPicBox.Image = ((System.Drawing.Image)(resources.GetObject("addressPicBox.Image")));
            this.addressPicBox.Location = new System.Drawing.Point(982, 90);
            this.addressPicBox.Name = "addressPicBox";
            this.addressPicBox.Size = new System.Drawing.Size(34, 28);
            this.addressPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addressPicBox.TabIndex = 22;
            this.addressPicBox.TabStop = false;
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 660);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerDashboard";
            this.Text = "ManagerDashboard";
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userRecordDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox phoneNumberText;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.DataGridView userRecordDataGridView;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label managerUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider userNameErrorProvider;
        private System.Windows.Forms.PictureBox tickPicBox;
        private System.Windows.Forms.ErrorProvider passErrorProvider;
        private System.Windows.Forms.PictureBox namePicBox;
        private System.Windows.Forms.PictureBox passPicBox;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.PictureBox addressPicBox;
        private System.Windows.Forms.PictureBox phonePicBox;
        private System.Windows.Forms.PictureBox emailPicBox;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;
        private System.Windows.Forms.ErrorProvider addressErrorProvider;
    }
}