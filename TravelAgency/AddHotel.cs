using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class AddHotel : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private string search = "";

        public AddHotel()
        {
            InitializeComponent();
            loadHotels(search);
        }

        private void loadHotels(string search)
        {
            try
            {
                //clear listViewHotels list
                listViewHotels.Items.Clear();

                conn.OpenConnection();
                SqlDataReader reader = conn.SelectAll("Hotels");

                while (reader.Read())
                {
                    string country = reader["country"].ToString();
                    string city = reader["city"].ToString();
                    string name = reader["name"].ToString();

                    //if search field is empty or default value "Search"
                    if (search == "" || search == "Search")
                    {
                        ListViewItem lvHotels = new ListViewItem(reader["ID"].ToString());
                        lvHotels.SubItems.Add(name);
                        lvHotels.SubItems.Add(country);
                        lvHotels.SubItems.Add(city);
                        lvHotels.SubItems.Add(reader["stars"].ToString());
                        lvHotels.SubItems.Add(reader["wifi"].ToString());
                        lvHotels.SubItems.Add(reader["spa"].ToString());
                        lvHotels.SubItems.Add(reader["pet_friendly"].ToString());
                        lvHotels.SubItems.Add(reader["gym"].ToString());
                        lvHotels.SubItems.Add(reader["pool"].ToString());

                        listViewHotels.Items.Add(lvHotels);
                    } else if (country.Contains(search) || city.Contains(search) || name.Contains(search))
                    {
                        ListViewItem lvHotels = new ListViewItem(reader["ID"].ToString());
                        lvHotels.SubItems.Add(name);
                        lvHotels.SubItems.Add(country);
                        lvHotels.SubItems.Add(city);
                        lvHotels.SubItems.Add(reader["stars"].ToString());
                        lvHotels.SubItems.Add(reader["wifi"].ToString());
                        lvHotels.SubItems.Add(reader["spa"].ToString());
                        lvHotels.SubItems.Add(reader["pet_friendly"].ToString());
                        lvHotels.SubItems.Add(reader["gym"].ToString());
                        lvHotels.SubItems.Add(reader["pool"].ToString());

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

        private void ListViewHotels_DoubleClick(object sender, EventArgs e)
        {
            //Set ID of hotel
            Data.hotelID = Convert.ToInt32(listViewHotels.SelectedItems[0].Text);
            this.Close();
            this.Dispose();
        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.SelectAll();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            search = textBoxSearch.Text.Trim();
            loadHotels(search);
        }
    }
}
