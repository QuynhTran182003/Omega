namespace Omega.Presentation_Tier.Panels
{
    partial class ProductPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.infoKateg = new System.Windows.Forms.GroupBox();
            this.cbKategorie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputCena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNazev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputKod = new System.Windows.Forms.TextBox();
            this.název = new System.Windows.Forms.Label();
            this.ulozitProdukt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.infoKateg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(125, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 102;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(2005, 1557);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // infoKateg
            // 
            this.infoKateg.Controls.Add(this.cbKategorie);
            this.infoKateg.Controls.Add(this.label4);
            this.infoKateg.Controls.Add(this.inputCena);
            this.infoKateg.Controls.Add(this.label3);
            this.infoKateg.Controls.Add(this.inputNazev);
            this.infoKateg.Controls.Add(this.label2);
            this.infoKateg.Controls.Add(this.inputKod);
            this.infoKateg.Controls.Add(this.název);
            this.infoKateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoKateg.Location = new System.Drawing.Point(2235, 145);
            this.infoKateg.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.infoKateg.Name = "infoKateg";
            this.infoKateg.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.infoKateg.Size = new System.Drawing.Size(981, 868);
            this.infoKateg.TabIndex = 9;
            this.infoKateg.TabStop = false;
            this.infoKateg.Text = "Informace";
            // 
            // cbKategorie
            // 
            this.cbKategorie.FormattingEnabled = true;
            this.cbKategorie.Location = new System.Drawing.Point(67, 727);
            this.cbKategorie.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbKategorie.Name = "cbKategorie";
            this.cbKategorie.Size = new System.Drawing.Size(841, 54);
            this.cbKategorie.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 651);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategorie";
            // 
            // inputCena
            // 
            this.inputCena.Location = new System.Drawing.Point(67, 544);
            this.inputCena.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputCena.Name = "inputCena";
            this.inputCena.Size = new System.Drawing.Size(841, 53);
            this.inputCena.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 463);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cena";
            // 
            // inputNazev
            // 
            this.inputNazev.Location = new System.Drawing.Point(67, 348);
            this.inputNazev.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputNazev.Name = "inputNazev";
            this.inputNazev.Size = new System.Drawing.Size(841, 53);
            this.inputNazev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Název";
            // 
            // inputKod
            // 
            this.inputKod.Location = new System.Drawing.Point(67, 162);
            this.inputKod.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputKod.Name = "inputKod";
            this.inputKod.Size = new System.Drawing.Size(841, 53);
            this.inputKod.TabIndex = 1;
            // 
            // název
            // 
            this.název.AutoSize = true;
            this.název.Location = new System.Drawing.Point(56, 81);
            this.název.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.název.Name = "název";
            this.název.Size = new System.Drawing.Size(91, 46);
            this.název.TabIndex = 0;
            this.název.Text = "Kod";
            // 
            // ulozitProdukt
            // 
            this.ulozitProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulozitProdukt.Location = new System.Drawing.Point(2949, 1090);
            this.ulozitProdukt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ulozitProdukt.Name = "ulozitProdukt";
            this.ulozitProdukt.Size = new System.Drawing.Size(267, 119);
            this.ulozitProdukt.TabIndex = 7;
            this.ulozitProdukt.Text = "Uložit";
            this.ulozitProdukt.UseVisualStyleBackColor = true;
            this.ulozitProdukt.Click += new System.EventHandler(this.ulozitProdukt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Produkty";
            // 
            // ProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.infoKateg);
            this.Controls.Add(this.ulozitProdukt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ProductPanel";
            this.Size = new System.Drawing.Size(3952, 1786);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.infoKateg.ResumeLayout(false);
            this.infoKateg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox infoKateg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputCena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNazev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputKod;
        private System.Windows.Forms.Label název;
        private System.Windows.Forms.Button ulozitProdukt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategorie;
    }
}
