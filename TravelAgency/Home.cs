using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class Home : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        public Home()
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonHome.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;
            loadLastPayments();
            loadLastContracts();
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

        private void ListViewLastContracts_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listViewLastContracts.SelectedItems[0].Text);
            PageController.DisplayContract(id);
            this.Hide();
            this.Dispose();
        }

        private void loadLastPayments()
        {
            listViewLastPayments.Items.Clear();

            SqlCommand cmd = conn.Command("SELECT Payments.ID, Payments.amount_paid, Payments.date_paid, Clients.first_name, Clients.last_name "
                + "FROM Payments INNER JOIN Clients ON Clients.ID=Payments.client_id ORDER BY ID DESC");
            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.DataReader(cmd);

                while (reader.Read())
                {
                    string name = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                    string amount = reader["amount_paid"].ToString() + " €";
                    string date = Convert.ToDateTime(reader["date_paid"]).ToString("dd-MM-yyyy");

                    ListViewItem lvLastPayments = new ListViewItem(reader["ID"].ToString());
                    lvLastPayments.SubItems.Add(name);
                    lvLastPayments.SubItems.Add(amount);
                    lvLastPayments.SubItems.Add(date);
                    listViewLastPayments.Items.Add(lvLastPayments);
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

        private void loadLastContracts()
        {
            listViewLastContracts.Items.Clear();

            SqlCommand cmd = conn.Command("SELECT Contracts.ID, Clients.first_name, Clients.last_name, Offers.country, Offers.city, Contracts.sum_price "
                    + "FROM Contracts INNER JOIN Clients ON Clients.ID=Contracts.client_id INNER JOIN Offers ON Offers.ID = Contracts.offer_id ORDER BY ID DESC");
            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.DataReader(cmd);

                while (reader.Read())
                {
                    string name = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                    string location = reader["city"].ToString() + ", " + reader["country"].ToString();
                    string price = reader["sum_price"].ToString() + " €";

                    ListViewItem lvLastContracts = new ListViewItem(reader["ID"].ToString());
                    lvLastContracts.SubItems.Add(name);
                    lvLastContracts.SubItems.Add(location);
                    lvLastContracts.SubItems.Add(price);
                    listViewLastContracts.Items.Add(lvLastContracts);
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

        private void ListViewLastPayments_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listViewLastPayments.SelectedItems[0].Text);
            PageController.DisplayPayment(id);
            this.Hide();
            this.Dispose();
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
