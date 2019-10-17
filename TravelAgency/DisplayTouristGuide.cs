using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class DisplayTouristGuide : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private Boolean editEnable = false;
        private int id;

        public DisplayTouristGuide(int ID)
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            buttonTouristGuides.ForeColor = System.Drawing.Color.Gold;
            labelUsername.Text = User.Username;

            id = ID;

            FieldsDisabled();
            loadTouristGuide(id);
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

        private void loadTouristGuide(int id)
        {
            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.SelectWithID("TouristGuides", id);

                while (reader.Read())
                {
                    labelID.Text = reader["ID"].ToString();
                    textBoxFirstName.Text = reader["first_name"].ToString();
                    textBoxLastName.Text = reader["last_name"].ToString();
                    textBoxJMBG.Text = reader["JMBG"].ToString();
                    textBoxGender.Text = reader["gender"].ToString();
                    textBoxAddress.Text = reader["address"].ToString();
                    textBoxPhone.Text = reader["phone"].ToString();
                    textBoxEmail.Text = reader["email"].ToString();
                    textBoxEducation.Text = reader["education"].ToString();
                    dateTimePickerDateOfHire.Value = Convert.ToDateTime(reader["date_of_hire"].ToString());
                    textBoxJobTitle.Text = reader["job_title"].ToString();
                    textBoxSalary.Text = reader["salary"].ToString();
                    textBoxAvailableForLocation.Text = reader["available_for_location"].ToString();


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

        private void PictureBoxEdit_Click(object sender, EventArgs e)
        {
            if (editEnable)
            {
                FieldsDisabled();
                editEnable = false;
                loadTouristGuide(id);
            }
            else
            {
                FieldsEnabled();
                editEnable = true;
                loadTouristGuide(id);
            }
        }

        private void PictureBoxSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.Command("UPDATE TouristGuides SET first_name=@FirstName, last_name=@LastName, JMBG=@JMBG, gender=@Gender, address=@Address, phone=@Phone, "
                + "email=@Email, education=@Education, date_of_hire=@DateOfHire, job_title=@JobTitle, salary=@Salary, available_for_location=@AvailableForLocation WHERE ID = @ID");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", labelID.Text);
            cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@JMBG", textBoxJMBG.Text.Trim());
            cmd.Parameters.AddWithValue("@Gender", textBoxGender.Text.Trim());
            cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@Education", textBoxEducation.Text.Trim());
            cmd.Parameters.AddWithValue("@DateOfHire", dateTimePickerDateOfHire.Value);
            cmd.Parameters.AddWithValue("@JobTitle", textBoxJobTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@Salary", Convert.ToInt32(textBoxSalary.Text));
            cmd.Parameters.AddWithValue("@AvailableForLocation", textBoxAvailableForLocation.Text.Trim());

            try
            {
                conn.OpenConnection();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Tourist guide information are successfully updated.");
                    FieldsDisabled();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
                loadTouristGuide(id);
            }
        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.OpenConnection();

                if (conn.DeleteWithID("TouristGuides",id))
                {
                    MessageBox.Show("Tourist guide is successfully deleted.");
                    PageController.TouristGuides();
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

        //Enable all fields
        private void FieldsEnabled()
        {
            pictureBoxSave.Enabled = true;
            labelSave.Enabled = true;
            pictureBoxDelete.Enabled = false;
            labelDelete.Enabled = false;

            textBoxFirstName.Enabled = true;
            textBoxLastName.Enabled = true;
            textBoxJMBG.Enabled = true;
            textBoxGender.Enabled = true;
            textBoxAddress.Enabled = true;
            textBoxPhone.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxEducation.Enabled = true;
            dateTimePickerDateOfHire.Enabled = true;
            textBoxJobTitle.Enabled = true;
            textBoxSalary.Enabled = true;
            textBoxAvailableForLocation.Enabled = true;
        }

        //Disable all fields
        private void FieldsDisabled()
        {
            pictureBoxSave.Enabled = false;
            labelSave.Enabled = false;
            pictureBoxDelete.Enabled = true;
            labelDelete.Enabled = true;

            textBoxFirstName.Enabled = false;
            textBoxLastName.Enabled = false;
            textBoxJMBG.Enabled = false;
            textBoxGender.Enabled = false;
            textBoxAddress.Enabled = false;
            textBoxPhone.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxEducation.Enabled = false;
            dateTimePickerDateOfHire.Enabled = false;
            textBoxJobTitle.Enabled = false;
            textBoxSalary.Enabled = false;
            textBoxAvailableForLocation.Enabled = false;
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

        private void DisplayTouristGuide_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
