namespace Omega.Forms.Panels
{
    partial class CategoryPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.ulozitKateg = new System.Windows.Forms.Button();
            this.tady = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputDPHsebou = new System.Windows.Forms.TextBox();
            this.ssebou = new System.Windows.Forms.Label();
            this.inputDPHtady = new System.Windows.Forms.TextBox();
            this.infoKateg = new System.Windows.Forms.GroupBox();
            this.inputNazev = new System.Windows.Forms.TextBox();
            this.název = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.infoKateg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorie";
            // 
            // ulozitKateg
            // 
            this.ulozitKateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulozitKateg.Location = new System.Drawing.Point(2917, 844);
            this.ulozitKateg.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ulozitKateg.Name = "ulozitKateg";
            this.ulozitKateg.Size = new System.Drawing.Size(267, 119);
            this.ulozitKateg.TabIndex = 1;
            this.ulozitKateg.Text = "Uložit";
            this.ulozitKateg.UseVisualStyleBackColor = true;
            this.ulozitKateg.Click += new System.EventHandler(this.ulozitKateg_Click);
            // 
            // tady
            // 
            this.tady.AutoSize = true;
            this.tady.Location = new System.Drawing.Point(56, 81);
            this.tady.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tady.Name = "tady";
            this.tady.Size = new System.Drawing.Size(108, 46);
            this.tady.TabIndex = 2;
            this.tady.Text = "Tady";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputDPHsebou);
            this.groupBox1.Controls.Add(this.ssebou);
            this.groupBox1.Controls.Add(this.tady);
            this.groupBox1.Controls.Add(this.inputDPHtady);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2203, 520);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(981, 274);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DPH";
            // 
            // inputDPHsebou
            // 
            this.inputDPHsebou.Location = new System.Drawing.Point(547, 162);
            this.inputDPHsebou.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputDPHsebou.Name = "inputDPHsebou";
            this.inputDPHsebou.Size = new System.Drawing.Size(361, 53);
            this.inputDPHsebou.TabIndex = 4;
            // 
            // ssebou
            // 
            this.ssebou.AutoSize = true;
            this.ssebou.Location = new System.Drawing.Point(536, 81);
            this.ssebou.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ssebou.Name = "ssebou";
            this.ssebou.Size = new System.Drawing.Size(350, 46);
            this.ssebou.TabIndex = 3;
            this.ssebou.Text = "S sebou (volitelné)";
            // 
            // inputDPHtady
            // 
            this.inputDPHtady.Location = new System.Drawing.Point(67, 162);
            this.inputDPHtady.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputDPHtady.Name = "inputDPHtady";
            this.inputDPHtady.Size = new System.Drawing.Size(361, 53);
            this.inputDPHtady.TabIndex = 2;
            // 
            // infoKateg
            // 
            this.infoKateg.Controls.Add(this.inputNazev);
            this.infoKateg.Controls.Add(this.název);
            this.infoKateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoKateg.Location = new System.Drawing.Point(2203, 136);
            this.infoKateg.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.infoKateg.Name = "infoKateg";
            this.infoKateg.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.infoKateg.Size = new System.Drawing.Size(981, 298);
            this.infoKateg.TabIndex = 4;
            this.infoKateg.TabStop = false;
            this.infoKateg.Text = "Informace";
            // 
            // inputNazev
            // 
            this.inputNazev.Location = new System.Drawing.Point(67, 162);
            this.inputNazev.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputNazev.Name = "inputNazev";
            this.inputNazev.Size = new System.Drawing.Size(841, 53);
            this.inputNazev.TabIndex = 1;
            // 
            // název
            // 
            this.název.AutoSize = true;
            this.název.Location = new System.Drawing.Point(56, 81);
            this.název.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.název.Name = "název";
            this.název.Size = new System.Drawing.Size(132, 46);
            this.název.TabIndex = 0;
            this.název.Text = "Název";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Chocolate;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            this.dataGridView1.GridColor = System.Drawing.Color.Chocolate;
            this.dataGridView1.Location = new System.Drawing.Point(93, 157);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 102;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(2005, 1557);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // CategoryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.infoKateg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ulozitKateg);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CategoryPanel";
            this.Size = new System.Drawing.Size(3952, 1786);
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.infoKateg.ResumeLayout(false);
            this.infoKateg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ulozitKateg;
        private System.Windows.Forms.Label tady;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputDPHtady;
        private System.Windows.Forms.Label ssebou;
        private System.Windows.Forms.GroupBox infoKateg;
        private System.Windows.Forms.TextBox inputDPHsebou;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox inputNazev;
        private System.Windows.Forms.Label název;
    }
}
