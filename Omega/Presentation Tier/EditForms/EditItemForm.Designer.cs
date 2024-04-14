namespace Omega.Presentation_Tier
{
    partial class EditItemForm
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
            this.mnozstvi = new System.Windows.Forms.Label();
            this.upraveCeny = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.nameProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mnozstvi
            // 
            this.mnozstvi.AutoSize = true;
            this.mnozstvi.Location = new System.Drawing.Point(45, 99);
            this.mnozstvi.Name = "mnozstvi";
            this.mnozstvi.Size = new System.Drawing.Size(49, 13);
            this.mnozstvi.TabIndex = 0;
            this.mnozstvi.Text = "Mnozstvi";
            // 
            // upraveCeny
            // 
            this.upraveCeny.AutoSize = true;
            this.upraveCeny.Location = new System.Drawing.Point(45, 135);
            this.upraveCeny.Name = "upraveCeny";
            this.upraveCeny.Size = new System.Drawing.Size(68, 13);
            this.upraveCeny.TabIndex = 1;
            this.upraveCeny.Text = "Uprava ceny";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(136, 96);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(116, 20);
            this.quantity.TabIndex = 2;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(136, 132);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(116, 20);
            this.price.TabIndex = 8;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(177, 177);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 9;
            this.save.Text = "OK";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSize = true;
            this.nameProduct.Location = new System.Drawing.Point(139, 63);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(35, 13);
            this.nameProduct.TabIndex = 10;
            this.nameProduct.Text = "label1";
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 254);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.save);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.upraveCeny);
            this.Controls.Add(this.mnozstvi);
            this.Name = "EditItemForm";
            this.Text = "EditItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mnozstvi;
        private System.Windows.Forms.Label upraveCeny;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label nameProduct;
    }
}