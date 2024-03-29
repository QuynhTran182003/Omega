﻿namespace Omega
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pokladnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamestnanciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamZaměstnancůToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozvrhZaměstnancůToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produktyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spravaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamFakturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denniReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelStul = new System.Windows.Forms.Panel();
            this.flowLayoutTable = new System.Windows.Forms.FlowLayoutPanel();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.totalPrice = new System.Windows.Forms.Label();
            this.celkem = new System.Windows.Forms.Label();
            this.kod = new System.Windows.Forms.Label();
            this.jmeno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DPH = new System.Windows.Forms.Label();
            this.cena = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.panelItems = new System.Windows.Forms.Panel();
            this.flowLayoutItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.flowLayoutCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.flowLayoutProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panelExecution = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.changeTable = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.poznamka = new System.Windows.Forms.Button();
            this.nahledUctenky = new System.Windows.Forms.Button();
            this.zaplatit = new System.Windows.Forms.Button();
            this.ulozitObj = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.idItemInput = new System.Windows.Forms.TextBox();
            this.productForm1 = new Omega.Presentation_Tier.Panels.ProductForm();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.categoryForm1 = new Omega.Forms.Panels.CategoryForm();
            this.menuStrip1.SuspendLayout();
            this.panelStul.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelItems.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.panelProducts.SuspendLayout();
            this.panelExecution.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokladnaToolStripMenuItem,
            this.zamestnanciToolStripMenuItem,
            this.productToolStripMenuItem,
            this.spravaToolStripMenuItem,
            this.nastaveniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip2";
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
            this.zamestnanciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seznamZaměstnancůToolStripMenuItem,
            this.rozvrhZaměstnancůToolStripMenuItem});
            this.zamestnanciToolStripMenuItem.Name = "zamestnanciToolStripMenuItem";
            this.zamestnanciToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.zamestnanciToolStripMenuItem.Text = "Zaměstnanci";
            this.zamestnanciToolStripMenuItem.Click += new System.EventHandler(this.zamestnanciToolStripMenuItem_Click);
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
            // 
            // denniReportToolStripMenuItem
            // 
            this.denniReportToolStripMenuItem.Name = "denniReportToolStripMenuItem";
            this.denniReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.denniReportToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.denniReportToolStripMenuItem.Text = "Denni Report";
            // 
            // nastaveniToolStripMenuItem
            // 
            this.nastaveniToolStripMenuItem.Name = "nastaveniToolStripMenuItem";
            this.nastaveniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nastaveniToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nastaveniToolStripMenuItem.Text = "Nastavení";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
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
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(0, 691);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(131, 50);
            this.Exit.TabIndex = 17;
            this.Exit.Tag = "";
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 10);
            this.label1.Size = new System.Drawing.Size(37, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stul";
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
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("hooge 05_55", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.ForeColor = System.Drawing.Color.Blue;
            this.totalPrice.Location = new System.Drawing.Point(147, 276);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(109, 37);
            this.totalPrice.TabIndex = 26;
            this.totalPrice.Text = "0.- Kč";
            // 
            // celkem
            // 
            this.celkem.AutoSize = true;
            this.celkem.Font = new System.Drawing.Font("hooge 05_55", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celkem.ForeColor = System.Drawing.Color.Blue;
            this.celkem.Location = new System.Drawing.Point(3, 276);
            this.celkem.Name = "celkem";
            this.celkem.Size = new System.Drawing.Size(156, 37);
            this.celkem.TabIndex = 24;
            this.celkem.Text = "Celkem: ";
            // 
            // kod
            // 
            this.kod.AutoSize = true;
            this.kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kod.Location = new System.Drawing.Point(274, 342);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(37, 20);
            this.kod.TabIndex = 23;
            this.kod.Text = "Kód";
            // 
            // jmeno
            // 
            this.jmeno.AutoSize = true;
            this.jmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmeno.Location = new System.Drawing.Point(133, 342);
            this.jmeno.Name = "jmeno";
            this.jmeno.Size = new System.Drawing.Size(57, 20);
            this.jmeno.TabIndex = 22;
            this.jmeno.Text = "Jméno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Množ.";
            // 
            // DPH
            // 
            this.DPH.AutoSize = true;
            this.DPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPH.Location = new System.Drawing.Point(379, 342);
            this.DPH.Name = "DPH";
            this.DPH.Size = new System.Drawing.Size(43, 20);
            this.DPH.TabIndex = 20;
            this.DPH.Text = "DPH";
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cena.Location = new System.Drawing.Point(326, 342);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(47, 20);
            this.cena.TabIndex = 19;
            this.cena.Text = "Cena";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(8, 342);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 18;
            this.ID.Text = "ID";
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
            this.panelItems.Visible = true;
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
            // flowLayoutCategory
            // 
            this.flowLayoutCategory.Location = new System.Drawing.Point(0, 6);
            this.flowLayoutCategory.Name = "flowLayoutCategory";
            this.flowLayoutCategory.Size = new System.Drawing.Size(820, 259);
            this.flowLayoutCategory.TabIndex = 1;
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
            // flowLayoutProduct
            // 
            this.flowLayoutProduct.Location = new System.Drawing.Point(0, 4);
            this.flowLayoutProduct.Name = "flowLayoutProduct";
            this.flowLayoutProduct.Size = new System.Drawing.Size(820, 467);
            this.flowLayoutProduct.TabIndex = 2;
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
            // idItemInput
            // 
            this.idItemInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idItemInput.Location = new System.Drawing.Point(19, 6);
            this.idItemInput.Name = "idItemInput";
            this.idItemInput.Size = new System.Drawing.Size(195, 29);
            this.idItemInput.TabIndex = 0;
            this.idItemInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 777);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.categoryForm1);
            this.Controls.Add(this.productForm1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restauce";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelStul.ResumeLayout(false);
            this.panelStul.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelItems.ResumeLayout(false);
            this.panelCategory.ResumeLayout(false);
            this.panelProducts.ResumeLayout(false);
            this.panelExecution.ResumeLayout(false);
            this.panelExecution.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zamestnanciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spravaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seznamFakturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denniReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokladnaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Panel panelStul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Panel panelExecution;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button poznamka;
        private System.Windows.Forms.Button nahledUctenky;
        private System.Windows.Forms.Button zaplatit;
        private System.Windows.Forms.Button ulozitObj;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox idItemInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Button changeTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem seznamZaměstnancůToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozvrhZaměstnancůToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produktyToolStripMenuItem;
        private Forms.Panels.CategoryForm categoryForm1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCategory;
        private Presentation_Tier.Panels.ProductForm productForm1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutProduct;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label kod;
        private System.Windows.Forms.Label jmeno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DPH;
        private System.Windows.Forms.Label cena;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label celkem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutItems;
    }
}

