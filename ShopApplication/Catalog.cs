using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ShopApplication
{
    public partial class CatalogForm : Form
    {
        private string _filePath;

        DataBase _dataBase = new DataBase();
        
            public ListView ProductListView { get; private set; }

        public CatalogForm()
        {
            InitializeComponent();
           /* ProductListView = new ListView
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

            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ListOfProducts.txt");*/

            LoadFromDatabase2();
            
           // LoadFromTextFile();
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
        public void Refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = "ListOFProducts";
        }
       
        public void LoadFromDatabase()
        {
            SqlConnection connection = new SqlConnection();
           
            var query = "SELECT * FROM Products";
            using (var command = new SqlCommand(query, connection))
            {
                _dataBase.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AddItemToListView(reader["ID"].ToString(), reader["KindOfProduct"].ToString(), reader["Producer"].ToString());
                    }
                }
                _dataBase.CloseConnection();
            }
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
        public void LoadFromDatabase2()
        {
            string connectString = "server = haspadaryk.mssql.somee.com;Initial Catalog = haspadaryk;Integrated Security = false;User ID = haspad_SQLLogin_1;password = m1628290";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT * from ListOfProducts";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
