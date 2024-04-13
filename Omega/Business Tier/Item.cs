using Omega.Data_Tier;
using Omega.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Business_Tier
{
    public class Item : IBaseClass<Item>
    {
        private int id;
        private string product_code;
        private int order_id;
        private int quantity;

        public int Id { get => id; set => id = value; }
        public string Product_code { get => product_code; set => product_code = value; }
        public int Order_id { get => order_id; set => order_id = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Item(string productCode, int orderId, int quantity)
        {
            Product_code = productCode;
            Order_id = orderId;
            Quantity = quantity;
        }

        public Item(int id, string productCode, int orderId, int quantity)
        {
            Id = id;
            Product_code = productCode;
            Order_id = orderId;
            Quantity = quantity;
        }

        public void AddToDB()
        {
            try
            {
                ItemDAO itemDAO = new ItemDAO();
                itemDAO.Insert(this);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
