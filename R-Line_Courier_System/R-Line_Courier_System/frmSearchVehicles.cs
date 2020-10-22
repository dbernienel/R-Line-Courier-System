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
            TrySearch("", "");
        }




        private void TrySearch(String field, String value)
        {
            cnn = new SqlConnection(connectionString);
            var sql = "";
            if ((field == "") || (value == ""))
            {
                sql = @"Select * FROM VEHICLES";
            }
            else
            {
                sql = @"Select * FROM VEHICLES WHERE " + field + " LIKE '%" + value + "%'";
            }
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


        private String GetField()
        {
            if (rbVehicleID.Checked)
                return "Vehicle_ID";
            else if (rbVehicleRegNo.Checked)
                return "Reg_No";
            else
                return "";
        }

        private void TxtSearchVehicle_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchVehicle.Text != null && GetField() != "")
            {
                TrySearch(GetField(), txtSearchVehicle.Text);
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            int vehicleID = Int32.Parse(dgVehicles.Rows[rowIndex].Cells[0].Value.ToString());
            try
            {
                if (vehicleID > -1)
                {
                    string delete_query = "DELETE FROM VEHICLES WHERE Vehicle_ID = '" + vehicleID + "'";
                    cnn.Open();
                    cmd = new SqlCommand(delete_query, cnn);

                    //dialog are you sure
                    cmd.ExecuteNonQuery();
                    cnn.Close();

                    MessageBox.Show(vehicleID.ToString() + " has been successfully deleted!");
                    gbSearchUser.Refresh();
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
            maintainVehicles.setVehicleID(dgVehicles.Rows[rowIndex].Cells[2].Value.ToString());

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
    }
}
