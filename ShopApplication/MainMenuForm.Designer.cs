namespace ShopApplication
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CatalogButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RemoveProdBut = new System.Windows.Forms.Button();
            this.FindProdBut = new System.Windows.Forms.Button();
            this.testBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(348, 47);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main menu";
            // 
            // CatalogButton
            // 
            this.CatalogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CatalogButton.Location = new System.Drawing.Point(361, 109);
            this.CatalogButton.Name = "CatalogButton";
            this.CatalogButton.Size = new System.Drawing.Size(96, 54);
            this.CatalogButton.TabIndex = 1;
            this.CatalogButton.Text = "Catalog";
            this.CatalogButton.UseVisualStyleBackColor = true;
            this.CatalogButton.Click += new System.EventHandler(this.CatalogButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Location = new System.Drawing.Point(361, 212);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(96, 54);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add new product";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Location = new System.Drawing.Point(361, 551);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(102, 63);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RemoveProdBut
            // 
            this.RemoveProdBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveProdBut.Location = new System.Drawing.Point(361, 314);
            this.RemoveProdBut.Name = "RemoveProdBut";
            this.RemoveProdBut.Size = new System.Drawing.Size(96, 57);
            this.RemoveProdBut.TabIndex = 4;
            this.RemoveProdBut.Text = "Remove product";
            this.RemoveProdBut.UseVisualStyleBackColor = true;
            this.RemoveProdBut.Click += new System.EventHandler(this.RemoveProdBut_Click);
            // 
            // FindProdBut
            // 
            this.FindProdBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindProdBut.Location = new System.Drawing.Point(361, 420);
            this.FindProdBut.Name = "FindProdBut";
            this.FindProdBut.Size = new System.Drawing.Size(96, 55);
            this.FindProdBut.TabIndex = 5;
            this.FindProdBut.Text = "Find product";
            this.FindProdBut.UseVisualStyleBackColor = true;
            this.FindProdBut.Click += new System.EventHandler(this.FindProdBut_Click);
            // 
            // testBD
            // 
            this.testBD.Location = new System.Drawing.Point(632, 140);
            this.testBD.Name = "testBD";
            this.testBD.Size = new System.Drawing.Size(86, 43);
            this.testBD.TabIndex = 6;
            this.testBD.Text = "testBD";
            this.testBD.UseVisualStyleBackColor = true;
            this.testBD.Click += new System.EventHandler(this.testBD_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(876, 666);
            this.Controls.Add(this.testBD);
            this.Controls.Add(this.FindProdBut);
            this.Controls.Add(this.RemoveProdBut);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CatalogButton);
            this.Controls.Add(this.label1);
            this.Name = "MainMenuForm";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CatalogButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RemoveProdBut;
        private System.Windows.Forms.Button FindProdBut;
        private System.Windows.Forms.Button testBD;
    }
}

