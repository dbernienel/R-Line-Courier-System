namespace R_Line_Courier_System
{
    partial class frmParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMaintainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parcelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allocateParcelsToVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliverParcelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalParcelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblUserLogged = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintainToolStripMenuItem,
            this.rToolStripMenuItem,
            this.reportingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // maintainToolStripMenuItem
            // 
            this.maintainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.parcelsToolStripMenuItem,
            this.vehiclesToolStripMenuItem,
            this.regionToolStripMenuItem,
            this.deliveriesToolStripMenuItem});
            this.maintainToolStripMenuItem.Name = "maintainToolStripMenuItem";
            this.maintainToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.maintainToolStripMenuItem.Text = "Maintain";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.viewMaintainToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem1.Text = "Add new";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddToolStripMenuItem1_Click);
            // 
            // viewMaintainToolStripMenuItem
            // 
            this.viewMaintainToolStripMenuItem.Name = "viewMaintainToolStripMenuItem";
            this.viewMaintainToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewMaintainToolStripMenuItem.Text = "View & Maintain";
            this.viewMaintainToolStripMenuItem.Click += new System.EventHandler(this.ViewMaintainToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.maintainToolStripMenuItem1});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.addToolStripMenuItem2.Text = "Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.AddToolStripMenuItem2_Click);
            // 
            // maintainToolStripMenuItem1
            // 
            this.maintainToolStripMenuItem1.Name = "maintainToolStripMenuItem1";
            this.maintainToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.maintainToolStripMenuItem1.Text = "Maintain";
            this.maintainToolStripMenuItem1.Click += new System.EventHandler(this.MaintainToolStripMenuItem1_Click);
            // 
            // parcelsToolStripMenuItem
            // 
            this.parcelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.parcelsToolStripMenuItem.Name = "parcelsToolStripMenuItem";
            this.parcelsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.parcelsToolStripMenuItem.Text = "Parcels";
            this.parcelsToolStripMenuItem.Click += new System.EventHandler(this.parcelsToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addToolStripMenuItem.Text = "Add new";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteToolStripMenuItem.Text = "View  & Maintain";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.maintainVehiclesToolStripMenuItem});
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addVehicleToolStripMenuItem.Text = "Add vehicle";
            this.addVehicleToolStripMenuItem.Click += new System.EventHandler(this.AddVehicleToolStripMenuItem_Click);
            // 
            // maintainVehiclesToolStripMenuItem
            // 
            this.maintainVehiclesToolStripMenuItem.Name = "maintainVehiclesToolStripMenuItem";
            this.maintainVehiclesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.maintainVehiclesToolStripMenuItem.Text = "Maintain vehicles";
            this.maintainVehiclesToolStripMenuItem.Click += new System.EventHandler(this.MaintainVehiclesToolStripMenuItem_Click);
            // 
            // regionToolStripMenuItem
            // 
            this.regionToolStripMenuItem.Name = "regionToolStripMenuItem";
            this.regionToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.regionToolStripMenuItem.Text = "Region";
            this.regionToolStripMenuItem.Click += new System.EventHandler(this.RegionToolStripMenuItem_Click);
            // 
            // deliveriesToolStripMenuItem
            // 
            this.deliveriesToolStripMenuItem.Name = "deliveriesToolStripMenuItem";
            this.deliveriesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deliveriesToolStripMenuItem.Text = "Deliveries";
            this.deliveriesToolStripMenuItem.Click += new System.EventHandler(this.DeliveriesToolStripMenuItem_Click);
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allocateParcelsToVehiclesToolStripMenuItem,
            this.deliverParcelsToolStripMenuItem});
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.rToolStripMenuItem.Text = "Deliveries";
            // 
            // allocateParcelsToVehiclesToolStripMenuItem
            // 
            this.allocateParcelsToVehiclesToolStripMenuItem.Name = "allocateParcelsToVehiclesToolStripMenuItem";
            this.allocateParcelsToVehiclesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.allocateParcelsToVehiclesToolStripMenuItem.Text = "Allocate parcels to vehicles";
            this.allocateParcelsToVehiclesToolStripMenuItem.Click += new System.EventHandler(this.AllocateParcelsToVehiclesToolStripMenuItem_Click);
            // 
            // deliverParcelsToolStripMenuItem
            // 
            this.deliverParcelsToolStripMenuItem.Name = "deliverParcelsToolStripMenuItem";
            this.deliverParcelsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.deliverParcelsToolStripMenuItem.Text = "Deliver parcels";
            this.deliverParcelsToolStripMenuItem.Click += new System.EventHandler(this.DeliverParcelsToolStripMenuItem_Click);
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportingToolStripMenuItem1,
            this.historicalParcelsToolStripMenuItem});
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.reportingToolStripMenuItem.Text = "Reporting";
            this.reportingToolStripMenuItem.Click += new System.EventHandler(this.ReportingToolStripMenuItem_Click);
            // 
            // reportingToolStripMenuItem1
            // 
            this.reportingToolStripMenuItem1.Name = "reportingToolStripMenuItem1";
            this.reportingToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.reportingToolStripMenuItem1.Text = "Parcels out for delivery";
            this.reportingToolStripMenuItem1.Click += new System.EventHandler(this.ReportingToolStripMenuItem1_Click);
            // 
            // historicalParcelsToolStripMenuItem
            // 
            this.historicalParcelsToolStripMenuItem.Name = "historicalParcelsToolStripMenuItem";
            this.historicalParcelsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.historicalParcelsToolStripMenuItem.Text = "Historical parcels";
            this.historicalParcelsToolStripMenuItem.Click += new System.EventHandler(this.HistoricalParcelsToolStripMenuItem_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUser.Controls.Add(this.btnSignOut);
            this.pnlUser.Controls.Add(this.lblUserLogged);
            this.pnlUser.Location = new System.Drawing.Point(848, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(261, 24);
            this.pnlUser.TabIndex = 4;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(183, 0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 1;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // lblUserLogged
            // 
            this.lblUserLogged.AutoSize = true;
            this.lblUserLogged.Location = new System.Drawing.Point(6, 5);
            this.lblUserLogged.Name = "lblUserLogged";
            this.lblUserLogged.Size = new System.Drawing.Size(71, 13);
            this.lblUserLogged.TabIndex = 0;
            this.lblUserLogged.Text = "Logged in as:";
            this.lblUserLogged.Click += new System.EventHandler(this.Label1_Click);
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1109, 591);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmParent";
            this.Text = "R-Line Courier System - Scaled Symmetry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmParent_Activated);
            this.Load += new System.EventHandler(this.FrmParent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocateParcelsToVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliverParcelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parcelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewMaintainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem maintainToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem regionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicalParcelsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblUserLogged;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.ToolStripMenuItem deliveriesToolStripMenuItem;
    }
}

