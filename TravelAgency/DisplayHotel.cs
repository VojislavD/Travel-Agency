using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class DisplayHotel : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private bool editEnable = false;
        private int id;

        public DisplayHotel(int ID)
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonHotels.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;
            id = ID;
            FieldsDisabled();
            loadHotel(id);
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

        private void loadHotel(int id)
        {
            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.SelectWithID("Hotels", id);

                while (reader.Read())
                {
                    labelID.Text = reader["ID"].ToString();
                    textBoxName.Text = reader["name"].ToString();
                    textBoxCountry.Text = reader["country"].ToString();
                    textBoxCity.Text = reader["city"].ToString();
                    textBoxAddress.Text = reader["address"].ToString();
                    textBoxPhone.Text = reader["phone"].ToString();
                    textBoxEmail.Text = reader["email"].ToString();
                    textBoxStars.Text = reader["stars"].ToString();

                    //set radio button to be checked or not
                    if(reader["wifi"].ToString() == "Yes")
                        radioButtonWifiYes.Checked = true;
                    else
                        radioButtonWifiNo.Checked = true;

                    if (reader["spa"].ToString() == "Yes")
                        radioButtonSpaYes.Checked = true;
                    else
                        radioButtonSpaNo.Checked = true;

                    if (reader["pet_friendly"].ToString() == "Yes")
                        radioButtonPetFriendlyYes.Checked = true;
                    else
                        radioButtonPetFriendlyNo.Checked = true;

                    if (reader["gym"].ToString() == "Yes")
                        radioButtonGymYes.Checked = true;
                    else
                        radioButtonGymNo.Checked = true;

                    if (reader["pool"].ToString() == "Yes")
                        radioButtonPoolYes.Checked = true;
                    else
                        radioButtonPoolNo.Checked = true;
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
            if (editEnable)
            {
                FieldsDisabled();
                editEnable = false;
                loadHotel(id);
            }
            else
            {
                FieldsEnabled();
                editEnable = true;
                loadHotel(id);
            }
        }

        private void PictureBoxSave_Click(object sender, EventArgs e)
        {
            string Wifi, Spa, PetFriendly, Gym, Pool;

            //check if radio button is checked or not
            Wifi = (radioButtonWifiYes.Checked == true) ? "Yes" : "No";
            Spa = (radioButtonSpaYes.Checked == true) ? "Yes" : "No";
            PetFriendly = (radioButtonPetFriendlyYes.Checked == true) ? "Yes" : "No";
            Gym = (radioButtonGymYes.Checked == true) ? "Yes" : "No";
            Pool = (radioButtonPoolYes.Checked == true) ? "Yes" : "No";

            SqlCommand cmd = conn.Command("UPDATE Hotels SET name=@Name, country=@Country, city=@City, Address=@Address, phone=@Phone, email=@Email, stars=@Stars, "
                + "wifi=@Wifi, spa=@Spa, pet_friendly=@PetFriendly, gym=@Gym, pool=@Pool WHERE ID = @ID");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", labelID.Text);
            cmd.Parameters.AddWithValue("@Name", textBoxName.Text.Trim());
            cmd.Parameters.AddWithValue("@Country", textBoxCountry.Text.Trim());
            cmd.Parameters.AddWithValue("@City", textBoxCity.Text.Trim());
            cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@Stars", textBoxStars.Text.Trim());
            cmd.Parameters.AddWithValue("@Wifi", Wifi);
            cmd.Parameters.AddWithValue("@Spa", Spa);
            cmd.Parameters.AddWithValue("@PetFriendly", PetFriendly);
            cmd.Parameters.AddWithValue("@Gym", Gym);
            cmd.Parameters.AddWithValue("@Pool", Pool);

            try
            {
                conn.OpenConnection();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Hotel information are successfully updated.");
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
                loadHotel(id);
            }
        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.OpenConnection();

                if (conn.DeleteWithID("Hotels", id))
                {
                    MessageBox.Show("Hotel is successfully deleted.");
                    PageController.Hotels();
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

        private void FieldsEnabled()
        {
            pictureBoxSave.Enabled = true;
            labelSave.Enabled = true;
            pictureBoxDelete.Enabled = false;
            labelDelete.Enabled = false;

            textBoxName.Enabled = true;
            textBoxCountry.Enabled = true;
            textBoxCity.Enabled = true;
            textBoxAddress.Enabled = true;
            textBoxPhone.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxStars.Enabled = true;
            radioButtonWifiYes.Enabled = true;
            radioButtonWifiNo.Enabled = true;
            radioButtonSpaYes.Enabled = true;
            radioButtonSpaNo.Enabled = true;
            radioButtonPetFriendlyYes.Enabled = true;
            radioButtonPetFriendlyNo.Enabled = true;
            radioButtonGymYes.Enabled = true;
            radioButtonGymNo.Enabled = true;
            radioButtonPoolYes.Enabled = true;
            radioButtonPoolNo.Enabled = true;
        }

        private void FieldsDisabled()
        {
            pictureBoxSave.Enabled = false;
            labelSave.Enabled = false;
            pictureBoxDelete.Enabled = true;
            labelDelete.Enabled = true;

            labelID.Enabled = false;
            textBoxName.Enabled = false;
            textBoxCountry.Enabled = false;
            textBoxCity.Enabled = false;
            textBoxAddress.Enabled = false;
            textBoxPhone.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxStars.Enabled = false;
            radioButtonWifiYes.Enabled = false;
            radioButtonWifiNo.Enabled = false;
            radioButtonSpaYes.Enabled = false;
            radioButtonSpaNo.Enabled = false;
            radioButtonPetFriendlyYes.Enabled = false;
            radioButtonPetFriendlyNo.Enabled = false;
            radioButtonGymYes.Enabled = false;
            radioButtonGymNo.Enabled = false;
            radioButtonPoolYes.Enabled = false;
            radioButtonPoolNo.Enabled = false;
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

        private void DisplayHotel_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
