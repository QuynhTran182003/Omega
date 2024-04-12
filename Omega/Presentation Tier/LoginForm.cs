using Omega.Business_Tier;
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
                try
                {
                    string hashed = Hashing.ComputeSHA256(password);
                    User u = new User().GetUser(username, hashed);
                    MessageBox.Show(hashed);
                    if (u != null)
                    {
                        this.Hide();
                        MessageBox.Show($"{u.Name} {u.Role}");
                        MainForm mainForm = new MainForm(this, u);
                        mainForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please try again");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fields cant be empty");
            }
        }
    }
}
