﻿using System;
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

            this.Hide();
            MainForm mainForm = new MainForm(this);
            mainForm.ShowDialog();
        }
    }
}
