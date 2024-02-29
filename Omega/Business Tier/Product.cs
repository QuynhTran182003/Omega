using Omega.Data_Tier;
using Omega.Objects;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /*public Product(int code, string name, int price, int cate_id)
        {
            Code = code;
            Name = name;
            Price = price;
            CategoryId = cate_id;
        }*/

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
            catch
            {

            }
        }

    }
}
