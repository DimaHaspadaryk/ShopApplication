using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApplication
{
    public partial class FindProdForm : Form
    {
        public FindProdForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["MainMenuForm"].Show();
        }




        private void findProdBut_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"server=haspadaryk.mssql.somee.com;Initial Catalog=haspadaryk;Integrated Security=false;User ID=haspad_SQLLogin_1;password=m1628290"))
            {
                string query = "SELECT * FROM ListOfProducts WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", idToFindTB.Text.Trim());

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string result = $"ID: {reader["ID"]}, Name: {reader["ProductName"]}, Producer: {reader["Producer"]}";
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Product doesn't exist");
                }

                connection.Close();
            }
        }

        private void FindByNameBut_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"server=haspadaryk.mssql.somee.com;Initial Catalog=haspadaryk;Integrated Security=false;User ID=haspad_SQLLogin_1;password=m1628290"))
            {
                string query = "SELECT * FROM ListOfProducts WHERE ProductName = @name";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", NameToFindTB.Text.Trim());

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string result = $"ID: {reader["ID"]}, Name: {reader["ProductName"]}, Producer: {reader["Producer"]}";
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Product doesn't exist");
                }

                connection.Close();
            }
        }

        private void FindByProducerBut_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"server=haspadaryk.mssql.somee.com;Initial Catalog=haspadaryk;Integrated Security=false;User ID=haspad_SQLLogin_1;password=m1628290"))
            {
                string query = "SELECT * FROM ListOfProducts WHERE Producer = @producer";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@producer", ProdecurToFindTb.Text.Trim());

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string result = $"ID: {reader["ID"]}, Name: {reader["ProductName"]}, Producer: {reader["Producer"]}";
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Product doesn't exist");
                }

                connection.Close();
            }
        }


        private void FindProdForm_Load(object sender, EventArgs e)
        {

        }
    }
}
