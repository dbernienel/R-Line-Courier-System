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
        string mode;
        string sql;

        public frmDeliveryReport()
        {
            InitializeComponent();
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
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Deliveries";
            // storing header part in Excel  
            for (int i = 1; i < dgvDeliveries.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvDeliveries.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvDeliveries.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvDeliveries.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvDeliveries.Rows[i].Cells[j].Value.ToString();
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
        private void clearForm()
        {
            //
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
                    cnn.Close();
                    return Int32.Parse(dataReader.GetValue(0).ToString());
                }
                else
                {
                    cnn.Close();
                    return -1;
                }
            }
            cnn.Close();
            return -1;

            
        }

    private void FillGrid()
        {
            String deliveryDate = dateTimeDeliver.Value.ToShortDateString();
            String vehicleRegNo = cbxRegNo.Text;
            //  int vehicleID = getVehicleID(cbxRegNo.Text);
            int vehicleID = 1;
            cnn = new SqlConnection(connectionString);
            var sql = "";
            if (vehicleID == null) 
            {
                sql = @"Select * FROM DELIVERIES";
            }
            else
            {

                // Kobus - join sql
                sql = @"Select * FROM DELIVERIES a RIGHT JOIN WHERE a.Vehicle_ID LIKE '%" + vehicleID + "%' AND Delivery_Date = '" + deliveryDate + "'"+
                    "LEFT JOIN PARCELS ON DELIVERIES.Delivery_ID = PARCELS.Delivery_ID";
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
            clearForm();
            populateComboBox();
            dateTimeDeliver.Value = DateTime.Now;
        }
    }
}
