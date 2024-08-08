using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace ShopApplication
{
    public partial class MainMenuForm : Form
    {
        private CatalogForm _catalog;
        DataBase data = new DataBase();
        public MainMenuForm()
        {
            
            InitializeComponent();
            _catalog = new CatalogForm();
        }

        private void CatalogButton_Click(object sender, EventArgs e)
        {
            _catalog.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add_Product add_Product = new Add_Product(_catalog);
            add_Product.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void RemoveProdBut_Click(object sender, EventArgs e)
        {
            Remove_Prod_Form remove_Prod_Form = new Remove_Prod_Form(_catalog);
            remove_Prod_Form.Show();
            this.Hide();
        }

        private void FindProdBut_Click(object sender, EventArgs e)
        {
            FindProdForm findProdForm = new FindProdForm();
            findProdForm.Show();
            this.Hide();
        }

        private void testBD_Click(object sender, EventArgs e)
        {
            TestBd testBd = new TestBd();
            testBd.Show();
            this.Hide();
           
        }
    }
}
