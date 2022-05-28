using ChapeauDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;

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
        public void AlterTables(Table tableId)
        {
            orderDAO.AlterTables(tableId);
        }
        public List<CurrentOrderItem> GetCurrentOrderItems(Table table)
        {
            List<CurrentOrderItem> orderItems = orderDAO.GetCurrentOrder(table);
            return orderItems;
        }
    }
}
