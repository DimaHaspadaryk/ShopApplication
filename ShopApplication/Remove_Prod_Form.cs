using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ShopApplication
{
    public partial class Remove_Prod_Form : Form
    {
        private CatalogForm _catalogform;

        public Remove_Prod_Form(CatalogForm catalogForm)
        {
            InitializeComponent();
            _catalogform = catalogForm;
        }

        private void Remove_Prod_Form_Load(object sender, EventArgs e)
        {

        }
        public void RemoveFromDB()
        {
            SqlConnection connection = new SqlConnection(@"server = haspadaryk.mssql.somee.com;Initial Catalog = haspadaryk;Integrated Security = false;User ID = haspad_SQLLogin_1;password = m1628290");
            connection.Open();
            string query = "Delete from ListOfProducts where ID = '" + IDTBRem.Text + "' ";
            SqlCommand command = new SqlCommand(query, connection);
           int i = command.ExecuteNonQuery();
            if(i != 0)
            {
                MessageBox.Show("Product successfully delete");
            }
            else
            {
                MessageBox.Show("Error,try again");
            }
        }
       
        private void RemoveBt_Click(object sender, EventArgs e)
        {

            RemoveFromDB();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["MainMenuForm"].Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
