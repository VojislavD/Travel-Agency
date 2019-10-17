using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class Offers : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        public Offers()
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonOffers.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;
            loadStandardOffers();
            loadCruiseOffers();
            loadLastminuteOffers();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            PageController.Home();
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

        private void PictureBoxAddNewOffer_Click(object sender, EventArgs e)
        {
            PageController.AddNewOffer();
            this.Hide();
            this.Dispose();
        }

        private void loadStandardOffers()
        {
            SqlCommand cmd = conn.Command("SELECT * FROM Offers WHERE date_departure>=@DateDeparture AND offer_type = @Standard");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateDeparture", dateTimePickerDeparture.Value);
            cmd.Parameters.AddWithValue("@Standard", "Standard");

            try
            {
                listViewStandard.Items.Clear();
                conn.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);

                while (reader.Read())
                {
                    
                    ListViewItem lvStandard = new ListViewItem(reader["ID"].ToString());
                    lvStandard.SubItems.Add(reader["city"].ToString() + ", " + reader["country"].ToString());
                    lvStandard.SubItems.Add(reader["days"].ToString());
                    lvStandard.SubItems.Add(Convert.ToDateTime(reader["date_departure"]).ToString("dd-MM-yyyy"));
                    lvStandard.SubItems.Add(reader["price"].ToString());

                    if (Convert.ToInt32(reader["capacity_available"]) <= 0 || Convert.ToDateTime(reader["date_departure"]) < DateTime.Now)
                    {
                        lvStandard.BackColor = Color.Red;
                    }

                    listViewStandard.Items.Add(lvStandard);
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

        private void loadCruiseOffers()
        {
            SqlCommand cmd = conn.Command("SELECT * FROM Offers WHERE date_departure>=@DateDeparture AND offer_type = @Cruise");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateDeparture", dateTimePickerDeparture.Value);
            cmd.Parameters.AddWithValue("@Cruise", "Cruise");

            try
            {
                listViewCruise.Items.Clear();
                conn.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);

                while (reader.Read())
                {
                    ListViewItem lvCruise = new ListViewItem(reader["ID"].ToString());
                    lvCruise.SubItems.Add(reader["country"].ToString());
                    lvCruise.SubItems.Add(reader["days"].ToString());
                    lvCruise.SubItems.Add(Convert.ToDateTime(reader["date_departure"]).ToString("dd-MM-yyyy"));
                    lvCruise.SubItems.Add(reader["price"].ToString());

                    if (Convert.ToInt32(reader["capacity_available"]) <= 0 || Convert.ToDateTime(reader["date_departure"]) < DateTime.Now)
                    {
                        lvCruise.BackColor = Color.Red;
                    }

                    listViewCruise.Items.Add(lvCruise);
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

        private void loadLastminuteOffers()
        {
            SqlCommand cmd = conn.Command("SELECT * FROM Offers WHERE date_departure>=@DateDeparture AND offer_type = @Last_minute");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateDeparture", dateTimePickerDeparture.Value);
            cmd.Parameters.AddWithValue("@Last_minute", "Last minute");

            try
            {
                listViewLastminute.Items.Clear();
                conn.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);

                while (reader.Read())
                {
                    ListViewItem lvLastminute = new ListViewItem(reader["ID"].ToString());
                    lvLastminute.SubItems.Add(reader["city"].ToString() + ", " + reader["country"].ToString());
                    lvLastminute.SubItems.Add(reader["days"].ToString());
                    lvLastminute.SubItems.Add(Convert.ToDateTime(reader["date_departure"]).ToString("dd-MM-yyyy"));
                    lvLastminute.SubItems.Add(reader["price"].ToString());

                    if (Convert.ToInt32(reader["capacity_available"]) <= 0 || Convert.ToDateTime(reader["date_departure"]) < DateTime.Now)
                    {
                        lvLastminute.BackColor = Color.Red;
                    }

                    listViewLastminute.Items.Add(lvLastminute);
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

        //When filter for days is changed
        private void TrackBarDays_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (trackBarDays.Value == 0 && trackBarPrice.Value != 0)
            {
                labelDays.Text = "Days: ";
                loadOffersWithFilterPrice(trackBarPrice.Value);
            }
            else if (trackBarDays.Value != 0 && trackBarPrice.Value == 0)
            {
                labelDays.Text = "Days: " + trackBarDays.Value.ToString();
                loadOffersWithFilterDays(trackBarDays.Value);
            }
            else if (trackBarPrice.Value != 0 && trackBarDays.Value != 0)
            {
                labelDays.Text = "Days: " + trackBarDays.Value.ToString();
                loadOffersWithFilterDaysAndPrice(trackBarDays.Value, trackBarPrice.Value);
            }
            else
            {
                labelDays.Text = "Days: ";
                loadStandardOffers();
                loadCruiseOffers();
                loadLastminuteOffers();
            }
        }

        //When filter for price is changed
        private void TrackBarPrice_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (trackBarPrice.Value == 0 && trackBarDays.Value != 0)
            {
                labelPrice.Text = "Price: ";
                loadOffersWithFilterDays(trackBarDays.Value);
            }
            else if (trackBarPrice.Value != 0 && trackBarDays.Value == 0)
            {
                labelPrice.Text = "Price: " + trackBarPrice.Value.ToString();
                loadOffersWithFilterPrice(trackBarPrice.Value);
            }
            else if (trackBarPrice.Value != 0 && trackBarDays.Value != 0)
            {
                labelPrice.Text = "Price: " + trackBarPrice.Value.ToString();
                loadOffersWithFilterDaysAndPrice(trackBarDays.Value, trackBarPrice.Value);
            }
            else
            {
                labelPrice.Text = "Price: ";
                loadStandardOffers();
                loadCruiseOffers();
                loadLastminuteOffers();
            }
        }

        private void loadOffersWithFilterDays(int numDays)
        {
            SqlCommand cmd = conn.Command("SELECT * FROM Offers WHERE days<=@NumDays AND  date_departure>=@DateDeparture AND offer_type = @Standard");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Standard", "Standard");
            cmd.Parameters.AddWithValue("@DateDeparture", dateTimePickerDeparture.Value);
            cmd.Parameters.AddWithValue("@NumDays", numDays);

            try
            {
                listViewStandard.Items.Clear();
                conn.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);

                while (reader.Read())
                {
                    ListViewItem lvStandard = new ListViewItem(reader["ID"].ToString());
                    lvStandard.SubItems.Add(reader["city"].ToString() + ", " + reader["country"].ToString());
                    lvStandard.SubItems.Add(reader["days"].ToString());
                    lvStandard.SubItems.Add(Convert.ToDateTime(reader["date_departure"]).ToString("dd-MM-yyyy"));
                    lvStandard.SubItems.Add(reader["price"].ToString());

                    listViewStandard.Items.Add(lvStandard);
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

            SqlCommand cmd2 = conn.Command("SELECT * FROM Offers WHERE days<=@NumDays AND date_departure>=@DateDeparture AND offer_type = @Cruise");
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@Cruise", "Cruise");
            cmd2.Parameters.AddWithValue("@DateDeparture", dateTimePickerDeparture.Value);
            cmd2.Parameters.AddWithValue("@NumDays", numDays);

            try
            {
                listViewCruise.Items.Clear();
                conn.OpenConnection();
                SqlDataReader reader = cmd2.ExecuteReader(CommandBehavior.SingleResult);

                while (reader.Read())
                {
                    ListViewItem lvCruiser = new ListViewItem(reader["ID"].ToString());
                    lvCruiser.SubItems.Add(reader["country"].ToString());
                    lvCruiser.SubItems.Add(reader["days"].ToString());
                    lvCruiser.SubItems.Add(Convert.ToDateTime(reader["date_departure"]).ToString("dd-MM-yyyy"));
                    lvCruiser.SubItems.Add(reader["price"].ToString());

                    listViewCruise.Items.Add(lvCruiser);
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

            SqlCommand cmd3 = conn.Command("SELECT * FROM Offers WHERE days<=@NumDays AND date_departure>=@DateDeparture AND offer_type = @LastMinute");

            cmd3.Parameters.Clear();
            cmd3.Parameters.AddWithValue("@LastMinute", "Last minute");
            cmd3.Parameters.AddWithValue("@DateDeparture", dateTimePickerDeparture.Value);
            cmd3.Parameters.AddWithValue("@NumDays", numDays);

            try
            {
                listViewLastminute.Items.Clear();
                conn.OpenConnection();
                SqlDataReader reader = cmd3.ExecuteReader(CommandBehavior.SingleResult);

                while (reader.Read())
                {
                    ListViewItem lvLastminute = new ListViewItem(reader["ID"].ToString());
                    lvLastminute.SubItems.Add(reader["city"].ToString() + ", " + reader["country"].ToString());
                    lvLastminute.SubItems.Add(reader["days"].ToString());
                    lvLastminute.SubItems.Add(Convert.ToDateTime(reader["date_departure"]).ToString("dd-MM-yyyy"));
                    lvLastminute.SubItems.Add(reader["price"].ToString());

                    listViewLastminute.Items.Add(lvLastminute);
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

        private void loadOffersWithFilterPrice(int numPrice)
        {
            SqlCommand cmd = conn.Command("SELECT * FROM Offers WHERE price<=@NumPrice AND date_departure>=@DateDeparture AND offer_type = @Standard");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Standard", "Standard");
            cmd.Parameters.AddWithValue("@DateDeparture", dateTimePickerDeparture.Value);
            cmd.Parameters.AddWithValue("@NumPrice", numPrice);

            try
            {
                listViewStandard.Items.Clear();
                conn.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);

                while (reader.Read())
                {
                    ListViewItem lvStandard = new ListViewItem(reader["ID"].ToString());
                    lvStandard.SubItems.Add(reader["city"].ToString() + ", " + reader["country"].ToString());
                    lvStandard.SubItems.Add(reader["days"].ToString());
                    lvStandard.SubItems.Add(Convert.ToDateTime(reader["date_departure"]).ToString("dd-MM-yyyy"));
                    lvStandard.SubItems.Add(reader["price"].ToString());

                    listViewStandard.Items.Add(lvStandard);
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

            SqlCommand cmd2 = conn.Command("SELECT * FROM Offers WHERE price<=@NumPrice AND date_departure>=@DateDeparture AND offer_type = @Cruise");
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@Cruise", "Cruise");
            cmd2.Parameters.AddWithValue("@DateDeparture", dateTimePickerDeparture.Value);
            cmd2.Parameters.AddWithValue("@NumPrice", numPrice);

            try
            {
                listViewCruise.Items.Clear();
                conn.OpenConnection();
                SqlDataReader reader = cmd2.ExecuteReader(CommandBehavior.SingleResult);

                while (reader.Read())
                {
                    ListViewItem lvCruiser = new ListViewItem(reader["ID"].ToString());
                    lvCruiser.SubItems.Add(reader["country"].ToString());
                    lvCruiser.SubItems.Add(reader["days"].ToString());
                    lvCruiser.SubItems.Add(Convert.ToDateTime(reader["date_departure"]).ToString("dd-MM-yyyy"));
                    lvCruiser.SubItems.Add(reader["price"].ToString());

                    listViewCruise.Items.Add(lvCruiser);
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

            SqlCommand cmd3 = conn.Command("SELECT * FROM Offers WHERE price<=@NumPrice AND date_departure>=@DateDeparture AND offer_type = @LastMinute");
            cmd3.Parameters.Clear();
            cmd3.Parameters.AddWithValue("@LastMinute", "Last minute");
            cmd3.Parameters.AddWithValue("@DateDeparture", dateTimePickerDeparture.Value);
            cmd3.Parameters.AddWithValue("@NumPrice", numPrice);

            try
            {
                listViewLastminute.Items.Clear();
                conn.OpenConnection();
                SqlDataReader reader = cmd3.ExecuteReader(CommandBehavior.SingleResult);

                while (reader.Read())
                {
                    ListViewItem lvLastminute = new ListViewItem(reader["ID"].ToString());
                    lvLastminute.SubItems.Add(reader["city"].ToString() + ", " + reader["country"].ToString());
                    lvLastminute.SubItems.Add(reader["days"].ToString());
                    lvLastminute.SubItems.Add(Convert.ToDateTime(reader["date_departure"]).ToString("dd-MM-yyyy"));
                    lvLastminute.SubItems.Add(reader["price"].ToString());

                    listViewLastminute.Items.Add(lvLastminute);
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

        private void loadOffersWithFilterDaysAndPrice(int numDays, int numPrice)
        {
            SqlCommand cmd = conn.Command("SELECT * FROM Offers WHERE days<=@NumDays AND date_departure>=@DateDeparture AND price<=@NumPrice AND offer_type = @Standard");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Standard", "Standard");
            cmd.Parameters.AddWithValue("@NumDays", numDays);
            cmd.Parameters.AddWithValue("@DateDeparture", dateTimePickerDeparture.Value);
            cmd.Parameters.AddWithValue("@NumPrice", numPrice);

            try
            {
                listViewStandard.Items.Clear();
                conn.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);

                while (reader.Read())
                {
                    ListViewItem lvStandard = new ListViewItem(reader["ID"].ToString());
                    lvStandard.SubItems.Add(reader["city"].ToString() + ", " + reader["country"].ToString());
                    lvStandard.SubItems.Add(reader["days"].ToString());
                    lvStandard.SubItems.Add(Convert.ToDateTime(reader["date_departure"]).ToString("dd-MM-yyyy"));
                    lvStandard.SubItems.Add(reader["price"].ToString());

                    listViewStandard.Items.Add(lvStandard);
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

            SqlCommand cmd2 = conn.Command("SELECT * FROM Offers WHERE days<=@NumDays AND date_departure>=@DateDeparture AND price<=@numPrice AND offer_type = @Cruise");
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@Cruise", "Cruise");
            cmd2.Parameters.AddWithValue("@NumDays", numDays);
            cmd2.Parameters.AddWithValue("@DateDeparture", dateTimePickerDeparture.Value);
            cmd2.Parameters.AddWithValue("@NumPrice", numPrice);

            try
            {
                listViewCruise.Items.Clear();
                conn.OpenConnection();
                SqlDataReader reader = cmd2.ExecuteReader(CommandBehavior.SingleResult);

                while (reader.Read())
                {
                    ListViewItem lvCruiser = new ListViewItem(reader["ID"].ToString());
                    lvCruiser.SubItems.Add(reader["country"].ToString());
                    lvCruiser.SubItems.Add(reader["days"].ToString());
                    lvCruiser.SubItems.Add(Convert.ToDateTime(reader["date_departure"]).ToString("dd-MM-yyyy"));
                    lvCruiser.SubItems.Add(reader["price"].ToString());

                    listViewCruise.Items.Add(lvCruiser);
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

            SqlCommand cmd3 = conn.Command("SELECT * FROM Offers WHERE days<=@NumDays AND date_departure>=@DateDeparture AND price<=@NumPrice AND offer_type = @LastMinute");
            cmd3.Parameters.Clear();
            cmd3.Parameters.AddWithValue("@LastMinute", "Last minute");
            cmd3.Parameters.AddWithValue("@NumDays", numDays);
            cmd3.Parameters.AddWithValue("@DateDeparture", dateTimePickerDeparture.Value);
            cmd3.Parameters.AddWithValue("@NumPrice", numPrice);

            try
            {
                listViewLastminute.Items.Clear();
                conn.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);

                while (reader.Read())
                {
                    ListViewItem lvLastminute = new ListViewItem(reader["ID"].ToString());
                    lvLastminute.SubItems.Add(reader["city"].ToString() + ", " + reader["country"].ToString());
                    lvLastminute.SubItems.Add(reader["days"].ToString());
                    lvLastminute.SubItems.Add(Convert.ToDateTime(reader["date_departure"]).ToString("dd-MM-yyyy"));
                    lvLastminute.SubItems.Add(reader["price"].ToString());

                    listViewLastminute.Items.Add(lvLastminute);
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

        private void ListViewStandard_DoubleClick(object sender, EventArgs e)
        {
            if (listViewStandard.SelectedItems.Count > 0)
            {
                int offerID = Convert.ToInt32(listViewStandard.SelectedItems[0].Text);
                PageController.DisplayOffer(offerID);
                this.Hide();
                this.Dispose();
            }
        }

        private void ListViewCruise_DoubleClick(object sender, EventArgs e)
        {
            if (listViewCruise.SelectedItems.Count > 0)
            {
                int offerID = Convert.ToInt32(listViewCruise.SelectedItems[0].Text);
                PageController.DisplayOffer(offerID);
                this.Hide();
                this.Dispose();
            }
        }

        private void ListViewLastminute_DoubleClick(object sender, EventArgs e)
        {
            if (listViewLastminute.SelectedItems.Count > 0)
            {
                int offerID = Convert.ToInt32(listViewLastminute.SelectedItems[0].Text);
                PageController.DisplayOffer(offerID);
                this.Hide();
                this.Dispose();
            }
        }

        //When filter for date of departure is changed
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarDays.Value == 0 && trackBarPrice.Value != 0)
            {
                labelDays.Text = "Days: ";
                loadOffersWithFilterPrice(trackBarPrice.Value);
            }
            else if (trackBarDays.Value != 0 && trackBarPrice.Value == 0)
            {
                labelDays.Text = "Days: " + trackBarDays.Value.ToString();
                loadOffersWithFilterDays(trackBarDays.Value);
            }
            else if (trackBarPrice.Value != 0 && trackBarDays.Value != 0)
            {
                labelDays.Text = "Days: " + trackBarDays.Value.ToString();
                loadOffersWithFilterDaysAndPrice(trackBarDays.Value, trackBarPrice.Value);
            }
            else
            {
                labelDays.Text = "Days: ";
                loadStandardOffers();
                loadCruiseOffers();
                loadLastminuteOffers();
            }
        }

        //When search field is changed
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            listViewSearchOffers.Items.Clear();

            string SearchCountry = textBoxSearchCountry.Text.Trim();
            string SearchCity = textBoxSearchCity.Text.Trim();
            int SearchDays = (textBoxSearchDays.Text.Trim() == "") ? 100 : Convert.ToInt32(textBoxSearchDays.Text.Trim());
            DateTime SearchDateDeparture = dateTimePickerSearchDateDeparture.Value;
            DateTime SearchDateReturn = dateTimePickerSearchDateReturn.Value;
            string SearchVisaRequired = (radioButtonSearchVisaRequiredYes.Checked == true) ? "Yes" : "No";
            string SearchRoom = (radioButtonSearchRoom1Bed.Checked == true) ? "1 bed" :
                                (radioButtonSearchRoom2Beds.Checked == true) ? "2 beds" :
                                (radioButtonSearchRoom3Beds.Checked == true) ? "3 beds" :
                                (radioButtonSearchRoom4Beds.Checked == true) ? "4 beds" : "";
            string SearchMeals = (checkBoxSearchMealsBreakfast.Checked == true && checkBoxSearchMealsLunch.Checked == true && checkBoxSearchMealsDinner.Checked == true) ? "Breakfast,Lunch,Dinner" :
                           (checkBoxSearchMealsBreakfast.Checked == true && checkBoxSearchMealsLunch.Checked == true) ? "Breakfast,Lunch" :
                           (checkBoxSearchMealsBreakfast.Checked == true && checkBoxSearchMealsDinner.Checked == true) ? "Breakfast,Dinner" :
                           (checkBoxSearchMealsLunch.Checked == true && checkBoxSearchMealsDinner.Checked == true) ? "Lunch,Dinner" :
                           (checkBoxSearchMealsBreakfast.Checked == true) ? "Breakfast" :
                           (checkBoxSearchMealsLunch.Checked == true) ? "Lunch" :
                           (checkBoxSearchMealsDinner.Checked == true) ? "Dinner" : "";
            int SearchMinPrice = (textBoxSearchPriceMin.Text == "") ? 0 : Convert.ToInt32(textBoxSearchPriceMin.Text.Trim());
            int SearchMaxPrice = (textBoxSearchPriceMax.Text == "") ? 100000 : Convert.ToInt32(textBoxSearchPriceMax.Text.Trim());
            int SearchTransportPrice = (textBoxSearchTransportPrice.Text == "") ? 10000 : Convert.ToInt32(textBoxSearchTransportPrice.Text.Trim());
            int SearchCapacitysAvailable = (textBoxSearchCapacityAvailable.Text == "") ? 0 : Convert.ToInt32(textBoxSearchCapacityAvailable.Text.Trim());
            string SearchOfferType = (radioButtonSearchTypeStandard.Checked == true) ? "Standard" :
                                    (radioButtonSearchTypeCruise.Checked == true) ? "Cruise" :
                                    (radioButtonSearchTypeLastMinute.Checked == true) ? "Last minute" : "";

            try
            {
                conn.OpenConnection();
                SqlCommand cmd = conn.Command("SELECT ID,country,city,days,date_departure,price FROM Offers WHERE "
                    + "country LIKE CASE WHEN @Country='' THEN '%' ELSE @Country END AND "
                    + "city LIKE CASE WHEN @City='' THEN '%' ELSE @City END AND "
                    + "days<=@Days AND date_departure>@DateDeparture AND date_return>@DateReturn AND "
                    + "visa_required LIKE CASE WHEN @VisaRequired='' THEN '%' ELSE @VisaRequired END AND "
                    + "room LIKE CASE WHEN @Room='' THEN '%' ELSE @Room END AND "
                    + "meals LIKE CASE WHEN @Meals='' THEN '%' ELSE @Meals END AND "
                    + "price>=@MinPrice AND price<=@MaxPrice AND transport_price<=@TransportPrice AND capacity_available>=@CapacityAvailable AND "
                    + "offer_type LIKE CASE WHEN @OfferType='' THEN '%' ELSE @OfferType END");
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Country", SearchCountry);
                cmd.Parameters.AddWithValue("@City", SearchCity);
                cmd.Parameters.AddWithValue("@Days", SearchDays);
                cmd.Parameters.AddWithValue("@DateDeparture", SearchDateDeparture);
                cmd.Parameters.AddWithValue("@DateReturn", SearchDateReturn);
                cmd.Parameters.AddWithValue("@VisaRequired", SearchVisaRequired);
                cmd.Parameters.AddWithValue("@Room", SearchRoom);
                cmd.Parameters.AddWithValue("@Meals", SearchMeals);
                cmd.Parameters.AddWithValue("@MinPrice", SearchMinPrice);
                cmd.Parameters.AddWithValue("@MaxPrice", SearchMaxPrice);
                cmd.Parameters.AddWithValue("@TransportPrice", SearchTransportPrice);
                cmd.Parameters.AddWithValue("@CapacityAvailable", SearchCapacitysAvailable);
                cmd.Parameters.AddWithValue("@OfferType", SearchOfferType);

                SqlDataReader reader = conn.DataReader(cmd);

                while (reader.Read())
                {
                    ListViewItem lvSearchOffers = new ListViewItem(reader["ID"].ToString());
                    lvSearchOffers.SubItems.Add(reader["country"].ToString() + " " + reader["city"].ToString());
                    lvSearchOffers.SubItems.Add(reader["days"].ToString());
                    lvSearchOffers.SubItems.Add(reader["date_departure"].ToString());
                    lvSearchOffers.SubItems.Add(reader["price"].ToString());

                    listViewSearchOffers.Items.Add(lvSearchOffers);
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

            tabPageSearch.VerticalScroll.Value = 600;
        }

        private void ListViewSearchOffers_DoubleClick(object sender, EventArgs e)
        {
            int offerID = Convert.ToInt32(listViewSearchOffers.SelectedItems[0].Text);
            PageController.DisplayOffer(offerID);
            this.Hide();
            this.Dispose();
        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            tabPageSearch.VerticalScroll.Value = 0;
        }

        private void Offers_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
