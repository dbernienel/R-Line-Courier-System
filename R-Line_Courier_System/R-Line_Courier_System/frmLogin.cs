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
    public partial class frmLogin : Form
    {
        //public variables
        public SqlConnection cnn;
        public SqlDataReader dataReader;
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
        public SqlCommand cmd;
        public int userID { get; set; }
        public bool adminP { get; set; }
        public string username { get; set; }

        public frmLogin()
        {

            InitializeComponent();
        }
        private void OpenConnection() //open sqlconnection
        {
            if (cnn != null && cnn.State == ConnectionState.Closed)
                cnn.Open();
        }


        private void TryLogin(string Username, string Password)
        {
            cnn = new SqlConnection(connectionString);
            var sql = @"Select * FROM Users WHERE Username = '" + Username + "' AND Password = '" + Password + "'";
            OpenConnection();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                if ((Username == dataReader.GetValue(4).ToString()) && (Password == dataReader.GetValue(5).ToString()))
                {
                    MessageBox.Show("Welcome " + dataReader.GetValue(1).ToString() + "!");
                    
                    frmParent parent = (frmParent)this.Owner;
                    this.userID = Int32.Parse(dataReader.GetValue(0).ToString());
                    this.adminP = Convert.ToBoolean(dataReader.GetValue(3));
                    this.username = dataReader.GetValue(1).ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect login credentials. Please try again.");
                    txtPassword.Clear();
                }

            }

            cnn.Close();

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            TryLogin(txtUsername.Text, txtPassword.Text);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
