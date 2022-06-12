using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAO;

namespace ChapeauLogica
{
    public class BarService : IBarKitchenService
    {
        private BarDAO barDAO;

        public BarService()
        {
            barDAO = new BarDAO();
        }

        public List<BarOrderOverview> GetBarOverviews()
        {
            return barDAO.GetBarOverviews();
        }

        public BarOrderOverview GetBarOverview(int orderId)
        {
            return barDAO.GetBarOverview(orderId);
        }

        public void ChangeOrderStatusWithType(OrderGerecht orderGerecht, OrderStatus newStatus)
        {
            barDAO.ChangeOrderStatusWithType(orderGerecht, newStatus);
        }

        public void ChangeServeStatusWithType(OrderGerecht orderGerecht, ServeerStatus serveerStatus)
        {
            barDAO.ChangeServeStatusWithType(orderGerecht, serveerStatus);
        }

        public void ChangeFullOrderStatus(OrderOverview barOrderOverview, OrderStatus newStatus)
        {
            barDAO.ChangeFullOrderStatus(barOrderOverview, newStatus);
        }

        public void ChangeFullServeStatus(OrderOverview barOrderOverview, ServeerStatus serveerStatus)
        {
            barDAO.ChangeFullServeStatus(barOrderOverview, serveerStatus);
        }
    }
}
