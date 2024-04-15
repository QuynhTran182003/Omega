using Omega.Business_Tier;
using Omega.Data_Tier;
using Omega.Presentation_Tier.Panels;
using Omega.vendor;
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
        private ZamestnanecPanel panel;
        public NewUserForm(ZamestnanecPanel zamestnanecPanel)
        {
            InitializeComponent();
            this.panel = zamestnanecPanel;

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
            if(this.jePokladnik.Checked == false && this.jeSpravce.Checked == false)
            {
                MessageBox.Show("Prosim vyberte roli pro zamestnance");
            }

            string role = this.jeSpravce.Checked ? "admin" : "pokladnik";
            string hashedPwd = Hashing.ComputeSHA256(pwd);
            UserDAO userDAO = new UserDAO();
            User newuser = new User(username, hashedPwd, surname, name, role);
            userDAO.Insert(newuser);
            this.Hide();
            this.panel.ZamestnanecPanel_Load(sender, e);
        }
    }
}
