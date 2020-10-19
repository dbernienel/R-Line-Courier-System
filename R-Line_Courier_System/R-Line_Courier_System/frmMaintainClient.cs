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
        private frmMaintainClient maintain;
        private frmClientDetails client;

        public frmMaintainClient()
        {
            InitializeComponent();
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
            maintain = this;
        }

        private void btnAddNewParcel_Click(object sender, EventArgs e)
        {
            client = new frmClientDetails(maintain);
            client.ShowDialog();
        }

        private void frmMaintainClient_Load(object sender, EventArgs e)
        {
            dataChange();
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

        public void dataChange() { 
            myQuery = "SELECT Client_ID, Company_Name, Contact_Name, Contact_Surname, Contact_No FROM CLIENTS";
            RefreshDGV();
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

        private void btnUpdateParcel_Click(object sender, EventArgs e)
        {
            client = new frmClientDetails(maintain);
            client.setClientID(dgvClients.SelectedCells[0].Value.ToString());
            client.autoFillForm();
            client.Show();
        }

        private void btnDeleteParcel_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM CLIENTS WHERE Client_ID=" + dgvClients.SelectedCells[0].Value.ToString(), con);
            cmd.ExecuteNonQuery();

            dataChange();

            con.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Client List"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Client List";
            // storing header part in Excel  
            for (int i = 1; i < dgvClients.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvClients.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvClients.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvClients.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvClients.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }
    }
}
