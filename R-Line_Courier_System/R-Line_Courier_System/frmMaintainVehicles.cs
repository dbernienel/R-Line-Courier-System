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
    public partial class frmMaintainVehicles : Form
    {

                //public variables
        public SqlConnection cnn;
        public SqlDataReader dataReader;
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
        public SqlCommand cmd;
        public SqlDataAdapter adapter;
        public DataSet ds;
        string sql;

        string mode = "new";

        frmSearchVehicles SearchVehicles = new frmSearchVehicles();
        public frmMaintainVehicles()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (mode == "update")
            {

            }


            if (mode == "new")
            {

                //run validation tests
                try
                {
                    string sql = "INSERT INTO VEHICLES (Reg_No) VALUES ('" + txtRegNo.Text + "')";
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    cmd = new SqlCommand(sql, cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Vehicle with registration number " + txtRegNo.Text + " has been successfully added!");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                cmd.Dispose();
                cnn.Close();
            }
       }


        private void FrmMaintainVehicles_Activated(object sender, EventArgs e)
        {
            txtID.Clear();
            txtRegNo.Clear();
            //update mode
            if (mode == "update")
            {

                txtID.Enabled = false;
                lblVehicleID.Show();
                txtID.Show();
                int vehicleID = SearchVehicles.vehicleID;


                cnn = new SqlConnection(connectionString);
                cnn.Open();
                sql = @"Select * FROM VEHICLES WHERE Vehicle_ID = '" + vehicleID + "'";

                cmd = new SqlCommand(sql, cnn);
                dataReader = cmd.ExecuteReader();

                txtID.Text = vehicleID.ToString();
                txtRegNo.Text = dataReader.GetValue(1).ToString();

                cnn.Close();
            }

            if (mode == "new")
            {
                lblVehicleID.Hide();
                txtID.Hide();
            }


        }

        private void frmMaintainVehicles_Load(object sender, EventArgs e)
        {

        }
    }
}
