using Omega.Data_Tier;
using System;
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
            MessageBox.Show(this.dateFrom.ToString(), this.dateTo.ToString());
            string from = this.dateFrom.Value.ToString("yyyy-MM-dd");
            string to = this.dateTo.Value.ToString("yyyy-MM-dd");
            BillDAO billDAO = new BillDAO();
            billDAO.GetBills(from, to, dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
            BillDAO billDAO = new BillDAO();
            billDAO.GetBillItems(id, this.dataGridView2);
        }
    }
}
