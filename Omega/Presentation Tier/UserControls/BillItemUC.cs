using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Presentation_Tier.UserControls
{
    public partial class BillItemUC : UserControl
    {
        public BillItemUC(string nazev, int cena, int dph, int quantity, int celkem)
        {
            InitializeComponent();
            this.nazev.Text = nazev.ToString();
            this.cena.Text = cena.ToString();
            this.dph.Text = dph.ToString();
            this.mnozstvi.Text = quantity.ToString();
            this.celkem.Text = celkem.ToString();
        }
    }
}
