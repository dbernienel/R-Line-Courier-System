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


            Microsoft.Office.Interop.Excel.Style myStyle1 = workbook.Styles.Add("myStyle1");
            myStyle1.Font.Name = "Verdana";
            myStyle1.Font.Size = 12;
            myStyle1.Font.Bold = true;
            myStyle1.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            // myStyle1.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DimGray);
            myStyle1.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid;

            Microsoft.Office.Interop.Excel.Style myStyle2 = workbook.Styles.Add("myStyle2");
            myStyle2.Font.Name = "Verdana";
            myStyle2.Font.Size = 11;
            myStyle2.Font.Bold = true;
            myStyle2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            myStyle2.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
            myStyle2.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid;


            worksheet.Cells[1, 1] = "R-Line Courier System";
            String title = "";
            if (rbDelivered.Checked)
                title = "Delivered";

            if (rbUndelivered.Checked)
                title = "Undelivered";


            worksheet.Cells[2, 1] =title+ " parcels during the period " + (dateTimeFrom.Value.ToString()).Substring(0, 10) + " to "+
                (dateTimeTo.Value.ToString()).Substring(0, 10);

            worksheet.Cells[3, 1] = "Report dated " + DateTime.Now.ToString();

            Microsoft.Office.Interop.Excel.Range formatRange;
            formatRange = worksheet.get_Range("a1", "c3");
            formatRange.Style = "myStyle1";


            formatRange = worksheet.get_Range("a5", "l5");
            formatRange.Style = "myStyle2";
            formatRange.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);


            //formatRange = worksheet.get_Range("a5", "h"+ dgvDeliveries.Columns.Count.ToString());

            formatRange.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);

            worksheet.Columns[1].ColumnWidth = 15;
            worksheet.Columns[2].ColumnWidth = 15;
            worksheet.Columns[3].ColumnWidth = 25;
            worksheet.Columns[4].ColumnWidth = 20;
            worksheet.Columns[5].ColumnWidth = 15;
            worksheet.Columns[6].ColumnWidth = 20;
            worksheet.Columns[7].ColumnWidth = 20;
            worksheet.Columns[8].ColumnWidth = 20;
            worksheet.Columns[9].ColumnWidth = 30;
            worksheet.Columns[10].ColumnWidth = 30;
            worksheet.Columns[11].ColumnWidth = 35;
            worksheet.Columns[12].ColumnWidth = 20;



            //columns will start at 4
            int counter = 4;








            for (int i = 1; i < dvgReport.Columns.Count + 1; i++)
            {
                worksheet.Cells[1 +counter, i] = dvgReport.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dvgReport.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dvgReport.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2 + counter, j + 1] = dvgReport.Rows[i].Cells[j].Value.ToString();
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

            if ((dateTimeFrom.Value > dateTimeTo.Value) )
            { 
                MessageBox.Show("The date from can not be newer than the to date.");
                dateTimeFrom.Value = dateTimeTo.Value.AddDays(-30);
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
                    +" b.Recipient_Name, b.Contact_No, b.Alt_Contact_No, b.Delivery_Street_Number, b.Delivery_Street_Name, b.Delivery_Complex_Building, b.Delivered   FROM DELIVERIES a LEFT JOIN PARCELS b ON a.Delivery_ID = b.Delivery_ID  WHERE b.Delivered" +
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
            
            dateTimeFrom.Value = DateTime.Today.AddDays(-30);
            dateTimeTo.Value = DateTime.Today;

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

        private void FrmReport_Load(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
