using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class AddNewOffer : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        public AddNewOffer()
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonOffers.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;
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
            PageController.Hotels();
            this.Hide();
            this.Dispose();
        }

        private void PictureBoxSave_Click(object sender, EventArgs e)
        {
            string country = textBoxCountry.Text.Trim();
            string city = textBoxCity.Text.Trim();
            string days = textBoxDays.Text.Trim();
            DateTime dateDeparture = dateTimePickerDateDeparture.Value;
            DateTime dateReturn = dateTimePickerDateReturn.Value;
            string description = textBoxDescription.Text.Trim();
            string price = textBoxPrice.Text.Trim();
            string transportPrice = textBoxTransportPrice.Text.Trim();
            string capacityAvailable = textBoxCapacityAvailable.Text.Trim();
            string hotel = labelHotelID.Text.Trim();
            string touristGuide = labelTouristGuideID.Text.Trim();
            string visaRequired, room, meals, offerType;

            visaRequired = (radioButtonVisaRequiredYes.Checked == true) ? "Yes" : "No";
            meals = (checkBoxMealsBreakfast.Checked == true) ? "Breakfast " : "";
            meals += (checkBoxMealsLunch.Checked == true) ? "Lunch " : "";
            meals += (checkBoxMealsDinner.Checked == true) ? "Dinner " : "";

            offerType = (radioButtonTypeStandard.Checked == true) ? "Standard" :
                        (radioButtonTypeCruise.Checked == true) ? "Cruise" :
                        (radioButtonTypeLastMinute.Checked == true) ? "Last minute" : "";

            room = (radioButtonRoom1Bed.Checked == true) ? "1 bed" :
                   (radioButtonRoom2Beds.Checked == true) ? "2 beds" :
                   (radioButtonRoom3Beds.Checked == true) ? "3 beds" :
                   (radioButtonRoom4Beds.Checked == true) ? "4 beds" : "";

            //If there is not empty field insert new offer
            if (country == "" || city == "" || days == "" || description == "" || price == "" || transportPrice == "" || capacityAvailable == "" ||
                hotel == "0" || touristGuide == "0" || visaRequired == "" || room == "" || offerType == "")
            {
                MessageBox.Show("All fields are required, please try again.");
            }
            else if (dateDeparture < DateTime.Now || dateReturn < dateDeparture)
            {
                MessageBox.Show("There is invalid date, please try again.");
            }
            else
            {
                SqlCommand cmd = conn.Command("INSERT INTO Offers(country, city, days, date_departure, date_return, visa_required, description, room, meals,"
                    + "price, transport_price, capacity_available, offer_type, hotel_id, tourist_guide_id) VALUES " +
                    "(@Country, @City, @Days, @DateDeparture, @DateReturn, @VisaRequired, @Description, @Room, @Meals, @Price, @TransportPrice, "
                    + "@CapacityAvailable, @OfferType, @HotelID, @TouristGuideID)");
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Days", Convert.ToInt32(days));
                cmd.Parameters.AddWithValue("@DateDeparture", dateDeparture);
                cmd.Parameters.AddWithValue("@DateReturn", dateReturn);
                cmd.Parameters.AddWithValue("@VisaRequired", visaRequired);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Room", room);
                cmd.Parameters.AddWithValue("@Meals", meals);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(price));
                cmd.Parameters.AddWithValue("@TransportPrice", Convert.ToDecimal(transportPrice));
                cmd.Parameters.AddWithValue("@CapacityAvailable", Convert.ToInt32(capacityAvailable));
                cmd.Parameters.AddWithValue("@OfferType", offerType);
                cmd.Parameters.AddWithValue("@HotelID", Convert.ToInt32(hotel));
                cmd.Parameters.AddWithValue("@TouristGuideID", Convert.ToInt32(touristGuide));

                try
                {
                    conn.OpenConnection();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("New offer is successfully added.");

                        Offers offers = new Offers();
                        offers.Show();
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
        }

        private void ButtonChooseHotel_Click(object sender, EventArgs e)
        {
            PageController.AddHotel();
        }

        private void ButtonChooseTouristGuide_Click(object sender, EventArgs e)
        {
            PageController.AddTouristGuide();
        }

        private void AddNewOffer_Activated(object sender, EventArgs e)
        {
            labelHotelID.Text = Data.hotelID.ToString();
            labelTouristGuideID.Text = Data.touristGuideID.ToString();
        }

        //Check if input is number
        private void TextBoxDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxTransportPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxCapacityAvailable_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        private void AddNewOffer_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
