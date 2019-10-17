using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class AddClient : Form
    {
        //Create DatabaseConnection instance
        DatabaseConnection conn = new DatabaseConnection();

        private string search = "";

        public AddClient()
        {
            InitializeComponent();
            loadClients(search);

        }

        private void loadClients(string search)
        {
            try
            {
                //clear listViewClients list
                listViewClients.Items.Clear();

                conn.OpenConnection();
                SqlDataReader reader = conn.SelectAll("Clients");

                while (reader.Read())
                {
                    string firstName = reader["first_name"].ToString();
                    string lastName = reader["last_name"].ToString();

                    //if search field is empty or default value "Search"
                    if (search == "" || search == "Search")
                    {
                        ListViewItem lvClient = new ListViewItem(reader["ID"].ToString());
                        lvClient.SubItems.Add(firstName);
                        lvClient.SubItems.Add(lastName);
                        lvClient.SubItems.Add(reader["JMBG"].ToString());
                        lvClient.SubItems.Add(reader["age"].ToString());
                        lvClient.SubItems.Add(reader["passport_number"].ToString());
                        lvClient.SubItems.Add(reader["citizenship"].ToString());
                        lvClient.SubItems.Add(reader["email"].ToString());
                        lvClient.SubItems.Add(reader["phone"].ToString());

                        listViewClients.Items.Add(lvClient);
                    } else if (firstName.Contains(search) || lastName.Contains(search))
                    {
                        ListViewItem lvClient = new ListViewItem(reader["ID"].ToString());
                        lvClient.SubItems.Add(firstName);
                        lvClient.SubItems.Add(lastName);
                        lvClient.SubItems.Add(reader["JMBG"].ToString());
                        lvClient.SubItems.Add(reader["age"].ToString());
                        lvClient.SubItems.Add(reader["passport_number"].ToString());
                        lvClient.SubItems.Add(reader["citizenship"].ToString());
                        lvClient.SubItems.Add(reader["email"].ToString());
                        lvClient.SubItems.Add(reader["phone"].ToString());

                        listViewClients.Items.Add(lvClient);
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            search = textBoxSearch.Text.Trim();
            loadClients(search);
        }

        private void ListViewClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                //Set clients data
                Data.id = Convert.ToInt32(listViewClients.SelectedItems[0].Text);
                Data.firstName = listViewClients.SelectedItems[0].SubItems[1].Text;
                Data.lastName = listViewClients.SelectedItems[0].SubItems[2].Text;
                Data.JMBG = listViewClients.SelectedItems[0].SubItems[3].Text;
                Data.age = listViewClients.SelectedItems[0].SubItems[4].Text;
                Data.passportNumber = listViewClients.SelectedItems[0].SubItems[5].Text;
                Data.citizenship = listViewClients.SelectedItems[0].SubItems[6].Text;
                Data.email = listViewClients.SelectedItems[0].SubItems[7].Text;
                Data.phone = listViewClients.SelectedItems[0].SubItems[8].Text;

            this.Close();
            this.Dispose();
        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.SelectAll();
        }
    }
}
