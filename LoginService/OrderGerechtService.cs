﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAO;
using ChapeauModel;
using ChapeauInterfaces;

namespace ChapeauLogica
{
    public class OrderGerechtService
    {
        OrderGerechtDAO orderGerechtDAO;

        public OrderGerechtService()
        {
            orderGerechtDAO = new OrderGerechtDAO();
        }

        public void ChangeOrderGerechtStatus(OrderGerecht orderGerecht, OrderStatus newStatus)
        {
            orderGerechtDAO.ChangeStatus(orderGerecht, newStatus);
        }

        public void InsertOrderGerecht(OrderGerecht orderGerecht)
        {
            orderGerechtDAO.InsertOrderGerecht(orderGerecht);
        }

        public List<OrderGerecht> GetCurrentOrderGerechten(Order order) 
        {
            List<OrderGerecht> orderGerecht = orderGerechtDAO.GetCurrentOrderGerechten(order);
            return orderGerecht;
        }

        public List<OrderGerecht> GetOrdersByTableId(Table table) 
        {
            List<OrderGerecht> orderGerecht = orderGerechtDAO.GetOrdersByTableId(table);
            return orderGerecht;
        }

        public void UpdateIsServed(Order order) 
        {
            orderGerechtDAO.UpdateIsServed(order);
        }
    }
}
