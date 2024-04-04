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
    public partial class ListBillPanel : UserControl
    {
        public ListBillPanel()
        {
            InitializeComponent();
        }

        private void ListBillPanel_Load(object sender, EventArgs e)
        {
            BillDAO billDAO = new BillDAO();
            billDAO.GetAll(this.dataGridView1);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
