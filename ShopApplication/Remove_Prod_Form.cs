using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void RemoveBt_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(IDTBRem.Text, out id))
            {
                MessageBox.Show("Field ID cannot be empty");
                return;
            }

            
            DialogResult iRemove;
            iRemove = MessageBox.Show("Do you really want delete Product", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(iRemove == DialogResult.Yes)
            {
                _catalogform.RemoveItemFromListView(id.ToString());
                IDTBRem.Clear();
                MessageBox.Show("Product successfully removed");
            }
         
            
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
