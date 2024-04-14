namespace Omega.Presentation_Tier
{
    partial class PaymentForm
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
            this.btnKartou = new System.Windows.Forms.Button();
            this.ssebouBtn = new System.Windows.Forms.Button();
            this.PayBtn = new System.Windows.Forms.Button();
            this.tableLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKartou
            // 
            this.btnKartou.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKartou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKartou.Location = new System.Drawing.Point(23, 158);
            this.btnKartou.Name = "btnKartou";
            this.btnKartou.Size = new System.Drawing.Size(125, 46);
            this.btnKartou.TabIndex = 0;
            this.btnKartou.Tag = "Unselected";
            this.btnKartou.Text = "Kartou";
            this.btnKartou.UseVisualStyleBackColor = false;
            this.btnKartou.Click += new System.EventHandler(this.btnKartou_Click);
            // 
            // ssebouBtn
            // 
            this.ssebouBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ssebouBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssebouBtn.Location = new System.Drawing.Point(23, 222);
            this.ssebouBtn.Name = "ssebouBtn";
            this.ssebouBtn.Size = new System.Drawing.Size(125, 45);
            this.ssebouBtn.TabIndex = 1;
            this.ssebouBtn.Tag = "Unselected";
            this.ssebouBtn.Text = "S Sebou";
            this.ssebouBtn.UseVisualStyleBackColor = false;
            this.ssebouBtn.Click += new System.EventHandler(this.ssebouBtn_Click);
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.PayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBtn.Location = new System.Drawing.Point(184, 158);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(226, 109);
            this.PayBtn.TabIndex = 2;
            this.PayBtn.Text = "Zaplatit";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabel.Location = new System.Drawing.Point(19, 29);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(37, 20);
            this.tableLabel.TabIndex = 3;
            this.tableLabel.Text = "Stul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Celkem:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(244, 33);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 20);
            this.priceLabel.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(244, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sleva %";
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(350, 71);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(45, 23);
            this.ok.TabIndex = 8;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = ",- Kč";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 296);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.ssebouBtn);
            this.Controls.Add(this.btnKartou);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKartou;
        private System.Windows.Forms.Button ssebouBtn;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label label3;
    }
}