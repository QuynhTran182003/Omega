using Omega.Business_Tier;
using Omega.Data_Tier;
using Omega.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Presentation_Tier.Panels
{
    public partial class ProductForm : UserControl
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            /*ziskame vsechny produkty do datagrid view a nacte se seznam kategorie z databaze*/
            ProductDAO productDAO = new ProductDAO();
            productDAO.GetAll(this.dataGridView1);
            this.LoadComboCategory(cbKategorie);
        }

        private void ulozitProdukt_Click(object sender, EventArgs e)
        {
            //Zde získám atributy nového produktu, vytvoří se novy produkt a prida se do databáze
            try
            {
                string new_code = (this.inputKod.Text);
                string new_name = (this.inputNazev.Text);
                int new_price= int.Parse(this.inputCena.Text);
                string category = (this.cbKategorie.Text);
                if (new_price <= 0)
                {
                    MessageBox.Show("Cena musí být větší než 0");
                    return;
                }

                Product newProduct = new Product(new_code, new_name, new_price, category);
                newProduct.AddToDB();
                ProductForm_Load(sender, e);
                this.inputKod.Text = "";
                this.inputNazev.Text = "";
                this.inputCena.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Cena musí být číslo");
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void LoadComboCategory(System.Windows.Forms.ComboBox comboCategory)
        {
            SqlCommand cmd = new SqlCommand("select Category.Name as 'Category' from Category;", DatabaseSingleton.GetInstance());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            comboCategory.Items.Clear();
            foreach (DataRow dr in table.Rows)
            {
                comboCategory.Items.Add(dr["Category"].ToString());
            }
        }
    }
}
