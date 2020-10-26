namespace R_Line_Courier_System
{
    partial class frmDeliveryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeliveryReport));
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.cbxRegNo = new System.Windows.Forms.ComboBox();
            this.dateTimeDeliver = new System.Windows.Forms.DateTimePicker();
            this.lblSelectVehicle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeliveries
            // 
            this.dgvDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveries.Location = new System.Drawing.Point(38, 92);
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveries.Size = new System.Drawing.Size(743, 243);
            this.dgvDeliveries.TabIndex = 0;
            this.dgvDeliveries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDeliveries_CellContentClick);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(38, 374);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbxRegNo
            // 
            this.cbxRegNo.FormattingEnabled = true;
            this.cbxRegNo.Location = new System.Drawing.Point(181, 30);
            this.cbxRegNo.Name = "cbxRegNo";
            this.cbxRegNo.Size = new System.Drawing.Size(121, 21);
            this.cbxRegNo.TabIndex = 2;
            this.cbxRegNo.SelectedIndexChanged += new System.EventHandler(this.CbxRegNo_SelectedIndexChanged);
            // 
            // dateTimeDeliver
            // 
            this.dateTimeDeliver.Location = new System.Drawing.Point(519, 30);
            this.dateTimeDeliver.Name = "dateTimeDeliver";
            this.dateTimeDeliver.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDeliver.TabIndex = 3;
            this.dateTimeDeliver.ValueChanged += new System.EventHandler(this.DateTimeDeliver_ValueChanged);
            // 
            // lblSelectVehicle
            // 
            this.lblSelectVehicle.AutoSize = true;
            this.lblSelectVehicle.Location = new System.Drawing.Point(45, 33);
            this.lblSelectVehicle.Name = "lblSelectVehicle";
            this.lblSelectVehicle.Size = new System.Drawing.Size(77, 13);
            this.lblSelectVehicle.TabIndex = 5;
            this.lblSelectVehicle.Text = "Select vehicle:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(410, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Select delivery date:";
            // 
            // frmDeliveryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSelectVehicle);
            this.Controls.Add(this.dateTimeDeliver);
            this.Controls.Add(this.cbxRegNo);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvDeliveries);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeliveryReport";
            this.Text = "Delivery Report";
            this.Activated += new System.EventHandler(this.FrmDeliveryReport_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeliveries;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cbxRegNo;
        private System.Windows.Forms.DateTimePicker dateTimeDeliver;
        private System.Windows.Forms.Label lblSelectVehicle;
        private System.Windows.Forms.Label lblDate;
    }
}