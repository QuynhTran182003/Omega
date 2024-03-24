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
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetOrderId(Order ele)
        {
            SqlCommand cmd = new SqlCommand("select Orders.id as 'ID' from Orders where table_id = (select id from Tabl where number_table = @table) and dtime_order = @dtime_order", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@table", ele.Table);
            cmd.Parameters.AddWithValue("@dtime_order", ele.DateOrder);
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
                MessageBox.Show("Successfully saved order.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            DatabaseSingleton.CloseConnection();
        }

        public void Update(int id, Order newEle)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetListOrders(int table)
        {
            SqlCommand cmd = new SqlCommand(@"select Orders.id, Tabl.number_table, Orders.dtime_order from Orders inner join Tabl on Tabl.id = Orders.table_id where table_id = (select id from Tabl where number_table = @table) ", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@table", table);
            List<Order> list = new List<Order>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    int tab = int.Parse(reader["number_table"].ToString());
                    DateTime dateTimeOrder = (DateTime)reader["dtime_order"];
                    Order order = new Order
                    (
                        id,
                        tab,
                        dateTimeOrder
                    );

                    list.Add(order);
                }
            }
            DatabaseSingleton.CloseConnection();

            return list;
        }
    }
}
