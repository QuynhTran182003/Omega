using Omega.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.Business_Tier
{
    public class BillItem : IBaseClass<BillItem>
    {
        private int id;
        private string name;
        private int price;
        private int quantity;
        private int dph;
        private int celkem;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public int Price { get => price; set => price = value; }

        public int Quantity { get => quantity; set => quantity = value; }

        public int Dph { get => dph; set => dph = value; }

        public int Celkem { get => celkem; set => celkem = value; }

        public BillItem(string name, int price, int quantity, int dph, int celkem)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Dph = dph;
            Celkem = celkem;
        }

        public BillItem() { }
    }
}
