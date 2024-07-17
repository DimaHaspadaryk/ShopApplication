using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ShopApplication
{
    public partial class CatalogForm : Form
    {
        public ListView ProductListView {get;private set; }
        public CatalogForm()
        {
            InitializeComponent();
            ProductListView = new ListView
            {
                Location = new Point(12, 12),
                Size = new Size(776, 200),
                View = View.Details
            };
            ProductListView.Columns.Add("ID", 50);
            ProductListView.Columns.Add("Kind of Product", 150);
            ProductListView.Columns.Add("Producer", 150);
            this.Controls.Add(ProductListView);
            ProductListView.Dock = DockStyle.Fill;


            LoadFromTextFile();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();  
            Application.OpenForms["MainMenuForm"].Show();  

        }
        public void AddItemToListView(string id, string kindOfProduct, string producer)
        {
            var item = new ListViewItem(new[] { id, kindOfProduct, producer });
            ProductListView.Items.Add(item);
            AppendToTextFile(id, kindOfProduct, producer);
        }

        public void AppendToTextFile(string id, string kindOfProduct, string producer)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\дима\\source\\repos\\ShopApplication\\ListOfProducts.txt", true)) 
                {
                    string line = $"{id},{kindOfProduct},{producer}";
                    writer.WriteLine(line);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Access denied: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exeption: " + ex.Message);
            }
        }


        public void SaveToTextFile()
        {
            using (StreamWriter writer = new StreamWriter("C:\\Users\\дима\\source\\repos\\ShopApplication\\ListOfProducts.txt"))
            {
                foreach (ListViewItem item in ProductListView.Items)
                {
                    string line = string.Join(",", item.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(subItem => subItem.Text));
                    writer.WriteLine(line);
                }
            }
        }

        public void LoadFromTextFile()
        {
            if (File.Exists("C:\\Users\\дима\\source\\repos\\ShopApplication\\ListOfProducts.txt"))
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\дима\\source\\repos\\ShopApplication\\ListOfProducts.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            AddItemToListView(parts[0], parts[1], parts[2]);
                        }
                    }
                }
            }
        }

        public void FindProd(string id)
        {
            
        }

       
        public void RemoveItemFromListView(string id)
        {
            foreach (ListViewItem item in ProductListView.Items)
            {
                if (item.SubItems[0].Text == id)
                {
                    ProductListView.Items.Remove(item);
                    SaveToTextFile();
                    break;
                }
            }
        }

            private void CatalogForm_Load(object sender, EventArgs e)
        {

        }

  
    }
}
