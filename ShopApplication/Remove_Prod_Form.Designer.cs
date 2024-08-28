namespace ShopApplication
{
    partial class Remove_Prod_Form
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
            this.RemoveBt = new System.Windows.Forms.Button();
            this.IDTBRem = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoveBt
            // 
            this.RemoveBt.Location = new System.Drawing.Point(263, 265);
            this.RemoveBt.Name = "RemoveBt";
            this.RemoveBt.Size = new System.Drawing.Size(154, 88);
            this.RemoveBt.TabIndex = 0;
            this.RemoveBt.Text = "Remove ";
            this.RemoveBt.UseVisualStyleBackColor = true;
            this.RemoveBt.Click += new System.EventHandler(this.RemoveBt_Click);
            // 
            // IDTBRem
            // 
            this.IDTBRem.Location = new System.Drawing.Point(117, 167);
            this.IDTBRem.Name = "IDTBRem";
            this.IDTBRem.Size = new System.Drawing.Size(94, 26);
            this.IDTBRem.TabIndex = 3;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(53, 432);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(84, 33);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input ID of product witch you want to delete";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Remove_Prod_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.IDTBRem);
            this.Controls.Add(this.RemoveBt);
            this.Name = "Remove_Prod_Form";
            this.Text = "Remove_Prod_Form";
            this.Load += new System.EventHandler(this.Remove_Prod_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveBt;
        private System.Windows.Forms.TextBox IDTBRem;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
    }
}