using Omega.Business_Tier;
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

namespace Omega.Presentation_Tier.EditForms
{
    public partial class EditCategoryForm : Form
    {
        private CategoryPanel categoryPanel;
        private int id;

        public EditCategoryForm(int id, string name, int dph, CategoryPanel panel)
        {
            InitializeComponent();
            this.id = id;
            this.nazev.Text = name;
            this.dph.Text = dph.ToString();
            categoryPanel = panel;
        }

        private void aktualizovat_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.nazev.Text;
                int dph = int.Parse(this.dph.Text);
                Category c = new Category(name, dph);
                c.UpdateCategory(this.id, c);
                this.Hide();
                this.categoryPanel.CategoryForm_Load(sender, e);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
