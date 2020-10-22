using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace R_Line_Courier_System {
    public partial class frmParcelDetails : Form {
        private String parcelID;
        private frmMaintainParcels maintain;
        private SqlConnection con;
        private SqlCommand cmd;
        private bool flag;
        private bool btnState;
        private int userID;

        public frmParcelDetails(frmMaintainParcels maintain, bool state, int userID) {
            InitializeComponent();
            this.userID = userID;
            btnState = state;
            flag = false;
            this.maintain = maintain;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RLine_Database.mdf;Integrated Security=True");

            populateControls("SELECT Status_ID,Status_Description FROM PARCEL_STATUS GROUP BY Status_Description,Status_ID", "Status_Description", "Status_ID", cbDeliveryStatus);
            populateControls("SELECT Client_ID,Company_Name FROM CLIENTS group by Company_Name,Client_ID", "Company_Name", "Client_ID", cbCompanyName);
            flag = true;
            populateControls("SELECT postal_Code_ID,Postal_Code FROM POSTAL_CODE GROUP BY Postal_Code,Postal_Code_ID", "Postal_Code", "Postal_Code_ID", cbPostalCode);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            ClearForm();
        }

            
        private void cbCompanyName_SelectedIndexChanged(object sender, EventArgs e) {
            populateClient();
        }

        private void populateClient() {
            if (cbCompanyName.SelectedValue != null && flag) {
                string cquery = "SELECT Contact_Name, Contact_Surname, Contact_No FROM CLIENTS WHERE Client_ID = " + cbCompanyName.SelectedValue.ToString() + "";
                SqlCommand c = new SqlCommand(cquery, con);
                if (con.State != ConnectionState.Open) { con.Open(); }
                SqlDataReader dr = c.ExecuteReader();
                if (dr.Read()) {
                    tbxClientName.Text = dr.GetValue(0).ToString();
                    tbxClientSurname.Text = dr.GetValue(1).ToString();
                    tbxClientContactNr.Text = dr.GetValue(2).ToString();
                }
                con.Close();
                dr.Close();
                c.Dispose();
            }
        }

        private void cbPostalCode_SelectedIndexChanged(object sender, EventArgs e) {
            //to do: load Postal_Codes to ComboBox
        }

        private void ttDueDate_Popup(object sender, PopupEventArgs e) {
            
        }

        private void frmParcelDetails_Load(object sender, EventArgs e) {
            ttDueDate.SetToolTip(this.dateDueDelivery, "Set deadline for parcel delivery");
            tbxClientName.Enabled = false;
            tbxClientSurname.Enabled = false;
            tbxClientContactNr.Enabled = false;
            

        }

        private void populateControls(String myQuery, String display, String value, ComboBox cb) {

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(myQuery, con);
            DataSet ds = new DataSet();
            
            cb.DisplayMember = display;
            cb.ValueMember = value;

            try { da.Fill(ds); } catch (SqlTypeException m) { 
                Console.WriteLine(m.Message); }

            try { cb.DataSource = ds.Tables[0]; } catch (NullReferenceException m) { 
                Console.WriteLine(m.Message); }

            con.Close();
            cb.SelectedIndex = -1;
        }

        private void btnApply_Click(object sender, EventArgs e) {
            if (btnState)
                dataAdd();
            else
                dataUpdate();
        }

        public void setParcelID(String pID) {
            parcelID = pID;
        }

        public void autoFillForm() {

            string query = maintain.getQueryAjustment() + " WHERE Parcel_ID =" + parcelID;
            cmd = new SqlCommand(query, con);
            flag = false;

            con.Open();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() && Int32.TryParse(parcelID, out int c))
                {
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
                    tbxRecepientName.Text = dr.GetValue(15).ToString();
                    if ((bool)dr.GetValue(14))
                        tbDelivered.CheckState = CheckState.Checked;
                }
            }
            catch (SqlException m) { Console.WriteLine(m.Message); }
            con.Close();
            flag = true;
            populateClient();
        }

        private void ClearForm() {
            foreach (Control controls in gbDeliveryInfo.Controls) {
                if (controls.GetType() == typeof(TextBox)) {
                    controls.Text = string.Empty;
                }
                if (controls.GetType() == typeof(ComboBox)) {
                    controls.Text = "";
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
                    controls.Text = "";
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
                    controls.Text = "";
                }
                if (controls.GetType() == typeof(DateTimePicker)) {
                    controls.ResetText();
                }
                if (controls.GetType() == typeof(MaskedTextBox)) {
                    controls.Text = string.Empty;
                }
            }

        }

        private void dataUpdate() {
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
            "Delivered = '" + tbDelivered.Checked.ToString() + "', " +
            "Recipient_Name = '" + tbxRecepientName.Text + "', " +
            "Client_ID = " + cbCompanyName.SelectedValue.ToString() +
            "WHERE Parcel_ID = " +parcelID, con);
            con.Open();

            try { cmd.ExecuteNonQuery(); } catch (SqlException m) { 
                Console.WriteLine(m.Message); }

            con.Close();

            maintain.dateCheck();

            btnApply.Enabled = true;
            this.Close();

            //ClearForm();

        }

        private void dataAdd() {
            SqlCommand cmd = new SqlCommand("INSERT INTO PARCELS(Status_ID, Postal_Code_ID, Client_ID, " +
                "Parcel_Weight, Parcel_Length, Parcel_Width, Parcel_Height, Delivery_Street_Number, Delivery_Street_Name, Delivery_Complex_Building, " +
                "Contact_No, Alt_Contact_No, Delivery_Due_Date, Delivered, Recipient_Name, User_ID) " +
                "VALUES(" + cbDeliveryStatus.SelectedValue + "," + cbPostalCode.SelectedValue + "," + cbCompanyName.SelectedValue + "," + nudWeight.Value + "," + nudLenght.Value + "," +
                nudWidth.Value + "," + nudHeight.Value + ",'" + tbxStreetNumber.Text + "','" + tbxStreetName.Text + "','" + tbxBuildingName.Text + "','" + 
                tbxRecipientContactNr.Text + "','" + tbxRecipientAltContactNr.Text + "','" + dateDueDelivery.Value.ToShortDateString() + "','" + tbDelivered.Checked.ToString() + "','" + 
                tbxRecepientName.Text + "'," + userID.ToString() + ")", con);

            con.Open();

            try { cmd.ExecuteNonQuery(); } catch (SqlException m) { 
                Console.WriteLine(m.Message); }

            maintain.dateCheck();
            con.Close();
        }

        private void cbDeliveryStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void validationCheck() { 
            
        }
    }
}
