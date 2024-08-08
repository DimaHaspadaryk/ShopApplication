using System;
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

        public void DeleteFromTextFile(string id)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ListOfProducts.txt");
            string[] textRead = File.ReadAllLines(path);
            File.WriteAllText(path, String.Empty);
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string line in textRead)
                {
                    if (!line.StartsWith(id + ","))
                    {
                        writer.WriteLine(line);
                    }
                }
            }
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
            iRemove = MessageBox.Show("Do you really want to delete the product?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iRemove == DialogResult.Yes)
            {
                _catalogform.RemoveItemFromListView(id.ToString());
              //  _catalogform.RemoveItemFromDatabase(id.ToString());
                DeleteFromTextFile(id.ToString());
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
