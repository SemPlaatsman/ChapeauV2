using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAO;

namespace ChapeauLogica
{
    public class BarService
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

        public void ChangeNextOrderStatus(OrderGerecht orderGerecht, OrderStatus newStatus)
        {
            barDAO.ChangeNextOrderStatus(orderGerecht, newStatus);
        }

        public void ChangeServeStatusWithType(int orderId, ServeerStatus serveerStatus)
        {
            barDAO.ChangeServeStatusWithType(orderId, serveerStatus);
        }
    }
}
