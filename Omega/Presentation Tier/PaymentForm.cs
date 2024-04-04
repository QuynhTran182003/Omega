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
    public partial class PaymentForm : Form
    {
        private string totalPrice;
        private int table;
        private MainForm mainForm1;
        public PaymentForm(string totalPrice, int table, MainForm mainForm)
        {
            InitializeComponent();
            this.totalPrice = totalPrice;
            this.table = table;
            this.priceLabel.Text = totalPrice;
            this.tableLabel.Text = "Stůl " + table.ToString();
            mainForm1 = mainForm;
        }

        private void ssebouBtn_Click(object sender, EventArgs e)
        {
            this.ssebouBtn.BackColor = Color.Red;
            this.ssebouBtn.Tag = "Selected";
        }

        private void btnKartou_Click(object sender, EventArgs e)
        {
            this.btnKartou.BackColor = Color.Red;
            this.btnKartou.Tag = "Selected";
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            // create a bill(id, numberBill, zpusobPlatby, datum_vystaveni, vystavitel)
            string paymentMethod = "Hotově";
            bool takeaway = false;
            if (btnKartou.Tag.Equals("Selected"))
            {
                paymentMethod = "Kartou";
            }
            if (ssebouBtn.Tag.Equals("Selected"))
            {
                takeaway = true;
            }
            int price = int.Parse(this.totalPrice);
            int table_id = new Table().GetIdByNumber(this.table);
            Bill b = new Bill(price, table_id, paymentMethod, takeaway, DateTime.Now);
            b.AddToDB();

            // get all items in the order of table number x
            List<Item> items = new Table().GetOrderDetail(this.table);

            foreach (Item item in items)
            {
                MessageBox.Show(item.Product_code + b.Id);
                b.AddBillItem(item);
            }
            new Order().DeleteOrder(this.table);
            this.Dispose();
            this.mainForm1.btnDel_Click(sender, e);
            this.mainForm1.Exit_Click(sender, e);
        }
    }
}
