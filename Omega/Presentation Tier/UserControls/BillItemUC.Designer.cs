namespace Omega.Presentation_Tier.UserControls
{
    partial class BillItemUC
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
            this.nazev = new System.Windows.Forms.Label();
            this.cena = new System.Windows.Forms.Label();
            this.dph = new System.Windows.Forms.Label();
            this.mnozstvi = new System.Windows.Forms.Label();
            this.celkem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nazev
            // 
            this.nazev.AutoSize = true;
            this.nazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazev.Location = new System.Drawing.Point(-3, 7);
            this.nazev.Name = "nazev";
            this.nazev.Size = new System.Drawing.Size(46, 17);
            this.nazev.TabIndex = 0;
            this.nazev.Text = "label1";
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cena.Location = new System.Drawing.Point(170, 7);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(46, 17);
            this.cena.TabIndex = 1;
            this.cena.Text = "label2";
            // 
            // dph
            // 
            this.dph.AutoSize = true;
            this.dph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dph.Location = new System.Drawing.Point(248, 7);
            this.dph.Name = "dph";
            this.dph.Size = new System.Drawing.Size(46, 17);
            this.dph.TabIndex = 2;
            this.dph.Text = "label3";
            // 
            // mnozstvi
            // 
            this.mnozstvi.AutoSize = true;
            this.mnozstvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnozstvi.Location = new System.Drawing.Point(320, 7);
            this.mnozstvi.Name = "mnozstvi";
            this.mnozstvi.Size = new System.Drawing.Size(46, 17);
            this.mnozstvi.TabIndex = 3;
            this.mnozstvi.Text = "label4";
            // 
            // celkem
            // 
            this.celkem.AutoSize = true;
            this.celkem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celkem.Location = new System.Drawing.Point(387, 7);
            this.celkem.Name = "celkem";
            this.celkem.Size = new System.Drawing.Size(46, 17);
            this.celkem.TabIndex = 4;
            this.celkem.Text = "label5";
            // 
            // BillItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.celkem);
            this.Controls.Add(this.mnozstvi);
            this.Controls.Add(this.dph);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.nazev);
            this.Name = "BillItemUC";
            this.Size = new System.Drawing.Size(438, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazev;
        private System.Windows.Forms.Label cena;
        private System.Windows.Forms.Label dph;
        private System.Windows.Forms.Label mnozstvi;
        private System.Windows.Forms.Label celkem;
    }
}
