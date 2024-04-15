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
        public BillForm(Bill b, int price, int discount, int final_price, MainForm mainForm)
        {
            InitializeComponent();
            this.b = b;
            this.mainForm = mainForm;
            this.label1.Text = "Shiba Sushi Fusion Asian";
            this.label2.Text = "Budějovická 371 Jesenice Praha - Západ 252 42";
            this.label3.Text = "ICO: 11774932";
            this.label4.Text = "DIC: CZ11774932";
            this.label5.Text = "Doklad Cislo";
            this.label6.Text = "Zpusob platby";
            this.label7.Text = "Datum vystaveni";
            this.label13.Text = "Děkujeme a těšíme se na další návštěvu";
            this.label14.Text = "Nazev";
            this.label15.Text = "Cena";
            this.label16.Text = "DPH";
            this.label17.Text = "Mnozstvi";
            this.label18.Text = "Součet";
            this.label19.Text = "HAISHIBA s.r.o";
            this.label20.Text = "Květnového vítězství 1339/5 - Chodov - Praha 11";
            this.labelVystavil.Text = "Vystavil";
            this.label25.Text = "S sebou";
            this.label9.Text = "Stůl";

            this.stul.Text = b.Table_id.ToString();
            this.sum.Text = discount > 0 ? $"Součet: {price},- Kč" : "";
            this.sleva.Text = discount > 0? $"Sleva: {discount}%: {price - final_price},- Kč" : "";
            this.labelTotal.Text =  $"Celkem: {final_price},- Kč";
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            this.doklad.Text = this.b.Id.ToString();
            this.vystaveni.Text = this.b.DateIssue.ToString();
            this.vystavil.Text = this.mainForm.LoggedInUser.Surname;
            this.zpusob.Text = this.b.PaymentMethod.ToString();
            this.ssebou.Text = this.b.Takeaway == true ? "Ano" : "Ne";
            RenderItems(this.b);
            this.sum.Location = new Point(350, flowLayoutPanel1.Location.Y + flowLayoutPanel1.Height + 20);
            this.sleva.Location = new Point(350, sum.Location.Y + sum.Height + 15);
            this.labelTotal.Location = new Point(350, sleva.Location.Y + sleva.Size.Height + 15);
            this.label13.Location = new Point(150, labelTotal.Location.Y + labelTotal.Size.Height + 30);
        }
        // todo
        private void RenderItems(Bill b)
        {
            BillDAO billDAO = new BillDAO();
            List<BillItem> list = billDAO.GetBillItems(b.Id);

            foreach(BillItem item in list)
            {
                BillItemUC biUC = new BillItemUC(item.Name, item.Price, item.Quantity, item.Dph, item.Celkem);
                this.flowLayoutPanel1.Controls.Add(biUC);
            }
        }
    }
}
