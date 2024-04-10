using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    partial class MainForm
    {
        private void InitializeButtonsNumber()
        {
            // 
            // idItemInput
            // 
            this.idItemInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idItemInput.Location = new System.Drawing.Point(19, 6);
            this.idItemInput.Name = "idItemInput";
            this.idItemInput.Size = new System.Drawing.Size(195, 29);
            this.idItemInput.TabIndex = 0;
            this.idItemInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(19, 209);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(61, 50);
            this.button0.TabIndex = 15;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Btn_numbers_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(153, 153);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 50);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Btn_numbers_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(86, 153);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 50);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Btn_numbers_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(19, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 50);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Btn_numbers_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(153, 97);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 50);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Btn_numbers_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(87, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 50);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Btn_numbers_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(19, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Btn_numbers_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(153, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Btn_numbers_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(86, 41);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(61, 50);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn_numbers_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(19, 41);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(61, 50);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn_numbers_Click);
            // 
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(86, 209);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(128, 50);
            this.backspace.TabIndex = 16;
            this.backspace.Text = "Back";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.Backspace_Click);
        }
    
        private void InitializeToolStripMenuItem()
        {
            // 
            // pokladnaToolStripMenuItem
            // 
            this.pokladnaToolStripMenuItem.Name = "pokladnaToolStripMenuItem";
            this.pokladnaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pokladnaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.pokladnaToolStripMenuItem.Text = "Pokladna";
            this.pokladnaToolStripMenuItem.Click += new System.EventHandler(this.pokladnaToolStripMenuItem_Click);
            // 
            // zamestnanciToolStripMenuItem
            // 
            if(this.user.Role.ToString().Equals("admin"))
            {
                this.zamestnanciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.seznamZaměstnancůToolStripMenuItem,
                this.rozvrhZaměstnancůToolStripMenuItem});
                this.zamestnanciToolStripMenuItem.Name = "zamestnanciToolStripMenuItem";
                this.zamestnanciToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
                this.zamestnanciToolStripMenuItem.Text = "Zaměstnanci";
                this.zamestnanciToolStripMenuItem.Click += new System.EventHandler(this.zamestnanciToolStripMenuItem_Click);
            }
            // 
            // seznamZaměstnancůToolStripMenuItem
            // 
            this.seznamZaměstnancůToolStripMenuItem.Name = "seznamZaměstnancůToolStripMenuItem";
            this.seznamZaměstnancůToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.seznamZaměstnancůToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.seznamZaměstnancůToolStripMenuItem.Text = "Seznam zaměstnanců";
            // 
            // rozvrhZaměstnancůToolStripMenuItem
            // 
            this.rozvrhZaměstnancůToolStripMenuItem.Name = "rozvrhZaměstnancůToolStripMenuItem";
            this.rozvrhZaměstnancůToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.rozvrhZaměstnancůToolStripMenuItem.Text = "Rozvrh zaměstnanců";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorieToolStripMenuItem,
            this.produktyToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.productToolStripMenuItem.Text = "Produkty";
            // 
            // kategorieToolStripMenuItem
            // 
            this.kategorieToolStripMenuItem.Name = "kategorieToolStripMenuItem";
            this.kategorieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.kategorieToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.kategorieToolStripMenuItem.Text = "Kategorie";
            this.kategorieToolStripMenuItem.Click += new System.EventHandler(this.kategorieToolStripMenuItem_Click);
            // 
            // produktyToolStripMenuItem
            // 
            this.produktyToolStripMenuItem.Name = "produktyToolStripMenuItem";
            this.produktyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.produktyToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.produktyToolStripMenuItem.Text = "Produkty";
            this.produktyToolStripMenuItem.Click += new System.EventHandler(this.produktyToolStripMenuItem_Click_1);
            // 
            // spravaToolStripMenuItem
            // 
            this.spravaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seznamFakturToolStripMenuItem,
            this.denniReportToolStripMenuItem});
            this.spravaToolStripMenuItem.Name = "spravaToolStripMenuItem";
            this.spravaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.spravaToolStripMenuItem.Text = "Správa";
            // 
            // seznamFakturToolStripMenuItem
            // 
            this.seznamFakturToolStripMenuItem.Name = "seznamFakturToolStripMenuItem";
            this.seznamFakturToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.seznamFakturToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.seznamFakturToolStripMenuItem.Text = "Seznam faktur";
            this.seznamFakturToolStripMenuItem.Click += new System.EventHandler(this.seznamFakturToolStripMenuItem_Click);

            // 
            // denniReportToolStripMenuItem
            // 
            this.denniReportToolStripMenuItem.Name = "denniReportToolStripMenuItem";
            this.denniReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.denniReportToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.denniReportToolStripMenuItem.Text = "Denni Report";
            this.denniReportToolStripMenuItem.Click += new System.EventHandler(this.denniReportToolStripMenuItem_Click);

            // 
            // nastaveniToolStripMenuItem
            // 
            this.nastaveniToolStripMenuItem.Name = "nastaveniToolStripMenuItem";
            this.nastaveniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nastaveniToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nastaveniToolStripMenuItem.Text = "Nastavení";
        }
    }
}