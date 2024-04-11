using Omega.Business_Tier;
using Omega.Data_Tier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Presentation_Tier
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string username = this.usernameTb.Text;
            string pwd = this.pwdTb.Text;
            string name = this.nameTb.Text;
            string surname = this.surnameTb.Text;
            if (username.Equals("") || pwd.Equals("") || name.Equals("") || surname.Equals(""))
            {
                MessageBox.Show("Every field must be filled");
            }
            else
            {
                UserDAO userDAO = new UserDAO();
                //User newuser = new User(username, pwd, surname, name, role);
                //userDAO.Insert(newuser);
            }
        }
    }
}
