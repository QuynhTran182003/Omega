using Omega.Business_Tier;
using Omega.Data_Tier;
using Omega.Objects;
using Omega.Presentation_Tier;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    partial class MainForm
    {
        private void InitializeTableButton(FlowLayoutPanel flowLayoutPanel)
        {
            TableDAO tableDAO = new TableDAO();
            List<Table> list = tableDAO.GetListTable();
            flowLayoutPanel.Controls.Clear();
            foreach (Table ta in list)
            {
                Button b = new Button();
                b.Text = "Stůl " + ta.NumberTable;
                b.Click += this.Button_Stul_Click;
                b.Size = new System.Drawing.Size(105, 50);
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                b.Tag = (ta.Status == "volno"? "volno" : "rezervovan");
                b.BackColor = (ta.Status == "volno" ? Color.White : Color.Red); ;

                flowLayoutPanel.Controls.Add(b);
            }
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

        private void UpdateTotalPrice()
        {
            int total = 0;
            List<ItemUC> list = flowLayoutItems.Controls.OfType<ItemUC>().ToList();
            foreach (ItemUC itemUc in list)
            {
                total += (int.Parse(itemUc.QuantityLabel.Text) * int.Parse(itemUc.PriceLabel.Text));
            }
            this.totalPrice.Text = $"{total} ,- Kč";
        }

        private void AddOrUpdateItem(Product product, int quantity)
        {
            bool existed = false;
            // Vytvorim jiny UserControl (polozku objednavky) UC -- usercontrol
            ItemUC n_itemUC = new ItemUC(product.Name, product.Code, product.Price, product.DPH(), 1);

            // ziskam vsechny polozky co uz mam v panelu
            List<ItemUC> list = flowLayoutItems.Controls.OfType<ItemUC>().ToList();

            // kontroluju jestli v listu existuje takovy produkt, ktery chci vlozit do objednavky, 
            foreach (ItemUC itemUc in list)
            {
                //Pokud uz existuje, zvysim jenom pocet tohoto produktu
                if (itemUc.CodeLabel.Text.Equals(n_itemUC.CodeLabel.Text))
                {
                    existed = true;
                    // update and set quantity label text
                    int actual_quant = int.Parse(itemUc.QuantityLabel.Text);
                    itemUc.QuantityLabel.Text = (actual_quant + quantity).ToString();
                    break;
                }
            }
            //Pokud takovy produkt jeste neexistuje, tak ho pridam to panelu
            if (!existed)
            {
                flowLayoutItems.Controls.Add(n_itemUC);
            }
        }

        public void ShowOrders(int selectedTable, FlowLayoutPanel flowLayoutPanel)
        {
            int total = 0;
            flowLayoutPanel.Controls.Clear();

            // get order details from selected table 
            List<Item> items = new Table().GetOrderDetail(selectedTable);

            // create a single itemUC for each item achieved
            foreach (Item item in items)
            {
                Product p = new Product().GetByCode(item.Product_code);
                total += item.Quantity * p.Price;

                ItemUC uc = new ItemUC(item.Id, p.Name, p.Code, p.Price, p.DPH(), item.Quantity, this);
                flowLayoutPanel.Controls.Add(uc);
            }
            totalPrice.Text = total.ToString() + ",-Kč";
        }
    }
}
