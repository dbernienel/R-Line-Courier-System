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
            frmMaintainParcels parcels = new frmMaintainParcels();
            frmParent frmParent = this;
            parcels.MdiParent = frmParent;
            parcels.Show();
        }
    }
}
