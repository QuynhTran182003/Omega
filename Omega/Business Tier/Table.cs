using Omega.Data_Tier;
using Omega.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.Business_Tier
{
    public class Table : IBaseClass<Table>
    {
        private int id;
        private string number_table;
        //private string status;
        public int Id { get => id; set => id = value; }
        public string NumberTable { get => number_table; set => number_table = value; }

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
            List<Item> items = new List<Item>();
            OrderDAO orderDAO = new OrderDAO();
            items = orderDAO.GetListItems(table);
            return items;
        }

        public int GetOrderIdFrTable(int table)
        {
            int order_id;
            OrderDAO orderDAO = new OrderDAO();
            order_id= orderDAO.GetOrderId(table);
            return order_id;
        }

        public int GetIdByNumber(int numberTable)
        {
            TableDAO tableDAO = new TableDAO();
            return tableDAO.GetId(numberTable);
        }

    }
}
