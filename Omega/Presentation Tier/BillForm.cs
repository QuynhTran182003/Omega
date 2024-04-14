using Omega.Business_Tier;
using Omega.Data_Tier;
using Omega.Presentation_Tier.UserControls;
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
    public partial class BillForm : Form
    {
        private Bill b;
        private MainForm mainForm;
        public BillForm(Bill b, int price, MainForm mainForm)
        {
            InitializeComponent();
            this.b = b;
            this.mainForm = mainForm;
            this.celkem.Text = price + ",- Kč";

        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            this.doklad.Text = this.b.Id.ToString();
            this.vystaveni.Text = this.b.DateIssue.ToString();
            this.vystavil.Text = this.mainForm.LoggedInUser.Surname;
            this.zpusob.Text = this.b.PaymentMethod.ToString();
            this.ssebou.Text = this.b.Takeaway == true ? "Ano" : "Ne";
            RenderItems(this.b);
        }
        // todo
        private void RenderItems(Bill b)
        {
            BillDAO billDAO = new BillDAO();
            List<BillItem> list = billDAO.GetBillItems(b.Id);

            foreach(BillItem item in list)
            {
                BillItemUC biUC = new BillItemUC(item.Name, item.Price, item.Dph, item.Quantity, item.Celkem);
                this.flowLayoutPanel1.Controls.Add(biUC);
            }
        }
    }
}
