using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class DisplayContract : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private Boolean editEnable = false;
        private int id;

        public DisplayContract(int contractID)
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonContracts.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;

            id = contractID;

            FieldsDisabled();

            showContract(id);
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            PageController.Home();
            this.Hide();
            this.Dispose();
        }

        private void ButtonOffers_Click(object sender, EventArgs e)
        {
            PageController.Offers();
            this.Hide();
            this.Dispose();
        }

        private void ButtonContracts_Click(object sender, EventArgs e)
        {
            PageController.Contracts();
            this.Hide();
            this.Dispose();
        }

        private void ButtonClients_Click(object sender, EventArgs e)
        {
            PageController.Clients();
            this.Hide();
            this.Dispose();
        }

        private void ButtonPayments_Click(object sender, EventArgs e)
        {
            PageController.Payments();
            this.Hide();
            this.Dispose();
        }

        private void ButtonHotels_Click(object sender, EventArgs e)
        {
            PageController.Hotels();
            this.Hide();
            this.Dispose();
        }

        private void ButtonTouristGuides_Click(object sender, EventArgs e)
        {
            PageController.TouristGuides();
            this.Hide();
            this.Dispose();
        }

        private void PictureBoxLogout_Click(object sender, EventArgs e)
        {
            PageController.Logout();
            this.Hide();
            this.Dispose();
        }
        private void PictureBoxBack_Click(object sender, EventArgs e)
        {
            PageController.Contracts();
            this.Hide();
            this.Dispose();
        }

        private void showContract(int id)
        {
            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.SelectWithID("Contracts", id);

                while (reader.Read())
                {
                    labelID.Text = reader["ID"].ToString();
                    textBoxContractID.Text = reader["contract_id"].ToString();
                    textBoxOfferID.Text = reader["offer_id"].ToString();
                    textBoxClientID.Text = reader["client_id"].ToString();
                    textBoxEmployeeID.Text = reader["employee_id"].ToString();
                    textBoxPassengerNumber.Text = reader["number_of_passengers"].ToString();
                    textBoxTransport.Text = reader["transport"].ToString();
                    textBoxFullPrice.Text = reader["full_price"].ToString();
                    textBoxDiscount.Text = reader["discount"].ToString();
                    textBoxPaidNow.Text = reader["paid_now"].ToString();
                    textBoxSumPrice.Text = reader["sum_price"].ToString();
                    textBoxNumOfPayments.Text = reader["number_of_payments"].ToString();
                    textBoxPriceEachPayment.Text = reader["price_each_payment"].ToString();
                    textBoxNote.Text = reader["note"].ToString();

                    if (reader["date_first_payment"] != DBNull.Value)
                    {
                        dateTimePickerFirstPayment.Value = Convert.ToDateTime(reader["date_first_payment"]);
                        dateTimePickerLastPayment.Value = Convert.ToDateTime(reader["date_last_payment"]);
                    }
                    else
                    {
                        dateTimePickerFirstPayment.Value = DateTime.Now;
                        dateTimePickerLastPayment.Value = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void PictureBoxEdit_Click(object sender, EventArgs e)
        {
            if (editEnable) {
                FieldsDisabled();

                editEnable = false;
                showContract(id);
            } else
            {
                FieldsEnabled();

                editEnable = true;
                showContract(id);
            }
        }

        private void PictureBoxSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.Command("UPDATE Contracts SET contract_id=@ContractID, offer_id=@OfferID, client_id=@ClientID, employee_id=@EmployeeID, number_of_passengers=@NumberOfPassenger"
                + ", transport=@Transport, full_price=@FullPrice, discount=@Discount, paid_now=@PaidNow, sum_price=@SumPrice, number_of_payments=@NumberOfPayments, " +
                "price_each_payment=@PriceEachPayment, date_first_payment=@DateFirstPayment, date_last_payment=@DateLastPayment, note=@Note WHERE ID = @ID");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", labelID.Text);
            cmd.Parameters.AddWithValue("@ContractID", textBoxContractID.Text.Trim());
            cmd.Parameters.AddWithValue("@OfferID", Convert.ToInt32(textBoxOfferID.Text.Trim()));
            cmd.Parameters.AddWithValue("@ClientID", Convert.ToInt32(textBoxClientID.Text.Trim()));
            cmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(textBoxEmployeeID.Text.Trim()));
            cmd.Parameters.AddWithValue("@NumberOfPassenger", Convert.ToInt32(textBoxPassengerNumber.Text.Trim()));
            cmd.Parameters.AddWithValue("@Transport", textBoxTransport.Text.Trim());
            cmd.Parameters.AddWithValue("@FullPrice", Convert.ToDecimal(textBoxFullPrice.Text.Trim()));
            cmd.Parameters.AddWithValue("@Discount", Convert.ToDecimal(textBoxDiscount.Text.Trim()));
            cmd.Parameters.AddWithValue("@PaidNow", Convert.ToDecimal(textBoxPaidNow.Text.Trim()));
            cmd.Parameters.AddWithValue("@SumPrice", Convert.ToDecimal(textBoxSumPrice.Text.Trim()));
            cmd.Parameters.AddWithValue("@Note", textBoxNote.Text.Trim());

            if(textBoxNumOfPayments.Text != "")
            {
                cmd.Parameters.AddWithValue("@NumberOfPayments", Convert.ToInt32(textBoxNumOfPayments.Text.Trim()));
                cmd.Parameters.AddWithValue("@PriceEachPayment", Convert.ToDecimal(textBoxPriceEachPayment.Text.Trim()));
                cmd.Parameters.AddWithValue("@DateFirstPayment", dateTimePickerFirstPayment.Value);
                cmd.Parameters.AddWithValue("@DateLastPayment", dateTimePickerLastPayment.Value);
            } else
            {
                cmd.Parameters.AddWithValue("@NumberOfPayments", DBNull.Value);
                cmd.Parameters.AddWithValue("@PriceEachPayment", DBNull.Value);
                cmd.Parameters.AddWithValue("@DateFirstPayment", DBNull.Value);
                cmd.Parameters.AddWithValue("@DateLastPayment", DBNull.Value);
            }

            try
            {
                conn.OpenConnection();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Contract is successfully updated.");

                    FieldsDisabled();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
                showContract(id);
            }
        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.OpenConnection();

                if (conn.DeleteWithID("Contracts",id))
                {
                    MessageBox.Show("Contract is successfully deleted.");
                    PageController.Contracts();
                    this.Hide();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        //Open PDF file of contract
        private void PictureBoxOpenPDF_Click(object sender, EventArgs e)
        {
            string filename = textBoxContractID.Text.Trim() + ".pdf";
            string path = "c:\\Users\\" + Environment.UserName + "\\Documents\\Travel Agency\\Contracts\\";
            try
            {
                System.Diagnostics.Process.Start(path+filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FieldsEnabled()
        {
            pictureBoxSave.Enabled = true;
            labelSave.Enabled = true;
            pictureBoxDelete.Enabled = false;
            labelDelete.Enabled = false;

            textBoxContractID.Enabled = true;
            textBoxOfferID.Enabled = true;
            textBoxClientID.Enabled = true;
            textBoxEmployeeID.Enabled = true;
            textBoxPassengerNumber.Enabled = true;
            textBoxTransport.Enabled = true;
            textBoxFullPrice.Enabled = true;
            textBoxDiscount.Enabled = true;
            textBoxPaidNow.Enabled = true;
            textBoxSumPrice.Enabled = true;
            textBoxNumOfPayments.Enabled = true;
            textBoxPriceEachPayment.Enabled = true;
            dateTimePickerFirstPayment.Enabled = true;
            dateTimePickerLastPayment.Enabled = true;
            textBoxNote.Enabled = true;
        }

        private void FieldsDisabled()
        {
            pictureBoxSave.Enabled = false;
            labelSave.Enabled = false;
            pictureBoxDelete.Enabled = true;
            labelDelete.Enabled = true;

            textBoxContractID.Enabled = false;
            textBoxOfferID.Enabled = false;
            textBoxClientID.Enabled = false;
            textBoxEmployeeID.Enabled = false;
            textBoxPassengerNumber.Enabled = false;
            textBoxTransport.Enabled = false;
            textBoxFullPrice.Enabled = false;
            textBoxDiscount.Enabled = false;
            textBoxPaidNow.Enabled = false;
            textBoxSumPrice.Enabled = false;
            textBoxNumOfPayments.Enabled = false;
            textBoxPriceEachPayment.Enabled = false;
            dateTimePickerFirstPayment.Enabled = false;
            dateTimePickerLastPayment.Enabled = false;
            textBoxNote.Enabled = false;
        }

        //Check if input is number
        private void TextBoxContractID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxOfferID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxClientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxPassengerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxFullPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxPaidNow_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxSumPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxNumOfPayments_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxPriceEachPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        private void DisplayContract_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
