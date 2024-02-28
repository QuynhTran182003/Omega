using Omega.Business_Tier;
using Omega.Objects;
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
    public class ProductDAO : IDAO<Product>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product ele)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Product newEle)
        {
            throw new NotImplementedException();
        }

        public void GetAll(DataGridView dataView)
        {
            SqlCommand cmd = new SqlCommand("select * from Product", DatabaseSingleton.GetInstance());
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

        public List<Product> GetListProduct()
        {
            SqlCommand cmd = new SqlCommand("select * from Product", DatabaseSingleton.GetInstance());
            List<Product> list = new List<Product>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Product p = new Product
                    {
                        Id = (int)reader["id"],
                        Code = (int)reader["code"],
                        Name = reader["name"].ToString(),
                        Price = (int)reader["price"],
                        CategoryId = (int)reader["category_id"],
                    };

                    list.Add(p);
                }
            }
            DatabaseSingleton.CloseConnection();

            return list;
        }
    }
}
