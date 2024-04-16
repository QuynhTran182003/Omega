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
    public class Table : IBaseClass<Table>
    {
        private int id;
        private string number_table;
        private string status;
        public int Id { get => id; set => id = value; }
        public string NumberTable { get => number_table; set => number_table = value; }

        public string Status { get => status; set => status = value; }

        public Table(int id, string numberTabl, string status)
        {
            Id = id;
            NumberTable = numberTabl;
            Status = status;
        }
        public Table(int id, string numberTabl)
        {
            Id = id;
            NumberTable = numberTabl;
        }

        public Table()
        {
        }

        public List<Item> GetOrderDetail(int table)
        {
            try
            {
                List<Item> items = new List<Item>();
                OrderDAO orderDAO = new OrderDAO();
                items = orderDAO.GetListItems(table);
                return items;
            }
            catch
            {
                MessageBox.Show("Error při získání položky objednávky");
                return null;
            }
            
        }

        public int GetOrderIdFrTable(int table)
        {
            try
            {
                int order_id;
                OrderDAO orderDAO = new OrderDAO();
                order_id = orderDAO.GetOrderId(table);
                return order_id;
            }
            catch
            {
                MessageBox.Show("Error při získání order_id na základě stolu");
                return 0;
            }
            
        }

        public int GetIdByNumber(int numberTable)
        {
            try
            {
                TableDAO tableDAO = new TableDAO();
                return tableDAO.GetId(numberTable);
            }
            catch
            {
                MessageBox.Show("Error při získání tableId na základě stolu");
                return 0;
            }
            
        }

    }
}
