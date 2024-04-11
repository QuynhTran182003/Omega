﻿using Omega.Business_Tier;
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
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(User ele)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, User newEle)
        {
            throw new NotImplementedException();
        }

        public User GetUserBy(string username, string pwd)
        {
            SqlCommand cmd = new SqlCommand("select * from Users where Users.username = @username and Users.pwd = @pwd;", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            User user = new User();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    user.Id = (int)reader["id"];
                    user.UserName = reader["username"].ToString();
                    user.Pwd = (string)reader["pwd"].ToString();
                    user.Name = (string)reader["name"].ToString();
                    user.Surname = (string)reader["surname"].ToString();
                    user.Role = (string)reader["role"].ToString();
                }
            }
            DatabaseSingleton.CloseConnection();
            return user;
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
