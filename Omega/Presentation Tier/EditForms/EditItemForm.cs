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
            selected = clicked;
        }

        private void save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("save itemd");
            //to do
        }
    }
}
