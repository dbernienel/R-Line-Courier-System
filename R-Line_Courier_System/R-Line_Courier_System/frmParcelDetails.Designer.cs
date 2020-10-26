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
            this.components = new System.ComponentModel.Container();
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
            this.tbxStreetNumber = new System.Windows.Forms.TextBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudLenght = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.ttDueDate = new System.Windows.Forms.ToolTip(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.ttDeliveryStatus = new System.Windows.Forms.ToolTip(this.components);
            this.ttDelivered = new System.Windows.Forms.ToolTip(this.components);
            this.ttCompanyName = new System.Windows.Forms.ToolTip(this.components);
            this.ttClear = new System.Windows.Forms.ToolTip(this.components);
            this.ttBuildingName = new System.Windows.Forms.ToolTip(this.components);
            this.ttContactNum = new System.Windows.Forms.ToolTip(this.components);
            this.gbClientInfo.SuspendLayout();
            this.gbDeliveryInfo.SuspendLayout();
            this.gbDeliveryAdress.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
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
            this.gbClientInfo.Location = new System.Drawing.Point(347, 71);
            this.gbClientInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbClientInfo.Name = "gbClientInfo";
            this.gbClientInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbClientInfo.Size = new System.Drawing.Size(378, 190);
            this.gbClientInfo.TabIndex = 2;
            this.gbClientInfo.TabStop = false;
            this.gbClientInfo.Text = "Client Info";
            // 
            // tbxClientContactNr
            // 
            this.tbxClientContactNr.Location = new System.Drawing.Point(128, 99);
            this.tbxClientContactNr.Margin = new System.Windows.Forms.Padding(2);
            this.tbxClientContactNr.Mask = "(999) 000-0000";
            this.tbxClientContactNr.Name = "tbxClientContactNr";
            this.tbxClientContactNr.Size = new System.Drawing.Size(117, 20);
            this.tbxClientContactNr.TabIndex = 9;
            // 
            // tbxClientSurname
            // 
            this.tbxClientSurname.Location = new System.Drawing.Point(225, 67);
            this.tbxClientSurname.Margin = new System.Windows.Forms.Padding(2);
            this.tbxClientSurname.Name = "tbxClientSurname";
            this.tbxClientSurname.Size = new System.Drawing.Size(140, 20);
            this.tbxClientSurname.TabIndex = 8;
            this.tbxClientSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxClientSurname_KeyPress);
            // 
            // tbxClientName
            // 
            this.tbxClientName.Location = new System.Drawing.Point(82, 67);
            this.tbxClientName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxClientName.Name = "tbxClientName";
            this.tbxClientName.Size = new System.Drawing.Size(76, 20);
            this.tbxClientName.TabIndex = 7;
            this.tbxClientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxClientName_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Client contact number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Client Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name*";
            // 
            // cbCompanyName
            // 
            this.cbCompanyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCompanyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCompanyName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbCompanyName.FormattingEnabled = true;
            this.cbCompanyName.Location = new System.Drawing.Point(100, 36);
            this.cbCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.cbCompanyName.Name = "cbCompanyName";
            this.cbCompanyName.Size = new System.Drawing.Size(202, 21);
            this.cbCompanyName.TabIndex = 6;
            this.ttCompanyName.SetToolTip(this.cbCompanyName, "Indicate which company initiated the delivery process");
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
            this.gbDeliveryInfo.Location = new System.Drawing.Point(21, 71);
            this.gbDeliveryInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbDeliveryInfo.Name = "gbDeliveryInfo";
            this.gbDeliveryInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbDeliveryInfo.Size = new System.Drawing.Size(322, 190);
            this.gbDeliveryInfo.TabIndex = 1;
            this.gbDeliveryInfo.TabStop = false;
            this.gbDeliveryInfo.Text = "Delivery info";
            // 
            // cbDeliveryStatus
            // 
            this.cbDeliveryStatus.ForeColor = System.Drawing.Color.Black;
            this.cbDeliveryStatus.FormattingEnabled = true;
            this.cbDeliveryStatus.Location = new System.Drawing.Point(95, 162);
            this.cbDeliveryStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbDeliveryStatus.Name = "cbDeliveryStatus";
            this.cbDeliveryStatus.Size = new System.Drawing.Size(92, 21);
            this.cbDeliveryStatus.TabIndex = 5;
            this.ttDeliveryStatus.SetToolTip(this.cbDeliveryStatus, "Choose the current state of the parcel (i.e. In Warehouse)");
            this.cbDeliveryStatus.SelectedIndexChanged += new System.EventHandler(this.cbDeliveryStatus_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 165);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Delivery status*";
            // 
            // tbxRecipientAltContactNr
            // 
            this.tbxRecipientAltContactNr.Location = new System.Drawing.Point(149, 131);
            this.tbxRecipientAltContactNr.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRecipientAltContactNr.Mask = "(999) 000-0000";
            this.tbxRecipientAltContactNr.Name = "tbxRecipientAltContactNr";
            this.tbxRecipientAltContactNr.Size = new System.Drawing.Size(111, 20);
            this.tbxRecipientAltContactNr.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Alternative contact number";
            // 
            // dateDueDelivery
            // 
            this.dateDueDelivery.Location = new System.Drawing.Point(106, 33);
            this.dateDueDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.dateDueDelivery.Name = "dateDueDelivery";
            this.dateDueDelivery.Size = new System.Drawing.Size(200, 20);
            this.dateDueDelivery.TabIndex = 1;
            this.ttDueDate.SetToolTip(this.dateDueDelivery, "ttDueDate");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Due delivery date*";
            // 
            // tbxRecipientContactNr
            // 
            this.tbxRecipientContactNr.Location = new System.Drawing.Point(149, 102);
            this.tbxRecipientContactNr.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRecipientContactNr.Mask = "(999) 000-0000";
            this.tbxRecipientContactNr.Name = "tbxRecipientContactNr";
            this.tbxRecipientContactNr.Size = new System.Drawing.Size(111, 20);
            this.tbxRecipientContactNr.TabIndex = 3;
            this.ttContactNum.SetToolTip(this.tbxRecipientContactNr, "Indicate the number to use for cointacting the recipient");
            // 
            // tbxRecepientName
            // 
            this.tbxRecepientName.Location = new System.Drawing.Point(106, 64);
            this.tbxRecepientName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRecepientName.Name = "tbxRecepientName";
            this.tbxRecepientName.Size = new System.Drawing.Size(76, 20);
            this.tbxRecepientName.TabIndex = 2;
            this.tbxRecepientName.TextChanged += new System.EventHandler(this.tbxRecepientName_TextChanged);
            this.tbxRecepientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRecepientName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recepient contact number*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Recepient Name*";
            // 
            // gbDeliveryAdress
            // 
            this.gbDeliveryAdress.Controls.Add(this.tbxStreetNumber);
            this.gbDeliveryAdress.Controls.Add(this.tbxStreetName);
            this.gbDeliveryAdress.Controls.Add(this.tbxBuildingName);
            this.gbDeliveryAdress.Controls.Add(this.label12);
            this.gbDeliveryAdress.Controls.Add(this.cbPostalCode);
            this.gbDeliveryAdress.Controls.Add(this.label11);
            this.gbDeliveryAdress.Controls.Add(this.label10);
            this.gbDeliveryAdress.Controls.Add(this.label8);
            this.gbDeliveryAdress.Location = new System.Drawing.Point(21, 265);
            this.gbDeliveryAdress.Margin = new System.Windows.Forms.Padding(2);
            this.gbDeliveryAdress.Name = "gbDeliveryAdress";
            this.gbDeliveryAdress.Padding = new System.Windows.Forms.Padding(2);
            this.gbDeliveryAdress.Size = new System.Drawing.Size(322, 124);
            this.gbDeliveryAdress.TabIndex = 3;
            this.gbDeliveryAdress.TabStop = false;
            this.gbDeliveryAdress.Text = "Delivery Street Adress";
            // 
            // tbxStreetNumber
            // 
            this.tbxStreetNumber.Location = new System.Drawing.Point(18, 50);
            this.tbxStreetNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStreetNumber.Name = "tbxStreetNumber";
            this.tbxStreetNumber.Size = new System.Drawing.Size(40, 20);
            this.tbxStreetNumber.TabIndex = 10;
            // 
            // tbxStreetName
            // 
            this.tbxStreetName.Location = new System.Drawing.Point(106, 49);
            this.tbxStreetName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStreetName.Name = "tbxStreetName";
            this.tbxStreetName.Size = new System.Drawing.Size(76, 20);
            this.tbxStreetName.TabIndex = 11;
            this.tbxStreetName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxStreetName_KeyPress);
            // 
            // tbxBuildingName
            // 
            this.tbxBuildingName.Location = new System.Drawing.Point(16, 94);
            this.tbxBuildingName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxBuildingName.Name = "tbxBuildingName";
            this.tbxBuildingName.Size = new System.Drawing.Size(76, 20);
            this.tbxBuildingName.TabIndex = 13;
            this.ttBuildingName.SetToolTip(this.tbxBuildingName, "Indicate the name of the delivery buidling or complex");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 78);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Complex/Buidling Name";
            // 
            // cbPostalCode
            // 
            this.cbPostalCode.FormattingEnabled = true;
            this.cbPostalCode.Location = new System.Drawing.Point(202, 47);
            this.cbPostalCode.Margin = new System.Windows.Forms.Padding(2);
            this.cbPostalCode.Name = "cbPostalCode";
            this.cbPostalCode.Size = new System.Drawing.Size(92, 21);
            this.cbPostalCode.TabIndex = 12;
            this.cbPostalCode.SelectedIndexChanged += new System.EventHandler(this.cbPostalCode_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Street Name*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Street Number*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Postal Code*";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(645, 402);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 31);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(456, 402);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(68, 31);
            this.btnApply.TabIndex = 18;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(550, 402);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 31);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.ttClear.SetToolTip(this.btnClear, "Clear the entire form");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.nudLenght);
            this.groupBox1.Controls.Add(this.nudWidth);
            this.groupBox1.Controls.Add(this.nudHeight);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.nudWeight);
            this.groupBox1.Location = new System.Drawing.Point(348, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parcel dimentions";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(132, 92);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "mm";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(300, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "mm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(300, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "mm";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Parcel length";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(174, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Oracel width";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(174, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Parcel height";
            // 
            // nudLenght
            // 
            this.nudLenght.Location = new System.Drawing.Point(6, 85);
            this.nudLenght.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLenght.Name = "nudLenght";
            this.nudLenght.Size = new System.Drawing.Size(120, 20);
            this.nudLenght.TabIndex = 16;
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(174, 41);
            this.nudWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 20);
            this.nudWidth.TabIndex = 15;
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(174, 85);
            this.nudHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(120, 20);
            this.nudHeight.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(132, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "kg";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Parcel weight";
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 4;
            this.nudWeight.Location = new System.Drawing.Point(6, 41);
            this.nudWeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(120, 20);
            this.nudWeight.TabIndex = 14;
            // 
            // ttDueDate
            // 
            this.ttDueDate.AutomaticDelay = 2;
            this.ttDueDate.AutoPopDelay = 100000;
            this.ttDueDate.InitialDelay = 2;
            this.ttDueDate.ReshowDelay = 0;
            this.ttDueDate.Tag = "Select date before which the parcel needs to be delivered";
            this.ttDueDate.ToolTipTitle = "Due Date";
            this.ttDueDate.UseFading = false;
            this.ttDueDate.Popup += new System.Windows.Forms.PopupEventHandler(this.ttDueDate_Popup);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(162, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Required fields are marked with *";
            // 
            // ttDeliveryStatus
            // 
            this.ttDeliveryStatus.AutomaticDelay = 2;
            this.ttDeliveryStatus.AutoPopDelay = 100000;
            this.ttDeliveryStatus.InitialDelay = 2;
            this.ttDeliveryStatus.ReshowDelay = 0;
            this.ttDeliveryStatus.Tag = "Select date before which the parcel needs to be delivered";
            this.ttDeliveryStatus.ToolTipTitle = "Delivery Status";
            this.ttDeliveryStatus.UseFading = false;
            // 
            // ttDelivered
            // 
            this.ttDelivered.AutomaticDelay = 2;
            this.ttDelivered.AutoPopDelay = 100000;
            this.ttDelivered.InitialDelay = 2;
            this.ttDelivered.ReshowDelay = 0;
            this.ttDelivered.Tag = "";
            this.ttDelivered.ToolTipTitle = "Delivered";
            this.ttDelivered.UseFading = false;
            // 
            // ttCompanyName
            // 
            this.ttCompanyName.AutomaticDelay = 2;
            this.ttCompanyName.AutoPopDelay = 100000;
            this.ttCompanyName.InitialDelay = 2;
            this.ttCompanyName.ReshowDelay = 0;
            this.ttCompanyName.Tag = "Select date before which the parcel needs to be delivered";
            this.ttCompanyName.ToolTipTitle = "Company Name";
            this.ttCompanyName.UseFading = false;
            // 
            // ttClear
            // 
            this.ttClear.AutomaticDelay = 2;
            this.ttClear.AutoPopDelay = 100000;
            this.ttClear.InitialDelay = 2;
            this.ttClear.ReshowDelay = 0;
            this.ttClear.Tag = "Select date before which the parcel needs to be delivered";
            this.ttClear.ToolTipTitle = "Clear all fields";
            this.ttClear.UseFading = false;
            // 
            // ttBuildingName
            // 
            this.ttBuildingName.AutomaticDelay = 2;
            this.ttBuildingName.AutoPopDelay = 100000;
            this.ttBuildingName.InitialDelay = 2;
            this.ttBuildingName.ReshowDelay = 0;
            this.ttBuildingName.Tag = "Select date before which the parcel needs to be delivered";
            this.ttBuildingName.ToolTipTitle = "Complex/Building";
            this.ttBuildingName.UseFading = false;
            // 
            // ttContactNum
            // 
            this.ttContactNum.AutomaticDelay = 2;
            this.ttContactNum.AutoPopDelay = 100000;
            this.ttContactNum.InitialDelay = 2;
            this.ttContactNum.ReshowDelay = 0;
            this.ttContactNum.Tag = "Select date before which the parcel needs to be delivered";
            this.ttContactNum.ToolTipTitle = "Recipient Contact Number";
            this.ttContactNum.UseFading = false;
            // 
            // frmParcelDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 445);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbDeliveryInfo);
            this.Controls.Add(this.gbClientInfo);
            this.Controls.Add(this.gbDeliveryAdress);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmParcelDetails";
            this.Text = "Parcel Details";
            this.Load += new System.EventHandler(this.frmParcelDetails_Load);
            this.gbClientInfo.ResumeLayout(false);
            this.gbClientInfo.PerformLayout();
            this.gbDeliveryInfo.ResumeLayout(false);
            this.gbDeliveryInfo.PerformLayout();
            this.gbDeliveryAdress.ResumeLayout(false);
            this.gbDeliveryAdress.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox tbxStreetNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip ttDueDate;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudLenght;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ToolTip ttDelivered;
        private System.Windows.Forms.ToolTip ttDeliveryStatus;
        private System.Windows.Forms.ToolTip ttContactNum;
        private System.Windows.Forms.ToolTip ttBuildingName;
        private System.Windows.Forms.ToolTip ttClear;
        private System.Windows.Forms.ToolTip ttCompanyName;
    }
}