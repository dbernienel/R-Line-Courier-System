namespace R_Line_Courier_System
{
    partial class frmMaintainDeliveries
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteDelivery = new System.Windows.Forms.Button();
            this.btnUpdateDelivery = new System.Windows.Forms.Button();
            this.dgvDelivery = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(310, 321);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 19;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(54, 14);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(76, 20);
            this.tbxSearch.TabIndex = 17;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnDeleteDelivery
            // 
            this.btnDeleteDelivery.Location = new System.Drawing.Point(106, 320);
            this.btnDeleteDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteDelivery.Name = "btnDeleteDelivery";
            this.btnDeleteDelivery.Size = new System.Drawing.Size(88, 24);
            this.btnDeleteDelivery.TabIndex = 15;
            this.btnDeleteDelivery.Text = "Delete";
            this.btnDeleteDelivery.UseVisualStyleBackColor = true;
            this.btnDeleteDelivery.Click += new System.EventHandler(this.btnDeleteDelivery_Click);
            // 
            // btnUpdateDelivery
            // 
            this.btnUpdateDelivery.Location = new System.Drawing.Point(14, 320);
            this.btnUpdateDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateDelivery.Name = "btnUpdateDelivery";
            this.btnUpdateDelivery.Size = new System.Drawing.Size(88, 24);
            this.btnUpdateDelivery.TabIndex = 14;
            this.btnUpdateDelivery.Text = "Update";
            this.btnUpdateDelivery.UseVisualStyleBackColor = true;
            this.btnUpdateDelivery.Click += new System.EventHandler(this.btnUpdateDelivery_Click);
            // 
            // dgvDelivery
            // 
            this.dgvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelivery.Location = new System.Drawing.Point(11, 36);
            this.dgvDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDelivery.Name = "dgvDelivery";
            this.dgvDelivery.RowHeadersWidth = 51;
            this.dgvDelivery.RowTemplate.Height = 24;
            this.dgvDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelivery.Size = new System.Drawing.Size(429, 280);
            this.dgvDelivery.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(198, 320);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 24);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMaintainDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 362);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnDeleteDelivery);
            this.Controls.Add(this.btnUpdateDelivery);
            this.Controls.Add(this.dgvDelivery);
            this.Name = "frmMaintainDeliveries";
            this.Text = "Maintain Deliveries";
            this.Load += new System.EventHandler(this.frmMaintainDeliveries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnDeleteDelivery;
        private System.Windows.Forms.Button btnUpdateDelivery;
        private System.Windows.Forms.DataGridView dgvDelivery;
        private System.Windows.Forms.Button btnRefresh;
    }
}