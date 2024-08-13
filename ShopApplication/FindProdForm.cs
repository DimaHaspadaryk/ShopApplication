using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
           
            SqlConnection connection = new SqlConnection(@"server = haspadaryk.mssql.somee.com;Initial Catalog = haspadaryk;Integrated Security = false;User ID = haspad_SQLLogin_1;password = m1628290");
            string query = "Select ID from ListOfProducts where Id = ' " + idToFindTB.Text + "' ";

            connection.Open();
            SqlCommand cmd = new SqlCommand(query,connection);
            
            int i = cmd.ExecuteNonQuery();
            if(i != 0)
            {
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Product doesn't exist");
            }
            connection.Close();
        }

        private void FindByNameBut_Click(object sender, EventArgs e)
        {
          
            SqlConnection connection = new SqlConnection(@"server = haspadaryk.mssql.somee.com;Initial Catalog = haspadaryk;Integrated Security = false;User ID = haspad_SQLLogin_1;password = m1628290");
            connection.Open();
            string query = "Select ProductName from ListOfProduct where Name = '" + NameToFindTB.Text + "'";
            SqlCommand command = new SqlCommand(query,connection);
            int i = command.ExecuteNonQuery(); 
            if(i != 0)
            {
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Product doesn't exist");
            }
        }

        private void FindByProducerBut_Click(object sender, EventArgs e)
        {
        
            SqlConnection connection = new SqlConnection(@"server = haspadaryk.mssql.somee.com;Initial Catalog = haspadaryk;Integrated Security = false;User ID = haspad_SQLLogin_1;password = m1628290");
            connection.Open();
            string query = "Select Producer from ListOfProduct where Producer = '" + ProdecurToFindTb.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int i = command.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Product doesn't exist");
            }
        }

        private void FindProdForm_Load(object sender, EventArgs e)
        {

        }
    }
}
