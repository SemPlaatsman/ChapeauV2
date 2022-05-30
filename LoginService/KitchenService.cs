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


        public KitchenOrderOverview ReadyToServe(OrderGerecht orderGerecht) 
        {
            return kitchenDAO.ReadyToServe(orderGerecht);
        }
        public void ChangeNextOrderStatus(OrderGerecht orderGerecht, OrderStatus newStatus)
        {
            kitchenDAO.ChangeNextOrderStatus(orderGerecht, newStatus);

        }
    }
}
