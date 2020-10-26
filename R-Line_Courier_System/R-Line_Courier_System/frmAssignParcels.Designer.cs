namespace R_Line_Courier_System
{
    partial class frmAssignParcels
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
            this.dgvParcels = new System.Windows.Forms.DataGridView();
            this.lbxParcels = new System.Windows.Forms.ListBox();
            this.tbxSearchParcels = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddParcel = new System.Windows.Forms.Button();
            this.btnRemoveParcel = new System.Windows.Forms.Button();
            this.cbDeliveryVehicle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDeliveryDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParcels
            // 
            this.dgvParcels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcels.Location = new System.Drawing.Point(12, 72);
            this.dgvParcels.Name = "dgvParcels";
            this.dgvParcels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcels.Size = new System.Drawing.Size(218, 319);
            this.dgvParcels.TabIndex = 0;
            // 
            // lbxParcels
            // 
            this.lbxParcels.FormattingEnabled = true;
            this.lbxParcels.Location = new System.Drawing.Point(339, 72);
            this.lbxParcels.Name = "lbxParcels";
            this.lbxParcels.Size = new System.Drawing.Size(219, 316);
            this.lbxParcels.TabIndex = 1;
            this.lbxParcels.SelectedIndexChanged += new System.EventHandler(this.lbxParcels_SelectedIndexChanged);
            // 
            // tbxSearchParcels
            // 
            this.tbxSearchParcels.Location = new System.Drawing.Point(91, 49);
            this.tbxSearchParcels.Name = "tbxSearchParcels";
            this.tbxSearchParcels.Size = new System.Drawing.Size(100, 20);
            this.tbxSearchParcels.TabIndex = 2;
            this.tbxSearchParcels.TextChanged += new System.EventHandler(this.tbxSearchParcels_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search parcel";
            // 
            // btnAddParcel
            // 
            this.btnAddParcel.Location = new System.Drawing.Point(245, 118);
            this.btnAddParcel.Name = "btnAddParcel";
            this.btnAddParcel.Size = new System.Drawing.Size(75, 39);
            this.btnAddParcel.TabIndex = 4;
            this.btnAddParcel.Text = "Add parcel";
            this.btnAddParcel.UseVisualStyleBackColor = true;
            this.btnAddParcel.Click += new System.EventHandler(this.btnAddParcel_Click);
            // 
            // btnRemoveParcel
            // 
            this.btnRemoveParcel.Location = new System.Drawing.Point(245, 189);
            this.btnRemoveParcel.Name = "btnRemoveParcel";
            this.btnRemoveParcel.Size = new System.Drawing.Size(75, 40);
            this.btnRemoveParcel.TabIndex = 5;
            this.btnRemoveParcel.Text = "Remove parcel";
            this.btnRemoveParcel.UseVisualStyleBackColor = true;
            this.btnRemoveParcel.Click += new System.EventHandler(this.btnRemoveParcel_Click);
            // 
            // cbDeliveryVehicle
            // 
            this.cbDeliveryVehicle.FormattingEnabled = true;
            this.cbDeliveryVehicle.Location = new System.Drawing.Point(424, 49);
            this.cbDeliveryVehicle.Name = "cbDeliveryVehicle";
            this.cbDeliveryVehicle.Size = new System.Drawing.Size(121, 21);
            this.cbDeliveryVehicle.TabIndex = 6;
            this.cbDeliveryVehicle.SelectedIndexChanged += new System.EventHandler(this.cbDeliveryVehicle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Delivery vehicle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Delivery date";
            // 
            // dateDeliveryDate
            // 
            this.dateDeliveryDate.Location = new System.Drawing.Point(411, 394);
            this.dateDeliveryDate.Name = "dateDeliveryDate";
            this.dateDeliveryDate.Size = new System.Drawing.Size(200, 20);
            this.dateDeliveryDate.TabIndex = 10;
            this.dateDeliveryDate.ValueChanged += new System.EventHandler(this.dateDeliveryDate_ValueChanged);
            // 
            // frmAssignParcels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.dateDeliveryDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDeliveryVehicle);
            this.Controls.Add(this.btnRemoveParcel);
            this.Controls.Add(this.btnAddParcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearchParcels);
            this.Controls.Add(this.lbxParcels);
            this.Controls.Add(this.dgvParcels);
            this.Name = "frmAssignParcels";
            this.Text = "frmAssignParcels";
            this.Load += new System.EventHandler(this.frmAssignParcels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParcels;
        private System.Windows.Forms.ListBox lbxParcels;
        private System.Windows.Forms.TextBox tbxSearchParcels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddParcel;
        private System.Windows.Forms.Button btnRemoveParcel;
        private System.Windows.Forms.ComboBox cbDeliveryVehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDeliveryDate;
    }
}