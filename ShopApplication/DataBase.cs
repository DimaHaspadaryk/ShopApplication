using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ShopApplication
{
    internal class DataBase
    { 
        
        SqlConnection connection;
        public void Database()
        {
            try
            {
                connection = new SqlConnection(@"server = haspadaryk.mssql.somee.com;Initial Catalog = haspadaryk;Integrated Security = false;User ID = haspad_SQLLogin_1;password = m1628290");
            }
            catch (Exception ex) {
                MessageBox.Show("Get connection message " + ex.Message);
            }
        }

        public void OpenConnection()

        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Open connection message " + ex.Message);
            }

        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Close connection message " + ex.Message);
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public void testBDBut()
        {

            try
            {

                string query = "Select * from ListOfProducts";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    MessageBox.Show($"{id} {name}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        

    }
    
    
}
