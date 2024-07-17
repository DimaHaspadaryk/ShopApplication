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
            this.SuspendLayout();
            // 
            // idToFindTB
            // 
            this.idToFindTB.Location = new System.Drawing.Point(89, 174);
            this.idToFindTB.Name = "idToFindTB";
            this.idToFindTB.Size = new System.Drawing.Size(112, 26);
            this.idToFindTB.TabIndex = 0;
            this.idToFindTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Id of product you want to find ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backBut
            // 
            this.backBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBut.Location = new System.Drawing.Point(35, 467);
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
            this.findProdBut.Location = new System.Drawing.Point(89, 96);
            this.findProdBut.Name = "findProdBut";
            this.findProdBut.Size = new System.Drawing.Size(112, 35);
            this.findProdBut.TabIndex = 3;
            this.findProdBut.Text = "Find";
            this.findProdBut.UseVisualStyleBackColor = true;
            this.findProdBut.Click += new System.EventHandler(this.findProdBut_Click);
            // 
            // FindProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(492, 560);
            this.Controls.Add(this.findProdBut);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idToFindTB);
            this.Name = "FindProdForm";
            this.Text = "FindProdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idToFindTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Button findProdBut;
    }
}