using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class AddTouristGuide : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private string search = "";

        public AddTouristGuide()
        {
            InitializeComponent();
            loadTouristGuide(search);
        }

        private void loadTouristGuide(string search)
        {
            try
            {
                //clear listViewTouristGuide list
                listViewTouristGuides.Items.Clear();

                conn.OpenConnection();
                SqlDataReader reader = conn.SelectAll("TouristGuides");

                while (reader.Read())
                {
                    string firstName = reader["first_name"].ToString();
                    string lastName = reader["last_name"].ToString();
                    string availableLocation = reader["available_for_location"].ToString();

                    //if search field is empty or default value "Search"
                    if (search == "" || search == "Search")
                    {
                        ListViewItem lvTouristGuide = new ListViewItem(reader["ID"].ToString());
                        lvTouristGuide.SubItems.Add(firstName);
                        lvTouristGuide.SubItems.Add(lastName);
                        lvTouristGuide.SubItems.Add(availableLocation);
                        lvTouristGuide.SubItems.Add(reader["gender"].ToString());
                        lvTouristGuide.SubItems.Add(reader["salary"].ToString());
                        lvTouristGuide.SubItems.Add(reader["job_title"].ToString());

                        listViewTouristGuides.Items.Add(lvTouristGuide);
                    }
                    else if (firstName.Contains(search) || lastName.Contains(search) || availableLocation.Contains(search))
                    {
                        ListViewItem lvTouristGuide = new ListViewItem(reader["ID"].ToString());
                        lvTouristGuide.SubItems.Add(firstName);
                        lvTouristGuide.SubItems.Add(lastName);
                        lvTouristGuide.SubItems.Add(availableLocation);
                        lvTouristGuide.SubItems.Add(reader["gender"].ToString());
                        lvTouristGuide.SubItems.Add(reader["salary"].ToString());
                        lvTouristGuide.SubItems.Add(reader["job_title"].ToString());

                        listViewTouristGuides.Items.Add(lvTouristGuide);
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
            loadTouristGuide(search);
        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.SelectAll();
        }

        private void ListViewTouristGuides_DoubleClick(object sender, EventArgs e)
        {
            //Set tourist guide ID
            Data.touristGuideID = Convert.ToInt32(listViewTouristGuides.SelectedItems[0].Text);
            this.Close();
        }
    }
}
