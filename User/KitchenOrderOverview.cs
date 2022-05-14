using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class KitchenOrderOverview
    {
        public Order Order;
        public List<OrderGerecht> Voorgerechten;
        public List<OrderGerecht> Tussengerechten;
        public List<OrderGerecht> Hoofdgerechten;
        public List<OrderGerecht> Nagerechten;
    }
}
