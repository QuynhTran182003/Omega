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
        private int code;
        private string name;
        private int price;
        private int category_id;
        public int Id { get => id; set => id = value; }
        public int Code { get => code; set => code = value; }

        public string Name { get => name; set => name = value; }

        public int Price { get => price; set => price = value; }

        public int CategoryId { get => category_id; set => category_id = value; }

        public Product() { }

        public Product(int code, string name, int price, int cate_id)
        {
            Code = code;
            Name = name;
            Price = price;
            CategoryId = cate_id;
        }

    }
}
