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

        public void setVehicleID(string ID)
        {
            txtID.Text = ID;
            txtID.Enabled = false;
        }
        public void setMode(string smode)
        {
            mode = smode;
            if (mode == "update")
            {
                btnSubmit.Text = "Update";
            }
            else
            {
                btnSubmit.Text = "Submit";
            }
        }

        public void clearForm()
        {
            txtID.Clear();
            txtRegNo.Clear();
        }

        public void setRegNo(String RegNo)
        {
            txtRegNo.Text = RegNo;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (mode == "update")
            {
                try
                {
                    int Id = Int32.Parse(txtID.Text);
                    string sql = "UPDATE VEHICLES SET Reg_No ='" + txtRegNo.Text + " WHERE Vehicle_ID= " + Id;
                    MessageBox.Show(sql);
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    cmd = new SqlCommand(sql, cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Vehicle Successfully updated");
                    clearForm();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                cmd.Dispose();
                cnn.Close();
            }


            if (mode == "add")
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
                    clearForm();
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
           // txtID.Clear();
           // txtRegNo.Clear();
            //update mode
            if (mode == "update")
            {

                txtID.Enabled = false;
                lblVehicleID.Show();
                txtID.Show();
               
             }

            if (mode == "add")
            {
                lblVehicleID.Hide();
                txtID.Hide();
            }


        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                clearForm();
            }
            else
            {
                MessageBox.Show("Cannot clear while updating");
            }
        }
    }
}
