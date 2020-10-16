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
    public partial class frmMaintainRegions : Form
    {
        private SqlConnection con;
        private String conString;
        private String myQuery;
        private SqlDataAdapter sd;

        public frmMaintainRegions()
        {
            InitializeComponent();
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kobus\Documents\GitHub\R-Line-Courier-System\R-Line_Courier_System\R-Line_Courier_System\RLine_Database.mdf;Integrated Security=True";
        }

        private void frmMaintainRegions_Load(object sender, EventArgs e)
        {
            dataChange();
        }

        private void RefreshDGV()
        {
            dgvRegion.ClearSelection();
            con = new SqlConnection(conString);
            con.Open();
            sd = new SqlDataAdapter(myQuery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvRegion.DataSource = dt;
            con.Close();
        }

        public void dataChange()
        {
            myQuery = "SELECT a.City_ID, a.City_Name, b.Postal_Code_ID, b.Postal_Code FROM CITY a LEFT JOIN POSTAL_CODE b ON b.City_ID = a.City_ID";
            RefreshDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM POSTAL_CODE WHERE Postal_Code_ID=" + dgvRegion.SelectedCells[2].Value.ToString(), con);
            cmd.ExecuteNonQuery();

            dataChange();

            con.Close();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            int search;
            String stringSearch;
            myQuery = "";

            if (int.TryParse(tbxSearch.Text, out search))
            {
                stringSearch = search.ToString();
            }
            else
            {
                search = -1;
                stringSearch = tbxSearch.Text;
            }

            myQuery = "SELECT a.City_ID, a.City_Name, b.Postal_Code_ID, b.Postal_Code FROM CITY a LEFT JOIN POSTAL_CODE b ON b.City_ID = a.City_ID WHERE City_ID LIKE '" + search.ToString() + "%' " +
                "OR City_Name LIKE '" + stringSearch + "%' " +
                "OR Postal_Code_ID LIKE '" + search.ToString() + "%' " +
                "OR Postal_Code LIKE '" + stringSearch + "%'";

            MessageBox.Show(myQuery);

            RefreshDGV();
        }
    }
}
