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
            frmAssignParcels assign = new frmAssignParcels(userID);
            assign.Show();
        }

        private void btnDeleteDelivery_Click(object sender, EventArgs e)
        {
            if (dgvDelivery.Rows.Count == 2) { btnDeleteDelivery.Enabled = false; }
            updateParcelDeliveryID(dgvDelivery.SelectedCells[0].Value.ToString());
            con = new SqlConnection(conString);

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM DELIVERIES WHERE Delivery_ID=" + dgvDelivery.SelectedCells[0].Value.ToString(), con);
            try { cmd.ExecuteNonQuery(); } catch (InvalidConstraintException m) { MessageBox.Show("Delivery contains parcels"); } catch (SqlException m) { MessageBox.Show("Delivery contains parcels"); }
            dataChange();
            con.Close();
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
            sd.Fill(dt);
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
            if (dgvDelivery.SelectedCells[0].Value.ToString() == null) { btnDeleteDelivery.Enabled = false; }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvDelivery.Rows.Count == 2) { btnDeleteDelivery.Enabled = false; } else { btnDeleteDelivery.Enabled = true; }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataChange();
        }
    }
}
