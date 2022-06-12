using ChapeauDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauInterfaces;

namespace ChapeauLogica
{
    public class OrderService
    {
        private OrderDAO orderDAO;
        public OrderService()
        {
            orderDAO = new OrderDAO();
        }
        public List<Table> tables()
        {
            List<Table> tables = orderDAO.GetAllTables();
            return tables;
        }
        public void InsertNewOrder(Table TableID)
        {
            orderDAO.InsertOrder(TableID);
        }
        public Order GetCurrentOrder(Table table)
        {
            Order order = orderDAO.GetCurrentOrder(table);
            return order;
        }
       
    }
}
