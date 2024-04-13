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
            SqlCommand cmd = new SqlCommand("delete from Product where id = @Id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id", id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product deleted successfully");
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

        public int GetDPH(string code)
        {
            SqlCommand cmd = new SqlCommand("select Category.dph as 'DPH' from Product inner join Category on Product.category_id = Category.id where Product.code = @code;", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@code", code);
            int dph = 0;
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dph = (int)reader["DPH"];
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            DatabaseSingleton.CloseConnection();
            return dph;
        }
        public Product GetProductByCode(string code)
        {
            SqlCommand cmd = new SqlCommand("select Product.id, Product.code, Product.name,Category.dph as 'DPH', Product.price from Product inner join Category on Product.category_id = Category.id where Product.code = @code;", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@code", code);
            Product product = new Product();
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product.Id = (int)reader["id"];
                        product.Name = (string)reader["name"];
                        product.Code = (string)reader["code"];
                        product.Price = (int)reader["price"];
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            DatabaseSingleton.CloseConnection();
            return product;
        }
        public void Insert(Product ele)
        {
            SqlCommand cmd = new SqlCommand("insert into Product(code, [name], price, category_id) values(@Code, @Name, @Price, (select Category.id from Category where Category.name = @CategoryName));", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Code", ele.Code);
            cmd.Parameters.AddWithValue("@Name", ele.Name);
            cmd.Parameters.AddWithValue("@Price", ele.Price);
            cmd.Parameters.AddWithValue("@CategoryName", ele.Category);
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

        public void Update(int id, Product newEle)
        {
            SqlCommand cmd = new SqlCommand("update Product set code = @code, name = @name, price = @price, category_id = (select Category.id from Category where Category.name = @CategoryName) where id = @id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@code", newEle.Code);
            cmd.Parameters.AddWithValue("@name", newEle.Name);
            cmd.Parameters.AddWithValue("@price", newEle.Price);
            cmd.Parameters.AddWithValue("@CategoryName", newEle.Category);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            DatabaseSingleton.CloseConnection();
        }

        public void GetAll(DataGridView dataView)
        {
            SqlCommand cmd = new SqlCommand("select Product.id, Product.code, Product.name, Product.price, Category.name as 'category' from Product inner join Category on Product.category_id = Category.id\r\n", DatabaseSingleton.GetInstance());
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataView.DataSource = dt;

            DatabaseSingleton.CloseConnection();
        }

        public List<Product> GetListProduct(string category)
        {
            SqlCommand cmd = new SqlCommand(@"select Product.id, Product.code, Product.name, Product.price, Category.name as 'category' from Product inner join Category on Product.category_id = Category.id where Category.name = @category ", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@category", category);
            List<Product> list = new List<Product>();
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product p = new Product
                        {
                            Id = (int)reader["id"],
                            Code = reader["code"].ToString(),
                            Name = reader["name"].ToString(),
                            Price = (int)reader["price"],
                            Category = reader["category"].ToString(),
                        };

                        list.Add(p);
                    }
                }
            } 
            catch(SqlException ex)
            {
                throw ex;
            }
            
            DatabaseSingleton.CloseConnection();

            return list;
        }
    }
}
