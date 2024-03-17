using Omega.Business_Tier;
using Omega.Data_Tier;
using Omega.Forms.Panels;
using Omega.Objects;
using Omega.Presentation_Tier;
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
    public partial class MainForm : Form
    {
        private LoginForm loginForm;
        private int selectedTable = 0;
        private int verticalPosition = 0;
        
        public int SelectedTable { get { return selectedTable; } set { selectedTable = value; } }
        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            panelMain.Visible = true;
            categoryForm1.Visible = false;
            productForm1.Visible = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeCategoryButton(this.flowLayoutCategory);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
        }
        private void pokladnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainForm_Load(sender, e);
            panelMain.Visible = true;
            categoryForm1.Visible = false;
        }
        private void zamestnanciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void produktyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.productForm1.Visible = true;
            this.categoryForm1.Visible = false;
            this.panelMain.Visible = false;
        }
        private void kategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            categoryForm1.Visible = true;
            productForm1.Visible = false;
        }
        private void Button_Stul_Click(object sender, EventArgs e)
        {
            // Reset all buttons in panelStul to white
            foreach (Button button in panelStul.Controls.OfType<Button>().Where(b => !b.Tag.Equals("Rezervovan")))
            {
                button.BackColor = Color.White;
            }

            // Change the clicked button's backcolor to red
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Red;
            Exit.BackColor = Color.MediumTurquoise;
            
            // Enable buttons execution
            foreach(Button button in panelExecution.Controls.OfType<Button>().Where(b => b.Tag != null && b.Tag.ToString() == "execution")){
                button.Enabled = true;
            }

            // Set visible panelItems
            panelItems.Visible = true;

            // Set the number of selected table, where we will add item to the order
            SelectedTable = int.Parse(clickedButton.Text.Split(' ')[1]);
            // MessageBox.Show($"Stul {NumberTable} je vybran");
        }
        private void Btn_numbers_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            this.idItemInput.Text += clickedButton.Text;
        }
        private void Backspace_Click(object sender, EventArgs e)
        {
            if (this.idItemInput.Text.Length == 0)
            {
                return;
            }
            this.idItemInput.Text = this.idItemInput.Text.Substring(0, this.idItemInput.Text.Length - 1);
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            string itemCode = this.idItemInput.Text;

            // Nejprve zjistim jestli stul je vybran
            if (SelectedTable == 0)
            {
                MessageBox.Show("Prosím vyberte stůl");
                return;
            }

            // empty handling            
            if (itemCode.Equals("")) {
                MessageBox.Show("Prazdna hodnota");
                return;
            }

            // clear input 
            this.idItemInput.Text = "";

            // Zde implementuju metodu na pridani polozky do objednavky pro urcity stul
            Product p = new Product().GetByCode(itemCode);
            if (p == null)
            {
                MessageBox.Show("Zbozi nenalezeno");
                return;
            }
            AddOrUpdateItem(p, 1);
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            panelItems.Controls.Clear();
            verticalPosition = 0;
            Button selectedTable = panelStul.Controls.OfType<Button>().FirstOrDefault(b => b.Text == ("Stůl " + SelectedTable.ToString()));
            selectedTable.BackColor = Color.White;
            selectedTable.Tag = "Volno";

        }
        private void UlozitObj_Click(object sender, EventArgs e)
        {
            /*Takes number stul as argument, add order to that table*/
            Button selectedTable = panelStul.Controls.OfType<Button>().FirstOrDefault(b => b.Text == ("Stůl " + SelectedTable.ToString()));
            selectedTable.BackColor = Color.IndianRed;
            selectedTable.Tag = "Rezervovan";
        }
        private void NahledUctenky_Click(object sender, EventArgs e)
        {
            /*Vystiskne nahled uctenky pro zakaznika (př. PDF)*/
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            /*Reset colors of all not reserved tables in panelStul to white*/
            foreach (Button button in panelStul.Controls.OfType<Button>().Where(b => !b.Tag.Equals("Rezervovan")))
            {
                button.BackColor = Color.White;
            }

            /*Disable/ set to invisible buttons in panelExecution*/
            foreach (Button button in panelExecution.Controls.OfType<Button>().Where(b => b.Tag != null && b.Tag.ToString() == "execution"))
            {
                button.Enabled = false;
            }
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.MediumTurquoise;
            selectedTable = 0;
        }
        private void InitializeCategoryButton(FlowLayoutPanel flowLayoutPanel)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            List<Category> list = categoryDAO.GetListCategory();
            flowLayoutPanel.Controls.Clear();
            foreach (Category category in list)
            {
                Button b = new Button();
                b.Text = category.Nazev;
                b.Click += CategoryButton_Click;
                b.Size = new System.Drawing.Size(140, 50);
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                flowLayoutPanel.Controls.Add(b);
            }
        }
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ProductDAO productDAO = new ProductDAO();
            List<Product> list = productDAO.GetListProduct(clickedButton.Text);
            flowLayoutProduct.Controls.Clear();
            foreach (Product product in list)
            {
                Button b = new Button();
                b.Text = product.Code +" - "+ product.Name;
                b.Click += ProductButton_Click;
                b.Size = new System.Drawing.Size(140, 50);
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                flowLayoutProduct.Controls.Add(b);
            }
        }
        private void ProductButton_Click(object sender, EventArgs e)
        {
            // Nejprve zjistim jestli stul je vybran
            if (SelectedTable == 0)
            {
                MessageBox.Show("Prosím vyberte stůl");
                return;
            }
            //musim ziskat kod kliknuteho jidla
            Button clickedButton = (Button)sender;
            string code = (clickedButton.Text.Split('-')[0]);

            Product p = new Product().GetByCode(code);
            AddOrUpdateItem(p, 1);
        }
        private void AddOrUpdateItem(Product product, int quantity)
        {
            //-----------------
            bool existed = false;

            // Vytvorim jiny UserControl (polozku objednavky) UC -- usercontrol
            ItemUC n_itemUC = new ItemUC(product.Name, product.Code, product.Price, product.DPH(), 1);
            n_itemUC.Location = new System.Drawing.Point(3, verticalPosition);

            // ziskam vsechny polozky co uz mam v panelu
            List<ItemUC> list = panelItems.Controls.OfType<ItemUC>().ToList();

            // kontroluju jestli existuje takovy produkt, ktery chci vlozit do objednavky, 
            foreach (ItemUC itemUc in list)
            {
                //Pokud uz existuje, zvysim jenom pocet tohoto produktu
                if (itemUc.CodeLabel.Text.Equals(n_itemUC.CodeLabel.Text))
                {
                    existed = true;
                    int actual_quant = int.Parse(itemUc.QuantityLabel.Text);
                    itemUc.QuantityLabel.Text = (actual_quant + quantity).ToString();
                    break;
                }
            }

            //Pokud takovy produkt jeste neexistuje, tak ho pridam to panelu
            if (!existed)
            {
                panelItems.Controls.Add(n_itemUC);
                verticalPosition += n_itemUC.Height + 2;
            }
            //-----------------
        }
    }
}
