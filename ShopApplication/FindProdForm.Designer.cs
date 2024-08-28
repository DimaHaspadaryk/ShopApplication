namespace ShopApplication
{
    partial class FindProdForm
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
            this.idToFindTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backBut = new System.Windows.Forms.Button();
            this.findProdBut = new System.Windows.Forms.Button();
            this.FindByNameBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameToFindTB = new System.Windows.Forms.TextBox();
            this.FindByProducerBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdecurToFindTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // idToFindTB
            // 
            this.idToFindTB.Location = new System.Drawing.Point(70, 124);
            this.idToFindTB.Name = "idToFindTB";
            this.idToFindTB.Size = new System.Drawing.Size(112, 26);
            this.idToFindTB.TabIndex = 0;
            this.idToFindTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Id of product you want to find ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backBut
            // 
            this.backBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBut.Location = new System.Drawing.Point(16, 283);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(112, 48);
            this.backBut.TabIndex = 2;
            this.backBut.Text = "Back";
            this.backBut.UseVisualStyleBackColor = true;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // findProdBut
            // 
            this.findProdBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findProdBut.Location = new System.Drawing.Point(70, 46);
            this.findProdBut.Name = "findProdBut";
            this.findProdBut.Size = new System.Drawing.Size(112, 35);
            this.findProdBut.TabIndex = 3;
            this.findProdBut.Text = "Find";
            this.findProdBut.UseVisualStyleBackColor = true;
            this.findProdBut.Click += new System.EventHandler(this.findProdBut_Click);
            // 
            // FindByNameBut
            // 
            this.FindByNameBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindByNameBut.Location = new System.Drawing.Point(335, 46);
            this.FindByNameBut.Name = "FindByNameBut";
            this.FindByNameBut.Size = new System.Drawing.Size(112, 35);
            this.FindByNameBut.TabIndex = 6;
            this.FindByNameBut.Text = "Find";
            this.FindByNameBut.UseVisualStyleBackColor = true;
            this.FindByNameBut.Click += new System.EventHandler(this.FindByNameBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input Name of product you want to find ";
            // 
            // NameToFindTB
            // 
            this.NameToFindTB.Location = new System.Drawing.Point(335, 124);
            this.NameToFindTB.Name = "NameToFindTB";
            this.NameToFindTB.Size = new System.Drawing.Size(112, 26);
            this.NameToFindTB.TabIndex = 4;
            // 
            // FindByProducerBut
            // 
            this.FindByProducerBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindByProducerBut.Location = new System.Drawing.Point(628, 46);
            this.FindByProducerBut.Name = "FindByProducerBut";
            this.FindByProducerBut.Size = new System.Drawing.Size(112, 35);
            this.FindByProducerBut.TabIndex = 9;
            this.FindByProducerBut.Text = "Find";
            this.FindByProducerBut.UseVisualStyleBackColor = true;
            this.FindByProducerBut.Click += new System.EventHandler(this.FindByProducerBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Input Producer of product you want to find ";
            // 
            // ProdecurToFindTb
            // 
            this.ProdecurToFindTb.Location = new System.Drawing.Point(628, 124);
            this.ProdecurToFindTb.Name = "ProdecurToFindTb";
            this.ProdecurToFindTb.Size = new System.Drawing.Size(112, 26);
            this.ProdecurToFindTb.TabIndex = 7;
            // 
            // FindProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(879, 408);
            this.Controls.Add(this.FindByProducerBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProdecurToFindTb);
            this.Controls.Add(this.FindByNameBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameToFindTB);
            this.Controls.Add(this.findProdBut);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idToFindTB);
            this.Name = "FindProdForm";
            this.Text = "FindProdForm";
            this.Load += new System.EventHandler(this.FindProdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idToFindTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Button findProdBut;
        private System.Windows.Forms.Button FindByNameBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameToFindTB;
        private System.Windows.Forms.Button FindByProducerBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProdecurToFindTb;
    }
}