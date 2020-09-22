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
    public partial class frmParcelDetails : Form
    {
        public frmParcelDetails()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //to do: create function to clear all field types
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //to do: load all values to database
        }

        private void cbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to do: auto fill all fields if value exist in Clients db else, add new client to Client db
            //to do: disable controls in ControlBox after selection
        }

        private void cbPostalCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to do: load Postal_Codes to ComboBox
        }
    }
}
