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
    public partial class ItemUC : UserControl
    {
        public ItemUC()
        {
            InitializeComponent();
        }

        public Label NameLabel { get { return jmeno; } }
        public Label IdLabel { get { return id; } }
        public Label CodeLabel { get { return kod; } }
        public Label PriceLabel { get { return cena; } }
        public Label DPHLabel { get { return dph; } }
        public Label QuantityLabel { get { return mnozstvi; } }

        public ItemUC(string jmeno, string kod, int cena, int dph, int mnozstvi)
        {
            InitializeComponent();
            this.NameLabel.Text = jmeno;
            this.CodeLabel.Text = kod;
            this.PriceLabel.Text = cena.ToString();
            this.DPHLabel.Text = dph.ToString();
            this.QuantityLabel.Text = mnozstvi.ToString();
        }

        private void ItemUC_Click(object sender, EventArgs e)
        {
/*Upravit cenu v pripade potreby, upravit mnozstvi na rychle*/
            ItemUC clicked = (ItemUC)sender;
            MessageBox.Show("Edit price edit Quantity for " + clicked.NameLabel.Text);
        }
    }
}
