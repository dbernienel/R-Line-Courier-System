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
    public partial class frmMaintainParcels : Form
    {
        public frmMaintainParcels()
        {
            InitializeComponent();
        }

        private void btnAddNewParcel_Click(object sender, EventArgs e)
        {
            frmParcelDetails details = new frmParcelDetails();
            details.ShowDialog();
        }

        private void btnUpdateParcel_Click(object sender, EventArgs e)
        {
            frmParcelDetails details = new frmParcelDetails();
            details.ShowDialog();
            //to do: fill frmParcelDetails fields with selected data entry
        }

        private void btnDeleteParcel_Click(object sender, EventArgs e)
        {
            //to do: remove selected entry from parcel db
        }

        private void btnMoreDetailsParcel_Click(object sender, EventArgs e)
        {
            //to do: show more complete view of data in parcel db
        }
    }
}
