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
    public partial class frmDeliveryReport : Form
    {

        //public variables
        public SqlConnection cnn;
        public SqlDataReader dataReader;
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True";
        public SqlCommand cmd;
        public SqlDataAdapter adapter;


        public frmDeliveryReport()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cbxRegNo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle first.");
            }
            else
            {

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Deliveries";

                Microsoft.Office.Interop.Excel.Style myStyle1 = workbook.Styles.Add("myStyle1");
                myStyle1.Font.Name = "Verdana";
                myStyle1.Font.Size = 12;
                myStyle1.Font.Bold = true;
                myStyle1.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                myStyle1.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid;

                Microsoft.Office.Interop.Excel.Style myStyle2 = workbook.Styles.Add("myStyle2");
                myStyle2.Font.Name = "Verdana";
                myStyle2.Font.Size = 11;
                myStyle2.Font.Bold = true;
                myStyle2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                myStyle2.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
                myStyle2.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid;


                worksheet.Cells[1, 1] = "R-Line Courier System";
                worksheet.Cells[2, 1] = "Vehicle " + cbxRegNo.Text + " delivery information for " + (dateTimeDeliver.Value.ToString()).Substring(0, 10);
                worksheet.Cells[3, 1] = "Report dated " + DateTime.Now.ToString();

                Microsoft.Office.Interop.Excel.Range formatRange;
                formatRange = worksheet.get_Range("a1", "c3");
                formatRange.Style = "myStyle1";

                formatRange = worksheet.get_Range("a5", "l5");
                formatRange.Style = "myStyle2";
                formatRange.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);

                formatRange.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);

                worksheet.Columns[1].ColumnWidth = 20;
                worksheet.Columns[2].ColumnWidth = 20;
                worksheet.Columns[3].ColumnWidth = 25;
                worksheet.Columns[4].ColumnWidth = 20;
                worksheet.Columns[5].ColumnWidth = 25;
                worksheet.Columns[6].ColumnWidth = 20;
                worksheet.Columns[7].ColumnWidth = 20;
                worksheet.Columns[8].ColumnWidth = 20;
                worksheet.Columns[9].ColumnWidth = 35;
                worksheet.Columns[10].ColumnWidth = 35;
                worksheet.Columns[11].ColumnWidth = 35;
                worksheet.Columns[12].ColumnWidth = 20;

                //columns will start at 4
                int counter = 4;


                for (int i = 1; i < dgvDeliveries.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1 + counter, i] = dgvDeliveries.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvDeliveries.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvDeliveries.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2 + counter, j + 1] = dgvDeliveries.Rows[i].Cells[j].Value.ToString();
                    }
                }


                app.Quit();
            }
        }

            private void OpenConnection() //open sqlconnection
        {
            if (cnn != null && cnn.State == ConnectionState.Closed)
                cnn.Open();
        }
        private void clearForm()
        {

        }
        private void populateComboBox()
        {
            cbxRegNo.Items.Clear();
            cnn = new SqlConnection(connectionString);


            cmd = new SqlCommand("SELECT * FROM VEHICLES", cnn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "Deliveries");

         

            cbxRegNo.DisplayMember = "Reg_No";
            cbxRegNo.ValueMember = "Vehicle_ID";
           // da.Fill(ds);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "Deliveries");
            cbxRegNo.DataSource = ds.Tables[0];
            cnn.Close();
            cbxRegNo.SelectedItem = null;

            cbxRegNo.Text = "Select Vehicle";
        }
    

        private int getVehicleID(String RegNo)
        {
            int id = -1;
            cnn = new SqlConnection(connectionString);
            var sql = @"Select * FROM VEHICLES WHERE Reg_No = '" + RegNo + "'";
            OpenConnection();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                if (RegNo == dataReader.GetValue(1).ToString()) 
                {
                    id = Int32.Parse(dataReader.GetValue(0).ToString());
                    cnn.Close();
                    return id;
                }
                else
                {
                    cnn.Close();
                    return -1;
                }
            }
            cnn.Close();
            return id;

            
        }

    private void FillGrid()
        {
            
            String deliveryDate = dateTimeDeliver.Value.ToShortDateString();
            String vehicleRegNo = cbxRegNo.Text;
             int vehicleID = getVehicleID(cbxRegNo.Text);
          
            cnn = new SqlConnection(connectionString);
            var sql = "";
            if (vehicleID == -1) 
            {
                sql = @"SELECT a.Delivery_ID, a.Vehicle_ID, b.Delivery_Due_Date, a.Delivery_Date, b.Parcel_ID, b.Recipient_Name, b.Contact_No, B.Alt_Contact_No, b.Delivery_Street_Number, b.Delivery_Street_Name, b.Delivery_Complex_Building, b.Delivered   FROM DELIVERIES a LEFT JOIN PARCELS b ON a.Delivery_ID = b.Delivery_ID  WHERE  a.Delivery_Date = '" + deliveryDate + "' ";
            }
            else
            {

                sql = @"SELECT a.Delivery_ID, a.Vehicle_ID, b.Delivery_Due_Date, a.Delivery_Date, b.Parcel_ID, b.Recipient_Name, b.Contact_No, B.Alt_Contact_No, b.Delivery_Street_Number, b.Delivery_Street_Name, b.Delivery_Complex_Building, b.Delivered   FROM DELIVERIES a LEFT JOIN PARCELS b ON a.Delivery_ID = b.Delivery_ID  WHERE a.Vehicle_ID" +
                    " LIKE '%" + vehicleID + "%' AND a.Delivery_Date = '" + deliveryDate + "' ";
            }
            OpenConnection();
            cmd = new SqlCommand(sql, cnn);


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "Deliveries");

            dgvDeliveries.DataSource = ds;
            dgvDeliveries.DataMember = "Deliveries";

            cnn.Close();

            //   cmd.ExecuteNonQuery();
        }

        private void DateTimeDeliver_ValueChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void CbxRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FrmDeliveryReport_Activated(object sender, EventArgs e)
        {
            dgvDeliveries.ReadOnly = true;
            clearForm();
            populateComboBox();
            dateTimeDeliver.Value = DateTime.Now;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);

            cnn.Open();
            try { SqlCommand cmd = new SqlCommand("UPDATE PARCELS SET DELIVERED = 1 WHERE  Parcel_ID=" + dgvDeliveries.SelectedCells[1].Value.ToString(), cnn);            MessageBox.Show("Parcel ID " + dgvDeliveries.SelectedCells[1].Value.ToString() + " successfully delivered"); } catch (ArgumentOutOfRangeException m) { Console.WriteLine(m.Message); }

            try { cmd.ExecuteNonQuery(); } catch (SqlException m) { Console.WriteLine(m.Message); } catch (InvalidOperationException m) { Console.WriteLine(m.Message); }


        }

        private void DgvDeliveries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
