using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAO;
using ChapeauModel;

namespace ChapeauLogica
{
    public class OrderGerechtService
    {
        OrderGerechtDAO orderGerechtDAO;

        public OrderGerechtService()
        {
            orderGerechtDAO = new OrderGerechtDAO();
        }

        public List<OrderGerecht> GetAllOrderGerechten()
        {
            List<OrderGerecht> orderGerechten = orderGerechtDAO.GetAllOrderGerechten();
            return orderGerechten;
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


        // helaas gebruik gemaakt van int. 
        public void UpdateIsServed(OrderGerecht orderGerecht) 
        {
            orderGerechtDAO.UpdateIsServed(orderGerecht);
        }
    }
}
