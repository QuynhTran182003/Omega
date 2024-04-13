using Omega.Business_Tier;
using Omega.Data_Tier;
using Omega.Objects;
using Omega.Presentation_Tier.EditForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Forms.Panels
{
    public partial class CategoryPanel : UserControl
    {

        public CategoryPanel()
        {
            InitializeComponent();
        }

        private void ulozitKateg_Click(object sender, EventArgs e)
        {
            //Zde získám název a DPH nové kategorie, vytvoří se nová kategorie a prida se do databáze
            try
            {
                string new_nazev = this.inputNazev.Text;
                int new_DPH_tady = int.Parse(this.inputDPHtady.Text);
                if(new_DPH_tady <= 0)
                {
                    MessageBox.Show("DPH musí být větší než 0");
                    return;
                }

                Category newCategory = new Category(new_nazev, new_DPH_tady);
                newCategory.AddToDB();
                CategoryForm_Load(sender, e);
                this.inputNazev.Text = "";
                this.inputDPHtady.Text = "";
                this.inputDPHsebou.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("DPH musí být číslo větší než 0");
                return;

            }
        }

        public void CategoryForm_Load(object sender, EventArgs e)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            categoryDAO.GetAll(this.dataGridView1);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string name = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                if (MessageBox.Show($"Are u sure to delete category {name}?", "Delete category", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    {
                        int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
                        new Category().DeleteCategory(id);
                        this.CategoryForm_Load(sender, e);
                    }
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
            string name = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            int dph = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["dph"].FormattedValue.ToString());

            EditCategoryForm edf = new EditCategoryForm(id, name, dph, this);
            edf.ShowDialog();
        }
    }
}
