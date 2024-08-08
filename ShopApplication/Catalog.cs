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
            LoadFromDatabase2();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["MainMenuForm"].Show();
        }


        public void Refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = "ListOFProducts";
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
