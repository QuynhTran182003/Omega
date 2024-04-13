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

        /// <summary>
        /// Method for authentication 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;
            // Check that every textbox should not contain NULL or EMPTY value
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    string hashed = Hashing.ComputeSHA256(password);
                    User u = new User().GetUser(username, hashed);

                    // if the user exists in database
                    if (u != null)
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm(this, u);
                        mainForm.ShowDialog();
                    }
                    // if the user doesnt exist in database, the user is requested to fill the credential in again
                    else
                    {
                        MessageBox.Show("Uživatel neexistuje. Prosím zkuste znovu!");
                        this.username.Text = "";
                        this.password.Text = "";
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
                MessageBox.Show("Pole nesmí být prázdné. Zadejte vhodnou hodnotu.");
            }
        }
    }
}
