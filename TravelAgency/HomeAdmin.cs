using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class HomeAdmin : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        public HomeAdmin()
        {
            InitializeComponent();
            //Check if window should be maximized
            WindowState = (Data.windowMaximized) ? FormWindowState.Maximized : FormWindowState.Normal;

            labelUsername.Text = User.Username;

            loadEmployees();
        }

        private void PictureBoxAddNewEmployee_Click(object sender, EventArgs e)
        {
            PageController.AddNewEmployee();
            this.Hide();
            this.Dispose();
        }

        private void PictureBoxLogout_Click(object sender, EventArgs e)
        {
            PageController.Logout();
            this.Hide();
            this.Dispose();
        }

        private void loadEmployees()
        {
            listViewEmployees.Items.Clear();

            try
            {
                conn.OpenConnection();
                SqlDataReader reader = conn.SelectAll("Employees");
                
                while(reader.Read())
                {
                    ListViewItem lvEmployees = new ListViewItem(reader["ID"].ToString());
                    lvEmployees.SubItems.Add(reader["first_name"].ToString());
                    lvEmployees.SubItems.Add(reader["last_name"].ToString());
                    lvEmployees.SubItems.Add(reader["email"].ToString());
                    lvEmployees.SubItems.Add(reader["phone"].ToString());

                    listViewEmployees.Items.Add(lvEmployees);
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

        private void ListViewEmployees_DoubleClick(object sender, EventArgs e)
        {
            int EmployeeID = Convert.ToInt32(listViewEmployees.SelectedItems[0].Text);
            PageController.DisplayEmployee(EmployeeID);
            this.Hide();
            this.Dispose();
        }

        private void HomeAdmin_Resize(object sender, EventArgs e)
        {
            //Check if window should be maximized
            Data.windowMaximized = (WindowState == FormWindowState.Maximized) ? true : false;
        }
    }
}
