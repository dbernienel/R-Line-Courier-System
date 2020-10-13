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
    public partial class frmMaintainClient : Form
    {
        private SqlConnection con;
        public SqlDataAdapter sd;
        private String conString;
        private String myQuery;

        public frmMaintainClient()
        {
            InitializeComponent();
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kobus\Documents\GitHub\R-Line-Courier-System\R-Line_Courier_System\R-Line_Courier_System\RLine_Database.mdf;Integrated Security=True";
        }

        private void btnAddNewParcel_Click(object sender, EventArgs e)
        {
            frmClientDetails details = new frmClientDetails();
            details.ShowDialog();
        }

        private void frmMaintainClient_Load(object sender, EventArgs e)
        {
            myQuery = "SELECT Client_ID, Company_Name, Contact_Name, Contact_Surname, Contact_No FROM CLIENTS";
            RefreshDGV();
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
    }
}
