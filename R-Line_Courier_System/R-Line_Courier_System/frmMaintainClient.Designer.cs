namespace R_Line_Courier_System
{
    partial class frmMaintainClient
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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnAddNewParcel = new System.Windows.Forms.Button();
            this.btnDeleteParcel = new System.Windows.Forms.Button();
            this.btnUpdateParcel = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(15, 32);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(274, 280);
            this.dgvClients.TabIndex = 0;
            // 
            // btnAddNewParcel
            // 
            this.btnAddNewParcel.Location = new System.Drawing.Point(15, 318);
            this.btnAddNewParcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewParcel.Name = "btnAddNewParcel";
            this.btnAddNewParcel.Size = new System.Drawing.Size(88, 22);
            this.btnAddNewParcel.TabIndex = 9;
            this.btnAddNewParcel.Text = "Add New";
            this.btnAddNewParcel.UseVisualStyleBackColor = true;
            this.btnAddNewParcel.Click += new System.EventHandler(this.btnAddNewParcel_Click);
            // 
            // btnDeleteParcel
            // 
            this.btnDeleteParcel.Location = new System.Drawing.Point(201, 317);
            this.btnDeleteParcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteParcel.Name = "btnDeleteParcel";
            this.btnDeleteParcel.Size = new System.Drawing.Size(88, 24);
            this.btnDeleteParcel.TabIndex = 8;
            this.btnDeleteParcel.Text = "Delete";
            this.btnDeleteParcel.UseVisualStyleBackColor = true;
            this.btnDeleteParcel.Click += new System.EventHandler(this.btnDeleteParcel_Click);
            // 
            // btnUpdateParcel
            // 
            this.btnUpdateParcel.Location = new System.Drawing.Point(108, 317);
            this.btnUpdateParcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateParcel.Name = "btnUpdateParcel";
            this.btnUpdateParcel.Size = new System.Drawing.Size(88, 24);
            this.btnUpdateParcel.TabIndex = 7;
            this.btnUpdateParcel.Text = "Update";
            this.btnUpdateParcel.UseVisualStyleBackColor = true;
            this.btnUpdateParcel.Click += new System.EventHandler(this.btnUpdateParcel_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(58, 10);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(76, 20);
            this.tbxSearch.TabIndex = 10;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search";
            // 
            // frmMaintainClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnAddNewParcel);
            this.Controls.Add(this.btnDeleteParcel);
            this.Controls.Add(this.btnUpdateParcel);
            this.Controls.Add(this.dgvClients);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMaintainClient";
            this.Text = "Maintain Clients";
            this.Load += new System.EventHandler(this.frmMaintainClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnAddNewParcel;
        private System.Windows.Forms.Button btnDeleteParcel;
        private System.Windows.Forms.Button btnUpdateParcel;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label1;
    }
}