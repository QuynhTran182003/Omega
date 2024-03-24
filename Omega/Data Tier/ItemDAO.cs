using Omega.Business_Tier;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Data_Tier
{
    public class ItemDAO : IDAO<Item>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Item ele)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Item (product_id, order_id, quantity) VALUES ((select product.id from Product where product.code = @prod_code), @order_id, @quantity)", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@prod_code", ele.Product_code);
            cmd.Parameters.AddWithValue("@order_id", ele.Order_id);
            cmd.Parameters.AddWithValue("@quantity", ele.Quantity);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved item.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            DatabaseSingleton.CloseConnection();
        }

        public void Update(int id, Item newEle)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetListItems(int order_id)
        {

            SqlCommand cmd = new SqlCommand(@"select Item.id, Product.code, Orders.id as OrderId, Item.quantity from Item 
                                                inner join Orders on Orders.id = Item.order_id 
                                                inner join Product on Product.id = Item.product_id 
                                                where Orders.id = @order_id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@order_id", order_id);
            List<Item> items = new List<Item>();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string code = reader["code"].ToString();
                    int orderId = int.Parse(reader["OrderId"].ToString());
                    int quantity = int.Parse(reader["quantity"].ToString());
                    Item p = new Item
                    (
                        id, code, orderId, quantity
                    );

                    items.Add(p);
                }
            }
            DatabaseSingleton.CloseConnection();

            return items;
        }
    }
}
