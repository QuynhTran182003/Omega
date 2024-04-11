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
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ulozitKateg
            // 
            this.ulozitKateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulozitKateg.Location = new System.Drawing.Point(1094, 354);
            this.ulozitKateg.Name = "ulozitKateg";
            this.ulozitKateg.Size = new System.Drawing.Size(100, 50);
            this.ulozitKateg.TabIndex = 1;
            this.ulozitKateg.Text = "Uložit";
            this.ulozitKateg.UseVisualStyleBackColor = true;
            this.ulozitKateg.Click += new System.EventHandler(this.ulozitKateg_Click);
            // 
            // tady
            // 
            this.tady.AutoSize = true;
            this.tady.Location = new System.Drawing.Point(21, 34);
            this.tady.Name = "tady";
            this.tady.Size = new System.Drawing.Size(43, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(826, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DPH";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // inputDPHsebou
            // 
            this.inputDPHsebou.Location = new System.Drawing.Point(205, 68);
            this.inputDPHsebou.Name = "inputDPHsebou";
            this.inputDPHsebou.Size = new System.Drawing.Size(138, 26);
            this.inputDPHsebou.TabIndex = 4;
            // 
            // ssebou
            // 
            this.ssebou.AutoSize = true;
            this.ssebou.Location = new System.Drawing.Point(201, 34);
            this.ssebou.Name = "ssebou";
            this.ssebou.Size = new System.Drawing.Size(139, 20);
            this.ssebou.TabIndex = 3;
            this.ssebou.Text = "S sebou (volitelné)";
            // 
            // inputDPHtady
            // 
            this.inputDPHtady.Location = new System.Drawing.Point(25, 68);
            this.inputDPHtady.Name = "inputDPHtady";
            this.inputDPHtady.Size = new System.Drawing.Size(138, 26);
            this.inputDPHtady.TabIndex = 2;
            // 
            // infoKateg
            // 
            this.infoKateg.Controls.Add(this.inputNazev);
            this.infoKateg.Controls.Add(this.název);
            this.infoKateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoKateg.Location = new System.Drawing.Point(826, 57);
            this.infoKateg.Name = "infoKateg";
            this.infoKateg.Size = new System.Drawing.Size(368, 125);
            this.infoKateg.TabIndex = 4;
            this.infoKateg.TabStop = false;
            this.infoKateg.Text = "Informace";
            this.infoKateg.Enter += new System.EventHandler(this.infoKateg_Enter);
            // 
            // inputNazev
            // 
            this.inputNazev.Location = new System.Drawing.Point(25, 68);
            this.inputNazev.Name = "inputNazev";
            this.inputNazev.Size = new System.Drawing.Size(318, 26);
            this.inputNazev.TabIndex = 1;
            // 
            // název
            // 
            this.název.AutoSize = true;
            this.název.Location = new System.Drawing.Point(21, 34);
            this.název.Name = "název";
            this.název.Size = new System.Drawing.Size(53, 20);
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
            this.dataGridView1.Location = new System.Drawing.Point(35, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(752, 653);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.infoKateg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ulozitKateg);
            this.Controls.Add(this.label1);
            this.Name = "CategoryForm";
            this.Size = new System.Drawing.Size(1482, 749);
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
