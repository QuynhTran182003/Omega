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
    public partial class MainForm
    {
        private void InitializeExecutionButtons()
        {
            // poznamka
            // 
            this.poznamka.Enabled = false;
            this.poznamka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poznamka.Location = new System.Drawing.Point(226, 209);
            this.poznamka.Name = "poznamka";
            this.poznamka.Size = new System.Drawing.Size(93, 50);
            this.poznamka.TabIndex = 5;
            this.poznamka.Tag = "execution";
            this.poznamka.Text = "Pozn.";
            this.poznamka.UseVisualStyleBackColor = true;
            this.poznamka.Visible = false;
            // 
            // nahledUctenky
            // 
            this.nahledUctenky.BackColor = System.Drawing.Color.Silver;
            this.nahledUctenky.Enabled = false;
            this.nahledUctenky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nahledUctenky.Location = new System.Drawing.Point(325, 209);
            this.nahledUctenky.Name = "nahledUctenky";
            this.nahledUctenky.Size = new System.Drawing.Size(154, 50);
            this.nahledUctenky.TabIndex = 4;
            this.nahledUctenky.Tag = "execution";
            this.nahledUctenky.Text = "Náhled Účtenky";
            this.nahledUctenky.UseVisualStyleBackColor = false;
            this.nahledUctenky.Visible = false;
            this.nahledUctenky.Click += new System.EventHandler(this.NahledUctenky_Click);
            // 
            // zaplatit
            // 
            this.zaplatit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.zaplatit.Enabled = false;
            this.zaplatit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zaplatit.Location = new System.Drawing.Point(365, 53);
            this.zaplatit.Name = "zaplatit";
            this.zaplatit.Size = new System.Drawing.Size(114, 94);
            this.zaplatit.TabIndex = 3;
            this.zaplatit.Tag = "execution";
            this.zaplatit.Text = "Zaplatit";
            this.zaplatit.UseVisualStyleBackColor = false;
            this.zaplatit.Visible = false;
            this.zaplatit.Click += new System.EventHandler(this.Zaplatit_Click);
            // 
            // ulozitObj
            // 
            this.ulozitObj.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ulozitObj.Enabled = false;
            this.ulozitObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulozitObj.Location = new System.Drawing.Point(325, 153);
            this.ulozitObj.Name = "ulozitObj";
            this.ulozitObj.Size = new System.Drawing.Size(154, 50);
            this.ulozitObj.TabIndex = 2;
            this.ulozitObj.Tag = "execution";
            this.ulozitObj.Text = "Uložit Objednávku";
            this.ulozitObj.UseVisualStyleBackColor = false;
            this.ulozitObj.Visible = false;
            this.ulozitObj.Click += new System.EventHandler(this.UlozitObj_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.enter.Enabled = false;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(226, 153);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(93, 50);
            this.enter.TabIndex = 1;
            this.enter.Tag = "execution";
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Visible = false;
            this.enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDel.Enabled = false;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(365, 7);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(114, 40);
            this.btnDel.TabIndex = 18;
            this.btnDel.Tag = "execution";
            this.btnDel.Text = "Smazat Obj.";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // changeTable
            // 
            this.changeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.changeTable.Enabled = false;
            this.changeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTable.Location = new System.Drawing.Point(226, 97);
            this.changeTable.Name = "changeTable";
            this.changeTable.Size = new System.Drawing.Size(133, 50);
            this.changeTable.TabIndex = 17;
            this.changeTable.Tag = "execution";
            this.changeTable.Text = "Stěhovat se";
            this.changeTable.UseVisualStyleBackColor = false;
            this.changeTable.Visible = false;
        }
        private void InitializePanels()
        {
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelMain.Controls.Add(this.totalPrice);
            this.panelMain.Controls.Add(this.celkem);
            this.panelMain.Controls.Add(this.kod);
            this.panelMain.Controls.Add(this.jmeno);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.DPH);
            this.panelMain.Controls.Add(this.cena);
            this.panelMain.Controls.Add(this.ID);
            this.panelMain.Controls.Add(this.panelStul);
            this.panelMain.Controls.Add(this.panelItems);
            this.panelMain.Controls.Add(this.panelCategory);
            this.panelMain.Controls.Add(this.panelProducts);
            this.panelMain.Controls.Add(this.panelExecution);
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1484, 751);
            this.panelMain.TabIndex = 5;
            // 
            // panelStul
            // 
            this.panelStul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStul.Controls.Add(this.flowLayoutTable);
            this.panelStul.Controls.Add(this.Exit);
            this.panelStul.Controls.Add(this.label1);
            this.panelStul.Location = new System.Drawing.Point(1347, 0);
            this.panelStul.Name = "panelStul";
            this.panelStul.Size = new System.Drawing.Size(134, 751);
            this.panelStul.TabIndex = 4;
            // 
            // panelItems
            // 
            this.panelItems.AutoScroll = true;
            this.panelItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelItems.Controls.Add(this.flowLayoutItems);
            this.panelItems.Location = new System.Drawing.Point(0, 365);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(495, 386);
            this.panelItems.TabIndex = 17;
            // 
            // panelCategory
            // 
            this.panelCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCategory.Controls.Add(this.flowLayoutCategory);
            this.panelCategory.Location = new System.Drawing.Point(517, 0);
            this.panelCategory.MinimumSize = new System.Drawing.Size(750, 240);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(824, 273);
            this.panelCategory.TabIndex = 0;
            // 
            // panelProducts
            // 
            this.panelProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProducts.Controls.Add(this.flowLayoutProduct);
            this.panelProducts.Location = new System.Drawing.Point(517, 279);
            this.panelProducts.MinimumSize = new System.Drawing.Size(750, 240);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(824, 472);
            this.panelProducts.TabIndex = 1;

            // 
            // panelExecution
            // 
            this.panelExecution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExecution.Controls.Add(this.btnDel);
            this.panelExecution.Controls.Add(this.changeTable);
            this.panelExecution.Controls.Add(this.backspace);
            this.panelExecution.Controls.Add(this.button0);
            this.panelExecution.Controls.Add(this.button9);
            this.panelExecution.Controls.Add(this.button8);
            this.panelExecution.Controls.Add(this.button7);
            this.panelExecution.Controls.Add(this.button6);
            this.panelExecution.Controls.Add(this.button5);
            this.panelExecution.Controls.Add(this.button4);
            this.panelExecution.Controls.Add(this.button3);
            this.panelExecution.Controls.Add(this.btn2);
            this.panelExecution.Controls.Add(this.btn1);
            this.panelExecution.Controls.Add(this.poznamka);
            this.panelExecution.Controls.Add(this.nahledUctenky);
            this.panelExecution.Controls.Add(this.zaplatit);
            this.panelExecution.Controls.Add(this.ulozitObj);
            this.panelExecution.Controls.Add(this.enter);
            this.panelExecution.Controls.Add(this.idItemInput);
            this.panelExecution.Location = new System.Drawing.Point(0, 0);
            this.panelExecution.Name = "panelExecution";
            this.panelExecution.Size = new System.Drawing.Size(495, 273);
            this.panelExecution.TabIndex = 1;
            // 
            // productForm1
            // 
            this.productForm1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productForm1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productForm1.Location = new System.Drawing.Point(0, 24);
            this.productForm1.Name = "productForm1";
            this.productForm1.Size = new System.Drawing.Size(1482, 749);
            this.productForm1.TabIndex = 18;
            // 
            // categoryForm1
            // 
            this.categoryForm1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryForm1.BackColor = System.Drawing.Color.Chocolate;
            this.categoryForm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryForm1.Location = new System.Drawing.Point(0, 24);
            this.categoryForm1.Name = "categoryForm1";
            this.categoryForm1.Size = new System.Drawing.Size(1484, 751);
            this.categoryForm1.TabIndex = 18;
            // flowLayoutTable
            // 
            this.flowLayoutTable.AutoScroll = true;
            this.flowLayoutTable.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutTable.Location = new System.Drawing.Point(0, 36);
            this.flowLayoutTable.Name = "flowLayoutTable";
            this.flowLayoutTable.Size = new System.Drawing.Size(131, 649);
            this.flowLayoutTable.TabIndex = 18;
            this.flowLayoutTable.WrapContents = false;
            // 
            // flowLayoutProduct
            // 
            this.flowLayoutProduct.Location = new System.Drawing.Point(0, 4);
            this.flowLayoutProduct.Name = "flowLayoutProduct";
            this.flowLayoutProduct.Size = new System.Drawing.Size(820, 467);
            this.flowLayoutProduct.TabIndex = 2;
            // 
            // flowLayoutCategory
            // 
            this.flowLayoutCategory.Location = new System.Drawing.Point(0, 6);
            this.flowLayoutCategory.Name = "flowLayoutCategory";
            this.flowLayoutCategory.Size = new System.Drawing.Size(820, 259);
            this.flowLayoutCategory.TabIndex = 1;
            // 
            // flowLayoutItems
            // 
            this.flowLayoutItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutItems.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutItems.Name = "flowLayoutItems";
            this.flowLayoutItems.Size = new System.Drawing.Size(479, 375);
            this.flowLayoutItems.TabIndex = 0;
            this.flowLayoutItems.WrapContents = false;

            // 
            // zamestnanecPanel1
            // 
            this.zamestnanecPanel1.Location = new System.Drawing.Point(0, 27);
            this.zamestnanecPanel1.Name = "zamestnanecPanel1";
            this.zamestnanecPanel1.Size = new System.Drawing.Size(752, 653);
            this.zamestnanecPanel1.TabIndex = 10;
            this.zamestnanecPanel1.Visible = false;
        }
    }
}
