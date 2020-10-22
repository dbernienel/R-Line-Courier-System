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
    public partial class frmClientDetails : Form
    {
        private frmMaintainClient maintain;
        private SqlConnection con;
        private String conString;
        private String clientID;
        private bool btnState;

        public frmClientDetails(frmMaintainClient maintain, bool state)
        {
            InitializeComponent();
            btnState = state;
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
            this.maintain = maintain;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (btnState)
                dataAdd();
            else
                dataUpdate();
        }

        public void setClientID(String cID) {
            clientID = cID;
        }

        public void autoFillForm()
        {
            con = new SqlConnection(conString);
            string query = "SELECT * FROM CLIENTS WHERE Client_ID =" + clientID;
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbxClientContactNr.Text = dr.GetValue(4).ToString();
                tbxClientName.Text = dr.GetValue(2).ToString();
                tbxClientSurname.Text = dr.GetValue(3).ToString();
                tbxCompanyName.Text = dr.GetValue(1).ToString();
            }
            con.Close();
        }

        private void dataUpdate() {
            con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("UPDATE CLIENTS SET Company_Name = '" + tbxCompanyName.Text + "', " +
            "Contact_Name = '" + tbxClientName.Text + "', " +
            "Contact_Surname = '" + tbxClientSurname.Text + "', " +
            "Contact_No = '" + tbxClientContactNr.Text + "' WHERE Client_ID = " + clientID, con);
            con.Open();
            cmd.ExecuteNonQuery();
            maintain.dataChange();
            con.Close();
            this.Close();
        }

        private void dataAdd() {
            con = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("INSERT INTO CLIENTS(Company_Name,Contact_Name,Contact_Surname,Contact_No) VALUES('" + tbxCompanyName.Text + "','" + tbxClientName.Text + "','" + tbxClientSurname.Text + "','" + tbxClientContactNr.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            maintain.dataChange();
            con.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void gbClientInfo_Enter(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
