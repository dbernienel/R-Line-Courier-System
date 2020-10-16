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
    public partial class frmRegionDetails : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private String myQuery;

        public frmRegionDetails()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True");
        }

        private void frmRegionDetails_Load(object sender, EventArgs e)
        {
            populateComboBox();
            btnDeleteCity.Enabled = false;
        }

        private void populateComboBox() {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CITY", con);
            DataSet ds = new DataSet();

            cbCity.DisplayMember = "City_Name";
            cbCity.ValueMember = "City_ID";
            da.Fill(ds);
            cbCity.DataSource = ds.Tables[0];
            con.Close();
            cbCity.SelectedItem = null;
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Closed && cbCity.SelectedItem != null)
                populateListbox();
            if (lbPostalCodes.Items.Count == 0 && cbCity.SelectedItem != null)
                btnDeleteCity.Enabled = true;
            else { btnDeleteCity.Enabled = false; }
        }

        private void populateListbox() {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM POSTAL_CODE WHERE City_ID = " + cbCity.SelectedValue, con);
            DataSet ds = new DataSet();

            lbPostalCodes.DisplayMember = "Postal_Code";
            lbPostalCodes.ValueMember = "Postal_Code_ID";
            da.Fill(ds);
            lbPostalCodes.DataSource = ds.Tables[0];
            con.Close();
        }

        private void addPostalCode_Click(object sender, EventArgs e)
        {
            myQuery = "INSERT INTO POSTAL_CODE(Postal_Code, City_ID) VALUES ('" + tbxPostalCode.Text + "', " + cbCity.SelectedValue.ToString() + ")";
            insertData();
            populateListbox();
            tbxPostalCode.Clear();
        }

        private void insertData() {
            SqlCommand cmd = new SqlCommand(myQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void addCity_Click(object sender, EventArgs e)
        {
            myQuery = "INSERT INTO CITY(City_Name) VALUES ('" + tbxCity.Text + "')";
            insertData();
            populateComboBox();
            tbxCity.Clear();
        }

        private void btnDeleteCity_Click(object sender, EventArgs e)
        {
            myQuery = "DELETE FROM CITY WHERE City_ID=" + cbCity.SelectedValue.ToString();
            deleteData();
            populateComboBox();
        }

        private void deleteData() { 
            con.Open();
            cmd = new SqlCommand(myQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnDeletePostalCodes_Click(object sender, EventArgs e)
        {
            myQuery = "DELETE FROM POSTAL_CODE WHERE Postal_Code_ID=" + lbPostalCodes.SelectedValue.ToString();
            deleteData();
            populateListbox();
        }
    }
}
