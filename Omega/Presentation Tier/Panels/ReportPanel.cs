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
    public partial class ReportPanel : UserControl
    {
        public ReportPanel()
        {
            InitializeComponent();
        }

        public void ReportPanel_Load(object sender, EventArgs e)
        {
            this.datum.Text = DateTime.Today.ToShortDateString();
            BillDAO billDAO = new BillDAO();
            this.prijem.Text = billDAO.GetTotalAllBills().ToString();
            this.hotove.Text = billDAO.GetCashAllBills().ToString();
            this.kartou.Text = billDAO.GetCardsAllBills().ToString();
        }

        
    }
}
