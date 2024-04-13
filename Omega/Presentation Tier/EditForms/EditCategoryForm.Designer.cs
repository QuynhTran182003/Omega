namespace Omega.Presentation_Tier.EditForms
{
    partial class EditCategoryForm
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
            this.nazev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dph = new System.Windows.Forms.TextBox();
            this.aktualizovat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazev
            // 
            this.nazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazev.Location = new System.Drawing.Point(323, 148);
            this.nazev.Name = "nazev";
            this.nazev.Size = new System.Drawing.Size(482, 53);
            this.nazev.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Název";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "DPH";
            // 
            // dph
            // 
            this.dph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dph.Location = new System.Drawing.Point(323, 243);
            this.dph.Name = "dph";
            this.dph.Size = new System.Drawing.Size(482, 53);
            this.dph.TabIndex = 5;
            // 
            // aktualizovat
            // 
            this.aktualizovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktualizovat.Location = new System.Drawing.Point(529, 368);
            this.aktualizovat.Name = "aktualizovat";
            this.aktualizovat.Size = new System.Drawing.Size(276, 109);
            this.aktualizovat.TabIndex = 9;
            this.aktualizovat.Text = "Aktualizovat";
            this.aktualizovat.UseVisualStyleBackColor = true;
            this.aktualizovat.Click += new System.EventHandler(this.aktualizovat_Click);
            // 
            // EditCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 555);
            this.Controls.Add(this.aktualizovat);
            this.Controls.Add(this.dph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazev);
            this.Controls.Add(this.label1);
            this.Name = "EditCategoryForm";
            this.Text = "EditCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nazev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dph;
        private System.Windows.Forms.Button aktualizovat;
    }
}