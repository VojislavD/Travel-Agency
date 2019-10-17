using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class Payments : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private string search = "";

        public Payments()
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonPayments.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;
            loadPayments(search);
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

        private void loadPayments(string search)
        {
            //clear listViewAllPayments list
            listViewAllPayments.Items.Clear();

            SqlCommand cmd = conn.Command("SELECT Payments.ID, Payments.amount_paid, Payments.amount_left_to_pay, Payments.date_paid, Payments.due_date_to_pay, "
                + "Clients.first_name, Clients.last_name, Contracts.contract_id, Contracts.offer_id, Offers.country, Offers.city, Offers.days FROM Payments INNER JOIN Clients ON Clients.ID=client_id "
                + "INNER JOIN Contracts ON Contracts.ID=Payments.contract_id INNER JOIN Offers ON Offers.ID=Contracts.offer_id ORDER BY Payments.date_paid DESC");

            try
            {
                conn.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["first_name"].ToString()+" "+ reader["last_name"].ToString();
                    DateTime datePaid= Convert.ToDateTime(reader["date_paid"]);
                    DateTime dateDueToPay= Convert.ToDateTime(reader["due_date_to_pay"]);

                    //if search field is empty or default value "Search"
                    if (search == "" || search == "search")
                    {
                        ListViewItem lvPayments = new ListViewItem(reader["ID"].ToString());
                        lvPayments.SubItems.Add(reader["contract_id"].ToString());
                        lvPayments.SubItems.Add(name);
                        lvPayments.SubItems.Add(reader["city"].ToString()+ " " + reader["country"].ToString());
                        lvPayments.SubItems.Add(reader["days"].ToString());
                        lvPayments.SubItems.Add(reader["amount_paid"].ToString());
                        lvPayments.SubItems.Add(reader["amount_left_to_pay"].ToString());
                        lvPayments.SubItems.Add(datePaid.ToString("dd-MM-yyyy"));
                        lvPayments.SubItems.Add(dateDueToPay.ToString("dd-MM-yyyy"));
                        
                        if(datePaid > dateDueToPay)
                        {
                            lvPayments.BackColor = Color.Red;
                        }

                        listViewAllPayments.Items.Add(lvPayments);
                    }
                    else if (name.Contains(search))
                    {
                        ListViewItem lvPayments = new ListViewItem(reader["ID"].ToString());
                        lvPayments.SubItems.Add(reader["contract_id"].ToString());
                        lvPayments.SubItems.Add(name);
                        lvPayments.SubItems.Add(reader["city"].ToString() + " " + reader["country"].ToString());
                        lvPayments.SubItems.Add(reader["days"].ToString());
                        lvPayments.SubItems.Add(reader["amount_paid"].ToString());
                        lvPayments.SubItems.Add(reader["amount_left_to_pay"].ToString());
                        lvPayments.SubItems.Add(datePaid.ToString("dd-MM-yyyy"));
                        lvPayments.SubItems.Add(dateDueToPay.ToString("dd-MM-yyyy"));

                        if (datePaid > dateDueToPay)
                        {
                            lvPayments.BackColor = Color.Red;
                        }

                        listViewAllPayments.Items.Add(lvPayments);
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
            loadPayments(search);
        }

        private void ListViewAllPayments_DoubleClick(object sender, EventArgs e)
        {
            int paymentID = Convert.ToInt32(listViewAllPayments.SelectedItems[0].Text);
            PageController.DisplayPayment(paymentID);
            this.Hide();
            this.Dispose();
        }

        private void Payments_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
