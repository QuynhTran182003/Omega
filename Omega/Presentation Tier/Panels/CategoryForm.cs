using Omega.Data_Tier;
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

namespace Omega.Forms.Panels
{
    public partial class CategoryForm : UserControl
    {
        public CategoryForm()
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
            catch (FormatException ex)
            {
                MessageBox.Show("DPH musí být číslo");
            }
            catch(Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            categoryDAO.GetAll(this.dataGridView1);
        }
    }
}
