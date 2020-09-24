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
    public partial class frmMaintainUsers : Form
    {
        //public variables
        public SqlConnection cnn;
        public SqlDataReader dataReader;
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
        public SqlCommand cmd;
        public SqlDataAdapter adapter;
        string mode;
        string sql;

        frmSearchUser SearchUser = new frmSearchUser();
        public frmMaintainUsers()
        {
            InitializeComponent();
        }
        private void OpenConnection() //open sqlconnection
        {
            if (cnn != null && cnn.State == ConnectionState.Closed)
                cnn.Open();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            frmSearchUser SearchUser = new frmSearchUser();
           // frmParent frmParent = this;
           // SearchUser.MdiParent = frmParent;
            SearchUser.ShowDialog();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (mode == "new")
            {
                int admin = 0;
                if (cbUserAdmin.SelectedIndex != -1)
                    admin = cbUserAdmin.SelectedIndex;

                //  var sql = "INSERT INTO USERS (User_Name, User_Surname, Username, Password, Admin_Privileges) VALUES ('"+txtUser_Name.Text+"' , '"+ txtUser_Surname.Text + "' , '"+ txtUserName.Text + "' , '"+ txtUser_Surname.Text + "' ," +admin+ ")";
                //  OpenConnection();

                try
                {
                    string sql = "INSERT INTO USERS ( User_Name, User_Surname, Username, Password, Admin_Privileges) VALUES ('" + txtUser_Name.Text + "', '" + txtUser_Surname.Text + "', '" + txtUserName.Text + "', '" + txtUser_Surname.Text + "', " + admin + ")";
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    cmd = new SqlCommand(sql, cnn);
                    //  cmd.Parameters.AddWithValue("@User_Name", txtUser_Name.Text);
                    //  cmd.Parameters.AddWithValue("@User_Surname", txtUser_Surname.Text);
                    //   cmd.Parameters.AddWithValue("@Username", txtUserName.Text);
                    //   cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    //   cmd.Parameters.AddWithValue("@Admin_Privileges", admin);

                    cmd.ExecuteNonQuery();
                    cnn.Close();


                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                cmd.Dispose();
                cnn.Close();
            }
        }

        private void ClearFields()
        {
            txtPassword.Clear();
        }

        private void FrmMaintainUsers_Load(object sender, EventArgs e)
        {
            mode = "add";
            
                 //update mode
                if (mode == "update")
                {

                    txtUserID.Enabled = false;
                    lblUserID.Show();
                    txtUserID.Show();
                    int userID = SearchUser.userID;


                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    sql = @"Select * FROM Users WHERE User_ID = '" + userID + "'";

                    cmd = new SqlCommand(sql, cnn);
                    dataReader = cmd.ExecuteReader();

                    txtUserID.Text = userID.ToString();
                    //txtRegNo.Text = dataReader.GetValue(1).ToString();
                    //fill in all other fields
                    cnn.Close();
                }

                if (mode == "new")
                {
                    lblUserID.Hide();
                    txtUserID.Hide();
                }


            }
        }
}
