namespace R_Line_Courier_System
{
    partial class frmRegionDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.lbPostalCodes = new System.Windows.Forms.ListBox();
            this.tbxPostalCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addPostalCode = new System.Windows.Forms.Button();
            this.btnDeletePostalCodes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.addCity = new System.Windows.Forms.Button();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(51, 55);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 24);
            this.cbCity.TabIndex = 1;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // lbPostalCodes
            // 
            this.lbPostalCodes.FormattingEnabled = true;
            this.lbPostalCodes.ItemHeight = 16;
            this.lbPostalCodes.Location = new System.Drawing.Point(16, 101);
            this.lbPostalCodes.Name = "lbPostalCodes";
            this.lbPostalCodes.Size = new System.Drawing.Size(156, 276);
            this.lbPostalCodes.TabIndex = 2;
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.Location = new System.Drawing.Point(307, 101);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.Size = new System.Drawing.Size(100, 22);
            this.tbxPostalCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Postal Code";
            // 
            // addPostalCode
            // 
            this.addPostalCode.Location = new System.Drawing.Point(307, 129);
            this.addPostalCode.Name = "addPostalCode";
            this.addPostalCode.Size = new System.Drawing.Size(75, 23);
            this.addPostalCode.TabIndex = 5;
            this.addPostalCode.Text = "Add";
            this.addPostalCode.UseVisualStyleBackColor = true;
            this.addPostalCode.Click += new System.EventHandler(this.addPostalCode_Click);
            // 
            // btnDeletePostalCodes
            // 
            this.btnDeletePostalCodes.Location = new System.Drawing.Point(16, 384);
            this.btnDeletePostalCodes.Name = "btnDeletePostalCodes";
            this.btnDeletePostalCodes.Size = new System.Drawing.Size(103, 36);
            this.btnDeletePostalCodes.TabIndex = 6;
            this.btnDeletePostalCodes.Text = "Delete code";
            this.btnDeletePostalCodes.UseVisualStyleBackColor = true;
            this.btnDeletePostalCodes.Click += new System.EventHandler(this.btnDeletePostalCodes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "City";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(307, 173);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(100, 22);
            this.tbxCity.TabIndex = 8;
            // 
            // addCity
            // 
            this.addCity.Location = new System.Drawing.Point(307, 202);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(75, 23);
            this.addCity.TabIndex = 9;
            this.addCity.Text = "Add";
            this.addCity.UseVisualStyleBackColor = true;
            this.addCity.Click += new System.EventHandler(this.addCity_Click);
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.Location = new System.Drawing.Point(125, 383);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(103, 36);
            this.btnDeleteCity.TabIndex = 10;
            this.btnDeleteCity.Text = "Delete city";
            this.btnDeleteCity.UseVisualStyleBackColor = true;
            this.btnDeleteCity.Click += new System.EventHandler(this.btnDeleteCity_Click);
            // 
            // frmRegionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 442);
            this.Controls.Add(this.btnDeleteCity);
            this.Controls.Add(this.addCity);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeletePostalCodes);
            this.Controls.Add(this.addPostalCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPostalCode);
            this.Controls.Add(this.lbPostalCodes);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.label1);
            this.Name = "frmRegionDetails";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.frmRegionDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ListBox lbPostalCodes;
        private System.Windows.Forms.TextBox tbxPostalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPostalCode;
        private System.Windows.Forms.Button btnDeletePostalCodes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Button addCity;
        private System.Windows.Forms.Button btnDeleteCity;
    }
}