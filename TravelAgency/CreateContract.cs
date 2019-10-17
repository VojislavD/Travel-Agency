using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class CreateContract : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        int OfferId, OfferDays, touristGuideId, hotelID;
        decimal OfferPrice, transportPrice,paidNow;
        string OfferCountry, OfferCity, room, meals, touristGuideName, touristGuidePhone, touristGuideEmail, hotelName, hotelAddress, hotelPhone;
        DateTime date_departure, date_return;
        string transport, contractID;
        

        public CreateContract(int ID, string Country, string City, int Days, string Room, string Meals, DateTime Date_departure, DateTime Date_return, int HotelID,decimal Price, decimal TransportPrice, int TouristGuideId)
        {
            OfferId = ID;
            OfferCountry = Country;
            OfferCity = City;
            OfferDays = Days;
            room = Room;
            meals = Meals;
            date_departure = Date_departure;
            date_return = Date_return;
            OfferPrice = Price;
            transportPrice = TransportPrice;
            touristGuideId = TouristGuideId;
            hotelID = HotelID;

            Data.firstName = "";
            Data.lastName = "";
            Data.JMBG = "";
            Data.age = "";
            Data.passportNumber = "";
            Data.citizenship = "";
            Data.email = "";
            Data.phone = "";

            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonOffers.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;

            displayOfferInformation();

            labelFullPrice.Text = (OfferPrice + transportPrice).ToString();
            labelDiscount.Text = "0";
            labelSumPrice.Text = (OfferPrice + transportPrice).ToString();
            labelAmountPerPayment.Text = "";
            transport = "Agency";

            getTouristGuide(touristGuideId);
            getHotel(hotelID);
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
            PageController.DisplayOffer(OfferId);
            this.Hide();
            this.Dispose();
        }

        private void displayOfferInformation()
        {
            labelOfferID.Text = OfferId.ToString();
            labelOfferInformation.Text = OfferCity + ", " + OfferCountry+" - "+date_departure.ToString("dd.MM.yyyy")+"\n"+ OfferDays + " days - "+ OfferPrice + "e";

        }

        private void ButtonChooseClient_MouseClick(object sender, MouseEventArgs e)
        {
            PageController.AddClient();
        }

        private void CreateContract_Activated(object sender, EventArgs e)
        {
            //Set data for client
            labelFirstName.Text = Data.firstName;
            labelLastName.Text = Data.lastName;
            labelAge.Text = Data.age;
            labelJMBG.Text = Data.JMBG;
            labelPassportNumber.Text = Data.passportNumber;
            labelCitizenship.Text = Data.citizenship;
            labelPhone.Text = Data.phone;
            labelEmail.Text = Data.email;
        }

        private void getTouristGuide(int id)
        {
            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.SelectWithID("TouristGuides", id);

                if (reader.Read())
                {
                    touristGuideName = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                    touristGuidePhone = reader["phone"].ToString();
                    touristGuideEmail = reader["email"].ToString();
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

        private void getHotel(int id)
        {
            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.SelectWithID("hotels", id);

                if (reader.Read())
                {
                    hotelName = reader["name"].ToString();
                    hotelAddress = reader["address"].ToString();
                    hotelPhone = reader["phone"].ToString();
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

        private void TextBoxPassengersNumber_TextChanged(object sender, EventArgs e)
        {
            CalculateFullPrice();
            CalculateSumPrice();
            CalculateDiscount();
            CalculateAmountPerPayment();
        }

        private void CalculateFullPrice()
        {
            if (textBoxPassengersNumber.Text == "" && radioButtonTransportAgency.Checked == true)
            {
                labelFullPrice.Text = (OfferPrice + transportPrice).ToString();
            }
            else if (textBoxPassengersNumber.Text == "" && radioButtonTransportOwn.Checked == true)
            {
                labelFullPrice.Text = OfferPrice.ToString();
            }
            else if (textBoxPassengersNumber.Text != "" && radioButtonTransportAgency.Checked == true)
            {
                labelFullPrice.Text = (Convert.ToInt32(textBoxPassengersNumber.Text.Trim()) * (OfferPrice + transportPrice)).ToString();
            }
            else if (textBoxPassengersNumber.Text != "" && radioButtonTransportOwn.Checked == true)
            {
                labelFullPrice.Text = (Convert.ToInt32(textBoxPassengersNumber.Text.Trim()) * OfferPrice).ToString();
            }
        }

        private void CalculateDiscount()
        {
            if (radioButtonNone.Checked == true)
            {
                labelDiscount.Text = "0";
                paidNow = 0;
            }
            else if (radioButtonHalf.Checked == true)
            {
                labelDiscount.Text = (Convert.ToInt32(labelFullPrice.Text) * 0.05).ToString();
                paidNow = Convert.ToDecimal(labelSumPrice.Text) / 2;
            }
            else if (radioButtonComplete.Checked == true)
            {
                labelDiscount.Text = (Convert.ToInt32(labelFullPrice.Text) * 0.15).ToString();
                paidNow = Convert.ToDecimal(labelSumPrice.Text);
            }
        }

        private void CalculateSumPrice()
        {
            if (radioButtonNone.Checked == true)
            {
                labelSumPrice.Text = labelFullPrice.Text.ToString();
            }
            else if (radioButtonHalf.Checked == true)
            {
                labelSumPrice.Text = (Convert.ToInt32(labelFullPrice.Text) - (Convert.ToInt32(labelFullPrice.Text) * 0.05)).ToString();
            }
            else if (radioButtonComplete.Checked == true)
            {
                labelSumPrice.Text = (Convert.ToInt32(labelFullPrice.Text) - (Convert.ToInt32(labelFullPrice.Text) * 0.15)).ToString();
            }
        }

        private void CalculateAmountPerPayment()
        {
            if (textBoxNumPayments.Text == "" || textBoxNumPayments.Text == "0")
            {
                labelAmountPerPayment.Text = "";
            }
            else
            {
                labelAmountPerPayment.Text = ((Convert.ToDecimal(labelSumPrice.Text) - paidNow) / Convert.ToInt32(textBoxNumPayments.Text.Trim())).ToString("0.00");
            }
        }

        //When paid now is changed to none
        private void RadioButtonNone_CheckedChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
            CalculateSumPrice();
            CalculateAmountPerPayment();
            textBoxNumPayments.Enabled = true;
            dateTimePickerFirstPayment.Enabled = true;
            dateTimePickerLastPayment.Enabled = true;
        }

        //When paid now is changed to half
        private void RadioButtonHalf_CheckedChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
            CalculateSumPrice();
            CalculateAmountPerPayment();
            textBoxNumPayments.Enabled = true;
            dateTimePickerFirstPayment.Enabled = true;
            dateTimePickerLastPayment.Enabled = true;
        }

        //When paid now is changed to complete
        private void RadioButtonComplete_CheckedChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
            CalculateSumPrice();
            CalculateAmountPerPayment();
            textBoxNumPayments.Text = "";
            textBoxNumPayments.Enabled = false;
            dateTimePickerFirstPayment.Enabled = false;
            dateTimePickerLastPayment.Enabled = false;
            labelAmountPerPayment.Text = "";
        }

        //When transport is changed to agency
        private void RadioButtonTransportAgency_CheckedChanged(object sender, EventArgs e)
        {
            CalculateFullPrice();
            CalculateDiscount();
            CalculateSumPrice();
            CalculateAmountPerPayment();
            transport = "Agency";
        }

        //When transport is changed to own
        private void RadioButtonTransportOwn_CheckedChanged(object sender, EventArgs e)
        {
            CalculateFullPrice();
            CalculateDiscount();
            CalculateSumPrice();
            CalculateAmountPerPayment();
            transport = "Own";
        }

        private void TextBoxNumPayments_TextChanged(object sender, EventArgs e)
        {
            CalculateAmountPerPayment();
        }

        private void PictureBoxSave_Click(object sender, EventArgs e)
        {
            int passengersNumber;
            if (textBoxPassengersNumber.Text == "")
            {
                passengersNumber = 1;
            }
            else
            {
                passengersNumber = Convert.ToInt32(textBoxPassengersNumber.Text.Trim());
            }

            getNextContractID();
            if (checkCapacityAvailable(passengersNumber))
            {
                string clientName = labelFirstName.Text + " " + labelLastName.Text;
                string clientJMBG = labelJMBG.Text;
                string clientPassport = labelPassportNumber.Text;
                string clientAge = labelAge.Text;
                string clientPhone = labelPhone.Text;
                string clientEmail = labelEmail.Text;
                string daysP = OfferDays.ToString();
                string dateDeparture = date_departure.ToString("dd-MM-yyyy");
                string dateReturn = date_return.ToString("dd-MM-yyyy");
                string numOfPassengers = passengersNumber.ToString();
                string fullPrice = labelFullPrice.Text;
                string discount = labelDiscount.Text;
                string sumPrice = labelSumPrice.Text;
                string paidNowP = paidNow.ToString();
                string leftToPay = (Convert.ToDecimal(labelSumPrice.Text) - paidNow).ToString();
                string numOfPayments = textBoxNumPayments.Text.Trim();
                string priceEachPayment = labelAmountPerPayment.Text;
                string dateFirstPayment = dateTimePickerFirstPayment.Value.ToString("dd.MM.yyyy");
                string dateLastPayment = dateTimePickerLastPayment.Value.ToString("dd.MM.yyyy");
                string note = textBoxNote.Text.Trim();

                if (radioButtonComplete.Checked == true)
                {
                    //Insert new contract when paid now is complete
                    if (labelFirstName.Text != "" && OfferId != 0 && Data.id != 0 && User.UserID != 0 && textBoxPassengersNumber.Text != "0" && labelFullPrice.Text != "" && labelDiscount.Text != "" && labelSumPrice.Text != "")
                    {
                        SqlCommand cmd = conn.Command("INSERT INTO Contracts (contract_id,offer_id,client_id,employee_id, number_of_passengers, transport, full_price, discount, paid_now, sum_price, note) "
                            + "VALUES(@ContractID, @OfferID, @ClientID, @EmployeeId, @NumOfPassenger, @Transport, @FullPrice, @Discount, @PaidNow, @SumPrice, @Note)");
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ContractID", contractID);
                        cmd.Parameters.AddWithValue("@OfferID", OfferId);
                        cmd.Parameters.AddWithValue("@ClientID", Data.id);
                        cmd.Parameters.AddWithValue("@EmployeeId", User.UserID);
                        cmd.Parameters.AddWithValue("@NumOfPassenger", passengersNumber);
                        cmd.Parameters.AddWithValue("@Transport", transport);
                        cmd.Parameters.AddWithValue("@FullPrice", Convert.ToDecimal(labelFullPrice.Text));
                        cmd.Parameters.AddWithValue("@Discount", Convert.ToDecimal(labelDiscount.Text));
                        cmd.Parameters.AddWithValue("@PaidNow", paidNow);
                        cmd.Parameters.AddWithValue("@SumPrice", Convert.ToDecimal(labelSumPrice.Text));
                        cmd.Parameters.AddWithValue("@Note", note);

                        try
                        {
                            conn.OpenConnection();
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                //create PDF file
                                new CreatePDF(contractID, touristGuideName, touristGuidePhone, touristGuideEmail, clientName, clientJMBG, clientPassport,
                                    clientAge, clientPhone, clientEmail, OfferCountry, OfferCity, daysP, room, meals, dateDeparture, dateReturn, hotelName,
                                    hotelAddress, hotelPhone, numOfPassengers, fullPrice, discount, sumPrice, paidNowP, leftToPay, numOfPayments, priceEachPayment,
                                    dateFirstPayment, dateLastPayment);

                                MessageBox.Show("Contract is successfully saved.");
                                changeCapacityAvailable(passengersNumber, OfferId);
                                int IdOfContract = Convert.ToInt32(contractID.Remove(contractID.Length - 5));
                                PageController.DisplayContract(IdOfContract);
                                this.Hide();
                                this.Dispose();
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conn.CloseConnection();
                        }
                    }
                    else
                    {
                        MessageBox.Show("All fields are required. Please try again.");
                    }
                }
                else
                {
                    //Insert new contract when paid now is none or half
                    if (labelFirstName.Text != "" && OfferId != 0 && Data.id != 0 && User.UserID != 0 && textBoxPassengersNumber.Text != "0" && labelFullPrice.Text != "" && labelDiscount.Text != "" && labelSumPrice.Text != "" && textBoxNumPayments.Text != "0" && textBoxNumPayments.Text != "" && labelAmountPerPayment.Text != "0")
                    {
                        SqlCommand cmd = conn.Command("INSERT INTO Contracts (contract_id,offer_id,client_id,employee_id, number_of_passengers, transport, full_price, discount, paid_now, sum_price, number_of_payments, price_each_payment, date_first_payment,date_last_payment, note) "
                            + "VALUES(@ContractID, @OfferID, @ClientID, @EmployeeId, @NumOfPassenger, @Transport, @FullPrice, @Discount, @PaidNow, @SumPrice, @NumberOfPayments, @PriceOfEachPayment, @DateFirstPayment, @DateLastPayment, @Note)");
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ContractID", contractID);
                        cmd.Parameters.AddWithValue("@OfferID", OfferId);
                        cmd.Parameters.AddWithValue("@ClientID", Data.id);
                        cmd.Parameters.AddWithValue("@EmployeeId", User.UserID);
                        cmd.Parameters.AddWithValue("@NumOfPassenger", passengersNumber);
                        cmd.Parameters.AddWithValue("@Transport", transport);
                        cmd.Parameters.AddWithValue("@FullPrice", Convert.ToDecimal(labelFullPrice.Text));
                        cmd.Parameters.AddWithValue("@Discount", Convert.ToDecimal(labelDiscount.Text));
                        cmd.Parameters.AddWithValue("@PaidNow", paidNow);
                        cmd.Parameters.AddWithValue("@SumPrice", Convert.ToDecimal(labelSumPrice.Text));
                        cmd.Parameters.AddWithValue("@NumberOfPayments", Convert.ToInt32(textBoxNumPayments.Text));
                        cmd.Parameters.AddWithValue("@PriceOfEachPayment", Convert.ToDecimal(labelAmountPerPayment.Text));
                        cmd.Parameters.AddWithValue("@DateFirstPayment", dateTimePickerFirstPayment.Value);
                        cmd.Parameters.AddWithValue("@DateLastPayment", dateTimePickerLastPayment.Value);
                        cmd.Parameters.AddWithValue("@Note", note);

                        try
                        {
                            conn.OpenConnection();
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                //create PDF file
                                new CreatePDF(contractID, touristGuideName, touristGuidePhone, touristGuideEmail, clientName, clientJMBG, clientPassport,
                                    clientAge, clientPhone, clientEmail, OfferCountry, OfferCity, daysP, room, meals, dateDeparture, dateReturn, hotelName,
                                    hotelAddress, hotelPhone, numOfPassengers, fullPrice, discount, sumPrice, paidNowP, leftToPay, numOfPayments, priceEachPayment,
                                    dateFirstPayment, dateLastPayment);

                                MessageBox.Show("Contract is successfully saved.");
                                changeCapacityAvailable(passengersNumber, OfferId);
                                int IdOfContract = Convert.ToInt32(contractID.Remove(contractID.Length - 5));
                                PageController.DisplayContract(IdOfContract);
                                this.Hide();
                                this.Dispose();
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conn.CloseConnection();
                        }
                    }
                    else
                    {
                        MessageBox.Show("All fields are required. Please try again.");
                    }
                }
            } else
            {
                MessageBox.Show("There is no enough capacity available.");
            }
        }

        private bool checkCapacityAvailable(int passNumb)
        {
            SqlCommand cmd = conn.Command("SELECT capacity_available FROM Offers WHERE ID=@ID");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", OfferId);

            try
            {
                conn.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    if(Convert.ToInt32(reader["capacity_available"]) < passNumb)
                    {
                        return false;
                    } else
                    {
                        return true;
                    }
                } else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void changeCapacityAvailable(int numberOfPassengers, int id)
        {
            conn.CloseConnection();

            SqlCommand cmd = conn.Command("UPDATE Offers SET capacity_available=capacity_available-@NumOfPassengers WHERE ID=@ID");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@NumOfPassengers", numberOfPassengers);

            try
            {
                conn.OpenConnection();
                int result = cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void getNextContractID()
        {
            SqlCommand cmd = conn.Command("SELECT IDENT_CURRENT('Contracts')+1");

            try
            {
                conn.OpenConnection();
                contractID = cmd.ExecuteScalar().ToString() + "-" + DateTime.Now.ToString("yyyy");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        //Check if input is number
        private void TextBoxPassengersNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxNumPayments_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        private void CreateContract_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
