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

    
        private void CatalogForm_Load(object sender, EventArgs e)
        {

        }

        private void surtIDbut_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void sortNameBut_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void sortProdBut_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], System.ComponentModel.ListSortDirection.Ascending);
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
            dataGridView1.Columns[0].ValueType = typeof(int);
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(int.Parse(s[0]), s[1], s[2]);  
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
