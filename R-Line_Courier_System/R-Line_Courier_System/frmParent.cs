/****************************/
/*GJ Oberholzer 27227928
/*DB Nel    27347435
/****************************/


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
        private bool adminUser;
        private int userID;
        private String username;

        public frmParent()
        {
            InitializeComponent();
        }

        private void FrmParent_Activated(object sender, EventArgs e)
        {


        }

        private void openLoginForm()
        {
            using (var login = new frmLogin())
            {
                var result = login.ShowDialog();
                if (result == DialogResult.OK)
                {
                    userID = login.userID;
                    adminUser = login.adminP;
                    username = login.username;

                    setUser(userID, adminUser, username);
                }
            }
        }

        public void setUser(int user_ID, bool admin, string user_Name)
        {

            if (user_Name != "")
            {
                enableMenu();
                lblUserLogged.Text = "Logged in as " + user_Name;
                userID = user_ID;
                adminUser = admin;
                btnSignOut.Text = "Log out";
            }
            else
            {
                disableMenu();
                userID = -1;
                adminUser = false;
                lblUserLogged.Text = "Please log in";
                btnSignOut.Text = "Log in";
            }
        }

        public int getUserID()
        {
            return userID;
        }

        public bool getUserAdmin()
        {
            return adminUser;
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
            frmMaintainParcels parcels = new frmMaintainParcels(getUserID());
            frmParcelDetails details = new frmParcelDetails(parcels, true, getUserID());
            frmParent parent = this;
            details.MdiParent = parent;
            details.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainParcels parcel = new frmMaintainParcels(getUserID());
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
            frmSearchUser user = new frmSearchUser();
            frmMaintainUsers users = new frmMaintainUsers(user);
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
            if (getUserAdmin() == false)
            {
                MessageBox.Show("Access denied: Only admin users have access to this feature");
            }
            else
            {
                frmSearchUser user = new frmSearchUser();
                frmMaintainUsers users = new frmMaintainUsers(user);
                frmParent parent = this;
                users.setMode("add");
                users.clearForm();
                users.MdiParent = parent;
                users.Show();
            }
        }

        private void MaintainToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //maintain user
            if (getUserAdmin() == false)
            {
                MessageBox.Show("Access denied: Only admin users have access to this feature");
            }
            else
            {
                frmSearchUser searchUsers = new frmSearchUser();
                frmParent parent = this;
                searchUsers.MdiParent = parent;
                searchUsers.Show();
            }
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

        private void HistoricalParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            frmParent parent = this;
            report.MdiParent = parent;
            report.Show();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ReportingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {

            setUser(-1, false, "");
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmParent")
                    Application.OpenForms[i].Close();
            }
            openLoginForm();
        }


        private void frmParent_Load(object sender, EventArgs e)
        {
            disableMenu();
        }


        private void FrmParent_Load(object sender, EventArgs e)
        {
            //no user logged in on startup
            setUser(-1, false, "");
            disableMenu();
            openLoginForm();

        }

        private void AllocateParcelsToVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssignParcels maintain = new frmAssignParcels(getUserID());
            frmParent parent = this;
            maintain.MdiParent = parent;
            maintain.Show();
        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMaintainClient maintain = new frmMaintainClient();
            frmParent parent = this;
            maintain.MdiParent = parent;
            frmClientDetails details = new frmClientDetails(maintain, true);
            details.MdiParent = parent;
            details.Show();
        }

        private void DeliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainDeliveries maintain = new frmMaintainDeliveries(getUserID());
            frmParent parent = this;
            maintain.MdiParent = parent;
            maintain.Show();
        }

        private void DeliverParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeliverParcels deliver = new frmDeliverParcels();
            frmParent parent = this;
            deliver.MdiParent = parent;
            deliver.Show();
        }

        private void disableMenu()
        {
            maintainToolStripMenuItem.Enabled = false;
            maintainToolStripMenuItem1.Enabled = false;
            rToolStripMenuItem.Enabled = false;
            reportingToolStripMenuItem.Enabled = false;
        }

        private void enableMenu()
        {
            maintainToolStripMenuItem.Enabled = true;
            maintainToolStripMenuItem1.Enabled = true;
            rToolStripMenuItem.Enabled = true;
            reportingToolStripMenuItem.Enabled = true;
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setUser(-1, false, "");
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmParent")
                    Application.OpenForms[i].Close();
            }
            openLoginForm();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
