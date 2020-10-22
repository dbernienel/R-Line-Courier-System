namespace R_Line_Courier_System
{
    partial class frmMaintainVehicles
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
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.lblVehicleRegNo = new System.Windows.Forms.Label();
            this.gbMaintainVehicles = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbMaintainVehicles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Location = new System.Drawing.Point(19, 34);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(59, 13);
            this.lblVehicleID.TabIndex = 0;
            this.lblVehicleID.Text = "Vehicle ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(110, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(110, 57);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(100, 20);
            this.txtRegNo.TabIndex = 3;
            // 
            // lblVehicleRegNo
            // 
            this.lblVehicleRegNo.AutoSize = true;
            this.lblVehicleRegNo.Location = new System.Drawing.Point(19, 60);
            this.lblVehicleRegNo.Name = "lblVehicleRegNo";
            this.lblVehicleRegNo.Size = new System.Drawing.Size(85, 13);
            this.lblVehicleRegNo.TabIndex = 2;
            this.lblVehicleRegNo.Text = "Vehicle Reg No:";
            // 
            // gbMaintainVehicles
            // 
            this.gbMaintainVehicles.Controls.Add(this.txtID);
            this.gbMaintainVehicles.Controls.Add(this.txtRegNo);
            this.gbMaintainVehicles.Controls.Add(this.lblVehicleID);
            this.gbMaintainVehicles.Controls.Add(this.lblVehicleRegNo);
            this.gbMaintainVehicles.Location = new System.Drawing.Point(12, 12);
            this.gbMaintainVehicles.Name = "gbMaintainVehicles";
            this.gbMaintainVehicles.Size = new System.Drawing.Size(238, 95);
            this.gbMaintainVehicles.TabIndex = 4;
            this.gbMaintainVehicles.TabStop = false;
            this.gbMaintainVehicles.Text = "Maintain Vehicles";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(25, 126);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "button1";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(122, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // frmMaintainVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 204);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbMaintainVehicles);
            this.Name = "frmMaintainVehicles";
            this.Text = "frmMaintainVehicles";
            this.Activated += new System.EventHandler(this.FrmMaintainVehicles_Activated);
            this.Load += new System.EventHandler(this.frmMaintainVehicles_Load);
            this.gbMaintainVehicles.ResumeLayout(false);
            this.gbMaintainVehicles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label lblVehicleRegNo;
        private System.Windows.Forms.GroupBox gbMaintainVehicles;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
    }
}