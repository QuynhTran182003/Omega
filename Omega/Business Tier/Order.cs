﻿using Omega.Data_Tier;
using Omega.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Business_Tier
{
    public class Order : IBaseClass<Order>
    {
        private int id;
        private int table;
        private DateTime date_order;

        public int Id { 
            get
            {
                OrderDAO c = new OrderDAO();
                return c.GetOrderId(this.Table);
            }
            set => id = value; 
        }
        public int Table { get => table; set => table = value; }

        public DateTime DateOrder { get => date_order; set => date_order = value; }


        public Order(int table, DateTime dateOrder)
        {
            Table = table;
            DateOrder = dateOrder;
        }
        public Order(){}

        public Order(int id, int table, DateTime dateOrder)
        {
            Id = id;
            Table = table;
            DateOrder = dateOrder;
        }

        public void AddToDB()
        {
            try
            {
                OrderDAO c = new OrderDAO();
                c.Insert(this);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Item> GetItems(int orderId)
        {
            try
            {
                ItemDAO itemDAO = new ItemDAO();
                return itemDAO.GetListItems(orderId);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void DeleteOrder(int numberTable)
        {
            try
            {
                OrderDAO orderDAO = new OrderDAO();
                orderDAO.Delete(numberTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
