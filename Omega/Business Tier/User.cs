using Omega.Data_Tier;
using Omega.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Business_Tier
{
    public class User : IBaseClass<User>
    {
        private int id;
        private string username;
        private string pwd;
        private string name;
        private string surname;
        private string role;
        public int Id { get => id; set => id = value; }
        public string UserName { get => username; set => username = value; }

        public string Pwd { get => pwd; set => pwd = value; }
        public string Surname { get => surname; set => surname = value; }

        public string Name { get => name; set => name = value; }

        public string Role { get => role; set => role = value; }


        public User(int id, string userName, string pwd, string surname, string name, string role)
        {
            Id = id;
            UserName = userName;
            Pwd = pwd;
            Surname = surname;
            Name = name;
            Role = role;
        }

        public User(string userName, string pwd, string surname, string name, string role)
        {
            UserName = userName;
            Pwd = pwd;
            Surname = surname;
            Name = name;
            Role = role;
        }

        public User() { }


        public User GetUser(string username, string pwd)
        {
            User user1 = new User();
            UserDAO userDAO = new UserDAO();
            user1 = userDAO.GetUserBy(username, pwd);
            return user1;
        }
    }
}
