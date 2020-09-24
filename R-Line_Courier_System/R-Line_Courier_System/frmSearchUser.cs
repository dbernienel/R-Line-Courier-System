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
    public partial class frmSearchUser : Form
    {
        //public variables
        public SqlConnection cnn;
        public SqlDataReader dataReader;
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
        public SqlCommand cmd;

        public frmSearchUser()
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
                sql = @"Select * FROM USERS";
            }
            else 
            {
                sql = @"Select * FROM USERS WHERE "+ field +" LIKE '%"+ value+ "%'";
            }
            OpenConnection();
            cmd = new SqlCommand(sql, cnn);


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "Users");

            dgViewUsers.DataSource = ds;
            dgViewUsers.DataMember = "Users";

            cnn.Close();

            //   cmd.ExecuteNonQuery();
        }
        private void OpenConnection() //open sqlconnection
        {
            if (cnn != null && cnn.State == ConnectionState.Closed)
                cnn.Open();
        }


        private void BtnSelectUser_Click(object sender, EventArgs e)
        {

        }
        private String GetField()
        {
            if (rbUserID.Checked)
                return "User_ID";
            else if (rbUserName.Checked)
                return "Username";
            else if (rbUser_Name.Checked)
                return "User_Name";
            else if (rbUserSurname.Checked)
                return "User_Surname";
            else
                return "";
        }

        private void TxtSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchUser.Text != null && GetField() != "")
            {
                TrySearch(GetField(), txtSearchUser.Text);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmMaintainUsers Users = new frmMaintainUsers();
          //  frmParent frmParent = Users;
           // Users.MdiParent = frmParent;
            Users.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
