using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ShopApplication
{
    public partial class MainMenuForm : Form
    {
        private CatalogForm _catalog;
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
            iExit = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ;
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void RemoveProdBut_Click(object sender, EventArgs e)
        {
            Remove_Prod_Form remove_Prod_Form = new Remove_Prod_Form(_catalog);
            remove_Prod_Form.Show();
            this.Hide();
        }
    }
}
