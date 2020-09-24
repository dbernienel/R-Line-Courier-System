namespace R_Line_Courier_System
{
    partial class frmSearchUser
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
            this.rbUserID = new System.Windows.Forms.RadioButton();
            this.rbUser_Name = new System.Windows.Forms.RadioButton();
            this.rbUserName = new System.Windows.Forms.RadioButton();
            this.rbUserSurname = new System.Windows.Forms.RadioButton();
            this.gbSearchUser = new System.Windows.Forms.GroupBox();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.dgViewUsers = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // rbUserID
            // 
            this.rbUserID.AutoSize = true;
            this.rbUserID.Location = new System.Drawing.Point(16, 19);
            this.rbUserID.Name = "rbUserID";
            this.rbUserID.Size = new System.Drawing.Size(58, 17);
            this.rbUserID.TabIndex = 0;
            this.rbUserID.TabStop = true;
            this.rbUserID.Text = "UserID";
            this.rbUserID.UseVisualStyleBackColor = true;
            // 
            // rbUser_Name
            // 
            this.rbUser_Name.AutoSize = true;
            this.rbUser_Name.Location = new System.Drawing.Point(107, 19);
            this.rbUser_Name.Name = "rbUser_Name";
            this.rbUser_Name.Size = new System.Drawing.Size(73, 17);
            this.rbUser_Name.TabIndex = 1;
            this.rbUser_Name.TabStop = true;
            this.rbUser_Name.Text = "Username";
            this.rbUser_Name.UseVisualStyleBackColor = true;
            // 
            // rbUserName
            // 
            this.rbUserName.AutoSize = true;
            this.rbUserName.Location = new System.Drawing.Point(212, 19);
            this.rbUserName.Name = "rbUserName";
            this.rbUserName.Size = new System.Drawing.Size(53, 17);
            this.rbUserName.TabIndex = 2;
            this.rbUserName.TabStop = true;
            this.rbUserName.Text = "Name";
            this.rbUserName.UseVisualStyleBackColor = true;
            // 
            // rbUserSurname
            // 
            this.rbUserSurname.AutoSize = true;
            this.rbUserSurname.Location = new System.Drawing.Point(315, 19);
            this.rbUserSurname.Name = "rbUserSurname";
            this.rbUserSurname.Size = new System.Drawing.Size(67, 17);
            this.rbUserSurname.TabIndex = 3;
            this.rbUserSurname.TabStop = true;
            this.rbUserSurname.Text = "Surname";
            this.rbUserSurname.UseVisualStyleBackColor = true;
            // 
            // gbSearchUser
            // 
            this.gbSearchUser.Controls.Add(this.rbUserID);
            this.gbSearchUser.Controls.Add(this.rbUserSurname);
            this.gbSearchUser.Controls.Add(this.rbUser_Name);
            this.gbSearchUser.Controls.Add(this.rbUserName);
            this.gbSearchUser.Location = new System.Drawing.Point(27, 25);
            this.gbSearchUser.Name = "gbSearchUser";
            this.gbSearchUser.Size = new System.Drawing.Size(411, 55);
            this.gbSearchUser.TabIndex = 4;
            this.gbSearchUser.TabStop = false;
            this.gbSearchUser.Text = "Search User By:";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(149, 110);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(100, 20);
            this.txtSearchUser.TabIndex = 5;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.TxtSearchUser_TextChanged);
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Location = new System.Drawing.Point(40, 110);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(44, 13);
            this.lblSearchUser.TabIndex = 6;
            this.lblSearchUser.Text = "Search:";
            // 
            // dgViewUsers
            // 
            this.dgViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewUsers.Location = new System.Drawing.Point(43, 154);
            this.dgViewUsers.Name = "dgViewUsers";
            this.dgViewUsers.Size = new System.Drawing.Size(624, 150);
            this.dgViewUsers.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(240, 334);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnSelectUser_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(149, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // frmSearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgViewUsers);
            this.Controls.Add(this.lblSearchUser);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.gbSearchUser);
            this.Name = "frmSearchUser";
            this.Text = "frmSearchUser";
            this.gbSearchUser.ResumeLayout(false);
            this.gbSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbUserID;
        private System.Windows.Forms.RadioButton rbUser_Name;
        private System.Windows.Forms.RadioButton rbUserName;
        private System.Windows.Forms.RadioButton rbUserSurname;
        private System.Windows.Forms.GroupBox gbSearchUser;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.DataGridView dgViewUsers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}