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
    public partial class BillOverview : Form
    {
        private MainForm mainForm;
        public BillOverview(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
            this.labelTotal.Text = "Celkem: " + main.TotalPrice;
            this.label3.Text = $"Stůl {main.SelectedTable}";
            RenderItems(main.flowLayoutItems);
        }

        private void BillOverview_Load(object sender, EventArgs e)
        {
            this.labelTotal.Location = new Point(350, flowLayoutPanel1.Location.Y + flowLayoutPanel1.Height + 10);
            this.label2.Location = new Point(flowLayoutPanel1.Location.X, labelTotal.Location.Y + labelTotal.Size.Height + 20);
        }

        private void RenderItems(FlowLayoutPanel flowLayoutPanel)
        {
            List<ItemUC> list = flowLayoutPanel.Controls.OfType<ItemUC>().ToList();

            foreach (ItemUC itemUC in list)
            {
                itemUC.BorderStyle = BorderStyle.None;
                this.flowLayoutPanel1.Controls.Add(itemUC);
            }
        }

    }
}
