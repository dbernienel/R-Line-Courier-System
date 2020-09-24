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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddNewParcel = new System.Windows.Forms.Button();
            this.btnDeleteParcel = new System.Windows.Forms.Button();
            this.btnUpdateParcel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(366, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddNewParcel
            // 
            this.btnAddNewParcel.Location = new System.Drawing.Point(20, 392);
            this.btnAddNewParcel.Name = "btnAddNewParcel";
            this.btnAddNewParcel.Size = new System.Drawing.Size(118, 27);
            this.btnAddNewParcel.TabIndex = 9;
            this.btnAddNewParcel.Text = "Add New";
            this.btnAddNewParcel.UseVisualStyleBackColor = true;
            this.btnAddNewParcel.Click += new System.EventHandler(this.btnAddNewParcel_Click);
            // 
            // btnDeleteParcel
            // 
            this.btnDeleteParcel.Location = new System.Drawing.Point(268, 390);
            this.btnDeleteParcel.Name = "btnDeleteParcel";
            this.btnDeleteParcel.Size = new System.Drawing.Size(118, 29);
            this.btnDeleteParcel.TabIndex = 8;
            this.btnDeleteParcel.Text = "Delete";
            this.btnDeleteParcel.UseVisualStyleBackColor = true;
            // 
            // btnUpdateParcel
            // 
            this.btnUpdateParcel.Location = new System.Drawing.Point(144, 390);
            this.btnUpdateParcel.Name = "btnUpdateParcel";
            this.btnUpdateParcel.Size = new System.Drawing.Size(118, 29);
            this.btnUpdateParcel.TabIndex = 7;
            this.btnUpdateParcel.Text = "Update";
            this.btnUpdateParcel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search";
            // 
            // frmMaintainClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddNewParcel);
            this.Controls.Add(this.btnDeleteParcel);
            this.Controls.Add(this.btnUpdateParcel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMaintainClient";
            this.Text = "Maintain Clients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddNewParcel;
        private System.Windows.Forms.Button btnDeleteParcel;
        private System.Windows.Forms.Button btnUpdateParcel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}