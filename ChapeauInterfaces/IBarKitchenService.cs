using System;
using ChapeauModel;

namespace ChapeauInterfaces
{
    public interface IBarKitchenService
    {
        void ChangeOrderStatusWithType(OrderGerecht orderGerecht, OrderStatus newStatus);
        void ChangeFullOrderStatus(OrderOverview orderOverview, OrderStatus newStatus);
        void ChangeServeStatusWithType(OrderGerecht orderGerecht, ServeerStatus serveerStatus);
        void ChangeFullServeStatus(OrderOverview kitchenOrderOverview, ServeerStatus serveerStatus);
    }
}
