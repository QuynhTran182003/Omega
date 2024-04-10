using Omega.Business_Tier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void prihlasitSe_Click(object sender, EventArgs e)
        {
            /*Implement method for authentication*/

            string username = this.username.Text;
            string password = this.password.Text;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                User u = new User().GetUser(username, password);
                MessageBox.Show(u.Role);
                if (u != null)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm(this, u);
                    mainForm.ShowDialog();
                }

            }
            
        }
    }
}
