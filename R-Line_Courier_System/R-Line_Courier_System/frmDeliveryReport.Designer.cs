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
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.cbxRegNo = new System.Windows.Forms.ComboBox();
            this.dateTimeDeliver = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeliveries
            // 
            this.dgvDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveries.Location = new System.Drawing.Point(28, 120);
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.Size = new System.Drawing.Size(743, 243);
            this.dgvDeliveries.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(38, 394);
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
            this.cbxRegNo.Location = new System.Drawing.Point(28, 76);
            this.cbxRegNo.Name = "cbxRegNo";
            this.cbxRegNo.Size = new System.Drawing.Size(121, 21);
            this.cbxRegNo.TabIndex = 2;
            this.cbxRegNo.SelectedIndexChanged += new System.EventHandler(this.CbxRegNo_SelectedIndexChanged);
            // 
            // dateTimeDeliver
            // 
            this.dateTimeDeliver.Location = new System.Drawing.Point(305, 76);
            this.dateTimeDeliver.Name = "dateTimeDeliver";
            this.dateTimeDeliver.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDeliver.TabIndex = 3;
            this.dateTimeDeliver.ValueChanged += new System.EventHandler(this.DateTimeDeliver_ValueChanged);
            // 
            // frmDeliveryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.dateTimeDeliver);
            this.Controls.Add(this.cbxRegNo);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvDeliveries);
            this.Name = "frmDeliveryReport";
            this.Text = "frmDeliveryReport";
            this.Activated += new System.EventHandler(this.FrmDeliveryReport_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeliveries;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cbxRegNo;
        private System.Windows.Forms.DateTimePicker dateTimeDeliver;
    }
}