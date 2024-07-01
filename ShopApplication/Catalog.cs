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

        }



        public void RemoveItemFromListView(string id)
        {
            foreach (ListViewItem item in ProductListView.Items)
            {
                if (item.SubItems[0].Text == id)
                {
                    ProductListView.Items.Remove(item);
                    break;
                }
            }
        }

            private void CatalogForm_Load(object sender, EventArgs e)
        {

        }

  
    }
}
