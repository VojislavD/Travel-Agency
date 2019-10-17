using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class Start : Form
    {
        DatabaseConnection conn = new DatabaseConnection();

        public Start()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            //If admin is logged-in
            if (textBoxEmail.Text.Trim() == "admin" && textBoxPassword.Text.Trim() == "admin")
            {
                User.UserID = 0;
                User.Username = "Admin";
                PageController.HomeAdmin();
                this.Hide();
            }
            //If employee is logged-in
            else
            {

                SqlCommand cmd = conn.Command("SELECT ID,First_name,Last_name FROM Employees WHERE email = @Email AND Password=@Password");
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text.Trim());

                try
                {
                    conn.OpenConnection();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                    {
                        User.UserID = Convert.ToInt32(reader["ID"].ToString());
                        User.Username = reader["First_name"].ToString() + " " + reader["Last_name"].ToString();
                        PageController.Home();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("There is no user with that credentials, please try again.");
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
        }
    }
}
