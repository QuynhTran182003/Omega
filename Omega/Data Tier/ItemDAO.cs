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

        public int GetItemId(int order_id, string code)
        {
            SqlCommand cmd = new SqlCommand("select Item.id as 'ID' from Item where order_id = @order_id and product_id = (select id from Product where code = @code) ", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@order_id", order_id);
            cmd.Parameters.AddWithValue("@code", code);
            int id = 0;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    id = (int)reader["ID"];
                }
            }
            DatabaseSingleton.CloseConnection();

            return id;
        }

        //this command first check if the same item has existed, if not it just updates the quantity otherwise it creates a new one
        public void Insert(Item ele)
        {
            //SqlCommand cmd = new SqlCommand("INSERT INTO Item (product_id, order_id, quantity) VALUES ((select product.id from Product where product.code = @prod_code), @order_id, @quantity)", DatabaseSingleton.GetInstance());
            SqlCommand cmd = new SqlCommand("MERGE INTO Item AS target\r\n" +
                "USING (VALUES ((SELECT id\r\nFROM Product\r\nWHERE code = @prod_code), @order_id)) AS source (product_id, order_id)\r\n" +
                "ON target.product_id = source.product_id AND target.order_id = source.order_id\r\n" +
                "WHEN MATCHED THEN\r\n    " +
                    "UPDATE SET target.quantity = target.quantity + @quantity\r\n" +
                "WHEN NOT MATCHED THEN\r\n    " +
                    "INSERT (product_id, order_id, quantity)\r\n    " +
                "VALUES (source.product_id, source.order_id, @quantity);", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@prod_code", ele.Product_code);
            cmd.Parameters.AddWithValue("@order_id", ele.Order_id);
            cmd.Parameters.AddWithValue("@quantity", ele.Quantity);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            DatabaseSingleton.CloseConnection();
        }

        public void Update(int id, Item newEle)
        {
            SqlCommand cmd = new SqlCommand("update Item set quantity = @quantity, price_at_order = @custom_price where id = @id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@quantity", newEle.Quantity);
            cmd.Parameters.AddWithValue("@custom_price", newEle.PriceCustom);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                return;
                throw ex;
            }

            DatabaseSingleton.CloseConnection();
        }
        public void UpdateQuant(int itemid, int newQuant)
        {
            SqlCommand cmd = new SqlCommand("update table Item set quantity = @quantity where id = @id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@quantity", newQuant);
            cmd.Parameters.AddWithValue("@id", itemid);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            DatabaseSingleton.CloseConnection();
        }

        public List<Item> GetListItems(int order_id)
        {

            SqlCommand cmd = new SqlCommand(@"select Item.id, Product.code, Orders.id as OrderId, Item.quantity from Item 
                                                inner join Orders on Orders.id = Item.order_id 
                                                inner join Product on Product.id = Item.product_id 
                                                where Orders.id = @order_id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@order_id", order_id);
            List<Item> items = new List<Item>();

            try
            {
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
                return items;

            }
            catch (SqlException ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                DatabaseSingleton.CloseConnection();
            }

        }
    }
}
