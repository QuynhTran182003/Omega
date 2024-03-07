﻿using Omega.Data_Tier;
using Omega.Objects;
using System;
using System.CodeDom;
using System.Collections.Generic;
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

        public Product GetByCode(int code)
        {
            ProductDAO productDAO = new ProductDAO();
            return productDAO.GetProductByCode(code);
        }

        public int DPH()
        {
            int dph;
            ProductDAO productDAO = new ProductDAO();
            dph = productDAO.GetDPH(this.Id);
            return dph;
        }

    }
}
