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


    public partial class frmSearchVehicles : Form
    {

        //public variables
        public SqlConnection cnn;
        public SqlDataReader dataReader;
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
        public SqlCommand cmd;
        int rowIndex;




        public frmSearchVehicles()
        {
            InitializeComponent();
            TrySearch(-1,"");
        }




        private void TrySearch(int searchID, String searchRegNo)
        {
            cnn = new SqlConnection(connectionString);
            var sql = "";
            if (txtSearchVehicle.Text != "")
            {
                sql = @"SELECT * FROM VEHICLES WHERE (Vehicle_ID LIKE '" + searchID.ToString() + "%' " +
                    "OR Reg_No LIKE '" + searchRegNo + "%')";
            }
            else
                sql = @"SELECT * FROM VEHICLES";
            OpenConnection();
            cmd = new SqlCommand(sql, cnn);


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "Vehicles");

            dgVehicles.DataSource = ds;
            dgVehicles.DataMember = "Vehicles";

            cnn.Close();

            //   cmd.ExecuteNonQuery();
        }
        private void OpenConnection() //open sqlconnection
        {
            if (cnn != null && cnn.State == ConnectionState.Closed)
                cnn.Open();
        }

        private void TxtSearchVehicle_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchVehicle.Text != null)
            {
                String stringSearch;
                if (int.TryParse(txtSearchVehicle.Text, out int search))
                {
                    stringSearch = search.ToString();
                }
                else
                {
                    search = -1;
                    stringSearch = txtSearchVehicle.Text;
                }
                TrySearch(search, stringSearch);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmMaintainVehicles vehicle = new frmMaintainVehicles();
            //  frmParent frmParent = Users;
            // Users.MdiParent = frmParent;
            vehicle.setMode("add");
            vehicle.clearForm();
            vehicle.ShowDialog();
        }

        private bool vehicleExistsDeliveries(int id)
        {
            cnn = new SqlConnection(connectionString);
            var sql = @"Select * FROM DELIVERIES WHERE Vehicle_ID = " + id;
            OpenConnection();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                if (id == int.Parse(dataReader.GetValue(1).ToString()))
                {
                    cnn.Close();
                    //vehicle is linked to deliveries
                    return true;
                }
            }

            cnn.Close();
            //vehicle is not liked to deliveries
            return false;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            int vehicleID = Int32.Parse(dgVehicles.Rows[rowIndex].Cells[0].Value.ToString());
            try
            {
                if (vehicleID > -1)
                {

                    if (vehicleExistsDeliveries(vehicleID))
                    {
                        MessageBox.Show("The vehicle can not be deleted (deletion is restricted).");

                    }
                    else
                    {
                        DialogResult res = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            string delete_query = "DELETE FROM VEHICLES WHERE Vehicle_ID = '" + vehicleID + "'";
                            cnn.Open();
                            cmd = new SqlCommand(delete_query, cnn);

                            //dialog are you sure
                            cmd.ExecuteNonQuery();
                            cnn.Close();

                            MessageBox.Show(vehicleID.ToString() + " has been successfully deleted!");
                            TrySearch(-1, "");
                        }
          

                        
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            frmMaintainVehicles maintainVehicles = new frmMaintainVehicles();

            maintainVehicles.setMode("update");
            maintainVehicles.clearForm();
            maintainVehicles.setRegNo(dgVehicles.Rows[rowIndex].Cells[1].Value.ToString());
            try { maintainVehicles.setVehicleID(dgVehicles.Rows[rowIndex].Cells[0].Value.ToString()); } catch (ArgumentOutOfRangeException m) { Console.WriteLine(m.Message); }

            maintainVehicles.Show();
        }

        private void setVehicleID(int VehicleID)
        {

        }

        private void DgVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgVehicles.Rows[e.RowIndex];



            }

        }

        private void DgVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgVehicles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void FrmSearchVehicles_Load(object sender, EventArgs e)
        {
            dgVehicles.ReadOnly = true;
        }
    }
}
