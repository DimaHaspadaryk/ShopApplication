using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ShopApplication
{
    public partial class CatalogForm : Form
    {
        private string _filePath;

        public ListView ProductListView { get; private set; }

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

            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ListOfProducts.txt");
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
        }

        public void AppendToTextFile(string id, string kindOfProduct, string producer)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_filePath, true))
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
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        public void SaveToTextFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_filePath))
                {
                    foreach (ListViewItem item in ProductListView.Items)
                    {
                        string line = string.Join(",", item.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(subItem => subItem.Text));
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        public void LoadFromTextFile()
        {
            if (File.Exists(_filePath))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(_filePath))
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message);
                }
            }
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

        private void SortListView(int columnIndex)
        {
            var items = ProductListView.Items.Cast<ListViewItem>().ToList();

            if (columnIndex == 0)
            {
                items.Sort((x, y) =>
                {
                    int idX = int.Parse(x.SubItems[columnIndex].Text);
                    int idY = int.Parse(y.SubItems[columnIndex].Text);
                    return idX.CompareTo(idY);
                });
            }
            else
            {
                items.Sort((x, y) => string.Compare(x.SubItems[columnIndex].Text, y.SubItems[columnIndex].Text));
            }

            ProductListView.BeginUpdate();
            ProductListView.Items.Clear();
            ProductListView.Items.AddRange(items.ToArray());
            ProductListView.EndUpdate();
        }

            private void CatalogForm_Load(object sender, EventArgs e)
        {

        }

        private void surtIDbut_Click(object sender, EventArgs e)
        {
            SortListView(0);
        }

        private void sortNameBut_Click(object sender, EventArgs e)
        {
            SortListView(1);
        }

        private void sortProdBut_Click(object sender, EventArgs e)
        {
            SortListView(2);
        }
    }
}
