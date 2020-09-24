namespace R_Line_Courier_System
{
    partial class frmMaintainParcels
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
            this.btnUpdateParcel = new System.Windows.Forms.Button();
            this.btnDeleteParcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoreDetailsParcel = new System.Windows.Forms.Button();
            this.btnAddNewParcel = new System.Windows.Forms.Button();
            this.dgvParcels = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateParcel
            // 
            this.btnUpdateParcel.Location = new System.Drawing.Point(781, 606);
            this.btnUpdateParcel.Name = "btnUpdateParcel";
            this.btnUpdateParcel.Size = new System.Drawing.Size(118, 29);
            this.btnUpdateParcel.TabIndex = 2;
            this.btnUpdateParcel.Text = "Update";
            this.btnUpdateParcel.UseVisualStyleBackColor = true;
            this.btnUpdateParcel.Click += new System.EventHandler(this.btnUpdateParcel_Click);
            // 
            // btnDeleteParcel
            // 
            this.btnDeleteParcel.Location = new System.Drawing.Point(905, 606);
            this.btnDeleteParcel.Name = "btnDeleteParcel";
            this.btnDeleteParcel.Size = new System.Drawing.Size(118, 29);
            this.btnDeleteParcel.TabIndex = 3;
            this.btnDeleteParcel.Text = "Delete";
            this.btnDeleteParcel.UseVisualStyleBackColor = true;
            this.btnDeleteParcel.Click += new System.EventHandler(this.btnDeleteParcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parcels";
            // 
            // btnMoreDetailsParcel
            // 
            this.btnMoreDetailsParcel.Location = new System.Drawing.Point(58, 608);
            this.btnMoreDetailsParcel.Name = "btnMoreDetailsParcel";
            this.btnMoreDetailsParcel.Size = new System.Drawing.Size(85, 43);
            this.btnMoreDetailsParcel.TabIndex = 5;
            this.btnMoreDetailsParcel.Text = "More Details";
            this.btnMoreDetailsParcel.UseVisualStyleBackColor = true;
            this.btnMoreDetailsParcel.Click += new System.EventHandler(this.btnMoreDetailsParcel_Click);
            // 
            // btnAddNewParcel
            // 
            this.btnAddNewParcel.Location = new System.Drawing.Point(657, 608);
            this.btnAddNewParcel.Name = "btnAddNewParcel";
            this.btnAddNewParcel.Size = new System.Drawing.Size(118, 27);
            this.btnAddNewParcel.TabIndex = 6;
            this.btnAddNewParcel.Text = "Add New";
            this.btnAddNewParcel.UseVisualStyleBackColor = true;
            this.btnAddNewParcel.Click += new System.EventHandler(this.btnAddNewParcel_Click);
            // 
            // dgvParcels
            // 
            this.dgvParcels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcels.Location = new System.Drawing.Point(12, 73);
            this.dgvParcels.Name = "dgvParcels";
            this.dgvParcels.RowTemplate.Height = 24;
            this.dgvParcels.Size = new System.Drawing.Size(1017, 507);
            this.dgvParcels.TabIndex = 7;
            this.dgvParcels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcels_CellContentClick);
            this.dgvParcels.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcels_CellContentClick);
            // 
            // frmMaintainParcels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 657);
            this.Controls.Add(this.dgvParcels);
            this.Controls.Add(this.btnAddNewParcel);
            this.Controls.Add(this.btnMoreDetailsParcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteParcel);
            this.Controls.Add(this.btnUpdateParcel);
            this.Name = "frmMaintainParcels";
            this.Text = "Maintain Parcel";
            this.Load += new System.EventHandler(this.frmMaintainParcels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateParcel;
        private System.Windows.Forms.Button btnDeleteParcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoreDetailsParcel;
        private System.Windows.Forms.Button btnAddNewParcel;
        private System.Windows.Forms.DataGridView dgvParcels;
    }
}