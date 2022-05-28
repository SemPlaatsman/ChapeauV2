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
        public void InsertOrderGerecht(OrderGerecht orderGerecht)
        {
            orderGerechtDAO.InsertOrderGerecht(orderGerecht);
        }
    }
}
