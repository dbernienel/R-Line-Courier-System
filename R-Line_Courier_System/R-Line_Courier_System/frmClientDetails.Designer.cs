namespace R_Line_Courier_System
{
    partial class frmClientDetails
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
            this.gbClientInfo = new System.Windows.Forms.GroupBox();
            this.tbxClientContactNr = new System.Windows.Forms.MaskedTextBox();
            this.tbxClientSurname = new System.Windows.Forms.TextBox();
            this.tbxClientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.gbClientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClientInfo
            // 
            this.gbClientInfo.Controls.Add(this.tbxCompanyName);
            this.gbClientInfo.Controls.Add(this.tbxClientContactNr);
            this.gbClientInfo.Controls.Add(this.tbxClientSurname);
            this.gbClientInfo.Controls.Add(this.tbxClientName);
            this.gbClientInfo.Controls.Add(this.label5);
            this.gbClientInfo.Controls.Add(this.label4);
            this.gbClientInfo.Controls.Add(this.label3);
            this.gbClientInfo.Controls.Add(this.label1);
            this.gbClientInfo.Location = new System.Drawing.Point(12, 57);
            this.gbClientInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClientInfo.Name = "gbClientInfo";
            this.gbClientInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClientInfo.Size = new System.Drawing.Size(504, 234);
            this.gbClientInfo.TabIndex = 3;
            this.gbClientInfo.TabStop = false;
            this.gbClientInfo.Text = "Client Info";
            // 
            // tbxClientContactNr
            // 
            this.tbxClientContactNr.Location = new System.Drawing.Point(165, 122);
            this.tbxClientContactNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxClientContactNr.Mask = "(999) 000-0000";
            this.tbxClientContactNr.Name = "tbxClientContactNr";
            this.tbxClientContactNr.Size = new System.Drawing.Size(155, 22);
            this.tbxClientContactNr.TabIndex = 9;
            // 
            // tbxClientSurname
            // 
            this.tbxClientSurname.Location = new System.Drawing.Point(300, 82);
            this.tbxClientSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxClientSurname.Name = "tbxClientSurname";
            this.tbxClientSurname.Size = new System.Drawing.Size(185, 22);
            this.tbxClientSurname.TabIndex = 8;
            // 
            // tbxClientName
            // 
            this.tbxClientName.Location = new System.Drawing.Point(109, 82);
            this.tbxClientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxClientName.Name = "tbxClientName";
            this.tbxClientName.Size = new System.Drawing.Size(100, 22);
            this.tbxClientName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Client contact number*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Surname*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Client Name*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name*";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(279, 320);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 38);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(150, 320);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(91, 38);
            this.btnApply.TabIndex = 22;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(406, 320);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 38);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 24);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(204, 16);
            this.label22.TabIndex = 25;
            this.label22.Text = "Required fields are marked with *";
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.Location = new System.Drawing.Point(138, 37);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.Size = new System.Drawing.Size(171, 22);
            this.tbxCompanyName.TabIndex = 10;
            // 
            // frmClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 366);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbClientInfo);
            this.Name = "frmClientDetails";
            this.Text = "Client Details";
            this.gbClientInfo.ResumeLayout(false);
            this.gbClientInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClientInfo;
        private System.Windows.Forms.MaskedTextBox tbxClientContactNr;
        private System.Windows.Forms.TextBox tbxClientSurname;
        private System.Windows.Forms.TextBox tbxClientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbxCompanyName;
    }
}