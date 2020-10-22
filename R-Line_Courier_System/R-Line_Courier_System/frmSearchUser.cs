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
        int rowIndex;

        public frmSearchUser()
        {
            InitializeComponent();
            TrySearch("", -1);

        }



        private void TrySearch(String stringSearch, int search)
        {
            cnn = new SqlConnection(connectionString);
            var sql = "";
            if (txtSearchUser.Text != "")
            {
                sql = @"Select * FROM USERS WHERE (User_Name LIKE '" + stringSearch + "%' " +
                    "OR User_Surname LIKE '" + stringSearch + "%' " +
                    "OR Username LIKE '" + stringSearch + "%')";
            }
            else
            {
                sql = @"Select * FROM USERS";
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
            frmMaintainUsers maintainUsers = new frmMaintainUsers();

            maintainUsers.setUserID(dgViewUsers.Rows[rowIndex].Cells[0].Value.ToString());
            maintainUsers.setMode("update");
            // MessageBox.Show((dgViewUsers.Rows[rowIndex].Cells[3].Value.ToString()));
            maintainUsers.setName(dgViewUsers.Rows[rowIndex].Cells[1].Value.ToString());
            maintainUsers.setSurname(dgViewUsers.Rows[rowIndex].Cells[2].Value.ToString());
            maintainUsers.setUsername(dgViewUsers.Rows[rowIndex].Cells[4].Value.ToString());
            maintainUsers.setPassword(dgViewUsers.Rows[rowIndex].Cells[5].Value.ToString());
            maintainUsers.setAdminP(dgViewUsers.Rows[rowIndex].Cells[3].Value.ToString());
            maintainUsers.ShowDialog();
        }

        private void TxtSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchUser.Text != null)
            {
                String stringSearch;
                if (int.TryParse(txtSearchUser.Text, out int search))
                {
                    stringSearch = search.ToString();
                }
                else
                {
                    search = -1;
                    stringSearch = txtSearchUser.Text;
                }
                TrySearch(stringSearch, search);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmMaintainUsers users = new frmMaintainUsers();
            users.setMode("add");
            //  frmParent frmParent = Users;
            // Users.MdiParent = frmParent;
            users.ShowDialog();
        }

        private bool userExistsDeliveries(int id)
        {
            cnn = new SqlConnection(connectionString);
            var sql = @"Select * FROM DELIVERIES WHERE User_ID = " + id;
            OpenConnection();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                if (id == int.Parse(dataReader.GetValue(2).ToString()))
                {
                    cnn.Close();
                    //user is linked to deliveries
                    return true;
                }
            }
            cnn.Close();
            //user is not liked to deliveries
            return false;
    }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int userID = Int32.Parse(dgViewUsers.Rows[rowIndex].Cells[0].Value.ToString());
            try
            {
                if (userID > -1)
                {
                    if (userExistsDeliveries(userID))
                    {
                        MessageBox.Show("The user can not be deleted (deletion is restricted).");
                    }
                    else
                    {
                        string delete_query = "DELETE FROM USERS WHERE User_ID = '" + userID + "'";
                        cnn.Open();
                        cmd = new SqlCommand(delete_query, cnn);

                        //dialog are you sure
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        MessageBox.Show(userID.ToString() + " has been successfully deleted!");
                        TrySearch("", -1);
                    }
                }

                    TrySearch("", -1);
                }
            
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            TrySearch("", -1);
        }

        private void DgViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgViewUsers.Rows[e.RowIndex];


            }
        }

        private void DgViewUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void DgViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
