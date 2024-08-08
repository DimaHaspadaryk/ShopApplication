using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShopApplication
{
    public partial class Add_Product : Form
    {
        private CatalogForm _catalogForm;

        public Add_Product(CatalogForm catalogForm)
        {
            InitializeComponent();
            _catalogForm = catalogForm;
        }

        private void addProduct_button_Click(object sender, EventArgs e)
        {
           

            addprod();
            KindOfProductTB.Clear();
            ProducerTb.Clear();
            IDTB.Clear();
        }
        public void addprod()
        {
            string kindOfProduct = KindOfProductTB.Text;
            string producer = ProducerTb.Text;
            int id;

            if (string.IsNullOrEmpty(kindOfProduct) || string.IsNullOrEmpty(producer) || !int.TryParse(IDTB.Text, out id))
            {
                if (string.IsNullOrEmpty(KindOfProductTB.Text))
                {
                    MessageBox.Show("Field Kind of product can't be empty");
                }
                if (string.IsNullOrEmpty(ProducerTb.Text))
                {
                    MessageBox.Show("Field Producer can't be empty");
                }
                if (!int.TryParse(IDTB.Text, out id))
                {
                    MessageBox.Show("Field ID is invalid");
                }
                return;
            }

            SqlConnection connection = new SqlConnection(@"server = haspadaryk.mssql.somee.com;Initial Catalog = haspadaryk;Integrated Security = false;User ID = haspad_SQLLogin_1;password = m1628290");
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into ListOfProducts(ID,ProductName,Producer) values ('"+IDTB.Text+"','"+KindOfProductTB.Text+"','"+ProducerTb.Text+"')",connection);
            int i = command.ExecuteNonQuery();
            if(i != 0)
            {
                MessageBox.Show("product successfully add");
            }
            else
            {
                MessageBox.Show("error,try again");
            }
            
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["MainMenuForm"].Show();
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {

        }
    }
}
