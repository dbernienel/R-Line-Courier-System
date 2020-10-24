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
    public partial class frmMaintainClient : Form
    {
        private SqlConnection con;
        public SqlDataAdapter sd;
        private String conString;
        private String myQuery;
        private frmMaintainClient maintain;
        private frmClientDetails client;
        public SqlDataReader dataReader;
        public SqlCommand cmd;

        public frmMaintainClient()
        {
            InitializeComponent();
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
            maintain = this;
        }

        private void btnAddNewParcel_Click(object sender, EventArgs e)
        {
            client = new frmClientDetails(maintain, true);
            client.ShowDialog();
         
        }

        private void frmMaintainClient_Load(object sender, EventArgs e)
        {
            dataChange();
        }

        private void RefreshDGV()
        {
            dgvClients.ClearSelection();
            con = new SqlConnection(conString);
            con.Open();
            sd = new SqlDataAdapter(myQuery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvClients.DataSource = dt;
            con.Close();
        }

        public void dataChange() { 
            myQuery = "SELECT Client_ID, Company_Name, Contact_Name, Contact_Surname, Contact_No FROM CLIENTS";
            RefreshDGV();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
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

            myQuery = "SELECT Client_ID, Company_Name, Contact_Name, Contact_Surname, Contact_No FROM CLIENTS WHERE (Client_ID LIKE '"+search.ToString()+"%' " +
                "OR Company_Name LIKE '"+stringSearch+"%' " +
                "OR Contact_Name LIKE '"+stringSearch+"%' " +
                "OR Contact_Surname LIKE '"+stringSearch+"%' " +
                "OR Contact_No LIKE '(%" + contactNumber.Substring(0, 3) + "%) %" + contactNumber.Substring(3, 3) + "%-%" + contactNumber.Substring(6) + "%')";

            RefreshDGV();
        }

        private void btnUpdateParcel_Click(object sender, EventArgs e)
        {
            client = new frmClientDetails(maintain, false);
            client.setClientID(dgvClients.SelectedCells[0].Value.ToString());
            client.autoFillForm();
            client.Show();
        }

        private void OpenConnection() //open sqlconnection
        {
            if (con != null && con.State == ConnectionState.Closed)
                con.Open();
        }

        private bool clientExists(int client_ID)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True");
            var sql = @"Select * FROM PARCELS WHERE Client_ID = " + client_ID;
            OpenConnection();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                if (client_ID == int.Parse(dataReader.GetValue(17).ToString()))
                {
                    con.Close();

                    return true;
                }
            }

            con.Close();
            
            return false;

        
    }

        private void btnDeleteParcel_Click(object sender, EventArgs e)
        {

            if (clientExists(int.Parse(dgvClients.SelectedCells[0].Value.ToString())))
            {
                MessageBox.Show("The client can not be deleted (deletion is restricted).");
            }
            else
            {
                con = new SqlConnection(conString);

                con.Open();
                
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM CLIENTS WHERE Client_ID=" + dgvClients.SelectedCells[0].Value.ToString(), con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client successfully deleted");
                }
                if (res == DialogResult.Cancel)
                {
                }

                

                dataChange();

                con.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

    }
}
