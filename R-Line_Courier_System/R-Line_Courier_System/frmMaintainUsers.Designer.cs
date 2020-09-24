namespace R_Line_Courier_System
{
    partial class frmMaintainUsers
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
            this.txtUser_Name = new System.Windows.Forms.TextBox();
            this.lblUser_Name = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUser_Password = new System.Windows.Forms.Label();
            this.txtUser_Surname = new System.Windows.Forms.TextBox();
            this.lblUser_Surname = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cbUserAdmin = new System.Windows.Forms.ComboBox();
            this.lblUserAdmin = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbMaintainUsers = new System.Windows.Forms.GroupBox();
            this.gbMaintainUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser_Name
            // 
            this.txtUser_Name.Location = new System.Drawing.Point(114, 64);
            this.txtUser_Name.Name = "txtUser_Name";
            this.txtUser_Name.Size = new System.Drawing.Size(100, 20);
            this.txtUser_Name.TabIndex = 19;
            // 
            // lblUser_Name
            // 
            this.lblUser_Name.AutoSize = true;
            this.lblUser_Name.Location = new System.Drawing.Point(21, 64);
            this.lblUser_Name.Name = "lblUser_Name";
            this.lblUser_Name.Size = new System.Drawing.Size(38, 13);
            this.lblUser_Name.TabIndex = 18;
            this.lblUser_Name.Text = "Name:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 17;
            // 
            // lblUser_Password
            // 
            this.lblUser_Password.AutoSize = true;
            this.lblUser_Password.Location = new System.Drawing.Point(21, 184);
            this.lblUser_Password.Name = "lblUser_Password";
            this.lblUser_Password.Size = new System.Drawing.Size(56, 13);
            this.lblUser_Password.TabIndex = 16;
            this.lblUser_Password.Text = "Password:";
            // 
            // txtUser_Surname
            // 
            this.txtUser_Surname.Location = new System.Drawing.Point(114, 99);
            this.txtUser_Surname.Name = "txtUser_Surname";
            this.txtUser_Surname.Size = new System.Drawing.Size(100, 20);
            this.txtUser_Surname.TabIndex = 15;
            // 
            // lblUser_Surname
            // 
            this.lblUser_Surname.AutoSize = true;
            this.lblUser_Surname.Location = new System.Drawing.Point(21, 109);
            this.lblUser_Surname.Name = "lblUser_Surname";
            this.lblUser_Surname.Size = new System.Drawing.Size(52, 13);
            this.lblUser_Surname.TabIndex = 14;
            this.lblUser_Surname.Text = "Surname:";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(114, 23);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 13;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(21, 23);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(46, 13);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "User ID:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(114, 136);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 27;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(21, 146);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 26;
            this.lblUsername.Text = "Username:";
            // 
            // cbUserAdmin
            // 
            this.cbUserAdmin.FormattingEnabled = true;
            this.cbUserAdmin.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cbUserAdmin.Location = new System.Drawing.Point(114, 212);
            this.cbUserAdmin.Name = "cbUserAdmin";
            this.cbUserAdmin.Size = new System.Drawing.Size(121, 21);
            this.cbUserAdmin.TabIndex = 28;
            // 
            // lblUserAdmin
            // 
            this.lblUserAdmin.AutoSize = true;
            this.lblUserAdmin.Location = new System.Drawing.Point(21, 220);
            this.lblUserAdmin.Name = "lblUserAdmin";
            this.lblUserAdmin.Size = new System.Drawing.Size(87, 13);
            this.lblUserAdmin.TabIndex = 29;
            this.lblUserAdmin.Text = "Admin Privileges:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(50, 304);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 30;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(165, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // gbMaintainUsers
            // 
            this.gbMaintainUsers.Controls.Add(this.cbUserAdmin);
            this.gbMaintainUsers.Controls.Add(this.lblUserID);
            this.gbMaintainUsers.Controls.Add(this.txtUserID);
            this.gbMaintainUsers.Controls.Add(this.lblUserAdmin);
            this.gbMaintainUsers.Controls.Add(this.lblUser_Surname);
            this.gbMaintainUsers.Controls.Add(this.txtUser_Surname);
            this.gbMaintainUsers.Controls.Add(this.txtUserName);
            this.gbMaintainUsers.Controls.Add(this.lblUser_Password);
            this.gbMaintainUsers.Controls.Add(this.lblUsername);
            this.gbMaintainUsers.Controls.Add(this.txtPassword);
            this.gbMaintainUsers.Controls.Add(this.lblUser_Name);
            this.gbMaintainUsers.Controls.Add(this.txtUser_Name);
            this.gbMaintainUsers.Location = new System.Drawing.Point(26, 24);
            this.gbMaintainUsers.Name = "gbMaintainUsers";
            this.gbMaintainUsers.Size = new System.Drawing.Size(298, 259);
            this.gbMaintainUsers.TabIndex = 32;
            this.gbMaintainUsers.TabStop = false;
            this.gbMaintainUsers.Text = "Maintain Users";
            // 
            // frmMaintainUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 357);
            this.Controls.Add(this.gbMaintainUsers);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Name = "frmMaintainUsers";
            this.Text = "frmMaintainUsers";
            this.gbMaintainUsers.ResumeLayout(false);
            this.gbMaintainUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser_Name;
        private System.Windows.Forms.Label lblUser_Name;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUser_Password;
        private System.Windows.Forms.TextBox txtUser_Surname;
        private System.Windows.Forms.Label lblUser_Surname;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cbUserAdmin;
        private System.Windows.Forms.Label lblUserAdmin;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbMaintainUsers;
    }
}