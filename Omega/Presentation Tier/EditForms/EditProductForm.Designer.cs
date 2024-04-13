namespace Omega.Presentation_Tier.EditForms
{
    partial class EditProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nazev = new System.Windows.Forms.TextBox();
            this.kod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryCbo = new System.Windows.Forms.ComboBox();
            this.aktualizovat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Název";
            // 
            // nazev
            // 
            this.nazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazev.Location = new System.Drawing.Point(301, 95);
            this.nazev.Name = "nazev";
            this.nazev.Size = new System.Drawing.Size(663, 53);
            this.nazev.TabIndex = 1;
            // 
            // kod
            // 
            this.kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kod.Location = new System.Drawing.Point(301, 211);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(663, 53);
            this.kod.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kód";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(301, 331);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(663, 53);
            this.price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cena (Kč)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategorie";
            // 
            // categoryCbo
            // 
            this.categoryCbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCbo.FormattingEnabled = true;
            this.categoryCbo.Location = new System.Drawing.Point(301, 458);
            this.categoryCbo.Name = "categoryCbo";
            this.categoryCbo.Size = new System.Drawing.Size(663, 54);
            this.categoryCbo.TabIndex = 7;
            // 
            // aktualizovat
            // 
            this.aktualizovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktualizovat.Location = new System.Drawing.Point(688, 569);
            this.aktualizovat.Name = "aktualizovat";
            this.aktualizovat.Size = new System.Drawing.Size(276, 109);
            this.aktualizovat.TabIndex = 8;
            this.aktualizovat.Text = "Aktualizovat";
            this.aktualizovat.UseVisualStyleBackColor = true;
            this.aktualizovat.Click += new System.EventHandler(this.aktualizovat_Click);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 738);
            this.Controls.Add(this.aktualizovat);
            this.Controls.Add(this.categoryCbo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazev);
            this.Controls.Add(this.label1);
            this.Name = "EditProductForm";
            this.Text = "EditProductForm";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazev;
        private System.Windows.Forms.TextBox kod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryCbo;
        private System.Windows.Forms.Button aktualizovat;
    }
}