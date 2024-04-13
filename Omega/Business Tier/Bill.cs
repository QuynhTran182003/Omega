using Omega.Data_Tier;
using Omega.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Business_Tier
{
    public class Bill : IBaseClass<Bill>
    {
        private int id;
        private int totalPrice;
        private int table_id;
        private string paymentMethod;
        private bool takeaway;
        private string date_issue;

        public int Id {
            get
            {
                BillDAO c = new BillDAO();
                return c.GetBillId(this.DateIssue);
            }
            set => id = value; }
        public int Table_id { get => table_id; set => table_id = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public bool Takeaway { get => takeaway; set => takeaway = value; }
        public string DateIssue { get => date_issue; set => date_issue = value; }

        public Bill(int id, int totalPrice, int table_id, string paymentMethod, bool takeaway, string date_issue)
        {
            Id = id;
            TotalPrice = totalPrice;
            Table_id = table_id;
            PaymentMethod = paymentMethod;
            Takeaway = takeaway;
            DateIssue = date_issue;
        }
        public Bill(int totalPrice, int table_id, string paymentMethod, bool takeaway, string date_issue)
        {
            TotalPrice = totalPrice;
            Table_id = table_id;
            PaymentMethod = paymentMethod;
            Takeaway = takeaway;
            DateIssue = date_issue;
        }

        public void AddToDB()
        {
            try
            {
                BillDAO c = new BillDAO();
                c.Insert(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddBillItem(Item i)
        {
            try
            {
                BillDAO billDAO = new BillDAO();
                billDAO.InsertItem(i, Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
