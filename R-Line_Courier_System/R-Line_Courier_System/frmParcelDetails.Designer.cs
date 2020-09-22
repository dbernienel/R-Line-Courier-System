namespace R_Line_Courier_System
{
    partial class frmParcelDetails
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
            this.cbCompanyName = new System.Windows.Forms.ComboBox();
            this.gbDeliveryInfo = new System.Windows.Forms.GroupBox();
            this.cbDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxRecipientAltContactNr = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateDueDelivery = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxRecipientContactNr = new System.Windows.Forms.MaskedTextBox();
            this.tbxRecepientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbDeliveryAdress = new System.Windows.Forms.GroupBox();
            this.nudStreetNr = new System.Windows.Forms.NumericUpDown();
            this.tbxStreetName = new System.Windows.Forms.TextBox();
            this.tbxBuildingName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbPostalCode = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbClientInfo.SuspendLayout();
            this.gbDeliveryInfo.SuspendLayout();
            this.gbDeliveryAdress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStreetNr)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClientInfo
            // 
            this.gbClientInfo.Controls.Add(this.tbxClientContactNr);
            this.gbClientInfo.Controls.Add(this.tbxClientSurname);
            this.gbClientInfo.Controls.Add(this.tbxClientName);
            this.gbClientInfo.Controls.Add(this.label5);
            this.gbClientInfo.Controls.Add(this.label4);
            this.gbClientInfo.Controls.Add(this.label3);
            this.gbClientInfo.Controls.Add(this.label1);
            this.gbClientInfo.Controls.Add(this.cbCompanyName);
            this.gbClientInfo.Location = new System.Drawing.Point(468, 16);
            this.gbClientInfo.Name = "gbClientInfo";
            this.gbClientInfo.Size = new System.Drawing.Size(529, 234);
            this.gbClientInfo.TabIndex = 0;
            this.gbClientInfo.TabStop = false;
            this.gbClientInfo.Text = "Client Info";
            // 
            // tbxClientContactNr
            // 
            this.tbxClientContactNr.Location = new System.Drawing.Point(170, 122);
            this.tbxClientContactNr.Mask = "(999) 000-0000";
            this.tbxClientContactNr.Name = "tbxClientContactNr";
            this.tbxClientContactNr.Size = new System.Drawing.Size(155, 22);
            this.tbxClientContactNr.TabIndex = 8;
            // 
            // tbxClientSurname
            // 
            this.tbxClientSurname.Location = new System.Drawing.Point(300, 83);
            this.tbxClientSurname.Name = "tbxClientSurname";
            this.tbxClientSurname.Size = new System.Drawing.Size(186, 22);
            this.tbxClientSurname.TabIndex = 7;
            // 
            // tbxClientName
            // 
            this.tbxClientName.Location = new System.Drawing.Point(109, 83);
            this.tbxClientName.Name = "tbxClientName";
            this.tbxClientName.Size = new System.Drawing.Size(100, 22);
            this.tbxClientName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Client contact number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Client Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name";
            // 
            // cbCompanyName
            // 
            this.cbCompanyName.FormattingEnabled = true;
            this.cbCompanyName.Location = new System.Drawing.Point(133, 44);
            this.cbCompanyName.Name = "cbCompanyName";
            this.cbCompanyName.Size = new System.Drawing.Size(268, 24);
            this.cbCompanyName.TabIndex = 0;
            this.cbCompanyName.SelectedIndexChanged += new System.EventHandler(this.cbCompanyName_SelectedIndexChanged);
            // 
            // gbDeliveryInfo
            // 
            this.gbDeliveryInfo.Controls.Add(this.cbDeliveryStatus);
            this.gbDeliveryInfo.Controls.Add(this.label13);
            this.gbDeliveryInfo.Controls.Add(this.tbxRecipientAltContactNr);
            this.gbDeliveryInfo.Controls.Add(this.label9);
            this.gbDeliveryInfo.Controls.Add(this.dateDueDelivery);
            this.gbDeliveryInfo.Controls.Add(this.label6);
            this.gbDeliveryInfo.Controls.Add(this.tbxRecipientContactNr);
            this.gbDeliveryInfo.Controls.Add(this.tbxRecepientName);
            this.gbDeliveryInfo.Controls.Add(this.label2);
            this.gbDeliveryInfo.Controls.Add(this.label7);
            this.gbDeliveryInfo.Location = new System.Drawing.Point(12, 16);
            this.gbDeliveryInfo.Name = "gbDeliveryInfo";
            this.gbDeliveryInfo.Size = new System.Drawing.Size(430, 234);
            this.gbDeliveryInfo.TabIndex = 9;
            this.gbDeliveryInfo.TabStop = false;
            this.gbDeliveryInfo.Text = "Delivery info";
            // 
            // cbDeliveryStatus
            // 
            this.cbDeliveryStatus.FormattingEnabled = true;
            this.cbDeliveryStatus.Location = new System.Drawing.Point(128, 203);
            this.cbDeliveryStatus.Name = "cbDeliveryStatus";
            this.cbDeliveryStatus.Size = new System.Drawing.Size(121, 24);
            this.cbDeliveryStatus.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Delivery status";
            // 
            // tbxRecipientAltContactNr
            // 
            this.tbxRecipientAltContactNr.Location = new System.Drawing.Point(199, 161);
            this.tbxRecipientAltContactNr.Mask = "(999) 000-0000";
            this.tbxRecipientAltContactNr.Name = "tbxRecipientAltContactNr";
            this.tbxRecipientAltContactNr.Size = new System.Drawing.Size(147, 22);
            this.tbxRecipientAltContactNr.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Alternative contact number";
            // 
            // dateDueDelivery
            // 
            this.dateDueDelivery.Location = new System.Drawing.Point(136, 45);
            this.dateDueDelivery.Name = "dateDueDelivery";
            this.dateDueDelivery.Size = new System.Drawing.Size(265, 22);
            this.dateDueDelivery.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Due delivery date";
            // 
            // tbxRecipientContactNr
            // 
            this.tbxRecipientContactNr.Location = new System.Drawing.Point(199, 125);
            this.tbxRecipientContactNr.Mask = "(999) 000-0000";
            this.tbxRecipientContactNr.Name = "tbxRecipientContactNr";
            this.tbxRecipientContactNr.Size = new System.Drawing.Size(147, 22);
            this.tbxRecipientContactNr.TabIndex = 11;
            // 
            // tbxRecepientName
            // 
            this.tbxRecepientName.Location = new System.Drawing.Point(136, 83);
            this.tbxRecepientName.Name = "tbxRecepientName";
            this.tbxRecepientName.Size = new System.Drawing.Size(100, 22);
            this.tbxRecepientName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recepient contact number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Recepient Name";
            // 
            // gbDeliveryAdress
            // 
            this.gbDeliveryAdress.Controls.Add(this.nudStreetNr);
            this.gbDeliveryAdress.Controls.Add(this.tbxStreetName);
            this.gbDeliveryAdress.Controls.Add(this.tbxBuildingName);
            this.gbDeliveryAdress.Controls.Add(this.label12);
            this.gbDeliveryAdress.Controls.Add(this.cbPostalCode);
            this.gbDeliveryAdress.Controls.Add(this.label11);
            this.gbDeliveryAdress.Controls.Add(this.label10);
            this.gbDeliveryAdress.Controls.Add(this.label8);
            this.gbDeliveryAdress.Location = new System.Drawing.Point(12, 265);
            this.gbDeliveryAdress.Name = "gbDeliveryAdress";
            this.gbDeliveryAdress.Size = new System.Drawing.Size(516, 219);
            this.gbDeliveryAdress.TabIndex = 14;
            this.gbDeliveryAdress.TabStop = false;
            this.gbDeliveryAdress.Text = "Delivery Street Adress";
            // 
            // nudStreetNr
            // 
            this.nudStreetNr.Location = new System.Drawing.Point(21, 61);
            this.nudStreetNr.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStreetNr.Name = "nudStreetNr";
            this.nudStreetNr.Size = new System.Drawing.Size(68, 22);
            this.nudStreetNr.TabIndex = 27;
            // 
            // tbxStreetName
            // 
            this.tbxStreetName.Location = new System.Drawing.Point(142, 60);
            this.tbxStreetName.Name = "tbxStreetName";
            this.tbxStreetName.Size = new System.Drawing.Size(100, 22);
            this.tbxStreetName.TabIndex = 26;
            // 
            // tbxBuildingName
            // 
            this.tbxBuildingName.Location = new System.Drawing.Point(21, 116);
            this.tbxBuildingName.Name = "tbxBuildingName";
            this.tbxBuildingName.Size = new System.Drawing.Size(100, 22);
            this.tbxBuildingName.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Complex/Buidling Name";
            // 
            // cbPostalCode
            // 
            this.cbPostalCode.FormattingEnabled = true;
            this.cbPostalCode.Location = new System.Drawing.Point(269, 58);
            this.cbPostalCode.Name = "cbPostalCode";
            this.cbPostalCode.Size = new System.Drawing.Size(121, 24);
            this.cbPostalCode.TabIndex = 10;
            this.cbPostalCode.SelectedIndexChanged += new System.EventHandler(this.cbPostalCode_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Street Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Street Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Postal Code";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(893, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 38);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(661, 445);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(91, 38);
            this.btnApply.TabIndex = 19;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(778, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 38);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmParcelDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 496);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbDeliveryInfo);
            this.Controls.Add(this.gbClientInfo);
            this.Controls.Add(this.gbDeliveryAdress);
            this.Name = "frmParcelDetails";
            this.Text = "Parcel Details";
            this.gbClientInfo.ResumeLayout(false);
            this.gbClientInfo.PerformLayout();
            this.gbDeliveryInfo.ResumeLayout(false);
            this.gbDeliveryInfo.PerformLayout();
            this.gbDeliveryAdress.ResumeLayout(false);
            this.gbDeliveryAdress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStreetNr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClientInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCompanyName;
        private System.Windows.Forms.TextBox tbxClientSurname;
        private System.Windows.Forms.TextBox tbxClientName;
        private System.Windows.Forms.GroupBox gbDeliveryInfo;
        private System.Windows.Forms.TextBox tbxRecepientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPostalCode;
        private System.Windows.Forms.MaskedTextBox tbxClientContactNr;
        private System.Windows.Forms.DateTimePicker dateDueDelivery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tbxRecipientContactNr;
        private System.Windows.Forms.GroupBox gbDeliveryAdress;
        private System.Windows.Forms.NumericUpDown nudStreetNr;
        private System.Windows.Forms.TextBox tbxStreetName;
        private System.Windows.Forms.TextBox tbxBuildingName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox tbxRecipientAltContactNr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDeliveryStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClear;
    }
}