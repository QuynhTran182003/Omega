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
        private int price_custom;

        public int Id { 
            get {
                ItemDAO c = new ItemDAO();
                return c.GetItemId(Order_id, Product_code);
            }
            set => id = value; }
        public string Product_code { get => product_code; set => product_code = value; }
        public int Order_id { get => order_id; set => order_id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int PriceCustom { get => price_custom; set => price_custom = value; }

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

        public Item()
        {
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
                return;
            }
        }

        public void UpdateQuantity(int id, int quantity)
        {
            try
            {
                ItemDAO itemDAO = new ItemDAO();
                itemDAO.UpdateQuant(id, quantity);
                MessageBox.Show("Update successfully");

            }
            catch (SqlException ex){
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
