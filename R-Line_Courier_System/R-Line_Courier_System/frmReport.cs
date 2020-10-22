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
    public partial class frmReport : Form
    {
        //public variables
        public SqlConnection cnn;
        public SqlDataReader dataReader;
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
        public SqlCommand cmd;
        public SqlDataAdapter adapter;
        string mode;
        string sql;
        public frmReport()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //to do - sit formatting in as delivery due date> delivery - rooi OR still undelivered(past due date)


            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Deliveries";
            // storing header part in Excel  
            for (int i = 1; i < dvgReport.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dvgReport.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dvgReport.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dvgReport.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dvgReport.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void OpenConnection() //open sqlconnection
        {
            if (cnn != null && cnn.State == ConnectionState.Closed)
                cnn.Open();
        }
        private void Filter()
        {
            bool isValid = true;
            if ((rbDelivered.Checked == false) && (rbDelivered.Checked == false))
                isValid = false;

            if (dateTimeFrom.Value > dateTimeTo.Value)
            {
                MessageBox.Show("The date from can not be newer than the to date.");
                isValid = false;
            }

            int delivered = 0;
            if (rbDelivered.Checked == true)
            {
                delivered = 0;
            }
            if (rbUndelivered.Checked == true)
            {
                delivered = 1;
            }

            if (isValid == true)
            {
                String dateFrom = dateTimeFrom.Value.ToShortDateString();
                String dateTo = dateTimeTo.Value.ToShortDateString();

                cnn = new SqlConnection(connectionString);
                var sql  = @"SELECT a.Delivery_ID, a.Vehicle_ID, b.Delivery_Due_Date, a.Delivery_Date, b.Parcel_ID, "
                    +" b.Recipient_Name, b.Contact_No, b.Alt_Contact_No, b.Delivery_Street_Number, b.Delivery_Street_Name, b.Delivery_Complex_Building, b.Delivered, b.Delivery_Due_Date   FROM DELIVERIES a LEFT JOIN PARCELS b ON a.Delivery_ID = b.Delivery_ID  WHERE b.Delivered" +
                    " = " + delivered + " AND b.Delivery_Due_Date BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";

                OpenConnection();
                cmd = new SqlCommand(sql, cnn);

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Deliveries");

                dvgReport.DataSource = ds;
                dvgReport.DataMember = "Deliveries";

                cnn.Close();
            }
        }

        private void clearForm()
        {
            rbDelivered.Checked = false;
            rbUndelivered.Checked = false;
            dateTimeTo.Value = DateTime.Today;
            dateTimeFrom.Value = DateTime.Today.AddDays(-30);

        }

        private void RbDelivered_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void RbUndelivered_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void DateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void DateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
