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
        public frmClientDetails()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kobus\Documents\GitHub\R-Line-Courier-System\R-Line_Courier_System\R-Line_Courier_System\RLine_Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("INSERT INTO CLIENTS(Company_Name,Contact_Name,Contact_Surname,Contact_No) VALUES('" + tbxCompanyName.Text + "','" + tbxClientName.Text + "','" + tbxClientSurname.Text + "','" + tbxClientContactNr.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
