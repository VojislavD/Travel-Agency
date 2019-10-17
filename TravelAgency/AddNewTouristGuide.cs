using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class AddNewTouristGuide : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        public AddNewTouristGuide()
        {
            InitializeComponent();

            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonTouristGuides.ForeColor = System.Drawing.Color.Gold;
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
            PageController.TouristGuides();
            this.Hide();
            this.Dispose();
        }

        private void PictureBoxSave_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            string JMBG = textBoxJMBG.Text.Trim();
            string gender = textBoxGender.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string education = textBoxEducation.Text.Trim();
            DateTime dateOfHire = dateTimePickerDateOfHire.Value;
            string jobTitle = textBoxJobTitle.Text.Trim();
            string salary = textBoxSalary.Text.Trim();
            string availableLocation = textBoxLocationCapable.Text.Trim();

            //If there is not empty field insert new tourist guide
            if (firstName != "" || lastName != "" || JMBG != "" || gender != "" || address != "" || phone != "" || email != "" || education != "" || jobTitle != "" || salary != "" || availableLocation != "")
            {
                SqlCommand cmd = conn.Command("INSERT INTO TouristGuides(first_name, last_name, email, JMBG, gender, address, phone, education, date_of_hire, job_title, salary, available_for_location) VALUES " +
                    "(@FirstName, @LastName, @Email, @JMBG, @Gender, @Address, @Phone, @Education, @DateOfHire, @JobTitle, @Salary, @AvailableForLocation)");
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@JMBG", JMBG);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Education", education);
                cmd.Parameters.AddWithValue("@DateOfHire", dateOfHire);
                cmd.Parameters.AddWithValue("@JobTitle", jobTitle);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToInt32(salary));
                cmd.Parameters.AddWithValue("@AvailableForLocation", availableLocation);

                try
                {
                    conn.OpenConnection();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("New tourist guide is successfully added.");

                        TouristGuides touristGuides = new TouristGuides();
                        touristGuides.Show();
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
            else
            {
                MessageBox.Show("All fields are required, please try again.");
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
        private void TextBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.");
            }
        }

        private void AddNewTouristGuide_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
