using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class DisplayClient : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private Boolean editEnable = false;
        private int id;

        public DisplayClient(int ID)
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonClients.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;

            id = ID;

            FieldsDisabled();

            displayClient(id);
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
            PageController.Clients();
            this.Hide();
            this.Dispose();
        }

        private void displayClient(int id)
        {
            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.SelectWithID("Clients",id);

                while (reader.Read())
                {
                    labelID.Text = reader["ID"].ToString();
                    textBoxFirstName.Text = reader["first_name"].ToString();
                    textBoxLastName.Text = reader["last_name"].ToString();
                    textBoxAge.Text = reader["age"].ToString();
                    textBoxJMBG.Text = reader["JMBG"].ToString();
                    textBoxPassportNumber.Text = reader["passport_number"].ToString();
                    textBoxCitizenship.Text = reader["citizenship"].ToString();
                    textBoxEmail.Text = reader["email"].ToString();
                    textBoxPhone.Text = reader["phone"].ToString();
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
            if(editEnable)
            {
                FieldsDisabled();

                editEnable = false;
                displayClient(id);
            } else
            {
                FieldsEnabled();

                editEnable = true;
                displayClient(id);
            }
        }

        private void PictureBoxSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.Command("UPDATE Clients SET first_name=@FirstName, last_name=@LastName, age=@Age, JMBG=@JMBG, passport_number=@PassportNumber"
                + ", citizenship=@Citizenship, email=@Email, phone=@Phone WHERE ID = @ID");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", labelID.Text.Trim());
            cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(textBoxAge.Text.Trim()));
            cmd.Parameters.AddWithValue("@JMBG", textBoxJMBG.Text.Trim());
            cmd.Parameters.AddWithValue("@PassportNumber", textBoxPassportNumber.Text.Trim());
            cmd.Parameters.AddWithValue("@Citizenship", textBoxCitizenship.Text.Trim());
            cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text.Trim());

            try
            {
                conn.OpenConnection();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Client information are successfully updated.");

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
                displayClient(id);
            }
        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.OpenConnection();

                if (conn.DeleteWithID("Clients",id))
                {
                    MessageBox.Show("Client is successfully deleted.");
                    PageController.Clients();
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

            textBoxFirstName.Enabled = true;
            textBoxLastName.Enabled = true;
            textBoxAge.Enabled = true;
            textBoxJMBG.Enabled = true;
            textBoxPassportNumber.Enabled = true;
            textBoxCitizenship.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxPhone.Enabled = true;
        }

        private void FieldsDisabled()
        {
            pictureBoxSave.Enabled = false;
            labelSave.Enabled = false;
            pictureBoxDelete.Enabled = true;
            labelDelete.Enabled = true;

            textBoxFirstName.Enabled = false;
            textBoxLastName.Enabled = false;
            textBoxAge.Enabled = false;
            textBoxJMBG.Enabled = false;
            textBoxPassportNumber.Enabled = false;
            textBoxCitizenship.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxPhone.Enabled = false;
        }

        //Check if input is number
        private void TextBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        //Check if input is number
        private void TextBoxPassportNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        private void DisplayClient_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
