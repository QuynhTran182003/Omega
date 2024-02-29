using Omega.Business_Tier;
using Omega.Data_Tier;
using Omega.Forms.Panels;
using Omega.Objects;
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
        private int numberTable;

        public int NumberTable { get { return numberTable; } set { numberTable = value; } }
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
            foreach (Button button in panelStul.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }

            // Change the clicked button's backcolor to red
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.IndianRed;
            Exit.BackColor = Color.MediumTurquoise;
            
            // Enable buttons execution
            foreach(Button button in panelExecution.Controls.OfType<Button>().Where(b => b.Tag != null && b.Tag.ToString() == "execution")){
                button.Enabled = true;
            }

            // Set visible panelItems
            panelItems.Visible = true;

            //Set the number of selected table, where we will add item to the order
            NumberTable = int.Parse(clickedButton.Text.Split(' ')[1]);
            MessageBox.Show($"Stul {NumberTable} je vybran");
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
            // Nejprve zjistim jestli stul je vybran
            if (NumberTable == 0)
            {
                MessageBox.Show("Prosím vyberte stůl");
                return;
            }
            int itemCode = int.Parse(this.idItemInput.Text);
            this.idItemInput.Text = "";
            MessageBox.Show(itemCode.ToString());

            //Zde implementuju metodu na pridani polozky do objednavky pro urcity stul
            Product selectedProduct = new Product().GetByCode(itemCode);
            
            //Pokud nenalezne zbozi
            //MessageBox.Show("Zboží nenalezeno");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            /*Reset all colors of button in panelStul to white*/
            foreach (Button button in panelStul.Controls.OfType<Button>())
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
        }

        private void UlozitObj_Click(object sender, EventArgs e)
        {
            /*Takes number stul as argument, add order to that table*/
        }

        private void NahledUctenky_Click(object sender, EventArgs e)
        {
            /*Vystiskne nahled uctenky pro zakaznika (př. PDF)*/
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
                //Console.WriteLine(category.Nazev);
            }
        }
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            MessageBox.Show($"Category '{clickedButton.Text}' clicked!");
            ProductDAO productDAO = new ProductDAO();
            List<Product> list = productDAO.GetListProduct(clickedButton.Text);
            flowLayoutProduct.Controls.Clear();
            foreach (Product product in list)
            {
                Button b = new Button();
                b.Text = product.Name;
                b.Click += ProductButton_Click;
                b.Size = new System.Drawing.Size(140, 50);
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                flowLayoutProduct.Controls.Add(b);
                //Console.WriteLine(product.Name);
            }
        }
        private void ProductButton_Click(object sender, EventArgs e)
        {
            // Nejprve zjistim jestli stul je vybran
            if (NumberTable == 0)
            {
                MessageBox.Show("Prosím vyberte stůl");
                return;
            }
            Button clickedButton = (Button)sender;
            MessageBox.Show($"Product '{clickedButton.Text}' clicked!");
        }
    }
}
