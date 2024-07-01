using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public void addProduct_button_Click(object sender, EventArgs e)
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
                if (!int.TryParse(IDTB.Text,out id))
                {
                    MessageBox.Show("Field Date is invalid");
                }
                return;
            }
           
            _catalogForm.AddItemToListView(id.ToString(), kindOfProduct, producer);
            KindOfProductTB.Clear();
            ProducerTb.Clear();
            IDTB.Clear();

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
