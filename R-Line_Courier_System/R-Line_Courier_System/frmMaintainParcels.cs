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
        private String queryAjustment;
        private int userID;


        public frmMaintainParcels(int iD) {
            InitializeComponent();
            userID = iD;
            setQueryAjustment();

            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
        }

        public void setQueryAjustment() { 
            queryAjustment = "SELECT a.Parcel_ID, c.Company_Name, a.Delivery_Due_Date, b.Status_Description, a.Parcel_Weight, a.Parcel_Length, a.Parcel_Width, a.Parcel_Height, a.Delivery_Street_Number, a.Delivery_Street_Name, a.Delivery_Complex_Building, d.Postal_Code, a.Contact_No, a.Alt_Contact_No, a.Delivered, a.Recipient_Name, e.User_Name, e.User_Surname, c.Client_ID, b.Status_ID, d.Postal_Code_ID, a.Delivery_ID " +
                        "FROM PARCELS a " +
                        "LEFT JOIN PARCEL_STATUS b ON a.Status_ID = b.Status_ID " +
                        "LEFT JOIN CLIENTS AS c ON a.Client_ID = c.Client_ID " +
                        "LEFT JOIN POSTAL_CODE AS d ON a.Postal_Code_ID = d.Postal_Code_ID " +
                        "LEFT JOIN USERS AS e ON a.User_ID = e.User_ID";
        }

        public String getQueryAjustment() {
            return queryAjustment;
        }

        private void btnAddNewParcel_Click(object sender, EventArgs e)
        {
            frmMaintainParcels maintain = this;
            frmParcelDetails details = new frmParcelDetails(maintain, true, userID);
            details.Show();

            con.Close();
        }

        private void btnUpdateParcel_Click(object sender, EventArgs e) {
            frmMaintainParcels maintain = this;
            if (Int32.TryParse(dgvParcels.SelectedCells[0].Value.ToString(), out int i)) {
                frmParcelDetails details = new frmParcelDetails(maintain, false, userID);
                details.setParcelID(dgvParcels.SelectedCells[0].Value.ToString());
                details.autoFillForm();
                details.Show();
            }
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
            frmMaintainParcels maintain = new frmMaintainParcels(userID);
            maintain.dateCheck();
        }

        private void frmMaintainParcels_Load(object sender, EventArgs e)
        {
            dgvParcels.ReadOnly = true;
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
            dgvParcels.Columns["Client_ID"].Visible = false;
            dgvParcels.Columns["Postal_Code_ID"].Visible = false;
            dgvParcels.Columns["Status_ID"].Visible = false;
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
            myQuery = "";
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
                search = -1;
                stringSearch = tbxSearch.Text;
            }

            myQuery = getQueryAjustment() + " WHERE (Parcel_ID LIKE '" + search.ToString() + "%' " +
                    "OR b.Status_Description LIKE '" + stringSearch + "%' " +
                    "OR c.Company_Name LIKE '" + stringSearch + "%' " +
                    "OR d.Postal_Code LIKE '" + stringSearch + "%' " +
                    "OR e.User_Name LIKE '" + stringSearch + "%' " + 
                    "OR e.User_Surname LIKE '" + stringSearch + "%' " +
                    "OR a.Parcel_Weight LIKE '" + search.ToString() + "%' " +
                    "OR a.Parcel_Length LIKE '" + search.ToString() + "%' " +
                    "OR a.Parcel_Width LIKE '" + search.ToString() + "%' " +
                    "OR a.Parcel_Height LIKE '" + search.ToString() + "%' " +
                    "OR a.Delivery_ID LIKE '" + search.ToString() + "%' " +
                    "OR a.Delivery_Street_Number LIKE '" + stringSearch + "%' " +
                    "OR a.Delivery_Street_Name LIKE '" + stringSearch + "%' " +
                    "OR a.Delivery_Complex_Building LIKE '" + stringSearch + "%' " +
                    "OR a.Contact_No LIKE '(%" + contactNumber.Substring(0, 3) + "%) %" + contactNumber.Substring(3, 3) + "%-%" + contactNumber.Substring(6) + "%' " +
                    "OR a.Alt_Contact_No LIKE '(%" + contactNumber.Substring(0, 3) + "%) %" + contactNumber.Substring(3, 3) + "%-%" + contactNumber.Substring(6) + "%' "+
                    "OR a.Recipient_Name LIKE '" + stringSearch + "%') " +
                    "AND a.Delivery_Due_Date >= '" + dateFrom.Value.ToShortDateString() + "' " +
                    "AND a.Delivery_Due_Date <= '" + dateTo.Value.ToShortDateString() + "'";


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

            myQuery = getQueryAjustment() + " WHERE Delivery_Due_Date >= '" + dateFrom.Value.ToShortDateString() + "' " +
                "AND Delivery_Due_Date <= '" + dateTo.Value.ToShortDateString() + "'";

            RefreshDGV();
        }
    }
}
