using Omega.Business_Tier;
using Omega.Data_Tier;
using Omega.Forms.Panels;
using Omega.Objects;
using Omega.Presentation_Tier;
using Omega.Presentation_Tier.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    public partial class MainForm : Form
    {
        private LoginForm loginForm;
        private int selectedTable = 0;
        private User loggedInUser;
        public int SelectedTable { get { return selectedTable; } set { selectedTable = value; } }
        public MainForm(LoginForm loginForm, User u)
        {
            this.loggedInUser = u;
            InitializeComponent();
            this.loginForm = loginForm;
            panelMain.Visible = true;
            categoryForm1.Visible = false;
            productForm1.Visible = false;
            reportPanel1.Visible = false;
            listBillPanel1.Visible = false;
            zamestnanecPanel1.Visible = false;
        }

        /// <summary>
        /// Loading the Category and Table buttons
        /// Render to the MainForm
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeCategoryButton(this.flowLayoutCategory);
            InitializeTableButton(this.flowLayoutTable);
        }

        /// <summary>
        /// Handles the FormClosed event of the MainForm.
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
        }

        /// <summary>
        /// Handles the Click event of the pokladnaToolStripMenuItem.
        /// </summary>
        private void pokladnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryForm1.Visible = false;
            productForm1.Visible = false;
            reportPanel1.Visible = false;
            listBillPanel1.Visible = false;
            zamestnanecPanel1.Visible = false;
            panelMain.Visible = true;
            this.MainForm_Load(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the zamestnanciToolStripMenuItem.
        /// </summary>
        private void zamestnanciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productForm1.Visible = false;
            categoryForm1.Visible = false;
            panelMain.Visible = false;
            reportPanel1.Visible = false;
            listBillPanel1.Visible = false;
            zamestnanecPanel1.Visible = true;
            zamestnanecPanel1.ZamestnanecPanel_Load(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the produktyToolStripMenuItem.
        /// </summary>
        private void produktyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            categoryForm1.Visible = false;
            panelMain.Visible = false;
            reportPanel1.Visible = false;
            listBillPanel1.Visible = false;
            zamestnanecPanel1.Visible = false;
            productForm1.Visible = true;
            productForm1.ProductForm_Load(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the kategorieToolStripMenuItem.
        /// </summary>
        private void kategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            productForm1.Visible = false;
            reportPanel1.Visible = false;
            listBillPanel1.Visible = false;
            zamestnanecPanel1.Visible = false;
            categoryForm1.Visible = true;
            categoryForm1.CategoryForm_Load(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the seznamFakturToolStripMenuItem.
        /// </summary>
        private void seznamFakturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            categoryForm1.Visible = false;
            productForm1.Visible = false;
            reportPanel1.Visible = false;
            zamestnanecPanel1.Visible = false;
            listBillPanel1.Visible = true;
            listBillPanel1.ListBillPanel_Load(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the denniReportToolStripMenuItem.
        /// </summary>
        private void denniReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            categoryForm1.Visible = false;
            productForm1.Visible = false;
            listBillPanel1.Visible = false;
            zamestnanecPanel1.Visible = false;
            reportPanel1.Visible = true;
            reportPanel1.ReportPanel_Load(sender, e);
        }

        /// <summary>
        /// Event handler for clicking on a table button.
        /// </summary>
        private void Button_Stul_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            int clickedTable = int.Parse(clickedButton.Text.Split(' ')[1]);
            // Check if selected table is the same with the one being selected
            if (clickedTable == SelectedTable) return;

            // Check if any table is being selected
            if (SelectedTable != 0 && int.Parse(clickedButton.Text.Split(' ')[1]) != SelectedTable)
            {
                MessageBox.Show("Musíte odcházet od vybraného stolu");
                return;
            }

            // Set the number of selected table, where we will add item to the order
            SelectedTable = clickedTable;

            // Reset colors of all free tables to white, reserved tables keep unchanged
            foreach (Button button in flowLayoutTable.Controls.OfType<Button>().Where(b => !b.Tag.Equals("rezervovan")))
            {
                button.BackColor = Color.White;
            }

            // Change the clicked button's backcolor to red
            clickedButton.BackColor = Color.Red;
            Exit.Visible = true;

            // Enable buttons execution
            foreach (Button button in panelExecution.Controls.OfType<Button>().Where(b => b.Tag != null && b.Tag.ToString() == "execution"))
            {
                button.Enabled = true;
                button.Visible = true;
            }

            // Set visible flowLayoutItemss
            panelItems.Visible = true;

            // Check if the clicked table represents a reserved table
            if (clickedButton.Tag.Equals("rezervovan"))
            {
                // Show existing orders for the selected table
                ShowOrders(SelectedTable, this.flowLayoutItems);
                this.ulozitObj.Visible = false;
            }
            else
            {
                // Reset order details for the selected table
                totalPrice.Text = "0.0,- Kc";
                flowLayoutItems.Controls.Clear();
                this.ulozitObj.Visible= false;
            }
        }

        /// <summary>
        /// Event handler for clicking on number buttons.
        /// </summary>
        private void Btn_numbers_Click(object sender, EventArgs e)
        {
            // Append the text of the clicked button to the idItemInput textbox
            Button clickedButton = (Button)sender;
            this.idItemInput.Text += clickedButton.Text;
        }

        /// <summary>
        /// Event handler for clicking on the "Backspace" button.
        /// </summary>
        private void Backspace_Click(object sender, EventArgs e)
        {
            // Check if the idItemInput textbox is empty
            if (this.idItemInput.Text.Length == 0) return; // If empty, do nothing

            // Remove the last character from the idItemInput textbox
            this.idItemInput.Text = this.idItemInput.Text.Substring(0, this.idItemInput.Text.Length - 1);
        }

        /// <summary>
        /// Event handler for clicking the "Enter" button.
        /// </summary>
        private void Enter_Click(object sender, EventArgs e)
        {
            string itemCode = this.idItemInput.Text;

            // Check if a table is selected
            if (SelectedTable == 0)
            {
                MessageBox.Show("Prosím vyberte stůl");
                return;
            }

            // Check for empty input         
            if (itemCode.Equals("")) {
                MessageBox.Show("Prázdná hodnota");
                return;
            }

            // Get product by code
            Product p = new Product().GetByCode(itemCode);
            if (p == null)
            {
                MessageBox.Show("Zboží nenalezeno");
                return;
            }

            // Clear items if "ulozitObj" is not visible
            if (!ulozitObj.Visible) flowLayoutItems.Controls.Clear();

            // Add or update item in the order
            AddOrUpdateItem(p, 1);

            // Update total price
            UpdateTotalPrice();

            // Clear input and make "ulozitObj" visible
            this.idItemInput.Text = "";
            this.ulozitObj.Visible = true;
        }

        /// <summary>
        /// Event handler for clicking the "Delete" button.
        /// </summary>
        public void btnDel_Click(object sender, EventArgs e)
        {
            Button selectedTable = flowLayoutTable.Controls.OfType<Button>().FirstOrDefault(b => b.Text == ("Stůl " + SelectedTable.ToString()));
            
            // Check if the selected table is reserved
            if (selectedTable.Tag.Equals("rezervovan")){
                // Clear items and reset table color and tag
                totalPrice.Text = "0.0,- Kc";
                flowLayoutItems.Controls.Clear();
                selectedTable.BackColor = Color.White;
                selectedTable.Tag = "volno";

                // Delete order associated with the table
                int numberTable = SelectedTable;
                int table_id = new Table().GetIdByNumber(numberTable);
                OrderDAO orderDAO = new OrderDAO();
                orderDAO.Delete(table_id);
            }
            else
            {
                // Clear all items in panelItems
                totalPrice.Text = "0.0,- Kc";
                flowLayoutItems.Controls.Clear();
            }
        }

        /// <summary>
        /// Event handler for clicking the "UlozitObj" (Save) button.
        /// </summary>
        private void UlozitObj_Click(object sender, EventArgs e)
        {
            // Check if a table is selected
            if (SelectedTable == 0)
            {
                MessageBox.Show("Prosím vyberte stůl");
                return;
            }

            // Get the button representing the selected table
            Button selectedTable = flowLayoutTable.Controls.OfType<Button>().FirstOrDefault(b => b.Text == ("Stůl " + SelectedTable.ToString()));
            
            // If the table is free, create a new order
            if (selectedTable.Tag.Equals("volno"))
            {
                // Create a new order
                Order newOrder = new Order(SelectedTable, DateTime.Now);
                newOrder.AddToDB();

                // Add items to the order
                List<ItemUC> listUC = flowLayoutItems.Controls.OfType<ItemUC>().ToList();
                foreach (ItemUC itemUc in listUC)
                {
                    Item item = new Item((itemUc.CodeLabel.Text), newOrder.Id, int.Parse(itemUc.QuantityLabel.Text));
                    item.AddToDB();
                }

                // Update table tag to indicate it's reserved
                selectedTable.Tag = ("rezervovan");

                // Close the order panel and reset selected table
                this.Exit_Click(sender, e);
                SelectedTable = 0;
            }
            // If the table is already reserved, update the order
            else if (selectedTable.Tag.Equals("rezervovan"))
            {
                // Get the order ID from the selected table
                int order_id = new Table().GetOrderIdFrTable(SelectedTable);

                // Update existing order with new items
                List<ItemUC> listUC = flowLayoutItems.Controls.OfType<ItemUC>().ToList();
                foreach (ItemUC itemUc in listUC)
                {
                    Item item = new Item((itemUc.CodeLabel.Text), order_id, int.Parse(itemUc.QuantityLabel.Text));
                    item.AddToDB();
                }

                // Close the order panel and reset selected table
                this.Exit_Click(sender, e);
                SelectedTable = 0;
            }
        }

        private void NahledUctenky_Click(object sender, EventArgs e)
        {
            /*Vystiskne nahled uctenky pro zakaznika (př. PDF)*/
        }

        /// <summary>
        /// Event handler for clicking the "Exit" button.
        /// </summary>
        public void Exit_Click(object sender, EventArgs e)
        {
            // Reset colors of all free tables to white
            foreach (Button button in flowLayoutTable.Controls.OfType<Button>().Where(b => !b.Tag.Equals("rezervovan")))
            {
                button.BackColor = Color.White;
            }

            // Set buttons in panelExecution to invisible 
            foreach (Button button in panelExecution.Controls.OfType<Button>().Where(b => b.Tag != null && b.Tag.ToString() == "execution"))
            {
                button.Enabled = false;
                button.Visible = false;
            }

            // Reset selected table, total price, and clear item list
            SelectedTable = 0;
            totalPrice.Text = "0.0,- Kc";
            flowLayoutItems.Controls.Clear();
            this.Exit.Visible = false;
        }

        /// <summary>
        /// Event handler for clicking category buttons.
        /// </summary>
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ProductDAO productDAO = new ProductDAO();

            // Retrieve list of products based on the category clicked
            List<Product> list = productDAO.GetListProduct(clickedButton.Text);

            // Clear existing product buttons in the product flow layout panel
            flowLayoutProduct.Controls.Clear();

            // Add buttons for each product to the product flow layout panel
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

        /// <summary>
        /// Event handler for clicking product buttons.
        /// </summary>
        private void ProductButton_Click(object sender, EventArgs e)
        {
            // Check if a table is selected
            if (SelectedTable == 0)
            {
                MessageBox.Show("Prosím vyberte stůl");
                return;
            }

            // Clear items if "ulozitObj" is not visible
            if (!ulozitObj.Visible) flowLayoutItems.Controls.Clear();

            // Get product code from clicked product button
            Button clickedButton = (Button)sender;
            string code = (clickedButton.Text.Split('-')[0]);
            Product p = new Product().GetByCode(code);

            // Add or update item in the order
            AddOrUpdateItem(p, 1);
            UpdateTotalPrice();
            this.ulozitObj.Visible = true;
        }

        /// <summary>
        /// Event handler for clicking the "Zaplatit" (Pay) button.
        /// </summary>
        private void Zaplatit_Click(object sender, EventArgs e)
        {
            // Check if a table is selected and there are items in the order
            if (SelectedTable == 0) return;

            // Open payment form
            if (flowLayoutItems.Controls.Count > 0)
            {
                PaymentForm pm = new PaymentForm(this.totalPrice.Text, SelectedTable, this);
                pm.Show();
            }
        }
    }
}
