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
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
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
            InitializeToolStripMenuItem();
            InitializeButtonsNumber();
            InitializeExecutionButtons();
            InitializePanels();
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