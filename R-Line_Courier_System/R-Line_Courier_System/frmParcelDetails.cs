using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace R_Line_Courier_System
{
    public partial class frmParcelDetails : Form
    {
        private String parcelID;
        private frmMaintainParcels maintain;
        private SqlConnection con;
        private SqlCommand cmd;

        public frmParcelDetails(frmMaintainParcels maintain)
        {
            InitializeComponent();
            this.maintain = maintain;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kobus\Documents\GitHub\R-Line-Courier-System\R-Line_Courier_System\R-Line_Courier_System\RLine_Database.mdf;Integrated Security=True");

            populateControls("SELECT Status_ID,Status_Description FROM PARCEL_STATUS GROUP BY Status_Description,Status_ID", "Status_Description", "Status_ID", cbDeliveryStatus);
            populateControls("SELECT Client_ID,Company_Name FROM CLIENTS group by Company_Name,Client_ID", "Company_Name", "Client_ID", cbCompanyName);
            populateControls("SELECT postal_Code_ID,Postal_Code FROM POSTAL_CODE GROUP BY Postal_Code,Postal_Code_ID", "Postal_Code", "Postal_Code_ID", cbPostalCode);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
            //cbCompanyName.SelectedValue = 3;
            autoFillForm();
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

            

        }

        private void populateControls(String myQuery, String display, String value, ComboBox cb) {

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(myQuery, con);
            DataSet ds = new DataSet();
            
            cb.DisplayMember = display;
            cb.ValueMember = value;
            da.Fill(ds);
            //cb.DataSource = dt;
            cb.DataSource = ds.Tables[0];
            //cbCompanyName.SelectedValue = 3;
            //cb.SelectedItem = null;
            con.Close();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            //to do: load all values to database
            // TO DO: CHECK SQL INJECTION RISK

            MessageBox.Show("INSERT INTO PARCELS(Parcel_Weight, Parcel_Length, Parcel_Width, Parcel_Height, Delivery_Street_Number, Delivery_Street_Name, Delivery_Complex_Building, Contact_No, Alt_Contact_No, Delivery_Due_Date, Recipient_Name) VALUES(" + nudWeight.Value + "," + nudLenght.Value + "," + nudWidth.Value + "," + nudHeight.Value + ",'" + tbxStreetNumber.Text + "','" + tbxStreetName.Text + "','" + tbxBuildingName.Text + "','" + tbxRecipientContactNr.Text + "','" + tbxRecipientAltContactNr.Text + "'," + dateDueDelivery.Value.ToShortDateString() + ",'" + tbxRecepientName.Text + "')");

            SqlCommand cmd = new SqlCommand("INSERT INTO PARCELS(Status_ID, Postal_Code_ID, Client_ID, Parcel_Weight, Parcel_Length, Parcel_Width, Parcel_Height, Delivery_Street_Number, Delivery_Street_Name, Delivery_Complex_Building, Contact_No, Alt_Contact_No, Delivery_Due_Date, Recipient_Name) VALUES(" + cbDeliveryStatus.SelectedValue + "," + cbPostalCode.SelectedValue + "," + cbCompanyName.SelectedValue + "," + nudWeight.Value + "," + nudLenght.Value + "," + nudWidth.Value + "," + nudHeight.Value + ",'" + tbxStreetNumber.Text + "','" + tbxStreetName.Text + "','" + tbxBuildingName.Text + "','" + tbxRecipientContactNr.Text + "','" + tbxRecipientAltContactNr.Text + "','" + dateDueDelivery.Value.ToShortDateString() + "','" + tbxRecepientName.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();

            maintain.dateCheck();

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

        public void autoFillForm() {

            string query = maintain.getQueryAjustment() + " WHERE Parcel_ID =" + parcelID;
            SqlCommand cmd = new SqlCommand(query, con);
            //cbCompanyName.SelectedValue = 3;

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //MessageBox.Show(dr.GetString(18));
                cbCompanyName.SelectedValue = dr.GetValue(18);
                dateDueDelivery.Value = (DateTime)dr.GetValue(2);
                cbDeliveryStatus.SelectedValue = dr.GetValue(19);
                nudWeight.Value = int.Parse(dr.GetValue(4).ToString());
                nudLenght.Value = int.Parse(dr.GetValue(5).ToString());
                nudWidth.Value = int.Parse(dr.GetValue(6).ToString());
                nudHeight.Value = int.Parse(dr.GetValue(7).ToString());
                tbxStreetNumber.Text = dr.GetValue(8).ToString();
                tbxStreetName.Text = dr.GetValue(9).ToString();
                tbxBuildingName.Text = dr.GetValue(10).ToString();
                cbPostalCode.SelectedValue = dr.GetValue(20);
                tbxRecipientContactNr.Text = dr.GetValue(12).ToString();
                tbxRecipientAltContactNr.Text = dr.GetValue(13).ToString();
                //tbDelivered.SelectedItem = dr.GetValue(14);
                tbxRecepientName.Text = dr.GetValue(15).ToString();
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

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE PARCELS SET Status_ID = " + cbDeliveryStatus.SelectedValue.ToString() + ", " +
            "Parcel_Weight = " + (nudWeight.Value).ToString() + ", " +
            "Parcel_Length = " + (nudLenght.Value).ToString() + ", " +
            "Parcel_Width = " + (nudWidth.Value).ToString() + ", " +
            "Parcel_Height = " + (nudHeight.Value).ToString() + ", " +
            "Delivery_Street_Number = '" + tbxStreetNumber.Text + "', " +
            "Delivery_Street_Name = '" + tbxStreetName.Text + "', " +
            "Delivery_Complex_Building = '" + tbxBuildingName.Text + "', " +
            "Postal_Code_ID = " + cbPostalCode.SelectedValue.ToString() + ", " +
            "Contact_No = '" + tbxRecipientContactNr.Text + "', " +
            "Alt_Contact_No = '" + tbxRecipientAltContactNr.Text + "', " +
            "Delivery_Due_Date = '" + dateDueDelivery.Value.ToShortDateString().ToString() + "', " +
            //"Delivered = " + tbDelivered.ToString() + ", " +
            "Recipient_Name = '" + tbxRecepientName.Text + "', " +
            "Client_ID = " + cbCompanyName.SelectedValue.ToString() +
            "WHERE Parcel_ID = " +parcelID, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            maintain.dateCheck();

            btnAddRecord.Enabled = true;
            btnUpdate.Enabled = false;
            this.Close();

            //ClearForm();

        }

        private void cbDeliveryStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test CB Index Changed");
        }
    }
}
