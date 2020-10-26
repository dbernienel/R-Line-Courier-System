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
        private String queryAjustment;

        public frmDeliverParcels()
        {
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
            InitializeComponent();
        }

        private void frmDeliverParcels_Load(object sender, EventArgs e)
        {
            setQueryAjustment();
            dataChange();
            populateComboBox();
            dgvParcels.ReadOnly = true;
        }

        private void RefreshDGV()
        {
            con = new SqlConnection(conString);
            con.Open();
            sd = new SqlDataAdapter(myQuery, con);
            dt = new DataTable();
            try { sd.Fill(dt); } catch (SqlException m) { Console.WriteLine(m.Message); }
            dgvParcels.DataSource = dt;
            con.Close();
        }

        public void dataChange()
        {
            string vehicle = "";
            try { vehicle = cbDeliveryVehicle.SelectedValue.ToString(); } catch (NullReferenceException m) { Console.WriteLine(m.Message); }
            myQuery = "SELECT a.Delivered, a.Parcel_ID, a.Delivery_Street_Number, a.Delivery_Street_Name, a.Delivery_Complex_Building, b.City_Name, a.Recipient_Name, a.Contact_No, a.Alt_Contact_No " +
                "FROM PARCELS a " +
                "LEFT JOIN POSTAL_CODE c ON a.Postal_Code_ID = c.Postal_Code_ID " +
                "LEFT JOIN CITY b ON c.City_ID = b.City_ID " +
                "LEFT JOIN DELIVERIES d ON a.Delivery_ID = d.Delivery_ID " +
                "WHERE a.Delivered = 0 " +
                "AND d.Delivery_Date = '" + dateParcels.Value.ToShortDateString() + "' " +
                "AND d.Vehicle_ID = " + vehicle;
            RefreshDGV();
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            myQuery = "UPDATE PARCELS SET Delivered = 1 WHERE Parcel_ID = " + dgvParcels.SelectedCells[1].Value.ToString();
            RefreshDGV();
            dataChange();
            if (dgvParcels.RowCount < 2) { btnApply.Enabled = false; }
        }

        private void dateParcels_ValueChanged(object sender, EventArgs e)
        {
            dataChange();
            if (dgvParcels.RowCount < 2) { btnApply.Enabled = false; } else { btnApply.Enabled = true; }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            searchQuery();
            RefreshDGV();
            if (dgvParcels.RowCount < 2) { btnApply.Enabled = false; } else { btnApply.Enabled = true; }
        }

        private String searchQuery()
        {
            int search;
            String stringSearch;
            myQuery = "";
            String contactNumber = tbxSearch.Text;

            if (contactNumber.Length < 10)
            {
                contactNumber = contactNumber + "__________";
                contactNumber = contactNumber.Substring(0, 9);
            }

            if (int.TryParse(tbxSearch.Text, out search))
            {
                stringSearch = search.ToString();
            }
            else
            {
                search = -1;
                stringSearch = tbxSearch.Text;
            }

            myQuery = queryAjustment + " WHERE (Parcel_ID LIKE '" + search.ToString() + "%' " +
                    "OR b.City_Name LIKE '" + stringSearch + "' " +
                    "OR a.Delivery_Street_Number LIKE '" + stringSearch + "%' " +
                    "OR a.Delivery_Street_Name LIKE '" + stringSearch + "%' " +
                    "OR a.Delivery_Complex_Building LIKE '" + stringSearch + "%' " +
                    "OR a.Contact_No LIKE '(%" + contactNumber.Substring(0, 3) + "%) %" + contactNumber.Substring(3, 3) + "%-%" + contactNumber.Substring(6) + "%' " +
                    "OR a.Alt_Contact_No LIKE '(%" + contactNumber.Substring(0, 3) + "%) %" + contactNumber.Substring(3, 3) + "%-%" + contactNumber.Substring(6) + "%' " +
                    "OR a.Recipient_Name LIKE '" + stringSearch + "%') " +
                    "AND a.Delivered = 0 " +
                    "AND d.Delivery_Date = '" + dateParcels.Value.ToShortDateString() + "' " +
                    "AND d.Vehicle_ID = " + cbDeliveryVehicle.SelectedValue.ToString();


            return myQuery;
        }

        public void setQueryAjustment()
        {
            queryAjustment = "SELECT a.Delivered, a.Parcel_ID, a.Delivery_Street_Number, a.Delivery_Street_Name, a.Delivery_Complex_Building, b.City_Name, a.Recipient_Name, a.Contact_No, a.Alt_Contact_No " +
                "FROM PARCELS a " +
                "LEFT JOIN POSTAL_CODE c ON a.Postal_Code_ID = c.Postal_Code_ID " +
                "LEFT JOIN CITY b ON c.City_ID = b.City_ID " +
                "LEFT JOIN DELIVERIES d ON a.Delivery_ID = d.Delivery_ID";
                
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

        private void cbDeliveryVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataChange();
            if (dgvParcels.RowCount < 2) { btnApply.Enabled = false; } else { btnApply.Enabled = true; }
        }
    }
}
