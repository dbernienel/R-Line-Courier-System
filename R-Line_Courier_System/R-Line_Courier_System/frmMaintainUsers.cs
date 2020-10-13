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
        public void setUserID(string ID)
        {
            txtUserID.Text = ID;
        }
        public void setName(string name)
        {
            txtUser_Name.Text = name;
        }

        public void setSurname(string surname)
        {
            txtUser_Surname.Text = surname;
        }

        public void setUsername(string username)
        {
            txtUserName.Text = username;
        }

        public void setPassword(string password)
        {
            txtPassword.Text = password;
        }

        public void setAdminP(string admin)
        {
            if (admin == "False")
            {
                cbUserAdmin.SelectedIndex = 0;
                cbUserAdmin.SelectedItem = 0;
            }
            else
            {
                cbUserAdmin.SelectedItem = 1;
                cbUserAdmin.SelectedItem = 1;
            }
        }

        public void clearForm()
        {
            txtPassword.Clear();
            txtUserID.Clear();
            txtUserName.Clear();
            txtUser_Name.Clear();
            txtUser_Surname.Clear();
            cbUserAdmin.SelectedIndex = -1;

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
            if (mode == "add")
            {
                int admin = 0;
                if (cbUserAdmin.SelectedIndex != -1)
                    admin = cbUserAdmin.SelectedIndex;

                try
                {
                    string sql = "INSERT INTO USERS ( User_Name, User_Surname, Username, Password, Admin_Privileges) VALUES ('" + txtUser_Name.Text + "', '" + txtUser_Surname.Text + "', '" + txtUserName.Text + "', '" + txtUser_Surname.Text + "', " + admin + ")";
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    cmd = new SqlCommand(sql, cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("User successfully added");
                    clearForm();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                cmd.Dispose();
                cnn.Close();
            }
            else if (mode == "update")
            {
                int admin = 0;
                if (cbUserAdmin.SelectedIndex != -1)
                    admin = cbUserAdmin.SelectedIndex;

                try
                {
                    int Id = Int32.Parse(txtUserID.Text);
                    string sql = "UPDATE USERS SET User_Name ='" + txtUser_Name.Text + "' , User_Surname = '" + txtUser_Surname.Text + "' , Username ='" + txtUserName.Text + "', Password ='" + txtPassword.Text + "', Admin_Privileges =" + admin + " WHERE User_ID= " + Id;
                    MessageBox.Show(sql);
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    cmd = new SqlCommand(sql, cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("User Successfully updated");
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

        private void ClearFields()
        {
            txtPassword.Clear();
        }

        private void FrmMaintainUsers_Load(object sender, EventArgs e)
        {


            //update mode
            if (mode == "update")
            {

                txtUserID.Enabled = false;
                lblUserID.Show();
                txtUserID.Show();

            }

            if (mode == "add")
            {
                lblUserID.Hide();
                txtUserID.Hide();
            }


        }

        private void CbUserAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

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
