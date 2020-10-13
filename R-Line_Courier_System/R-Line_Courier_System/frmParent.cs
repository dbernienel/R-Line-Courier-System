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
        private frmMaintainParcels maintain;

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
            maintain = new frmMaintainParcels();
            frmParent parent = this;
            frmParcelDetails details = new frmParcelDetails(maintain);
            details.disableButton(true);
            details.MdiParent = parent;
            details.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintain = new frmMaintainParcels();
            frmParent parent = this;
            maintain.MdiParent = parent;
            maintain.Show();
        }

        private void frmParent_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMaintainClient client = new frmMaintainClient();
            frmClientDetails details = new frmClientDetails(client);
            frmParent parent = this;
            details.MdiParent = parent;
            details.Show();
        }

        private void viewMaintainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainClient maintain = new frmMaintainClient();
            frmParent parent = this;
            maintain.MdiParent = parent;
            maintain.Show();
        }

        private void maintainVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchVehicles vehicles = new frmSearchVehicles();
            vehicles.Show();
        }

        private void maintainRegionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainRegions regions = new frmMaintainRegions();
            regions.Show();
        }
    }
}
