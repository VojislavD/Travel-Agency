using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class AddNewHotel : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        public AddNewHotel()
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonHotels.ForeColor = System.Drawing.Color.Gold;
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
            string name = textBoxName.Text.Trim();
            string country = textBoxCountry.Text.Trim();
            string city = textBoxCity.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string stars = textBoxStars.Text.Trim();
            string wifi, spa, petFriendly, gym, pool;

            wifi = (radioButtonWifiYes.Checked == true) ? "Yes" : "No";
            spa = (radioButtonSpaYes.Checked == true) ? "Yes" : "No";
            petFriendly = (radioButtonPetFriendlyYes.Checked == true) ? "Yes" : "No";
            gym = (radioButtonGymYes.Checked == true) ? "Yes" : "No";
            pool = (radioButtonPoolYes.Checked == true) ? "Yes" : "No";

            //If there is not empty field insert new hotel
            if (name != "" || country != "" || city != "" || address != "" || phone !="" || email !="" || stars !="" || wifi !="" || spa != "" || petFriendly !="" || gym!="" || pool!="")
            {
                SqlCommand cmd = conn.Command("INSERT INTO Hotels(name, country, city, address, phone, email, stars, wifi, spa, pet_friendly, gym, pool) VALUES " +
                    "(@Name, @Country, @City, @Address, @Phone, @Email, @Stars, @Wifi, @Spa, @PetFriendly, @Gym, @Pool)");
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Stars", stars);
                cmd.Parameters.AddWithValue("@Wifi", wifi);
                cmd.Parameters.AddWithValue("@Spa", spa);
                cmd.Parameters.AddWithValue("@PetFriendly", petFriendly);
                cmd.Parameters.AddWithValue("@Gym", gym);
                cmd.Parameters.AddWithValue("@Pool", pool);

                try
                {
                    conn.OpenConnection();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("New hotel is successfully added.");

                        Hotels hotels = new Hotels();
                        hotels.Show();
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
            } else
            {
                MessageBox.Show("All fields are required, please try again.");
            }
        }

        //Check if input is number
        private void TextBoxStars_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        private void AddNewHotel_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
