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
            if (!this.ssebouBtn.Tag.Equals("Selected"))
            {
                this.ssebouBtn.BackColor = Color.Red;
                this.ssebouBtn.Tag = "Selected";
            }
            else
            {
                this.ssebouBtn.BackColor = Color.PaleTurquoise;
                this.ssebouBtn.Tag = "Unselected";
            }
            
        }

        private void btnKartou_Click(object sender, EventArgs e)
        {
            if (!this.btnKartou.Tag.Equals("Selected"))
            {
                this.btnKartou.BackColor = Color.Red;
                this.btnKartou.Tag = "Selected";
            }

            else
            {
                this.btnKartou.BackColor = Color.PaleTurquoise;
                this.btnKartou.Tag = "Unselected";
            }
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            // create a bill(id, numberBill, zpusobPlatby, datum_vystaveni, vystavitel)
            int table_id = new Table().GetIdByNumber(this.table);

            string paymentMethod = btnKartou.Tag.Equals("Selected")? "Kartou" : "Hotově";
            bool takeaway = ssebouBtn.Tag.Equals("Selected")? true : false;
            /*if (btnKartou.Tag.Equals("Selected"))
            {
                paymentMethod = "Kartou";
            }*/
            /* if (ssebouBtn.Tag.Equals("Selected"))
             {
                 takeaway = true;
             }*/
            //int commaIndex = this.totalPrice.IndexOf(',');
            int price = int.Parse(this.totalPrice);
            int discount = (int)this.discount.Value;

            //create a bill
            int final_price = discount == 0 ? price : price - (price * discount / 100);
            string billDT = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Bill b = new Bill(final_price, table_id, paymentMethod, takeaway, billDT);
            b.AddToDB();

            // get all items in the order of table number x
            List<Item> items = new Table().GetOrderDetail(this.table);

            foreach (Item item in items)
            {
                b.AddBillItem(item);
            }
            new Order().DeleteOrder(this.table);
            this.Dispose();
            this.mainForm1.btnDel_Click(sender, e);
            this.mainForm1.Exit_Click(sender, e);
            BillForm bf = new BillForm(b, price, discount, final_price, this.mainForm1);
            bf.Show();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            try
            {
                //int commaIndex = this.priceLabel.Text.IndexOf(',');
                int original_price = int.Parse(this.priceLabel.Text);
                int sleva = int.Parse(this.discount.Text);

                int newprice = original_price - (original_price * sleva/100);
                this.priceLabel.Text = newprice.ToString();
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
