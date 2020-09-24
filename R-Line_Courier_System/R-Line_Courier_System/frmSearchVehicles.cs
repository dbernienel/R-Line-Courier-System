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
                sql = @"Select * FROM VEHiCLES";
            }
            else
            {
                sql = @"Select * FROM Vehciles WHERE " + field + " LIKE '%" + value + "%'";
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
            frmMaintainVehicles Vehcicles = new frmMaintainVehicles();
            //  frmParent frmParent = Users;
            // Users.MdiParent = frmParent;
            Vehcicles.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
