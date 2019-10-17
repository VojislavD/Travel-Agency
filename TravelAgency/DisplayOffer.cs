using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class DisplayOffer : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        Boolean editEnable = false;
        int id, days, capacity_available, hotel_id, tourist_guide_id;
        decimal price, transport_price;
        string country, city, visa_required, description, room, meals, offer_type;
        DateTime date_departure, date_return;

        public DisplayOffer(int ID)
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;


            id = ID;
            labelUsername.Text = User.Username;
            buttonOffers.ForeColor = System.Drawing.Color.Gold;
            loadOffer(id);

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
            PageController.Offers();
            this.Hide();
            this.Dispose();
        }

        private void loadOffer(int id)
        {
            FieldsDisabled();

            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.SelectWithID("Offers", id);

                if (reader.Read())
                {
                    //If there is not available capacity or date of daparture is passed user can't create new contract
                    if(Convert.ToInt32(reader["capacity_available"]) <= 0 || Convert.ToDateTime(reader["date_departure"]) < DateTime.Now)
                    {
                        pictureBoxCreateContract.Enabled = false;
                        labelCreateContract.Enabled = false;
                    }

                    country = reader["country"].ToString();
                    city = reader["city"].ToString();
                    days = Convert.ToInt32(reader["days"]);
                    date_departure = Convert.ToDateTime(reader["date_departure"].ToString());
                    date_return = Convert.ToDateTime(reader["date_return"].ToString());
                    visa_required = reader["visa_required"].ToString();
                    description = reader["description"].ToString();
                    room = reader["room"].ToString();
                    meals = reader["meals"].ToString();
                    price = Convert.ToDecimal(reader["price"]);
                    transport_price = Convert.ToDecimal(reader["transport_price"]);
                    capacity_available = Convert.ToInt32(reader["capacity_available"]);
                    offer_type = reader["offer_type"].ToString();
                    hotel_id = Convert.ToInt32(reader["hotel_id"]);
                    tourist_guide_id = Convert.ToInt32(reader["tourist_guide_id"]);

                    labelID.Text = reader["ID"].ToString();
                    textBoxCountry.Text = country.ToString();
                    textBoxCity.Text = city.ToString();
                    textBoxDays.Text = days.ToString();
                    dateTimePickerDeparture.Value = date_departure;
                    dateTimePickerReturn.Value = date_return;
                    textBoxVisaRequired.Text = visa_required;
                    textBoxDescription.Text = description;
                    textBoxRoom.Text = room;
                    textBoxMeals.Text = meals;
                    textBoxPrice.Text = price.ToString();
                    textBoxTransportPrice.Text = transport_price.ToString();
                    textBoxCapacityAvailable.Text = capacity_available.ToString();
                    textBoxOfferType.Text = offer_type;
                    textBoxHotel.Text = hotel_id.ToString();
                    textBoxTouristGuide.Text = tourist_guide_id.ToString();
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
            if (!editEnable)
            {
                FieldsEnabled();
                editEnable = true;
            } else
            {
                FieldsDisabled();
                editEnable = false;
                loadOffer(id);
            }
        }

        private void PictureBoxSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.Command("UPDATE Offers SET country=@Country, city=@City, days=@Days, date_departure=@DateDeparture, date_return=@DateReturn"
                + ", visa_required=@VisaRequired, description=@Description, room=@Room, meals=@Meals, price=@Price, transport_price=@TransportPrice, " +
                "capacity_available=@CapacityAvailable, offer_type=@OfferType, hotel_id=@HotelID, tourist_guide_id=@TouristGuideID WHERE ID = @ID");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Country", textBoxCountry.Text.Trim());
            cmd.Parameters.AddWithValue("@City", textBoxCity.Text.Trim());
            cmd.Parameters.AddWithValue("@Days", textBoxDays.Text.Trim());
            cmd.Parameters.AddWithValue("@DateDeparture", dateTimePickerDeparture.Value);
            cmd.Parameters.AddWithValue("@DateReturn", dateTimePickerReturn.Value);
            cmd.Parameters.AddWithValue("@VisaRequired", textBoxVisaRequired.Text.Trim());
            cmd.Parameters.AddWithValue("@Description", textBoxDescription.Text.Trim());
            cmd.Parameters.AddWithValue("@Room", textBoxRoom.Text.Trim());
            cmd.Parameters.AddWithValue("@Meals", textBoxMeals.Text.Trim());
            cmd.Parameters.AddWithValue("@Price", textBoxPrice.Text.Trim());
            cmd.Parameters.AddWithValue("@TransportPrice", textBoxTransportPrice.Text.Trim());
            cmd.Parameters.AddWithValue("@CapacityAvailable", textBoxCapacityAvailable.Text.Trim());
            cmd.Parameters.AddWithValue("@OfferType", textBoxOfferType.Text.Trim());
            cmd.Parameters.AddWithValue("@HotelID", textBoxHotel.Text.Trim());
            cmd.Parameters.AddWithValue("@TouristGuideID", textBoxTouristGuide.Text.Trim());
            cmd.Parameters.AddWithValue("@ID", labelID.Text);

            try
            {
                conn.OpenConnection();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Offer is successfully updated.");
                    PageController.DisplayOffer(id);
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

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.OpenConnection();

                if (conn.DeleteWithID("Offers", id))
                {
                    MessageBox.Show("Offer is successfully deleted.");
                    PageController.Offers();
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

        private void PictureBoxCreateContract_Click(object sender, EventArgs e)
        {
            PageController.CreateContract(id, country, city, days, room, meals, date_departure, date_return, hotel_id, price, transport_price, tourist_guide_id);
            this.Hide();
            this.Dispose();
        }

        private void FieldsEnabled()
        {
            textBoxCountry.Enabled = true;
            textBoxCity.Enabled = true;
            textBoxDays.Enabled = true;
            dateTimePickerDeparture.Enabled = true;
            dateTimePickerReturn.Enabled = true;
            textBoxVisaRequired.Enabled = true;
            textBoxDescription.Enabled = true;
            textBoxRoom.Enabled = true;
            textBoxMeals.Enabled = true;
            textBoxPrice.Enabled = true;
            textBoxTransportPrice.Enabled = true;
            textBoxCapacityAvailable.Enabled = true;
            textBoxOfferType.Enabled = true;
            textBoxHotel.Enabled = true;
            textBoxTouristGuide.Enabled = true;

            labelDelete.Enabled = false;
            pictureBoxDelete.Enabled = false;
            labelSave.Enabled = true;
            pictureBoxSave.Enabled = true;
            labelCreateContract.Enabled = false;
            pictureBoxCreateContract.Enabled = false;
        }

        private void FieldsDisabled()
        {
            textBoxCountry.Enabled = false;
            textBoxCity.Enabled = false;
            textBoxDays.Enabled = false;
            dateTimePickerDeparture.Enabled = false;
            dateTimePickerReturn.Enabled = false;
            textBoxVisaRequired.Enabled = false;
            textBoxDescription.Enabled = false;
            textBoxRoom.Enabled = false;
            textBoxMeals.Enabled = false;
            textBoxPrice.Enabled = false;
            textBoxTransportPrice.Enabled = false;
            textBoxCapacityAvailable.Enabled = false;
            textBoxOfferType.Enabled = false;
            textBoxHotel.Enabled = false;
            textBoxTouristGuide.Enabled = false;

            labelDelete.Enabled = true;
            pictureBoxDelete.Enabled = true;
            labelSave.Enabled = false;
            pictureBoxSave.Enabled = false;
            labelCreateContract.Enabled = true;
            pictureBoxCreateContract.Enabled = true;
        }

        //Check if input is number
        private void TextBoxDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch))
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

        //Check if input is number
        private void TextBoxHotel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxTouristGuide_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        private void DisplayOffer_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
