using Omega.Business_Tier;
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
        public EditItemForm(ItemUC clicked)
        {
            InitializeComponent();
            this.selected = clicked;
            this.nameProduct.Text = clicked.NameLabel.Text;
            this.textBox1.Text = clicked.QuantityLabel.Text;
            this.price.Text = clicked.PriceLabel.Text;
        }

        private void save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("save itemd");
            /*new Item().UpdateQuantity(int.Parse(selected.IdLabel.Text), int.Parse(this.textBox1.Text));
            this.Hide();*/
            //to do
        }
    }
}
