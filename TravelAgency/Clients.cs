using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class Clients : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private string search ="";

        public Clients()
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonClients.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;

            loadClients(search);
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

        private void loadClients(string search)
        {
            listViewClients.Items.Clear();

            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.SelectAll("Clients");

                while (reader.Read())
                {
                    string name = reader["first_name"].ToString() + " " + reader["last_name"].ToString();

                    //if search field is empty or default value "Search"
                    if (search == "" || search == "search")
                    {
                        ListViewItem lvClients = new ListViewItem(reader["ID"].ToString());
                        lvClients.SubItems.Add(name);
                        lvClients.SubItems.Add(reader["age"].ToString());
                        lvClients.SubItems.Add(reader["JMBG"].ToString());
                        lvClients.SubItems.Add(reader["passport_number"].ToString());
                        lvClients.SubItems.Add(reader["citizenship"].ToString());
                        lvClients.SubItems.Add(reader["email"].ToString());
                        lvClients.SubItems.Add(reader["phone"].ToString());
                        listViewClients.Items.Add(lvClients);
                    } else if (name.Contains(search))
                    {
                        ListViewItem lvClients = new ListViewItem(reader["ID"].ToString());
                        lvClients.SubItems.Add(name);
                        lvClients.SubItems.Add(reader["age"].ToString());
                        lvClients.SubItems.Add(reader["JMBG"].ToString());
                        lvClients.SubItems.Add(reader["passport_number"].ToString());
                        lvClients.SubItems.Add(reader["citizenship"].ToString());
                        lvClients.SubItems.Add(reader["email"].ToString());
                        lvClients.SubItems.Add(reader["phone"].ToString());
                        listViewClients.Items.Add(lvClients);
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

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.SelectAll();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            search = textBoxSearch.Text.Trim();
            loadClients(search);
        }

        private void ListViewClients_DoubleClick(object sender, EventArgs e)
        {
            //open client with selected ID
            int clientID = Convert.ToInt32(listViewClients.SelectedItems[0].Text);
            PageController.DisplayClient(clientID);
            this.Hide();
            this.Dispose();
        }

        private void PictureBoxAddNewClient_Click(object sender, EventArgs e)
        {
            PageController.AddNewClient();
            this.Hide();
            this.Dispose();
        }

        private void ListViewClients_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
