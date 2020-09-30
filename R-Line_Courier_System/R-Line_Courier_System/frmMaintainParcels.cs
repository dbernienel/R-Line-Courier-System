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
        private String conString;
        private String myQuery;


        public frmMaintainParcels()
        {
            InitializeComponent();
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kobus\Documents\GitHub\R-Line-Courier-System\R-Line_Courier_System\R-Line_Courier_System\RLine_Database.mdf;Integrated Security=True";
        }

        private void btnAddNewParcel_Click(object sender, EventArgs e)
        {
            frmMaintainParcels maintain = this;
            frmParcelDetails details = new frmParcelDetails(maintain);
            details.disableButton(true);
            details.Show();

            con.Close();
        }

        private void btnUpdateParcel_Click(object sender, EventArgs e)
        {
            frmMaintainParcels maintain = this;
            frmParcelDetails details = new frmParcelDetails(maintain);
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

            RefreshDGV();

            con.Close();

        }

        private void btnMoreDetailsParcel_Click(object sender, EventArgs e)
        {
            //to do: show more complete view of data in parcel db
            frmMaintainParcels maintain = new frmMaintainParcels();
            maintain.dateCheck();
        }

        private void frmMaintainParcels_Load(object sender, EventArgs e)
        {
            dateCheck();
        }

        private void dgvParcels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshDGV() {
            dgvParcels.ClearSelection();
            con = new SqlConnection(conString);
            con.Open();
            sd = new SqlDataAdapter(myQuery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvParcels.DataSource = dt;
            con.Close();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            myQuery = "";
            con = new SqlConnection(conString);


            if (tbxSearch.Text != "") {
                myQuery = searchQuery();
                RefreshDGV();
            }
            else {
                dateCheck();
            }

            
        }

        private String searchQuery() {
            int search;
            String stringSearch;
            String myQuery;
            String contactNumber = tbxSearch.Text;

            if (contactNumber.Length < 10)
            {
                contactNumber = contactNumber + "__________";
                contactNumber = contactNumber.Substring(0, 9);
            }

            if (int.TryParse(tbxSearch.Text, out search)) {
                stringSearch = search.ToString();
            }
            else {
                stringSearch = tbxSearch.Text;
            }

            myQuery = "SELECT * FROM PARCELS WHERE (Parcel_ID LIKE '" + search.ToString() + "%' " +
                    "OR Parcel_Weight LIKE '" + search.ToString() + "%' " +
                    "OR Parcel_Length LIKE '" + search.ToString() + "%' " +
                    "OR Parcel_Width LIKE '" + search.ToString() + "%' " +
                    "OR Parcel_Height LIKE '" + search.ToString() + "%' " +
                    "OR Delivery_ID LIKE '" + search.ToString() + "%' " +
                    "OR Delivery_Street_Number LIKE '" + stringSearch + "%' " +
                    "OR  Delivery_Street_Name LIKE '" + stringSearch + "%' " +
                    "OR Delivery_Complex_Building LIKE '" + stringSearch + "%' " +
                    "OR Contact_No LIKE '(%" + contactNumber.Substring(0, 3) + "%) %" + contactNumber.Substring(3, 3) + "%-%" + contactNumber.Substring(6) + "%' " +
                    "OR Alt_Contact_No LIKE '(%" + contactNumber.Substring(0, 3) + "%) %" + contactNumber.Substring(3, 3) + "%-%" + contactNumber.Substring(6) + "%' "+
                    "OR  Recipient_Name LIKE '" + stringSearch + "%') " +
                    "AND Delivery_Due_Date >= '" + dateFrom.Value.ToShortDateString() + "' " +
                    "AND Delivery_Due_Date <= '" + dateTo.Value.ToShortDateString() + "'";


            return myQuery;
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            dateCheck();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            dateCheck();
        }

        public void dateCheck() { 
            myQuery = "";
            con = new SqlConnection(conString);
            con.Open();

            myQuery = "SELECT * FROM PARCELS WHERE Delivery_Due_Date >= '" + dateFrom.Value.ToShortDateString() + "' " +
                "AND Delivery_Due_Date <= '" + dateTo.Value.ToShortDateString() + "'";

            RefreshDGV();
        }
    }
}
