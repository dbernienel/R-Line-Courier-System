namespace R_Line_Courier_System
{
    partial class frmDeliverParcels
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
            this.btnApply = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateParcels = new System.Windows.Forms.DateTimePicker();
            this.cbDeliveryVehicle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParcels
            // 
            this.dgvParcels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcels.Location = new System.Drawing.Point(12, 35);
            this.dgvParcels.Name = "dgvParcels";
            this.dgvParcels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcels.Size = new System.Drawing.Size(664, 260);
            this.dgvParcels.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(601, 301);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Deliver";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(83, 9);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // dateParcels
            // 
            this.dateParcels.Location = new System.Drawing.Point(198, 9);
            this.dateParcels.Name = "dateParcels";
            this.dateParcels.Size = new System.Drawing.Size(200, 20);
            this.dateParcels.TabIndex = 4;
            this.dateParcels.ValueChanged += new System.EventHandler(this.dateParcels_ValueChanged);
            // 
            // cbDeliveryVehicle
            // 
            this.cbDeliveryVehicle.FormattingEnabled = true;
            this.cbDeliveryVehicle.Location = new System.Drawing.Point(451, 8);
            this.cbDeliveryVehicle.Name = "cbDeliveryVehicle";
            this.cbDeliveryVehicle.Size = new System.Drawing.Size(121, 21);
            this.cbDeliveryVehicle.TabIndex = 5;
            this.cbDeliveryVehicle.SelectedIndexChanged += new System.EventHandler(this.cbDeliveryVehicle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vehicle";
            // 
            // frmDeliverParcels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDeliveryVehicle);
            this.Controls.Add(this.dateParcels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.dgvParcels);
            this.Name = "frmDeliverParcels";
            this.Text = "Deliver Parcels";
            this.Load += new System.EventHandler(this.frmDeliverParcels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParcels;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateParcels;
        private System.Windows.Forms.ComboBox cbDeliveryVehicle;
        private System.Windows.Forms.Label label2;
    }
}