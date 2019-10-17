using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class Hotels : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private string search = "";

        public Hotels()
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonHotels.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;
            loadHotels(search);
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

        private void PictureBoxAddNewHotel_Click(object sender, EventArgs e)
        {
            PageController.AddNewHotel();
            this.Hide();
            this.Dispose();
        }

        public void loadHotels(string search)
        {
            //clear listViewHotels list 
            listViewHotels.Items.Clear();

            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.SelectAll("Hotels");

                while (reader.Read())
                {
                    string name = reader["name"].ToString();

                    //if search field is empty or default value "Search"
                    if (search == "" || search == "search")
                    {
                        ListViewItem lvHotels = new ListViewItem(reader["ID"].ToString());
                        lvHotels.SubItems.Add(name);
                        lvHotels.SubItems.Add(reader["country"].ToString());
                        lvHotels.SubItems.Add(reader["city"].ToString());
                        lvHotels.SubItems.Add(reader["stars"].ToString());
                        lvHotels.SubItems.Add(reader["email"].ToString());
                        lvHotels.SubItems.Add(reader["phone"].ToString());
                        listViewHotels.Items.Add(lvHotels);
                    }
                    else if (name.Contains(search))
                    {
                        ListViewItem lvHotels = new ListViewItem(reader["ID"].ToString());
                        lvHotels.SubItems.Add(name);
                        lvHotels.SubItems.Add(reader["country"].ToString());
                        lvHotels.SubItems.Add(reader["city"].ToString());
                        lvHotels.SubItems.Add(reader["stars"].ToString());
                        lvHotels.SubItems.Add(reader["email"].ToString());
                        lvHotels.SubItems.Add(reader["phone"].ToString());
                        listViewHotels.Items.Add(lvHotels);
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

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            search = textBoxSearch.Text.Trim();
            loadHotels(search);
        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.SelectAll();
        }

        private void ListViewHotels_DoubleClick(object sender, EventArgs e)
        {
            int hotelID = Convert.ToInt32(listViewHotels.SelectedItems[0].Text);
            PageController.DisplayHotel(hotelID);
            this.Hide();
            this.Dispose(); ;
        }

        private void Hotels_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
