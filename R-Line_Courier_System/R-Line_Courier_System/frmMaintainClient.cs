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
    public partial class frmMaintainClient : Form
    {
        public frmMaintainClient()
        {
            InitializeComponent();
        }

        private void btnAddNewParcel_Click(object sender, EventArgs e)
        {
            frmClientDetails details = new frmClientDetails();
            details.ShowDialog();
        }
    }
}
