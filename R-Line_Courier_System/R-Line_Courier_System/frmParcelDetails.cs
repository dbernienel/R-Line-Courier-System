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
    public partial class frmParcelDetails : Form
    {
        public frmParcelDetails()
        {
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //to do: create function to clear all field types
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //to do: load all values to database
            // TO DO: CHECK SQL INJECTION RISK

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kobus\Documents\GitHub\R-Line-Courier-System\R-Line_Courier_System\R-Line_Courier_System\RLine_Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("INSERT INTO PARCELS(Delivery_Street_Number,Delivery_Street_Name,Delivery_Complex_Building,Contact_No,Alt_Contact_No) VALUES('"+tbxStreetNumber.Text+"','"+tbxStreetName.Text+"','"+tbxBuildingName.Text+"','"+tbxRecipientContactNr.Text+"','"+tbxRecipientAltContactNr.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
            
        private void cbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to do: auto fill all fields if value exist in Clients db else, add new client to Client db
            //to do: disable controls in ControlBox after selection
        }

        private void cbPostalCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to do: load Postal_Codes to ComboBox
        }

        private void ttDueDate_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void frmParcelDetails_Load(object sender, EventArgs e)
        {
            ttDueDate.SetToolTip(this.dateDueDelivery, "Set deadline for parcel delivery");

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kobus\Documents\GitHub\R-Line-Courier-System\R-Line_Courier_System\R-Line_Courier_System\RLine_Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            //populate cbCompanyName
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Client_ID,Company_Name FROM CLIENTS group by Company_Name,Client_ID", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            cbCompanyName.DisplayMember = "Company_Name";
            cbCompanyName.ValueMember = "Client_ID";
            cbCompanyName.DataSource = ds.Tables[0];
            cbCompanyName.SelectedItem = null;
            cbCompanyName.SelectedText = "--Select--";
            con.Close();
            /**********************************************************/

            //populate cbDeliveryStatus
            con.Open();
            cmd.CommandText = "SELECT Status_ID,Status_Description FROM PARCEL_STATUS GROUP BY Status_Description,Status_ID";
            da.SelectCommand = cmd;
            da.Fill(ds);
            cbDeliveryStatus.DisplayMember = "Status_Description";
            cbDeliveryStatus.ValueMember = "Status_ID";
            cbDeliveryStatus.DataSource = ds.Tables[0];
            cbDeliveryStatus.SelectedItem = null;
            cbDeliveryStatus.SelectedText = "--Select--";
            con.Close();
            /**********************************************************/

            //populate cbDeliveryStatus
            con.Open();
            cmd.CommandText = "SELECT postal_Code_ID,Postal_Code FROM POSTAL_CODE GROUP BY Postal_Code,postal_Code_ID";
            da.SelectCommand = cmd;
            da.Fill(ds);
            cbDeliveryStatus.DisplayMember = "Postal_Code";
            cbDeliveryStatus.ValueMember = "Postal_Code_ID";
            cbDeliveryStatus.DataSource = ds.Tables[0];
            cbDeliveryStatus.SelectedItem = null;
            cbDeliveryStatus.SelectedText = "--Select--";
            con.Close();
            con.Dispose();
            /**********************************************************/

        }
    }
}
