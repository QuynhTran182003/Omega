namespace Omega
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
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spravaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamZaměstnancůToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozvrhZaměstnancůToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produktyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamFakturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denniReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelStul = new System.Windows.Forms.Panel();
            this.flowLayoutTable = new System.Windows.Forms.FlowLayoutPanel();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.listBillPanel1 = new Omega.Presentation_Tier.Panels.ListBillPanel();
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
            this.productForm1 = new Omega.Presentation_Tier.Panels.ProductPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.categoryForm1 = new Omega.Forms.Panels.CategoryPanel();
            this.reportPanel1 = new Omega.Presentation_Tier.Panels.ReportPanel();
            this.zamestnanecPanel2 = new Omega.Presentation_Tier.Panels.ZamestnanecPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
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
            /*// 
            // pokladnaToolStripMenuItem
            // 
            this.pokladnaToolStripMenuItem.Name = "pokladnaToolStripMenuItem";
            this.pokladnaToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // zamestnanciToolStripMenuItem
            // 
            this.zamestnanciToolStripMenuItem.Name = "zamestnanciToolStripMenuItem";
            this.zamestnanciToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // spravaToolStripMenuItem
            // 
            this.spravaToolStripMenuItem.Name = "spravaToolStripMenuItem";
            this.spravaToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // nastaveniToolStripMenuItem
            // 
            this.nastaveniToolStripMenuItem.Name = "nastaveniToolStripMenuItem";
            this.nastaveniToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // seznamZaměstnancůToolStripMenuItem
            // 
            this.seznamZaměstnancůToolStripMenuItem.Name = "seznamZaměstnancůToolStripMenuItem";
            this.seznamZaměstnancůToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // rozvrhZaměstnancůToolStripMenuItem
            // 
            this.rozvrhZaměstnancůToolStripMenuItem.Name = "rozvrhZaměstnancůToolStripMenuItem";
            this.rozvrhZaměstnancůToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // kategorieToolStripMenuItem
            // 
            this.kategorieToolStripMenuItem.Name = "kategorieToolStripMenuItem";
            this.kategorieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // produktyToolStripMenuItem
            // 
            this.produktyToolStripMenuItem.Name = "produktyToolStripMenuItem";
            this.produktyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // seznamFakturToolStripMenuItem
            // 
            this.seznamFakturToolStripMenuItem.Name = "seznamFakturToolStripMenuItem";
            this.seznamFakturToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // denniReportToolStripMenuItem
            // 
            this.denniReportToolStripMenuItem.Name = "denniReportToolStripMenuItem";
            this.denniReportToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // panelStul
            // 
            this.panelStul.Location = new System.Drawing.Point(0, 0);
            this.panelStul.Name = "panelStul";
            this.panelStul.Size = new System.Drawing.Size(200, 100);
            this.panelStul.TabIndex = 0;
            // 
            // flowLayoutTable
            // 
            this.flowLayoutTable.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutTable.Name = "flowLayoutTable";
            this.flowLayoutTable.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutTable.TabIndex = 0;*/
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
            /*// 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(200, 100);
            this.panelMain.TabIndex = 3;
            // 
            // listBillPanel1
            // 
            this.listBillPanel1.Location = new System.Drawing.Point(0, 0);
            this.listBillPanel1.Name = "listBillPanel1";
            this.listBillPanel1.Size = new System.Drawing.Size(1482, 749);
            this.listBillPanel1.TabIndex = 8;*/
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
            /*// panelItems
            // 
            this.panelItems.Location = new System.Drawing.Point(0, 0);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(200, 100);
            this.panelItems.TabIndex = 0;
            // 
            // flowLayoutItems
            // 
            this.flowLayoutItems.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutItems.Name = "flowLayoutItems";
            this.flowLayoutItems.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutItems.TabIndex = 0;
            // 
            // panelCategory
            // 
            this.panelCategory.Location = new System.Drawing.Point(0, 0);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(200, 100);
            this.panelCategory.TabIndex = 0;
            // 
            // flowLayoutCategory
            // 
            this.flowLayoutCategory.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutCategory.Name = "flowLayoutCategory";
            this.flowLayoutCategory.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutCategory.TabIndex = 0;
            // 
            // panelProducts
            // 
            this.panelProducts.Location = new System.Drawing.Point(0, 0);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(200, 100);
            this.panelProducts.TabIndex = 0;
            // 
            // flowLayoutProduct
            // 
            this.flowLayoutProduct.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutProduct.Name = "flowLayoutProduct";
            this.flowLayoutProduct.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutProduct.TabIndex = 0;
            // 
            // panelExecution
            // 
            this.panelExecution.Location = new System.Drawing.Point(0, 0);
            this.panelExecution.Name = "panelExecution";
            this.panelExecution.Size = new System.Drawing.Size(200, 100);
            this.panelExecution.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(0, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 0;
            // 
            // changeTable
            // 
            this.changeTable.Location = new System.Drawing.Point(0, 0);
            this.changeTable.Name = "changeTable";
            this.changeTable.Size = new System.Drawing.Size(75, 23);
            this.changeTable.TabIndex = 0;
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(0, 0);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(75, 23);
            this.backspace.TabIndex = 0;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(0, 0);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 23);
            this.button0.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(0, 0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(0, 0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            // 
            // poznamka
            // 
            this.poznamka.Location = new System.Drawing.Point(0, 0);
            this.poznamka.Name = "poznamka";
            this.poznamka.Size = new System.Drawing.Size(75, 23);
            this.poznamka.TabIndex = 0;
            // 
            // nahledUctenky
            // 
            this.nahledUctenky.Location = new System.Drawing.Point(0, 0);
            this.nahledUctenky.Name = "nahledUctenky";
            this.nahledUctenky.Size = new System.Drawing.Size(75, 23);
            this.nahledUctenky.TabIndex = 0;
            // 
            // zaplatit
            // 
            this.zaplatit.Location = new System.Drawing.Point(0, 0);
            this.zaplatit.Name = "zaplatit";
            this.zaplatit.Size = new System.Drawing.Size(75, 23);
            this.zaplatit.TabIndex = 0;
            // 
            // ulozitObj
            // 
            this.ulozitObj.Location = new System.Drawing.Point(0, 0);
            this.ulozitObj.Name = "ulozitObj";
            this.ulozitObj.Size = new System.Drawing.Size(75, 23);
            this.ulozitObj.TabIndex = 0;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(0, 0);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 0;
            // 
            // idItemInput
            // 
            this.idItemInput.Location = new System.Drawing.Point(0, 0);
            this.idItemInput.Name = "idItemInput";
            this.idItemInput.Size = new System.Drawing.Size(100, 20);
            this.idItemInput.TabIndex = 0;
            // 
            // productForm1
            // 
            this.productForm1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productForm1.Location = new System.Drawing.Point(0, 0);
            this.productForm1.Name = "productForm1";
            this.productForm1.Size = new System.Drawing.Size(1482, 749);
            this.productForm1.TabIndex = 6;
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
            this.categoryForm1.BackColor = System.Drawing.Color.Chocolate;
            this.categoryForm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryForm1.Location = new System.Drawing.Point(0, 0);
            this.categoryForm1.Name = "categoryForm1";
            this.categoryForm1.Size = new System.Drawing.Size(1482, 749);
            this.categoryForm1.TabIndex = 5;
            // 
            // reportPanel1
            // 
            this.reportPanel1.Location = new System.Drawing.Point(0, 0);
            this.reportPanel1.Name = "reportPanel1";
            this.reportPanel1.Size = new System.Drawing.Size(1482, 749);
            this.reportPanel1.TabIndex = 7;
            // 
            // zamestnanecPanel2
            // 
            this.zamestnanecPanel2.Location = new System.Drawing.Point(0, 0);
            this.zamestnanecPanel2.Name = "zamestnanecPanel2";
            this.zamestnanecPanel2.Size = new System.Drawing.Size(1484, 751);
            this.zamestnanecPanel2.TabIndex = 4;*/

            InitializePanels();
            InitializeToolStripMenuItem();
            InitializeButtonsNumber();
            InitializeExecutionButtons();
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 777);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.zamestnanecPanel2);
            this.Controls.Add(this.categoryForm1);
            this.Controls.Add(this.productForm1);
            this.Controls.Add(this.reportPanel1);
            this.Controls.Add(this.listBillPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restauce";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private Forms.Panels.CategoryPanel categoryForm1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCategory;
        private Presentation_Tier.Panels.ProductPanel productForm1;
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
        private Presentation_Tier.Panels.ListBillPanel listBillPanel1;
        private Presentation_Tier.Panels.ReportPanel reportPanel1;
        private Presentation_Tier.Panels.ZamestnanecPanel zamestnanecPanel2;
    }
}