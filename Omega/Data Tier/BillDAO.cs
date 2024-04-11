using Omega.Business_Tier;
using Omega.Presentation_Tier.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Data_Tier
{
    public class BillDAO : IDAO<Bill>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetBillId(string dateissue)
        {
            SqlCommand cmd = new SqlCommand("select Bill.id as 'ID' from Bill where date_issue = @date_issue", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@date_issue", dateissue);
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

        public void Insert(Bill ele)
        {
            SqlCommand cmd = new SqlCommand("insert into Bill(total_price, table_id, paymentMethod, takeaway, date_issue) values(@total_price, @table_id, @paymentMethod, @takeaway, @date_issue);", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@total_price", ele.TotalPrice);
            cmd.Parameters.AddWithValue("@table_id", ele.Table_id);
            cmd.Parameters.AddWithValue("@paymentMethod", ele.PaymentMethod);
            cmd.Parameters.AddWithValue("@takeaway", ele.Takeaway? 1: 0);
            cmd.Parameters.AddWithValue("@date_issue", ele.DateIssue);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved bill.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            DatabaseSingleton.CloseConnection();
        }

        public void InsertItem(Item i, int b)
        {
            SqlCommand cmd = new SqlCommand("insert into ItemBill(product_id, bill_id, quantity) values((select Product.id as ID from Product where Product.code = @prod_code), @bill_id, @quantity);", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@prod_code", i.Product_code);
            cmd.Parameters.AddWithValue("@bill_id", b);
            cmd.Parameters.AddWithValue("@quantity", i.Quantity);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted bill item.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            DatabaseSingleton.CloseConnection();
        }
        public void Update(int id, Bill newEle)
        {
            throw new NotImplementedException();
        }

        public void GetAll(DataGridView dataView)
        {
            SqlCommand cmd = new SqlCommand("select date_issue, id, total_price from Bill where CONVERT(date, date_issue) = @date;", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"));

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataView.DataSource = dt;

            DatabaseSingleton.CloseConnection();
        }

        public void GetBills(string from, string to, DataGridView dataView)
        {
            SqlCommand cmd = new SqlCommand("select date_issue, id, total_price from Bill where CONVERT(date, date_issue) between @datefrom and @dateto", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@datefrom", from);
            cmd.Parameters.AddWithValue("@dateto", to);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataView.DataSource = dt;

            DatabaseSingleton.CloseConnection();
        }

        public void GetBillItems(int bill_id, DataGridView dataView)
        {
            SqlCommand cmd = new SqlCommand("select ItemBill.id, Product.name, Product.price, quantity, (quantity * Product.price) as 'subtotal (Kc)' from ItemBill inner join Product on Product.id = ItemBill.product_id where bill_id = @bill_id;", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@bill_id", bill_id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataView.DataSource = dt;

            DatabaseSingleton.CloseConnection();
        }

        public List<BillItem> GetBillItems(int bill_id)
        {
            SqlCommand cmd = new SqlCommand("select Product.name as 'Nazev', Product.price as 'Cena', Category.dph as 'DPH', ItemBill.quantity as 'Mnozstvi', (Product.price * ItemBill.quantity) as 'Celkem' \r\nfrom ItemBill\r\ninner join Product on Product.id = ItemBill.product_id\r\ninner join Category on Category.id = Product.category_id\r\n where bill_id = @bill_id;", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@bill_id", bill_id);
            List<BillItem> list = new List<BillItem>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    BillItem bi = new BillItem(
                        reader["Nazev"].ToString(),
                        Convert.ToInt32(reader["Cena"]),
                        Convert.ToInt32(reader["DPH"]),
                        Convert.ToInt32(reader["Mnozstvi"]),
                        Convert.ToInt32(reader["Celkem"])
                        );
                    

                    list.Add(bi);
                }
            }
            DatabaseSingleton.CloseConnection();

            return list;
        }

        public int GetTotalAllBills()
        {
            int total = 0;
            SqlCommand cmd = new SqlCommand("select sum(total_price) as 'SUM' from Bill WHERE CONVERT(date, date_issue) = @date;", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"));

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("SUM")))
                    {
                        total = Convert.ToInt32(reader["SUM"]);
                    }
                }
            }
            DatabaseSingleton.CloseConnection();

            return total;
        }
        public int GetCashAllBills()
        {
            int total = 0;
            SqlCommand cmd = new SqlCommand("select sum(total_price) as 'SUM' from Bill where Bill.paymentMethod = 'Hotově' and CONVERT(date, date_issue) = @date;", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"));

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("SUM")))
                    {
                        total = Convert.ToInt32(reader["SUM"]);
                    }
                }
            }
            DatabaseSingleton.CloseConnection();

            return total;
        }
        public int GetCardsAllBills()
        {
            int total = 0;
            SqlCommand cmd = new SqlCommand("select sum(total_price) as 'SUM' from Bill where Bill.paymentMethod = 'Kartou' and CONVERT(date, date_issue) = @date;", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"));

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("SUM")))
                    {
                        total = Convert.ToInt32(reader["SUM"]);
                    }
                }
            }
            DatabaseSingleton.CloseConnection();

            return total;
        }
    }
}
