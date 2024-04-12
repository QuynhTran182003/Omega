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

namespace Omega.Presentation_Tier.Panels
{
    public partial class ZamestnanecPanel : UserControl
    {
        public ZamestnanecPanel()
        {
            InitializeComponent();
            
        }

        public void ZamestnanecPanel_Load(object sender, EventArgs e)
        {
            UserDAO empDAO = new UserDAO();
            empDAO.GetAll(this.dataGridView1);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            NewUserForm nuf = new NewUserForm(this);
            nuf.Show();
        }
    }
}
