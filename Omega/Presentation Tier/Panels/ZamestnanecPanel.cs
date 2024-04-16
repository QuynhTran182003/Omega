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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());

                string username = dataGridView1.Rows[e.RowIndex].Cells["username"].FormattedValue.ToString();
                if (MessageBox.Show($"Are u sure to delete employee {id} {username}?", "Delete User", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    {
                        //int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
                        new User().DeleteUser(id);
                        this.ZamestnanecPanel_Load(sender, e);
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit zamestnance
        }
    }
}
