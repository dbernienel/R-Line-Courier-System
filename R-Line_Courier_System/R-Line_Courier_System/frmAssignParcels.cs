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
    public partial class frmAssignParcels : Form
    {
        private SqlConnection con;
        private String myQuery;
        private String conString;
        private SqlDataAdapter sd;
        private String defaultQuery;
        private DataSet ds;
        private SqlCommand cmd;
        private int userID;

        public frmAssignParcels(int iD)
        {   
            userID = iD;
            InitializeComponent();
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
        }

        private void frmAssignParcels_Load(object sender, EventArgs e)
        {
            defaultQuery = "SELECT a.Parcel_ID, b.Postal_Code, c.City_Name, a.Delivery_Due_Date, d.Company_Name " +
                "FROM PARCELS a " +
                "LEFT JOIN POSTAL_CODE b ON a.Postal_Code_ID = b.Postal_Code_ID " +
                "JOIN CITY c ON b.City_ID = c.City_ID " +
                "LEFT JOIN CLIENTS d ON a.Client_ID = d.Client_ID ";
            dataChange();
            populateComboBox();
            btnAddParcel.Enabled = false;
            btnRemoveParcel.Enabled = false;
        }

        private void RefreshDGV()
        {
            dgvParcels.ClearSelection();
            con = new SqlConnection(conString);
            con.Open();
            sd = new SqlDataAdapter(myQuery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvParcels.DataSource = dt;
            con.Close();
        }

        public void dataChange()
        {
            myQuery = defaultQuery+ "WHERE a.Delivered = 'False' AND a.Delivery_ID IS NULL";
            RefreshDGV();
        }

        private void populateComboBox()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM VEHICLES", con);
            DataSet ds = new DataSet();

            cbDeliveryVehicle.DisplayMember = "Reg_No";
            cbDeliveryVehicle.ValueMember = "Vehicle_ID";
            da.Fill(ds);
            cbDeliveryVehicle.DataSource = ds.Tables[0];
            con.Close();
            cbDeliveryVehicle.SelectedItem = null;
        }

        private void populateListbox()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT a.Parcel_ID FROM PARCELS a LEFT JOIN DELIVERIES b ON a.Delivery_ID = b.Delivery_ID WHERE b.Vehicle_ID = " + cbDeliveryVehicle.SelectedValue + " AND b.Delivery_Date = '" + dateDeliveryDate.Value.ToShortDateString() + "'", con);
            ds = new DataSet();

            lbxParcels.DisplayMember = "Parcel_ID";
            lbxParcels.ValueMember = "Parcel_ID";
            da.Fill(ds);
            lbxParcels.DataSource = ds.Tables[0];
            con.Close();
        }

        private void tbxSearchParcels_TextChanged(object sender, EventArgs e)
        {
            myQuery = "";
            con = new SqlConnection(conString);


            if (tbxSearchParcels.Text != "")
            {
                myQuery = searchQuery();
                RefreshDGV();
            }
            else
            {
                dataChange();
            }
        }

        private String searchQuery()
        {
            int search;
            String stringSearch;
            myQuery = "";

            if (int.TryParse(tbxSearchParcels.Text, out search))
            {
                stringSearch = search.ToString();
            }
            else
            {
                search = -1;
                stringSearch = tbxSearchParcels.Text;
            }

            myQuery = defaultQuery + "WHERE a.Delivered LIKE 'False' " +
                    "OR a.Parcel_ID LIKE '" + stringSearch + "%' " +
                    "OR b.Postal_Code LIKE '" + stringSearch + "%' " +
                    "OR c.City_Name LIKE '" + stringSearch + "%' " +
                    "OR d.Company_Name LIKE '" + stringSearch + "%'";


            return myQuery;
        }

        private void cbDeliveryVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed && cbDeliveryVehicle.SelectedItem != null) {
                populateListbox();
                if (dateDeliveryDate.Value >= DateTime.Now.AddDays(-1)){
                    btnAddParcel.Enabled = true;
                }
                else { btnAddParcel.Enabled = false; }
                if (lbxParcels.SelectedValue == null)
                {
                    btnRemoveParcel.Enabled = false;
                }
                else { btnRemoveParcel.Enabled = true; }
            }
            //if (lbxParcels.Items.Count == 0 && cbDeliveryVehicle.SelectedItem != null)
            //    btnDeleteCity.Enabled = true;
            //else { btnDeleteCity.Enabled = false; }
        }

        private void btnAddParcel_Click(object sender, EventArgs e)
        {
            if (lbxParcels.Items.Count == 0 && !compareRecords(cbDeliveryVehicle.SelectedValue.ToString(), dateDeliveryDate.Value.ToShortDateString()))
            {
                addDelivery("INSERT INTO DELIVERIES(Vehicle_ID,Delivery_Date,User_ID) VALUES(" + cbDeliveryVehicle.SelectedValue.ToString() + ",'" + dateDeliveryDate.Value.ToShortDateString() + "',1)");
                updateParcels(dgvParcels.SelectedCells[0].Value.ToString(), getDeliveryID());
            }
            else {
                updateParcels(dgvParcels.SelectedCells[0].Value.ToString(), getDeliveryID());
            }

            btnRemoveParcel.Enabled = true;

            populateListbox();
            dataChange();
        }

        public bool compareRecords(String record1, String record2) {
            bool exists = false;
            String query = "SELECT COUNT(*) FROM DELIVERIES WHERE Vehicle_ID = " + record1 + " AND Delivery_Date ='" + record2 + "'";
            con.Open();
            cmd = new SqlCommand(query, con);
            int dataCount = (int)cmd.ExecuteScalar();
            if (dataCount > 0)
                exists = true;
            con.Close();

            return exists;
        }

        private void updateParcels(String parcelID, String deliveryID) {
            cmd = new SqlCommand("UPDATE PARCELS SET Delivery_ID = " + deliveryID + " WHERE Parcel_ID = " + parcelID, con );
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void addDelivery(String query) {
            SqlCommand cmd = new SqlCommand("INSERT INTO DELIVERIES(Vehicle_ID,Delivery_Date) VALUES(" + cbDeliveryVehicle.SelectedValue.ToString() + ",'" + dateDeliveryDate.Value.ToShortDateString() + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private String getDeliveryID() {
            String deliveryID;
            con.Open();
            cmd = new SqlCommand("SELECT Delivery_ID FROM DELIVERIES WHERE Vehicle_ID = " + cbDeliveryVehicle.SelectedValue.ToString() + " AND Delivery_Date = '" + dateDeliveryDate.Value.ToShortDateString() + "'", con);
            deliveryID = cmd.ExecuteScalar().ToString();
            con.Close();
            return deliveryID;
        }

        private void dateDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            if(cbDeliveryVehicle.SelectedValue != null)
                populateListbox();
            if (dateDeliveryDate.Value >= DateTime.Now.AddDays(-1)) {
                btnAddParcel.Enabled = true;
            }
            else { btnAddParcel.Enabled = false; }
            if (lbxParcels.SelectedValue == null) {
                btnRemoveParcel.Enabled = false;
            }
            else { btnRemoveParcel.Enabled = true; }
        }

        private void btnRemoveParcel_Click(object sender, EventArgs e)
        {
            updateParcels(lbxParcels.SelectedValue.ToString(), "NULL");
            dataChange();
            populateListbox();
            if (lbxParcels.SelectedValue == null)
            {
                btnRemoveParcel.Enabled = false;
            }
        }
    }
}
