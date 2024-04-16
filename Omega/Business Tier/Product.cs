using Omega.Data_Tier;
using Omega.Objects;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Business_Tier
{
    public class Product: IBaseClass<Product>
    {
        private int id;
        private string code;
        private string name;
        private int price;
        private string category;
        public int Id { get => id; set => id = value; }
        public string Code { get => code; set => code = value; }

        public string Name { get => name; set => name = value; }

        public int Price { get => price; set => price = value; }

        public string Category { get => category; set => category = value; }

        public Product() { }

        public Product(string code, string name, int price, string cate)
        {
            Code = code;
            Name = name;
            Price = price;
            Category = cate;
        }


        // -------------------WORK WITH DATABASE=================

        public void AddToDB()
        {
            try
            {
                ProductDAO c = new ProductDAO();
                c.Insert(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error se objevil v 51. line Product.cs: {ex.Message}");
            }
        }

        public Product GetByCode(string code)
        {
            try
            {
                ProductDAO productDAO = new ProductDAO();
                Product product = productDAO.GetProductByCode(code);
                // if this product exists in database
                if (product.Name == null || product.Code == null)
                {
                    return null;
                }
                return product;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public int DPH()
        {
            try
            {
                int dph = 0;
                ProductDAO productDAO = new ProductDAO();
                dph = productDAO.GetDPH(this.Code);
                return dph;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                ProductDAO productDAO = new ProductDAO();
                productDAO.Delete(id);
                MessageBox.Show("Product deleted successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void UpdateProduct(int id, Product p)
        {
            try
            {
                ProductDAO productDAO = new ProductDAO();
                productDAO.Update(id, p);
                MessageBox.Show("Product updated successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ;
            }
        }
    }
}
