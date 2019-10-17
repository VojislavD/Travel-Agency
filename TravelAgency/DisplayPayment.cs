using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class DisplayPayment : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private int id, clientID, contractID;

        public DisplayPayment(int ID)
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonPayments.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;

            id = ID;
            FieldsDisabled();
            loadPayment(id);
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

        private void PictureBoxViewClient_Click(object sender, EventArgs e)
        {
            PageController.DisplayClient(clientID);
            this.Hide();
            this.Dispose();
        }

        private void PictureBoxViewContract_Click(object sender, EventArgs e)
        {
            PageController.DisplayContract(contractID);
            this.Hide();
            this.Dispose();
        }

        private void PictureBoxBack_Click(object sender, EventArgs e)
        {
            PageController.Payments();
            this.Hide();
            this.Dispose();
        }

        private void loadPayment(int id)
        {
            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.SelectWithID("Payments",id);

                if (reader.Read())
                {
                    clientID = Convert.ToInt32(reader["client_id"]);
                    contractID = Convert.ToInt32(reader["contract_id"]);

                    labelID.Text = reader["ID"].ToString();
                    textBoxClient.Text = reader["client_id"].ToString();
                    textBoxContract.Text = reader["contract_id"].ToString();
                    textBoxAmountPaid.Text = reader["amount_paid"].ToString();
                    textBoxAmountLeftToPay.Text = reader["amount_left_to_pay"].ToString();
                    dateTimePickerDatePaid.Value = Convert.ToDateTime(reader["date_paid"]);
                    dateTimePickerDueDateToPay.Value = Convert.ToDateTime(reader["due_date_to_pay"]);
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

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.OpenConnection();

                if (conn.DeleteWithID("Payments",id))
                {
                    MessageBox.Show("Payment is successfully deleted.");
                    PageController.Payments();
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

        private void FieldsDisabled()
        {
            textBoxClient.Enabled = false;
            textBoxContract.Enabled = false;
            textBoxAmountPaid.Enabled = false;
            textBoxAmountLeftToPay.Enabled = false;
            dateTimePickerDatePaid.Enabled = false;
            dateTimePickerDueDateToPay.Enabled = false;
        }

        private void DisplayPayment_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
