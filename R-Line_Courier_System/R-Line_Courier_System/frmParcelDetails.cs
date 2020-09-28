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
        private String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kobus\Documents\GitHub\R-Line-Courier-System\R-Line_Courier_System\R-Line_Courier_System\RLine_Database.mdf;Integrated Security=True";
        private String parcelID;

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
            ClearForm();
        }

            
        private void cbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to do: auto fill all fields if value exist in Clients db else, add new client to Client db
            //to do: disable controls in ControlBox after selection
            cbCompanyName.ForeColor = System.Drawing.Color.Black;
        }

        private void cbPostalCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to do: load Postal_Codes to ComboBox
            cbPostalCode.ForeColor = System.Drawing.Color.Black;
        }

        private void ttDueDate_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void frmParcelDetails_Load(object sender, EventArgs e)
        {
            ttDueDate.SetToolTip(this.dateDueDelivery, "Set deadline for parcel delivery");

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

            //populate delivery address
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

            cbCompanyName.ForeColor = System.Drawing.Color.Gray;
            cbPostalCode.ForeColor = System.Drawing.Color.Gray;
            cbDeliveryStatus.ForeColor = System.Drawing.Color.Gray;

        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            //to do: load all values to database
            // TO DO: CHECK SQL INJECTION RISK

            SqlConnection con = new SqlConnection(conString);

            MessageBox.Show("INSERT INTO PARCELS(Parcel_Weight, Parcel_Length, Parcel_Width, Parcel_Height, Delivery_Street_Number, Delivery_Street_Name, Delivery_Complex_Building, Contact_No, Alt_Contact_No, Delivery_Due_Date, Recipient_Name) VALUES(" + nudWeight.Value + "," + nudLenght.Value + "," + nudWidth.Value + "," + nudHeight.Value + ",'" + tbxStreetNumber.Text + "','" + tbxStreetName.Text + "','" + tbxBuildingName.Text + "','" + tbxRecipientContactNr.Text + "','" + tbxRecipientAltContactNr.Text + "'," + dateDueDelivery.Value.ToShortDateString() + ",'" + tbxRecepientName.Text + "')");

            SqlCommand cmd = new SqlCommand("INSERT INTO PARCELS(Parcel_Weight, Parcel_Length, Parcel_Width, Parcel_Height, Delivery_Street_Number, Delivery_Street_Name, Delivery_Complex_Building, Contact_No, Alt_Contact_No, Delivery_Due_Date, Recipient_Name) VALUES(" + nudWeight.Value + "," + nudLenght.Value + "," + nudWidth.Value + "," + nudHeight.Value + ",'" + tbxStreetNumber.Text + "','" + tbxStreetName.Text + "','" + tbxBuildingName.Text + "','" + tbxRecipientContactNr.Text + "','" + tbxRecipientAltContactNr.Text + "','" + dateDueDelivery.Value.ToShortDateString() + "','" + tbxRecepientName.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();

            frmMaintainParcels maintain = new frmMaintainParcels();
            maintain.refreshDGV();

            con.Close();
        }

        public void disableButton(bool btnIsPressed) {
            if (btnIsPressed)
                btnUpdate.Enabled = false;
            else {
                btnAddRecord.Enabled = false;
                tbxClientName.Enabled = false;
                tbxClientSurname.Enabled = false;
                tbxClientContactNr.Enabled = false;
            }
        }

        public void setParcelID(String pID) {
            parcelID = pID;
        }

        public String getParcelID() {
            return parcelID;
        }

        public void autoFillForm() {
            tbxClientName.Text = "working";

            SqlConnection con = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("SELECT * FROM PARCELS WHERE Parcel_ID ="+parcelID.ToString(), con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbxStreetNumber.Text = dr.GetValue(7).ToString();
                tbxStreetName.Text = dr.GetValue(8).ToString();
                tbxBuildingName.Text = dr.GetValue(9).ToString();
                //postal code
                tbxRecepientName.Text = dr.GetValue(15).ToString();
                tbxRecipientContactNr.Text = dr.GetValue(11).ToString();
                tbxRecipientAltContactNr.Text = dr.GetValue(12).ToString();
                //Company name
                //weight
            }
            con.Close();
        }

        private void ClearForm() {
            foreach (Control controls in gbDeliveryInfo.Controls) {
                if (controls.GetType() == typeof(TextBox)) {
                    controls.Text = string.Empty;
                }
                if (controls.GetType() == typeof(ComboBox)) {
                    controls.Text = "--Select--";
                }
                if (controls.GetType() == typeof(DateTimePicker)) {
                    controls.ResetText();
                }
                if (controls.GetType() == typeof(MaskedTextBox)) {
                    controls.Text = string.Empty;
                }
            }
            foreach (Control controls in gbDeliveryAdress.Controls) {
                if (controls.GetType() == typeof(TextBox)) {
                    controls.Text = string.Empty;
                }
                if (controls.GetType() == typeof(ComboBox)) {
                    controls.Text = "--Select--";
                }
                if (controls.GetType() == typeof(DateTimePicker)) {
                    controls.ResetText();
                }
                if (controls.GetType() == typeof(MaskedTextBox)) {
                    controls.Text = string.Empty;
                }
            }
            foreach (Control controls in gbClientInfo.Controls) {
                if (controls.GetType() == typeof(TextBox)) {
                    controls.Text = string.Empty;
                }
                if (controls.GetType() == typeof(ComboBox)) {
                    controls.Text = "--Select--";
                }
                if (controls.GetType() == typeof(DateTimePicker)) {
                    controls.ResetText();
                }
                if (controls.GetType() == typeof(MaskedTextBox)) {
                    controls.Text = string.Empty;
                }
            }

            cbCompanyName.ForeColor = System.Drawing.Color.Gray;
            cbPostalCode.ForeColor = System.Drawing.Color.Gray;
            cbDeliveryStatus.ForeColor = System.Drawing.Color.Gray;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("UPDATE PARCELS SET Delivery_Street_Number = '" + tbxStreetNumber.Text + "', Delivery_Street_Name = '" + tbxStreetName.Text + "', Delivery_Complex_Building = '" + tbxBuildingName.Text + "', Contact_No = '" + tbxRecipientContactNr.Text + "', Alt_Contact_No = '" + tbxRecipientAltContactNr.Text + "' WHERE Parcel_ID = "+parcelID+"", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            
            //maintain.refreshDGV();

            btnAddRecord.Enabled = true;
            btnUpdate.Enabled = false;

            ClearForm();

        }

        private void cbDeliveryStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDeliveryStatus.ForeColor = System.Drawing.Color.Black;
        }
    }
}
