using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAO;

namespace ChapeauLogica
{
    public class KitchenService
    {
        private KitchenDAO kitchenDAO;

        public KitchenService()
        {
            kitchenDAO = new KitchenDAO();
        }

        public List<KitchenOrderOverview> GetKitchenOverviews()
        {
            return kitchenDAO.GetKitchenOverviews();
        }

        public KitchenOrderOverview GetKitchenOverview(int orderId)
        {
            return kitchenDAO.GetKitchenOverview(orderId);
        }

        public KitchenOrderOverview GetKitchenOverviewWithTableId(int tableId)
        {
            return kitchenDAO.GetKitchenOverviewWithTableId(tableId);
        }

        public KitchenOrderOverview ReadyToServe(OrderGerecht orderGerecht) 
        {
            return kitchenDAO.ReadyToServe(orderGerecht);
        }

        public void ChangeNextOrderStatus(OrderGerecht orderGerecht, OrderStatus newStatus)
        {
            kitchenDAO.ChangeNextOrderStatus(orderGerecht, newStatus);
        }

        public void ChangeServeStatusWithType(int orderId, TypeOfProduct type, ServeerStatus serveerStatus)
        {
            kitchenDAO.ChangeServeStatusWithType(orderId, type, serveerStatus);
        }
    }
}
