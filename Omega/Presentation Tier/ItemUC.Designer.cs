namespace Omega.Presentation_Tier
{
    partial class ItemUC
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
            this.id = new System.Windows.Forms.Label();
            this.jmeno = new System.Windows.Forms.Label();
            this.cena = new System.Windows.Forms.Label();
            this.mnozstvi = new System.Windows.Forms.Label();
            this.dph = new System.Windows.Forms.Label();
            this.kod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(1, 10);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(26, 20);
            this.id.TabIndex = 0;
            this.id.Text = "ID";
            // 
            // jmeno
            // 
            this.jmeno.AutoSize = true;
            this.jmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmeno.Location = new System.Drawing.Point(43, 10);
            this.jmeno.Name = "jmeno";
            this.jmeno.Size = new System.Drawing.Size(42, 20);
            this.jmeno.TabIndex = 1;
            this.jmeno.Text = "label";
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cena.Location = new System.Drawing.Point(327, 10);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(18, 20);
            this.cena.TabIndex = 2;
            this.cena.Text = ".-";
            // 
            // mnozstvi
            // 
            this.mnozstvi.AutoSize = true;
            this.mnozstvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnozstvi.Location = new System.Drawing.Point(433, 9);
            this.mnozstvi.Name = "mnozstvi";
            this.mnozstvi.Size = new System.Drawing.Size(25, 20);
            this.mnozstvi.TabIndex = 3;
            this.mnozstvi.Text = "ks";
            // 
            // dph
            // 
            this.dph.AutoSize = true;
            this.dph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dph.Location = new System.Drawing.Point(378, 10);
            this.dph.Name = "dph";
            this.dph.Size = new System.Drawing.Size(23, 20);
            this.dph.TabIndex = 3;
            this.dph.Text = "%";
            // 
            // kod
            // 
            this.kod.AutoSize = true;
            this.kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kod.Location = new System.Drawing.Point(276, 10);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(13, 20);
            this.kod.TabIndex = 4;
            this.kod.Text = ".";
            // 
            // ItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.kod);
            this.Controls.Add(this.dph);
            this.Controls.Add(this.mnozstvi);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.jmeno);
            this.Controls.Add(this.id);
            this.Name = "ItemUC";
            this.Size = new System.Drawing.Size(470, 36);
            this.Click += new System.EventHandler(this.ItemUC_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label jmeno;
        private System.Windows.Forms.Label cena;
        private System.Windows.Forms.Label mnozstvi;
        private System.Windows.Forms.Label dph;
        private System.Windows.Forms.Label kod;
    }
}
