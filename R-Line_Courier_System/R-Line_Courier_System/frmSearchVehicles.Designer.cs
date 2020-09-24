namespace R_Line_Courier_System
{
    partial class frmSearchVehicles
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgVehicles = new System.Windows.Forms.DataGridView();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.txtSearchVehicle = new System.Windows.Forms.TextBox();
            this.gbSearchUser = new System.Windows.Forms.GroupBox();
            this.rbVehicleID = new System.Windows.Forms.RadioButton();
            this.rbVehicleRegNo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicles)).BeginInit();
            this.gbSearchUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 338);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(159, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(250, 338);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dgVehicles
            // 
            this.dgVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehicles.Location = new System.Drawing.Point(53, 158);
            this.dgVehicles.Name = "dgVehicles";
            this.dgVehicles.Size = new System.Drawing.Size(624, 150);
            this.dgVehicles.TabIndex = 14;
            this.dgVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgVehicles_CellClick);
            this.dgVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgVehicles_CellContentClick);
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Location = new System.Drawing.Point(50, 114);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(44, 13);
            this.lblSearchUser.TabIndex = 13;
            this.lblSearchUser.Text = "Search:";
            // 
            // txtSearchVehicle
            // 
            this.txtSearchVehicle.Location = new System.Drawing.Point(159, 114);
            this.txtSearchVehicle.Name = "txtSearchVehicle";
            this.txtSearchVehicle.Size = new System.Drawing.Size(100, 20);
            this.txtSearchVehicle.TabIndex = 12;
            this.txtSearchVehicle.TextChanged += new System.EventHandler(this.TxtSearchVehicle_TextChanged);
            // 
            // gbSearchUser
            // 
            this.gbSearchUser.Controls.Add(this.rbVehicleID);
            this.gbSearchUser.Controls.Add(this.rbVehicleRegNo);
            this.gbSearchUser.Location = new System.Drawing.Point(37, 29);
            this.gbSearchUser.Name = "gbSearchUser";
            this.gbSearchUser.Size = new System.Drawing.Size(241, 55);
            this.gbSearchUser.TabIndex = 11;
            this.gbSearchUser.TabStop = false;
            this.gbSearchUser.Text = "Search User By:";
            // 
            // rbVehicleID
            // 
            this.rbVehicleID.AutoSize = true;
            this.rbVehicleID.Location = new System.Drawing.Point(16, 19);
            this.rbVehicleID.Name = "rbVehicleID";
            this.rbVehicleID.Size = new System.Drawing.Size(71, 17);
            this.rbVehicleID.TabIndex = 0;
            this.rbVehicleID.TabStop = true;
            this.rbVehicleID.Text = "VehicleID";
            this.rbVehicleID.UseVisualStyleBackColor = true;
            // 
            // rbVehicleRegNo
            // 
            this.rbVehicleRegNo.AutoSize = true;
            this.rbVehicleRegNo.Location = new System.Drawing.Point(107, 19);
            this.rbVehicleRegNo.Name = "rbVehicleRegNo";
            this.rbVehicleRegNo.Size = new System.Drawing.Size(100, 17);
            this.rbVehicleRegNo.TabIndex = 1;
            this.rbVehicleRegNo.TabStop = true;
            this.rbVehicleRegNo.Text = "Vehicle Reg No";
            this.rbVehicleRegNo.UseVisualStyleBackColor = true;
            // 
            // frmSearchVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgVehicles);
            this.Controls.Add(this.lblSearchUser);
            this.Controls.Add(this.txtSearchVehicle);
            this.Controls.Add(this.gbSearchUser);
            this.Name = "frmSearchVehicles";
            this.Text = "frmSearchVehicles";
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicles)).EndInit();
            this.gbSearchUser.ResumeLayout(false);
            this.gbSearchUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgVehicles;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.TextBox txtSearchVehicle;
        private System.Windows.Forms.GroupBox gbSearchUser;
        private System.Windows.Forms.RadioButton rbVehicleID;
        private System.Windows.Forms.RadioButton rbVehicleRegNo;
    }
}