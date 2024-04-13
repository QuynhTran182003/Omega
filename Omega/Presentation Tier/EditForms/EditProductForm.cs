using Omega.Business_Tier;
using Omega.Presentation_Tier.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Presentation_Tier.EditForms
{
    public partial class EditProductForm : Form
    {
        private ProductPanel productPanel;
        private int id;
        public EditProductForm(int id, string name, string code, int price, string category, ProductPanel panel)
        {
            InitializeComponent();
            this.id = id;
            this.nazev.Text = name;
            this.kod.Text = code;
            this.price.Text = price.ToString();
            this.categoryCbo.Text = category;
            productPanel = panel;
        }

        private void aktualizovat_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.nazev.Text;
                string code = this.kod.Text;
                int price = int.Parse(this.price.Text);
                string category = this.categoryCbo.Text;
                Product p = new Product(name, code, price, category);
                p.UpdateProduct(this.id, p);
                this.Hide();
                this.productPanel.ProductForm_Load(sender, e);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            productPanel.LoadComboCategory(this.categoryCbo);
        }
    }
}
