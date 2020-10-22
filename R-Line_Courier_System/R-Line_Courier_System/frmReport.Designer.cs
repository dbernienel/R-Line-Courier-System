namespace R_Line_Courier_System
{
    partial class frmReport
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
            this.btnExport = new System.Windows.Forms.Button();
            this.rbDelivered = new System.Windows.Forms.RadioButton();
            this.rbUndelivered = new System.Windows.Forms.RadioButton();
            this.gbDeliver = new System.Windows.Forms.GroupBox();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dvgReport = new System.Windows.Forms.DataGridView();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.gbDeliver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(44, 367);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rbDelivered
            // 
            this.rbDelivered.AutoSize = true;
            this.rbDelivered.Location = new System.Drawing.Point(18, 19);
            this.rbDelivered.Name = "rbDelivered";
            this.rbDelivered.Size = new System.Drawing.Size(70, 17);
            this.rbDelivered.TabIndex = 1;
            this.rbDelivered.TabStop = true;
            this.rbDelivered.Text = "Delivered";
            this.rbDelivered.UseVisualStyleBackColor = true;
            this.rbDelivered.CheckedChanged += new System.EventHandler(this.RbDelivered_CheckedChanged);
            // 
            // rbUndelivered
            // 
            this.rbUndelivered.AutoSize = true;
            this.rbUndelivered.Location = new System.Drawing.Point(103, 19);
            this.rbUndelivered.Name = "rbUndelivered";
            this.rbUndelivered.Size = new System.Drawing.Size(82, 17);
            this.rbUndelivered.TabIndex = 2;
            this.rbUndelivered.TabStop = true;
            this.rbUndelivered.Text = "Undelivered";
            this.rbUndelivered.UseVisualStyleBackColor = true;
            this.rbUndelivered.CheckedChanged += new System.EventHandler(this.RbUndelivered_CheckedChanged);
            // 
            // gbDeliver
            // 
            this.gbDeliver.Controls.Add(this.rbDelivered);
            this.gbDeliver.Controls.Add(this.rbUndelivered);
            this.gbDeliver.Location = new System.Drawing.Point(44, 22);
            this.gbDeliver.Name = "gbDeliver";
            this.gbDeliver.Size = new System.Drawing.Size(200, 49);
            this.gbDeliver.TabIndex = 3;
            this.gbDeliver.TabStop = false;
            this.gbDeliver.Text = "Select";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Location = new System.Drawing.Point(147, 135);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTo.TabIndex = 4;
            this.dateTimeTo.ValueChanged += new System.EventHandler(this.DateTimeTo_ValueChanged);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Location = new System.Drawing.Point(147, 90);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFrom.TabIndex = 5;
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.DateTimeFrom_ValueChanged);
            // 
            // dvgReport
            // 
            this.dvgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgReport.Location = new System.Drawing.Point(44, 179);
            this.dvgReport.Name = "dvgReport";
            this.dvgReport.Size = new System.Drawing.Size(485, 150);
            this.dvgReport.TabIndex = 6;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(44, 96);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(59, 13);
            this.lblDateFrom.TabIndex = 7;
            this.lblDateFrom.Text = "Date From:";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(44, 141);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(49, 13);
            this.lblDateTo.TabIndex = 8;
            this.lblDateTo.Text = "Date To:";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.dvgReport);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.gbDeliver);
            this.Controls.Add(this.btnExport);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.gbDeliver.ResumeLayout(false);
            this.gbDeliver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.RadioButton rbDelivered;
        private System.Windows.Forms.RadioButton rbUndelivered;
        private System.Windows.Forms.GroupBox gbDeliver;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.DataGridView dvgReport;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
    }
}