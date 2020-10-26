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
    public partial class frmMaintainDeliveries : Form
    {
        private int userID;
        private String conString;
        private SqlConnection con;
        private String myQuery;
        private SqlDataAdapter sd;

        public frmMaintainDeliveries(int iD)
        {
            userID = iD;
            InitializeComponent();
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
        }

        private void btnUpdateDelivery_Click(object sender, EventArgs e)
        {
            try {
                frmAssignParcels assign = new frmAssignParcels(userID);
                assign.Show(); } catch (NullReferenceException m) { MessageBox.Show("No entry selected."); }
            
        }

        private void btnDeleteDelivery_Click(object sender, EventArgs e)
        {
            
            updateParcelDeliveryID(dgvDelivery.SelectedCells[0].Value.ToString());
            con = new SqlConnection(conString);

            con.Open();

            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM DELIVERIES WHERE Delivery_ID=" + dgvDelivery.SelectedCells[0].Value.ToString(), con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delivery successfully deleted");
            }
            if (res == DialogResult.Cancel)
            {
            }
            
            dataChange();
            con.Close();
            if (dgvDelivery.Rows.Count < 2) { btnDeleteDelivery.Enabled = false; btnUpdateDelivery.Enabled = false; }
        }

        private void updateParcelDeliveryID(string deliveryID) {
            con = new SqlConnection(conString);

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE PARCELS SET Delivery_ID = null" +
            " WHERE Delivery_ID = " + deliveryID, con);
            try { cmd.ExecuteNonQuery(); } catch (SqlException m) { Console.WriteLine(m.Message); }
            dataChange();
            con.Close();
        }

        private void RefreshDGV()
        {
            dgvDelivery.ClearSelection();
            con = new SqlConnection(conString);
            con.Open();
            sd = new SqlDataAdapter(myQuery, con);
            DataTable dt = new DataTable();
            try { sd.Fill(dt); } catch (SqlException m) { Console.WriteLine(m.Message); }
            dgvDelivery.DataSource = dt;
            con.Close();
        }

        public void dataChange()
        {
            myQuery = "SELECT a.Delivery_ID, b.Reg_No, c.User_Name, c.User_Surname, a.Delivery_Date FROM DELIVERIES a " +
                "LEFT JOIN VEHICLES b ON a.Vehicle_ID = b.Vehicle_ID " +
                "LEFT JOIN USERS c ON a.User_ID = c.User_ID";
            RefreshDGV();
        }

        private void frmMaintainDeliveries_Load(object sender, EventArgs e)
        {
            dgvDelivery.ReadOnly = true;
            dataChange();
            if (dgvDelivery.Rows.Count < 2) { btnDeleteDelivery.Enabled = false; btnUpdateDelivery.Enabled = false; }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            int search;
            String stringSearch;
            myQuery = "";

            if (tbxSearch.Text != "") {

                if (int.TryParse(tbxSearch.Text, out search)) {
                    stringSearch = search.ToString();
                }
                else {
                    search = -1;
                    stringSearch = tbxSearch.Text;
                }

                myQuery = "SELECT a.Delivery_ID, b.Reg_No, c.User_Name, c.User_Surname, a.Delivery_Date FROM DELIVERIES a " +
                    "LEFT JOIN VEHICLES b ON a.Vehicle_ID = b.Vehicle_ID " +
                    "LEFT JOIN USERS c ON a.User_ID = c.User_ID " +
                    "WHERE a.Delivery_ID LIKE '" + search.ToString() + "%' " +
                    "OR b.Reg_No LIKE '" + stringSearch + "%' " +
                    "OR c.User_Name LIKE '" + stringSearch + "%' " +
                    "OR c.User_Surname LIKE '" + stringSearch + "%'";
            } else { dataChange(); }

            RefreshDGV();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataChange();
            if (dgvDelivery.Rows.Count < 2) { btnDeleteDelivery.Enabled = false; btnUpdateDelivery.Enabled = false; } else { btnDeleteDelivery.Enabled = true; btnUpdateDelivery.Enabled = true; }
        }
    }
}
