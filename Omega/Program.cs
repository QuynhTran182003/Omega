using Omega.Data_Tier;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //CreateDatabase.CreateDatabaseQuery("../../Data Tier/SQLQuery1.sql");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        public static string ComputeSHA256(string input)
        {
            string hash = String.Empty;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(input + ConfigurationManager.AppSettings["passwordSalt"]));

                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }
            return hash;
        }
    }
}
