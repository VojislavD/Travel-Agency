using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class TouristGuides : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private string search = "";

        public TouristGuides()
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonTouristGuides.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;
            loadTouristGuides(search);
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

        private void PictureBoxLogout_Click(object sender, EventArgs e)
        {
            PageController.Logout();
            this.Hide();
            this.Dispose();
        }

        private void loadTouristGuides(string search)
        {
            //clear listViewTourGuides list
            listViewTourGuides.Items.Clear();

            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.SelectAll("TouristGuides");

                while (reader.Read())
                {
                    string name = reader["first_name"].ToString() + " " + reader["last_name"].ToString();

                    //if search field is empty or default value "Search"
                    if (search == "" || search == "search")
                    {
                        ListViewItem lvTouristGuides = new ListViewItem(reader["ID"].ToString());
                        lvTouristGuides.SubItems.Add(name);
                        lvTouristGuides.SubItems.Add(reader["JMBG"].ToString());
                        lvTouristGuides.SubItems.Add(reader["gender"].ToString());
                        lvTouristGuides.SubItems.Add(reader["email"].ToString());
                        lvTouristGuides.SubItems.Add(reader["phone"].ToString());
                        listViewTourGuides.Items.Add(lvTouristGuides);
                    } else if (name.Contains(search))
                    {
                        ListViewItem lvTouristGuides = new ListViewItem(reader["ID"].ToString());
                        lvTouristGuides.SubItems.Add(name);
                        lvTouristGuides.SubItems.Add(reader["JMBG"].ToString());
                        lvTouristGuides.SubItems.Add(reader["gender"].ToString());
                        lvTouristGuides.SubItems.Add(reader["email"].ToString());
                        lvTouristGuides.SubItems.Add(reader["phone"].ToString());
                        listViewTourGuides.Items.Add(lvTouristGuides);
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
            loadTouristGuides(search);
        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.SelectAll();
        }

        private void PictureBoxAddNewTouristGuide_Click(object sender, EventArgs e)
        {
            PageController.AddNewTouristGuide();
            this.Hide();
            this.Dispose();
        }

        private void ListViewTourGuides_DoubleClick(object sender, EventArgs e)
        {
            //When touristGuide is double clicked open tourist guide information
            int touristGuideID = Convert.ToInt32(listViewTourGuides.SelectedItems[0].Text);
            PageController.DisplayTouristGuide(touristGuideID);
            this.Hide();
            this.Dispose();
        }

        private void TouristGuides_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
