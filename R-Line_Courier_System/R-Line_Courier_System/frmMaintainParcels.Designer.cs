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
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateParcel
            // 
            this.btnUpdateParcel.Location = new System.Drawing.Point(586, 492);
            this.btnUpdateParcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateParcel.Name = "btnUpdateParcel";
            this.btnUpdateParcel.Size = new System.Drawing.Size(88, 24);
            this.btnUpdateParcel.TabIndex = 3;
            this.btnUpdateParcel.Text = "Update";
            this.btnUpdateParcel.UseVisualStyleBackColor = true;
            this.btnUpdateParcel.Click += new System.EventHandler(this.btnUpdateParcel_Click);
            // 
            // btnDeleteParcel
            // 
            this.btnDeleteParcel.Location = new System.Drawing.Point(679, 492);
            this.btnDeleteParcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteParcel.Name = "btnDeleteParcel";
            this.btnDeleteParcel.Size = new System.Drawing.Size(88, 24);
            this.btnDeleteParcel.TabIndex = 4;
            this.btnDeleteParcel.Text = "Delete";
            this.btnDeleteParcel.UseVisualStyleBackColor = true;
            this.btnDeleteParcel.Click += new System.EventHandler(this.btnDeleteParcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // btnMoreDetailsParcel
            // 
            this.btnMoreDetailsParcel.Location = new System.Drawing.Point(44, 494);
            this.btnMoreDetailsParcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoreDetailsParcel.Name = "btnMoreDetailsParcel";
            this.btnMoreDetailsParcel.Size = new System.Drawing.Size(64, 35);
            this.btnMoreDetailsParcel.TabIndex = 5;
            this.btnMoreDetailsParcel.Text = "More Details";
            this.btnMoreDetailsParcel.UseVisualStyleBackColor = true;
            this.btnMoreDetailsParcel.Click += new System.EventHandler(this.btnMoreDetailsParcel_Click);
            // 
            // btnAddNewParcel
            // 
            this.btnAddNewParcel.Location = new System.Drawing.Point(493, 494);
            this.btnAddNewParcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewParcel.Name = "btnAddNewParcel";
            this.btnAddNewParcel.Size = new System.Drawing.Size(88, 22);
            this.btnAddNewParcel.TabIndex = 2;
            this.btnAddNewParcel.Text = "Add New";
            this.btnAddNewParcel.UseVisualStyleBackColor = true;
            this.btnAddNewParcel.Click += new System.EventHandler(this.btnAddNewParcel_Click);
            // 
            // dgvParcels
            // 
            this.dgvParcels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcels.Location = new System.Drawing.Point(9, 59);
            this.dgvParcels.Margin = new System.Windows.Forms.Padding(2);
            this.dgvParcels.Name = "dgvParcels";
            this.dgvParcels.RowTemplate.Height = 24;
            this.dgvParcels.Size = new System.Drawing.Size(763, 412);
            this.dgvParcels.TabIndex = 5;
            this.dgvParcels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcels_CellContentClick);
            this.dgvParcels.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcels_CellContentClick);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(56, 34);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(208, 34);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateFrom.TabIndex = 6;
            this.dateFrom.Value = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(451, 34);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTo.TabIndex = 7;
            this.dateTo.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "to";
            // 
            // frmMaintainParcels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgvParcels);
            this.Controls.Add(this.btnAddNewParcel);
            this.Controls.Add(this.btnMoreDetailsParcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteParcel);
            this.Controls.Add(this.btnUpdateParcel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMaintainParcels";
            this.Text = " ";
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
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}