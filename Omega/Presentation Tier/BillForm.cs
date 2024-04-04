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

namespace Omega.Presentation_Tier
{
    public partial class BillForm : Form
    {
        private Bill b;
        public BillForm(Bill b)
        {
            InitializeComponent();
            this.b = b;
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            this.doklad.Text = this.b.Id.ToString();
            this.vystaveni.Text = this.b.DateIssue.ToString();
            this.zpusob.Text = this.b.PaymentMethod.ToString();
        }
        // todo
        private void GetBillItem(Bill b)
        {

        }
    }
}
