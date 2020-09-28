using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace R_Line_Courier_System
{
    public partial class frmMaintainParcels : Form
    {

        public SqlConnection con;
        public SqlDataAdapter sd;
        public DataSet ds;
        public DataTable dt;
        private String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kobus\Documents\GitHub\R-Line-Courier-System\R-Line_Courier_System\R-Line_Courier_System\RLine_Database.mdf;Integrated Security=True";


        public frmMaintainParcels()
        {
            InitializeComponent();
        }

        private void btnAddNewParcel_Click(object sender, EventArgs e)
        {
            frmParcelDetails details = new frmParcelDetails();
            details.disableButton(true);
            details.Show();

            con.Close();
        }

        private void btnUpdateParcel_Click(object sender, EventArgs e)
        {
            frmParcelDetails details = new frmParcelDetails();
            details.setParcelID(dgvParcels.SelectedCells[0].Value.ToString());
            details.autoFillForm();
            details.disableButton(false);
            details.Show();

            //to do: fill frmParcelDetails fields with selected data entry

        }

        private void btnDeleteParcel_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(conString);

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM PARCELS WHERE Parcel_ID="+ dgvParcels.SelectedCells[0].Value.ToString(), con);
            cmd.ExecuteNonQuery();

            refreshDGV();

            con.Close();

        }

        private void btnMoreDetailsParcel_Click(object sender, EventArgs e)
        {
            //to do: show more complete view of data in parcel db
        }

        private void frmMaintainParcels_Load(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void dgvParcels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void refreshDGV() {
            con = new SqlConnection(conString);
            con.Open();
            sd = new SqlDataAdapter("SELECT * FROM PARCELS", con);
            ds = new DataSet();
            sd.Fill(ds, "PARCELS");
            dgvParcels.DataSource = ds.Tables[0];
        }
    }
}
