using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class KitchenOrderOverview : Order
    {
        public List<OrderGerecht> Voorgerechten;
        public List<OrderGerecht> Tussengerechten;
        public List<OrderGerecht> Hoofdgerechten;
        public List<OrderGerecht> Nagerechten;

        public KitchenOrderOverview()
        {
            Voorgerechten = new List<OrderGerecht>();
            Tussengerechten = new List<OrderGerecht>();
            Hoofdgerechten = new List<OrderGerecht>();
            Nagerechten = new List<OrderGerecht>();
        }

        public void Add(OrderGerecht orderGerecht)
        {
            switch (orderGerecht.MenuItem.Type)
            {
                case "Voorgerecht":
                    Voorgerechten.Add(orderGerecht);
                    break;
                case "Tussengerecht":
                    Tussengerechten.Add(orderGerecht);
                    break;
                case "Hoofdgerecht":
                    Hoofdgerechten.Add(orderGerecht);
                    break;
                case "Nagerecht":
                    Nagerechten.Add(orderGerecht);
                    break;
                default:
                    throw new Exception($"An attempts was made to add a OrderGerecht with the type {orderGerecht.MenuItem.Type} to a {this.GetType().Name} which is not possible!");
            }
        }
    }
}
