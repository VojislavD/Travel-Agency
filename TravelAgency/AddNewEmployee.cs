using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class AddNewEmployee : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        public AddNewEmployee()
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void PictureBoxBack_Click(object sender, EventArgs e)
        {
            PageController.HomeAdmin();
            this.Hide();
            this.Dispose();
        }

        private void PictureBoxSave_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string jmbg = textBoxJMBG.Text.Trim();
            string gender = (radioButtonGenderMale.Checked == true) ? "Male":"Female";
            string phone = textBoxPhone.Text.Trim();
            string education = textBoxEducation.Text.Trim();
            DateTime dateOfHire = dateTimePickerDateOfHire.Value;
            string jobTitle = textBoxJobTitle.Text.Trim();
            decimal salary = Convert.ToDecimal(textBoxSalary.Text.Trim());

            //If there is not empty field insert new employee
            if(firstName != "" && lastName != "" && email != "" && password != "" && jmbg != "" && gender != "" && phone != "" && education != "" && dateOfHire < DateTime.Now && jobTitle != "" && salary > 0)
            {
                SqlCommand cmd = conn.Command("INSERT INTO Employees (first_name, last_name, email, password, JMBG, gender, phone, education, date_of_hire, job_title, salary) "
                    +"VALUES (@FirstName, @LastName, @Email, @Password, @JMBG, @Gender, @Phone, @Education, @DateOfHire, @JobTitle, @Salary)");
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@JMBG", jmbg);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Education", education);
                cmd.Parameters.AddWithValue("@DateOfHire", dateOfHire);
                cmd.Parameters.AddWithValue("@JobTitle", jobTitle);
                cmd.Parameters.AddWithValue("@Salary", salary);

                try
                {
                    conn.OpenConnection();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("New employee is successfully added.");
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
            } else
            {
                MessageBox.Show("All field are required. Please try again.");
            }
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

        private void AddNewEmployee_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
