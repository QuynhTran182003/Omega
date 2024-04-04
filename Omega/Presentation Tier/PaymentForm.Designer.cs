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
            this.SuspendLayout();
            // 
            // btnKartou
            // 
            this.btnKartou.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKartou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKartou.Location = new System.Drawing.Point(16, 157);
            this.btnKartou.Name = "btnKartou";
            this.btnKartou.Size = new System.Drawing.Size(142, 46);
            this.btnKartou.TabIndex = 0;
            this.btnKartou.Text = "Kartou";
            this.btnKartou.UseVisualStyleBackColor = false;
            this.btnKartou.Click += new System.EventHandler(this.btnKartou_Click);
            // 
            // ssebouBtn
            // 
            this.ssebouBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ssebouBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssebouBtn.Location = new System.Drawing.Point(16, 221);
            this.ssebouBtn.Name = "ssebouBtn";
            this.ssebouBtn.Size = new System.Drawing.Size(142, 45);
            this.ssebouBtn.TabIndex = 1;
            this.ssebouBtn.Text = "S Sebou";
            this.ssebouBtn.UseVisualStyleBackColor = false;
            this.ssebouBtn.Click += new System.EventHandler(this.ssebouBtn_Click);
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.PayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBtn.Location = new System.Drawing.Point(260, 209);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(211, 57);
            this.PayBtn.TabIndex = 2;
            this.PayBtn.Text = "Zaplatit";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabel.Location = new System.Drawing.Point(256, 48);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(51, 20);
            this.tableLabel.TabIndex = 3;
            this.tableLabel.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Celkem:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(354, 96);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 20);
            this.priceLabel.TabIndex = 5;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 297);
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
    }
}