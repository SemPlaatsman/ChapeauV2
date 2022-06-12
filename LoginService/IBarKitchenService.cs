using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAO;

namespace ChapeauLogica
{
    public interface IBarKitchenService
    {
        void ChangeOrderStatusWithType(OrderGerecht orderGerecht, OrderStatus newStatus);
        void ChangeFullOrderStatus(OrderOverview orderOverview, OrderStatus newStatus);
        void ChangeServeStatusWithType(OrderGerecht orderGerecht, ServeerStatus serveerStatus);
        void ChangeFullServeStatus(OrderOverview kitchenOrderOverview, ServeerStatus serveerStatus);
    }
}
