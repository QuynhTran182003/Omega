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
    public class CategoryDAO : IDAO<Category>
    {
        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Category where id = @Id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id", id);
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

        public void Insert(Category ele)
        {
            SqlCommand cmd = new SqlCommand("insert into Category([name], dph) values(@Name, @DPH);", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Name", ele.Nazev);
            cmd.Parameters.AddWithValue("@DPH", ele.DPH);
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

        public void Update(int id, Category newEle)
        {
            SqlCommand cmd = new SqlCommand("update Category set name = @name, dph = @dph where id = @id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", newEle.Nazev);
            cmd.Parameters.AddWithValue("@dph", newEle.DPH);
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
            SqlCommand cmd = new SqlCommand("select * from Category", DatabaseSingleton.GetInstance());
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

        public List<Category> GetListCategory()
        {
            SqlCommand cmd = new SqlCommand("select * from Category", DatabaseSingleton.GetInstance());
            List<Category> list = new List<Category>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Category category = new Category
                    {
                        Id = (int)reader["id"],
                        Nazev = reader["name"].ToString(),
                        DPH = (int)reader["dph"]
                    };

                    list.Add(category);
                }
            }
            DatabaseSingleton.CloseConnection();

            return list;
        }
    }
}
