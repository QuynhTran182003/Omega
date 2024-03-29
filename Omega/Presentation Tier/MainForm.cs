﻿using Omega.Business_Tier;
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
            InitializeTableButton(this.flowLayoutTable);
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
            Button clickedButton = (Button)sender;
            if(SelectedTable != 0)
            {
                MessageBox.Show("Musite odchazet od vybraneho stolu");
                return;
            }
            // Reset colors of all not-reserved tables in flowLayoutTable to white, reserved tables keep color unchanged
            foreach (Button button in flowLayoutTable.Controls.OfType<Button>().Where(b => !b.Tag.Equals("Rezervovan")))
            {
                button.BackColor = Color.White;
            }

            // Change the clicked button's backcolor to red
            clickedButton.BackColor = Color.Red;
            Exit.BackColor = Color.MediumTurquoise;

            // Enable buttons execution
            foreach (Button button in panelExecution.Controls.OfType<Button>().Where(b => b.Tag != null && b.Tag.ToString() == "execution"))
            {
                button.Enabled = true;
                button.Visible = true;
            }
            // Set visible flowLayoutItemss
            panelItems.Visible = true;
            // Set the number of selected table, where we will add item to the order
            SelectedTable = int.Parse(clickedButton.Text.Split(' ')[1]);

            if (clickedButton.Tag.Equals("Rezervovan"))
            {
                //MessageBox.Show("ShowOrder execus ");
                ShowOrders(SelectedTable, this.flowLayoutItems);
            }
            else
            {
                totalPrice.Text = "0.0 Kc";
                flowLayoutItems.Controls.Clear();
            }
        }
        private void ShowOrders(int selectedTable, FlowLayoutPanel flowLayoutPanel)
        {
            int total = 0;
            // get order details from selected table 
            List<Item> items = new Table().GetOrderDetail(selectedTable);

            // create a single itemUC for each item achieved
            foreach (Item item in items)
            {
                Product p = new Product().GetByCode(item.Product_code);
                total += item.Quantity * p.Price;

                ItemUC uc = new ItemUC(p.Name, p.Code, p.Price, p.DPH(), item.Quantity);
                flowLayoutPanel.Controls.Add(uc);
            }
            totalPrice.Text = total + ",- Kc";
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
            UpdateTotalPrice();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            Button selectedTable = flowLayoutTable.Controls.OfType<Button>().FirstOrDefault(b => b.Text == ("Stůl " + SelectedTable.ToString()));
            if (selectedTable.Tag.Equals("Rezervovan")){
             // verticalPosition = 0;
                totalPrice.Text = "0.0,- Kc";
                flowLayoutItems.Controls.Clear();
                selectedTable.BackColor = Color.White;
                selectedTable.Tag = "Volno";
             // delete all items of order id, delete the order
                int numberTable = SelectedTable;
                // get the table id and with this table id we can 
                int table_id = new Table().GetIdByNumber(numberTable);
             //delete order of the table
                OrderDAO orderDAO = new OrderDAO();
                orderDAO.Delete(table_id);
            }
            else
            {
                MessageBox.Show("Tag neni rezzervovan");
            }
        }
        private void UlozitObj_Click(object sender, EventArgs e)
        {
            
            Button selectedTable = flowLayoutTable.Controls.OfType<Button>().FirstOrDefault(b => b.Text == ("Stůl " + SelectedTable.ToString()));
            // pokud table je volny, tak se vytvori novy order
            if (selectedTable.Tag.Equals("Volno"))
            {
                Order newOrder = new Order(SelectedTable, DateTime.Now);
                newOrder.AddToDB();
                selectedTable.Tag = ("Rezervovan");
                List<ItemUC> listUC = flowLayoutItems.Controls.OfType<ItemUC>().ToList();
                foreach (ItemUC itemUc in listUC)
                {
                    Item item = new Item((itemUc.CodeLabel.Text), newOrder.Id, int.Parse(itemUc.QuantityLabel.Text));
                    item.AddToDB();
                }
                this.Exit_Click(sender, e);
                SelectedTable = 0;
            }
            //pokud je rezervovan (sedi tam nekdo uz, tak update )
            else if (selectedTable.Tag.Equals("Rezervovan"))
            {
            }
            /*List<Item> items = new List<Item>();
            List<ItemUC> listUC = flowLayoutItemss.Controls.OfType<ItemUC>().ToList();

            *//*Takes number stul as argument, add order to that table*//*
            Button selectedTable = flowLayoutTable.Controls.OfType<Button>().FirstOrDefault(b => b.Text == ("Stůl " + SelectedTable.ToString()));
            selectedTable.BackColor = Color.IndianRed;


            selectedTable.Tag = "Rezervovan";

            // Create order with all items in flowLayoutItemss
            Order newOrder = new Order(SelectedTable, DateTime.Now);
            newOrder.AddToDB();
            int newOrder_id = newOrder.Id;

            // add item iclude order_id to db
            foreach (ItemUC itemUc in listUC)
            {
                Item item = new Item((itemUc.CodeLabel.Text), newOrder_id, int.Parse(itemUc.QuantityLabel.Text));
                item.AddToDB();
            }
            this.Exit_Click(sender, e);*/

        }
        private void NahledUctenky_Click(object sender, EventArgs e)
        {
            /*Vystiskne nahled uctenky pro zakaznika (př. PDF)*/
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            /*Reset colors of all not reserved tables in flowLayoutTable to white*/
            foreach (Button button in flowLayoutTable.Controls.OfType<Button>().Where(b => !b.Tag.Equals("Rezervovan")))
            {
                button.BackColor = Color.White;
            }

            /*Disable/ set to invisible buttons in panelExecution*/
            foreach (Button button in panelExecution.Controls.OfType<Button>().Where(b => b.Tag != null && b.Tag.ToString() == "execution"))
            {
                button.Enabled = false;
                button.Visible = false;
            }
            Button clickedButton = (Button)sender;
            if(clickedButton.Text.Equals("Exit"))
                clickedButton.BackColor = Color.MediumTurquoise;
            SelectedTable = 0;
            totalPrice.Text = "0.0,- Kc";
            flowLayoutItems.Controls.Clear();
            //verticalPosition = 0;

        }
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ProductDAO productDAO = new ProductDAO();
            List<Product> list = productDAO.GetListProduct(clickedButton.Text);
            flowLayoutProduct.Controls.Clear();
            foreach (Product product in list)
            {
                string text = product.Code + " - " + product.Name + Environment.NewLine + Environment.NewLine + product.Price;
                Button b = new Button();
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                b.Text = text;
                b.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                b.Click += ProductButton_Click;
                b.Size = new System.Drawing.Size(170, 80);
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
            UpdateTotalPrice();
        }
    }
}
