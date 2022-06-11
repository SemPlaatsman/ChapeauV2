﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public abstract class OrderOverview : Order
    {
        public static bool ListHasMeeBezig(List<OrderGerecht> orders)
        {
            foreach (OrderGerecht orderGerecht in orders)
            {
                if (orderGerecht.Status == OrderStatus.MeeBezig)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ListOnlyHasStatus(List<OrderGerecht> orders, OrderStatus orderStatus)
        {
            foreach (OrderGerecht orderGerecht in orders)
            {
                if (orderGerecht.Status != orderStatus)
                {
                    return false;
                }
            }
            return true;
        }

        //public static bool ListIsMixed(List<OrderGerecht> orders)
        //{
        //    foreach (OrderStatus orderStatus in Enum.GetValues(typeof(OrderStatus)))
        //    {
        //        if (ListOnlyHasStatus(orders, orderStatus))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        public abstract List<OrderGerecht> GetCombinedGerechten();
    }
}
