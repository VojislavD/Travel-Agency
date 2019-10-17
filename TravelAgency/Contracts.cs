using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class Contracts : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private int minPrice=100, maxPrice=3000;
        private DateTime date = Convert.ToDateTime("05/01/2019 00:00:00");
        private string search="";

        public Contracts()
        {
            InitializeComponent();

            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonContracts.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;

            loadContracts(minPrice, maxPrice, date, search);
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

        private void loadContracts(int minPrice, int maxPrice, DateTime date, string search)
        {
            //clear listViewContracts list
            listViewContracts.Items.Clear();

            SqlCommand cmd = conn.Command("SELECT  Contracts.ID, Contracts.contract_id, Clients.first_name, Clients.last_name, Offers.country, Offers.city, Contracts.sum_price, Offers.date_departure " +
                "FROM Contracts INNER JOIN Clients ON Clients.ID=Contracts.client_id INNER JOIN Offers ON Offers.ID = Contracts.offer_id");

            try
            {
                conn.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                    string location = reader["city"].ToString() + ", " + reader["country"].ToString();

                    //If fields match search criteria
                    if (minPrice < Convert.ToInt32(reader["sum_price"]) && maxPrice > Convert.ToInt32(reader["sum_price"]) && date <= Convert.ToDateTime(reader["date_departure"]) && name.Contains(search))
                    {
                        ListViewItem lvContracts = new ListViewItem(reader["ID"].ToString());
                        lvContracts.SubItems.Add(reader["contract_id"].ToString());
                        lvContracts.SubItems.Add(name);
                        lvContracts.SubItems.Add(location);
                        lvContracts.SubItems.Add(reader["sum_price"].ToString() + " €");
                        lvContracts.SubItems.Add(Convert.ToDateTime(reader["date_departure"]).ToString("dd-MM-yyyy"));

                        listViewContracts.Items.Add(lvContracts);
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

        //When max price is changed
        private void TrackBarMaxPrice_Scroll(object sender, EventArgs e)
        {
            labelMaxPrice.Text = "Max price: " + trackBarMaxPrice.Value.ToString() + " €";
            maxPrice = trackBarMaxPrice.Value;
            loadContracts(minPrice, maxPrice, date, search);
        }

        //When date of departure is changed
        private void DateTimePickerDeparture_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePickerDeparture.Value;
            loadContracts(minPrice, maxPrice, date, search);
        }

        //When search field is changed
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            search = textBoxSearch.Text.Trim();
            loadContracts(minPrice, maxPrice, date, search);
        }

        private void ListViewContracts_DoubleClick(object sender, EventArgs e)
        {
            //Open Contract with specified ID
            int contractID = Convert.ToInt32(listViewContracts.SelectedItems[0].Text);
            PageController.DisplayContract(contractID);
            this.Hide();
            this.Dispose();
        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.SelectAll();
        }

        //When min price is changed
        private void TrackBarMinPrice_Scroll(object sender, EventArgs e)
        {
            labelMinPrice.Text = "Min price: " + trackBarMinPrice.Value.ToString() + " €";
            minPrice = trackBarMinPrice.Value;
            loadContracts(minPrice, maxPrice, date, search);
        }

        private void Contracts_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
