﻿using System;
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


        private int _vehicleID;
        public int vehicleID
        {
            get { return _vehicleID;}
            set {_vehicleID = value; }
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
            frmMaintainVehicles Vehicles = new frmMaintainVehicles();
            //  frmParent frmParent = Users;
            // Users.MdiParent = frmParent;
            Vehicles.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
              if (this.vehicleID > -1)
                {
                    string delete_query = "DELETE FROM VEHICLES WHERE Vehicle_ID = '" + this.vehicleID + "'";
                    cnn.Open();
                    cmd = new SqlCommand(delete_query, cnn);

                    //dialog are you sure
                    cmd.ExecuteNonQuery();
                    cnn.Close();

                    MessageBox.Show(this.vehicleID.ToString() + " has been successfully deleted!");
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

        }

        private void setVehicleID(int VehicleID)
        {

        }

        private void DgVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex !=-1)
            {
                DataGridViewRow dgvRow = dgVehicles.Rows[e.RowIndex];
                this.vehicleID = Int32.Parse(dgvRow.Cells[0].Value.ToString());

                
            }
            
        }

        private void DgVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}