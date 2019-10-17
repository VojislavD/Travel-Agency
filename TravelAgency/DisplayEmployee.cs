using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class DisplayEmployee : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private bool editEnable = false;
        private int id;

        public DisplayEmployee(int ID)
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            labelUsername.Text = User.Username;
            id = ID;

            FieldsDisabled();
            loadEmployee(id);
        }

        private void PictureBoxBack_Click(object sender, EventArgs e)
        {
            PageController.HomeAdmin();
            this.Hide();
            this.Dispose();
        }

        private void PictureBoxLogout_Click(object sender, EventArgs e)
        {
            PageController.Logout();
            this.Hide();
            this.Dispose();
        }

        private void loadEmployee(int id)
        {
            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.SelectWithID("Employees", id);

                if(reader.Read())
                {
                    labelID.Text = reader["ID"].ToString();
                    textBoxFirstName.Text = reader["first_name"].ToString();
                    textBoxLastName.Text = reader["last_name"].ToString();
                    textBoxEmail.Text = reader["email"].ToString();
                    textBoxPassword.Text = reader["password"].ToString();
                    textBoxJMBG.Text = reader["JMBG"].ToString();
                    textBoxPhone.Text = reader["phone"].ToString();
                    textBoxEducation.Text = reader["education"].ToString();
                    dateTimePickerDateOfHire.Value = Convert.ToDateTime(reader["date_of_hire"].ToString());
                    textBoxJobTitle.Text = reader["job_title"].ToString();
                    textBoxSalary.Text = reader["salary"].ToString();

                    if(reader["gender"].ToString() == "Male")
                    {
                        radioButtonGenderMale.Checked = true;
                    } else if(reader["gender"].ToString() == "Female")
                    {
                        radioButtonGenderFemale.Checked = true;
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

        private void PictureBoxEdit_Click(object sender, EventArgs e)
        {
            if (editEnable)
            {
                FieldsDisabled();
                editEnable = false;
                loadEmployee(id);
            }
            else
            {
                FieldsEnabled();
                editEnable = true;
                loadEmployee(id);
            }
        }

        private void PictureBoxSave_Click(object sender, EventArgs e)
        {
            //check if gender is male of female
            string gender = (radioButtonGenderMale.Checked == true) ? "Male" : "Female";

            SqlCommand cmd = conn.Command("UPDATE Employees SET first_name = @FirstName, last_name= @LastName, email = @Email, password = @Password, "
                + "JMBG=@JMBG, gender = @Gender, phone= @Phone, education = @Education, date_of_hire = @DateOfHire, job_title = @JobTitle, salary = @Salary "
                +"WHERE ID = @ID");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text.Trim());
            cmd.Parameters.AddWithValue("@JMBG", textBoxJMBG.Text.Trim());
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@Education", textBoxEducation.Text.Trim());
            cmd.Parameters.AddWithValue("@DateOfHire", dateTimePickerDateOfHire.Value);
            cmd.Parameters.AddWithValue("@JobTitle", textBoxJobTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@Salary", textBoxSalary.Text.Trim());

            try
            {
                conn.OpenConnection();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Emplolee information are successfully updated.");
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
                loadEmployee(id);
            }

        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.OpenConnection();

                if (conn.DeleteWithID("Employees", id))
                {
                    MessageBox.Show("Employee is successfully deleted.");
                    PageController.HomeAdmin();
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

        private void FieldsEnabled()
        {
            pictureBoxSave.Enabled = true;
            labelSave.Enabled = true;
            pictureBoxDelete.Enabled = false;
            labelDelete.Enabled = false;

            textBoxFirstName.Enabled = true;
            textBoxLastName.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxPassword.Enabled = true;
            textBoxJMBG.Enabled = true;
            radioButtonGenderMale.Enabled = true;
            radioButtonGenderFemale.Enabled = true;
            textBoxPhone.Enabled = true;
            textBoxEducation.Enabled = true;
            dateTimePickerDateOfHire.Enabled = true;
            textBoxJobTitle.Enabled = true;
            textBoxSalary.Enabled = true;
        }

        private void FieldsDisabled()
        {
            pictureBoxSave.Enabled = false;
            labelSave.Enabled = false;
            pictureBoxDelete.Enabled = true;
            labelDelete.Enabled = true;

            labelID.Enabled = false;
            textBoxFirstName.Enabled = false;
            textBoxLastName.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxPassword.Enabled = false;
            textBoxJMBG.Enabled = false;
            radioButtonGenderMale.Enabled = false;
            radioButtonGenderFemale.Enabled = false;
            textBoxPhone.Enabled = false;
            textBoxEducation.Enabled = false;
            dateTimePickerDateOfHire.Enabled = false;
            textBoxJobTitle.Enabled = false;
            textBoxSalary.Enabled = false;
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

        private void DisplayEmployee_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
