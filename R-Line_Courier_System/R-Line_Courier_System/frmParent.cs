using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R_Line_Courier_System
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
            frmLogin Login = new frmLogin();
            Login.MdiParent = this;
            Login.StartPosition = FormStartPosition.CenterScreen;
            Login.Show();
        }

        private void FrmParent_Activated(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void parcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainParcels parcels = new frmMaintainParcels();
            frmParcelDetails details = new frmParcelDetails(parcels, true);
            frmParent parent = this;
            details.MdiParent = parent;
            details.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainParcels parcel = new frmMaintainParcels();
            frmParent parent = this;
            parcel.MdiParent = parent;
            parcel.Show();
        }

        private void MaintainVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchVehicles searchVehicle = new frmSearchVehicles();
            frmParent parent = this;
            searchVehicle.MdiParent = parent;
            searchVehicle.Show();
        }

        private void AddNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainVehicles vehicle = new frmMaintainVehicles();
            frmParent parent = this;
            vehicle.setMode("add");
            vehicle.clearForm();
            vehicle.MdiParent = parent;
            vehicle.Show();
        }

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainUsers users = new frmMaintainUsers();
            frmParent parent = this;
            users.setMode("add");
            users.clearForm();
            users.MdiParent = parent;
            users.Show();
        }

        private void MaintainUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchUser searchUsers = new frmSearchUser();
            frmParent parent = this;
            searchUsers.MdiParent = parent;
            searchUsers.Show();
        }

        private void AddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //add new user
            frmMaintainUsers users = new frmMaintainUsers();
            frmParent parent = this;
            users.setMode("add");
            users.clearForm();
            users.MdiParent = parent;
            users.Show();
        }

        private void MaintainToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //maintain user
            frmSearchUser searchUsers = new frmSearchUser();
            frmParent parent = this;
            searchUsers.MdiParent = parent;
            searchUsers.Show();
        }

        private void AddVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //add vehicle
            frmMaintainVehicles vehicle = new frmMaintainVehicles();
            frmParent parent = this;
            vehicle.setMode("add");
            vehicle.clearForm();
            vehicle.MdiParent = parent;
            vehicle.Show();
        }

        private void MaintainVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        //maintain vehicle
            frmSearchVehicles searchVehicle = new frmSearchVehicles();
            frmParent parent = this;
            searchVehicle.MdiParent = parent;
            searchVehicle.Show();
        }

        private void maintainRegionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainRegions regions = new frmMaintainRegions();
            regions.Show();
        }

        private void addCitypostalCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegionDetails regions = new frmRegionDetails();
            regions.Show();
        }

        private void RegionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegionDetails regionDetails = new frmRegionDetails();
            frmParent parent = this;
            regionDetails.MdiParent = parent;
            regionDetails.Show();
        }

        private void ViewMaintainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainClient maintainClient = new frmMaintainClient();
            frmParent parent = this;
            maintainClient.MdiParent = parent;
            maintainClient.Show();
        }

        private void ReportingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDeliveryReport deliveryReport = new frmDeliveryReport();
            frmParent parent = this;
            deliveryReport.MdiParent = parent;
            deliveryReport.Show();
        }

        private void deliverParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allocateParcelsToVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssignParcels assign = new frmAssignParcels();
            assign.Show();
        }

        private void frmParent_Load(object sender, EventArgs e)
        {

        }

    }
}
