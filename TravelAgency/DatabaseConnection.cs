using System;
using System.Data.SqlClient;


namespace TravelAgency
{
    class DatabaseConnection
    {
        SqlConnection con;

        public DatabaseConnection()
        {
            //Create instance for local database
            string path = @"c:\Users\" + Environment.UserName + @"\Documents\Travel Agency\Database";
            string databaseName = "TravelAgency.mdf";
            con = new SqlConnection(@"Data Source=(localdb)\v11.0;AttachDbFilename="+path+@"\"+databaseName+";Integrated Security=True");

            /*
            //Create instance for database on server
            con = new SqlConnection(@"Server=YOUR_SERVER_NAME;Database=TravelAgency;Integrated Security=true");
            */
        }

        public void OpenConnection()
        {
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }

        //Select all from tableName
        public SqlDataReader SelectAll(string tableName)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + tableName, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader;
        }

        //Select all from tableName with id
        public SqlDataReader SelectWithID(string tableName, int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + tableName + " WHERE ID=" + id , con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader;
        }

        //Delete all from tableName with id
        public bool DeleteWithID(string tableName, int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM " + tableName + " WHERE id=" + id, con);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Create SQL command
        public SqlCommand Command(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, con);
            return cmd;
        }

        //Execute reader for SQL command cmd
        public SqlDataReader DataReader(SqlCommand cmd)
        {
            SqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader;
        }
    }
}
