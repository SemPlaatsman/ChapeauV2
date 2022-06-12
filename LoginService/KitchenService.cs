using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAO;
using ChapeauInterfaces;

namespace ChapeauLogica
{
    public class KitchenService : IBarKitchenService
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

/*        public KitchenOrderOverview ReadyToServe(OrderGerecht orderGerecht) 
        {
            return kitchenDAO.ReadyToServe(orderGerecht);
        }*/

        public void ChangeOrderStatusWithType(OrderGerecht orderGerecht, OrderStatus newStatus)
        {
            kitchenDAO.ChangeOrderStatusWithType(orderGerecht, newStatus);
        }

        public void ChangeServeStatusWithType(OrderGerecht orderGerecht, ServeerStatus serveerStatus)
        {
            kitchenDAO.ChangeServeStatusWithType(orderGerecht, serveerStatus);
        }

        public void ChangeFullOrderStatus(OrderOverview kitchenOrderOverview, OrderStatus newStatus)
        {
            kitchenDAO.ChangeFullOrderStatus(kitchenOrderOverview, newStatus);
        }

        public void ChangeFullServeStatus(OrderOverview kitchenOrderOverview, ServeerStatus serveerStatus)
        {
            kitchenDAO.ChangeFullServeStatus(kitchenOrderOverview, serveerStatus);
        }
    }
}
