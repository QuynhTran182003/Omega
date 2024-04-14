using Omega.Business_Tier;
using Omega.Data_Tier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Presentation_Tier
{
    public partial class EditItemForm : Form
    {
        private ItemUC selected;
        private MainForm main;
        public EditItemForm(ItemUC clicked, MainForm mainForm)
        {
            InitializeComponent();
            this.selected = clicked;
            this.nameProduct.Text = clicked.NameLabel.Text;
            this.quantity.Text = clicked.QuantityLabel.Text;
            this.price.Text = clicked.PriceLabel.Text;
            this.main = mainForm;
        }

        private void save_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("save itemd");
            int id_to_update = int.Parse(selected.IdLabel.Text);
            ItemDAO itemDAO = new ItemDAO();

            Item newItem = new Item();
            newItem.Quantity = int.Parse(this.quantity.Text);
            newItem.PriceCustom = int.Parse(this.price.Text);

            itemDAO.Update(id_to_update, newItem);
            MessageBox.Show("update successfulllllllllll");
            this.Hide();
            this.main.ShowOrders(this.main.SelectedTable, this.main.flowLayoutItems);
            /*new Item().UpdateQuantity(int.Parse(selected.IdLabel.Text), int.Parse(this.quantity.Text));
            */
            //to do
        }
    }
}
