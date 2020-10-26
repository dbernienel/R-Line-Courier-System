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
    public partial class frmDeliverParcels : Form
    {
        private String myQuery;
        private String conString;
        private SqlConnection con;
        private SqlDataAdapter sd;
        private DataTable dt;

        public frmDeliverParcels()
        {
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
            InitializeComponent();
        }

        private void frmDeliverParcels_Load(object sender, EventArgs e)
        {
            //dgvParcels.ReadOnly = true;
            dataChange();
            dgvParcels.Columns["Parcel_ID"].ReadOnly = true;
            dgvParcels.Columns["Delivery_Street_NUmber"].ReadOnly = true;
            dgvParcels.Columns["Delivery_Street_Name"].ReadOnly = true;
            dgvParcels.Columns["Delivery_Complex_Building"].ReadOnly = true;
            dgvParcels.Columns["City_Name"].ReadOnly = true;
            dgvParcels.Columns["Recipient_Name"].ReadOnly = true;
            dgvParcels.Columns["Contact_No"].ReadOnly = true;
            dgvParcels.Columns["Alt_Contact_No"].ReadOnly = true;
        }

        private void RefreshDGV()
        {
            con = new SqlConnection(conString);
            con.Open();
            sd = new SqlDataAdapter(myQuery, con);
            dt = new DataTable();
            sd.Fill(dt);
            dgvParcels.DataSource = dt;
            con.Close();
        }

        public void dataChange()
        {
            myQuery = "SELECT a.Delivered, a.Parcel_ID, a.Delivery_Street_Number, a.Delivery_Street_Name, a.Delivery_Complex_Building, b.City_Name, a.Recipient_Name, a.Contact_No, a.Alt_Contact_No " +
                "FROM PARCELS a " +
                "LEFT JOIN POSTAL_CODE c ON a.Postal_Code_ID = c.Postal_Code_ID " +
                "LEFT JOIN CITY b ON c.City_ID = b.City_ID " +
                "WHERE a.Delivered = 0";
            RefreshDGV();
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        private void dgvParcels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            myQuery = "UPDATE PARCELS SET Delivered = '" + dgvParcels.SelectedCells[0].Value.ToString() + "' WHERE Delivery_ID = " + dgvParcels.SelectedCells[1].Value.ToString();
            RefreshDGV();
        }
    }
}
