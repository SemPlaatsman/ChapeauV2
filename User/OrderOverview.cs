using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public abstract class OrderOverview : Order
    {
        public static bool ListHasMeeBezig(List<OrderGerecht> gerechten)
        {
            foreach (OrderGerecht gerecht in gerechten)
            {
                if (gerecht.Status == OrderStatus.MeeBezig)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ListCompleted(List<OrderGerecht> gerechten)
        {
            foreach (OrderGerecht gerecht in gerechten)
            {
                if (gerecht.Status != OrderStatus.Klaar)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
