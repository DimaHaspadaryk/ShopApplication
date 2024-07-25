using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string path = "C:\\Users\\дима\\source\\repos\\ShopApplication\\ListOfProducts.txt";
            string[] textRead = File.ReadAllLines(path);
            string foundLine = textRead.FirstOrDefault(line => line.Contains(idToFindTB.Text));

            bool found = textRead.Any(line => line.Contains(idToFindTB.Text));
            if (foundLine != null)
            {
                MessageBox.Show($"Product is exist : {foundLine}");
                idToFindTB.Clear();
            }
            else
            {
                MessageBox.Show("Product not found");
                idToFindTB.Clear();
            }
        }

        private void FindByNameBut_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\дима\\source\\repos\\ShopApplication\\ListOfProducts.txt";
            string[] textRead = File.ReadAllLines(path);
            string foundLine = textRead.FirstOrDefault(line => line.Contains(NameToFindTB.Text));

            bool found = textRead.Any(line => line.Contains(NameToFindTB.Text));
            if (foundLine != null)
            {
                MessageBox.Show($"Product is exist : {foundLine}");
                NameToFindTB.Clear();
            }
            else
            {
                MessageBox.Show("Product not found");
                NameToFindTB.Clear();
            }
        }

        private void FindByProducerBut_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\дима\\source\\repos\\ShopApplication\\ListOfProducts.txt";
            string[] textread = File.ReadAllLines(path);
            string foundline = textread.FirstOrDefault(line => line.Contains(ProdecurToFindTb.Text));

            bool found = textread.Any(line => line.Contains(ProdecurToFindTb.Text));
            if(foundline != null)
            {
                MessageBox.Show($"Product exist :  {foundline}");
                ProdecurToFindTb.Clear();

            }
            else
            {
                MessageBox.Show("Product not found");
                ProdecurToFindTb.Clear();
            }

        }

        private void FindProdForm_Load(object sender, EventArgs e)
        {

        }
    }
}
