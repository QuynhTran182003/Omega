using Omega.Business_Tier;
using Omega.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.Data_Tier
{
    public class TableDAO : IDAO<Table>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Table ele)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Table newEle)
        {
            throw new NotImplementedException();
        }

        public List<Table> GetListTable()
        {
            SqlCommand cmd = new SqlCommand("select * from Tabl order by CAST(number_table as int)", DatabaseSingleton.GetInstance());
            List<Table> list = new List<Table>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Table table = new Table(
                        (int)reader["id"], 
                        reader["number_table"].ToString()
                    );
                    list.Add(table);
                }
            }
            DatabaseSingleton.CloseConnection();

            return list;
        }
    }
}
