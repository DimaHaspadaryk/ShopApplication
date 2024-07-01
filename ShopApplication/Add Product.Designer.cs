namespace ShopApplication
{
    partial class Add_Product
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
            this.addProduct_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.back_button = new System.Windows.Forms.Button();
            this.KindOfProductTB = new System.Windows.Forms.TextBox();
            this.ProducerTb = new System.Windows.Forms.TextBox();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addProduct_button
            // 
            this.addProduct_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProduct_button.Location = new System.Drawing.Point(295, 226);
            this.addProduct_button.Name = "addProduct_button";
            this.addProduct_button.Size = new System.Drawing.Size(178, 83);
            this.addProduct_button.TabIndex = 1;
            this.addProduct_button.Text = "Add Product";
            this.addProduct_button.UseVisualStyleBackColor = true;
            this.addProduct_button.Click += new System.EventHandler(this.addProduct_button_Click);
            // 
            // back_button
            // 
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.Location = new System.Drawing.Point(12, 372);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(111, 66);
            this.back_button.TabIndex = 2;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // KindOfProductTB
            // 
            this.KindOfProductTB.Location = new System.Drawing.Point(153, 27);
            this.KindOfProductTB.Name = "KindOfProductTB";
            this.KindOfProductTB.Size = new System.Drawing.Size(100, 26);
            this.KindOfProductTB.TabIndex = 3;
            // 
            // ProducerTb
            // 
            this.ProducerTb.Location = new System.Drawing.Point(153, 88);
            this.ProducerTb.Name = "ProducerTb";
            this.ProducerTb.Size = new System.Drawing.Size(100, 26);
            this.ProducerTb.TabIndex = 4;
            // 
            // IDTB
            // 
            this.IDTB.Location = new System.Drawing.Point(153, 152);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(100, 26);
            this.IDTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kind of product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Producer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDTB);
            this.Controls.Add(this.ProducerTb);
            this.Controls.Add(this.KindOfProductTB);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.addProduct_button);
            this.Name = "Add_Product";
            this.Text = "Add_Product";
            this.Load += new System.EventHandler(this.Add_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addProduct_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox KindOfProductTB;
        private System.Windows.Forms.TextBox ProducerTb;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}