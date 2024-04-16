using Omega.Business_Tier;
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
    public class UserDAO : IDAO<User>
    {
        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Users where id = @Id", DatabaseSingleton.GetInstance());
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

        public void Insert(User u)
        {
            SqlCommand cmd = new SqlCommand("insert into Users(username, pwd, [name], surname, [role]) values (@username, @pwd, @name, @surname, @role)", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@username", u.UserName);
            cmd.Parameters.AddWithValue("@pwd", u.Pwd);
            cmd.Parameters.AddWithValue("@name", u.Name);
            cmd.Parameters.AddWithValue("@surname", u.Surname);
            cmd.Parameters.AddWithValue("@role", u.Role);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully created employee.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            DatabaseSingleton.CloseConnection();
        }

        public void Update(int id, User newEle)
        {
            throw new NotImplementedException();
        }

        public User GetUserBy(string username, string pwd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select id, username, pwd, name, surname, role from Users where Users.username = @username and Users.pwd = @pwd;", DatabaseSingleton.GetInstance());
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pwd);

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                if (!reader.HasRows) return null;

               
                return new User(
                (int)reader[0],
                (string)reader[1],
                (string)reader[2],
                (string)reader[3],
                (string)reader[4],
                (string)reader[5]
                );
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                DatabaseSingleton.CloseConnection();
            }

        }

        public void GetAll(DataGridView dataView)
        {
            SqlCommand cmd = new SqlCommand("select id, username, name, surname, role from Users", DatabaseSingleton.GetInstance());
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
    }
}
