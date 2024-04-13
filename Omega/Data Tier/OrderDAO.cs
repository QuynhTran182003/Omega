using Omega.Business_Tier;
using Omega.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Data_Tier
{
    public class OrderDAO : IDAO<Order>
    {
        public void Delete(int numberTable)
        {
            // delete all Items in x order_id
            // delete order in x numbertable
            SqlCommand cmd = new SqlCommand("delete from Item where order_id IN (select id from Orders where Orders.table_id = (select id from Tabl where number_table = @numberTable))" +
                                             ";delete from Orders where table_id = @numberTable", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@numberTable", numberTable);
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

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetOrderId(int table)
        {
            SqlCommand cmd = new SqlCommand("select Orders.id as 'ID' from Orders where table_id = (select id from Tabl where number_table = @table) " +
                //"and dtime_order = @dtime_order" +
                "", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@table", table);
            /*cmd.Parameters.AddWithValue("@dtime_order", ele.DateOrder);*/
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



        public void Insert(Order ele)
        {
            SqlCommand cmd = new SqlCommand("insert into Orders(table_id, dtime_order) values((select id from Tabl where number_table = @table), @dtime)", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@dtime", ele.DateOrder);
            cmd.Parameters.AddWithValue("@table", ele.Table);
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

        public void Update(int id, Order newEle)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetListItems(int table)
        {
            SqlCommand cmd = new SqlCommand(@"select  Product.code, Item.order_id, sum(Item.quantity) as quantity
from Item
inner join Product on Item.product_id = Product.id 
where order_id IN (
	select id 
	from Orders 
	where Orders.table_id = 
		(select id	
		from Tabl 
		where number_table = @table))
group by Product.code, Item.order_id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@table", table);
            List<Item> list = new List<Item>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //int id = int.Parse(reader["id"].ToString());
                    string prod_code = reader["code"].ToString();
                    int order_id = int.Parse(reader["order_id"].ToString());
                    int quantity = int.Parse(reader["quantity"].ToString());
                    Item i = new Item(prod_code, order_id, quantity);

                    list.Add(i);
                }
            }
            DatabaseSingleton.CloseConnection();

            return list;
        }

    }
}
