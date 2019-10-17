using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class AddNewClient : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        public AddNewClient()
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonClients.ForeColor = System.Drawing.Color.Gold;
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
            PageController.Clients();
            this.Hide();
            this.Dispose();
        }

        private void PictureBoxSave_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            int age = Convert.ToInt32(textBoxAge.Text.Trim());
            string JMBG = textBoxJMBG.Text.Trim();
            string passport_number = textBoxPassportNumber.Text.Trim();
            string citizenship = textBoxCitizenship.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string phone = textBoxPhone.Text.Trim();

            if (firstName == "" || lastName == "" || age == 0 || JMBG == "" || citizenship =="" || email =="" || phone =="" )
            {
                MessageBox.Show("All fields except Passport number are required, please try again.");
            } else if(passport_number == "")
            {
                //Insert new Client without passport number
                SqlCommand cmd = conn.Command("INSERT INTO Clients(first_name, last_name, age,JMBG, citizenship, email, phone) VALUES " +
                    "(@FirstName, @LastName, @Age, @JMBG, @Citizenship, @Email, @Phone)");
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@JMBG", JMBG);
                cmd.Parameters.AddWithValue("@Citizenship", passport_number);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);

                try
                {
                    conn.OpenConnection();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("New client is successfully added.");
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
                //Insert new client with all fields
                SqlCommand cmd = conn.Command("INSERT INTO Clients(first_name, last_name, age,JMBG, passport_number, citizenship, email, phone) VALUES " +
                    "(@FirstName, @LastName, @Age, @JMBG, @PassportNumber, @Citizenship, @Email, @Phone)");
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@JMBG", JMBG);
                cmd.Parameters.AddWithValue("@PassportNumber", passport_number);
                cmd.Parameters.AddWithValue("@Citizenship", citizenship);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);

                try
                {
                    conn.OpenConnection();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("New client is successfully added.");
                        Clients clients = new Clients();
                        clients.Show();
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

        private void AddNewClient_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
