namespace ShopApplication
{
    partial class CatalogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackButton = new System.Windows.Forms.Button();
            this.surtIDbut = new System.Windows.Forms.Button();
            this.sortNameBut = new System.Windows.Forms.Button();
            this.sortProdBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Location = new System.Drawing.Point(915, 526);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(112, 56);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // surtIDbut
            // 
            this.surtIDbut.Location = new System.Drawing.Point(917, 12);
            this.surtIDbut.Name = "surtIDbut";
            this.surtIDbut.Size = new System.Drawing.Size(110, 56);
            this.surtIDbut.TabIndex = 3;
            this.surtIDbut.Text = "Sort by ID";
            this.surtIDbut.UseVisualStyleBackColor = true;
            this.surtIDbut.Click += new System.EventHandler(this.surtIDbut_Click);
            // 
            // sortNameBut
            // 
            this.sortNameBut.Location = new System.Drawing.Point(917, 105);
            this.sortNameBut.Name = "sortNameBut";
            this.sortNameBut.Size = new System.Drawing.Size(110, 56);
            this.sortNameBut.TabIndex = 4;
            this.sortNameBut.Text = "Sort by Name";
            this.sortNameBut.UseVisualStyleBackColor = true;
            this.sortNameBut.Click += new System.EventHandler(this.sortNameBut_Click);
            // 
            // sortProdBut
            // 
            this.sortProdBut.Location = new System.Drawing.Point(917, 182);
            this.sortProdBut.Name = "sortProdBut";
            this.sortProdBut.Size = new System.Drawing.Size(110, 56);
            this.sortProdBut.TabIndex = 5;
            this.sortProdBut.Text = "Sort by producer";
            this.sortProdBut.UseVisualStyleBackColor = true;
            this.sortProdBut.Click += new System.EventHandler(this.sortProdBut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameOfProduct,
            this.Producer});
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(687, 619);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // NameOfProduct
            // 
            this.NameOfProduct.HeaderText = "Name of Product";
            this.NameOfProduct.MinimumWidth = 8;
            this.NameOfProduct.Name = "NameOfProduct";
            this.NameOfProduct.Width = 150;
            // 
            // Producer
            // 
            this.Producer.HeaderText = "Producer";
            this.Producer.MinimumWidth = 8;
            this.Producer.Name = "Producer";
            this.Producer.Width = 150;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sortProdBut);
            this.Controls.Add(this.sortNameBut);
            this.Controls.Add(this.surtIDbut);
            this.Controls.Add(this.BackButton);
            this.Name = "CatalogForm";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.CatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button surtIDbut;
        private System.Windows.Forms.Button sortNameBut;
        private System.Windows.Forms.Button sortProdBut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producer;
    }
}