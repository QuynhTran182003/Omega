using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.Data_Tier
{
    public class CreateDatabase
    {
        /// <summary>
        /// Creates database with all entities
        /// </summary>
        /// <param name="path">Path where is your sql query</param>
        /// <returns>True if success</returns>
        public static bool CreateDatabaseQuery(string path)
        {

            string query = File.ReadAllText(path);
            Console.WriteLine(query);
            SqlConnection conn = DatabaseSingleton.GetInstance();

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                    DatabaseSingleton.CloseConnection();
                    return true;
                }
            }
            catch (Exception)
            {
                DatabaseSingleton.CloseConnection();
                return false;
            }
        }
    }
}
