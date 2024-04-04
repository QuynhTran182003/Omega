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

        public int GetBillId(Bill ele)
        {
            SqlCommand cmd = new SqlCommand("select Bill.id as 'ID' from Bill where table_id =  @table and date_issue = @date_issue", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@table", ele.Table_id);
            cmd.Parameters.AddWithValue("@date_issue", ele.DateIssue);
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
            SqlCommand cmd = new SqlCommand("insert into Bill(total_price, table_id, paymentMethod, takeaway) values(@total_price, @table_id, @paymentMethod, @takeaway);", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@total_price", ele.TotalPrice);
            cmd.Parameters.AddWithValue("@table_id", ele.Table_id);
            cmd.Parameters.AddWithValue("@paymentMethod", ele.PaymentMethod);
            cmd.Parameters.AddWithValue("@takeaway", ele.Takeaway? 1: 0);
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
    }
}
