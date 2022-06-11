using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ChapeauModel
{
    public class KitchenOrderOverview : OrderOverview
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
                case TypeOfProduct.Voorgerecht:
                    Voorgerechten.Add(orderGerecht);
                    break;
                case TypeOfProduct.Tussengerecht:
                    Tussengerechten.Add(orderGerecht);
                    break;
                case TypeOfProduct.Hoofdgerecht:
                    Hoofdgerechten.Add(orderGerecht);
                    break;
                case TypeOfProduct.Nagerecht:
                    Nagerechten.Add(orderGerecht);
                    break;
                default:
                    throw new Exception($"An attempt was made to add an OrderGerecht with the type {orderGerecht.MenuItem.Type} to a {this.GetType().Name} which is not possible!");
            }
        }

        public List<OrderGerecht> GetNextMoetNogList()
        {
            if (Voorgerechten.Count != 0 && !ListHasMeeBezig(Voorgerechten) && !ListOnlyHasStatus(Voorgerechten, OrderStatus.Klaar))
            {
                return Voorgerechten;
            }
            else if (Tussengerechten.Count != 0 && !ListHasMeeBezig(Tussengerechten) && !ListOnlyHasStatus(Tussengerechten, OrderStatus.Klaar))
            {
                return Tussengerechten;
            }
            else if (Hoofdgerechten.Count != 0 && !ListHasMeeBezig(Hoofdgerechten) && !ListOnlyHasStatus(Hoofdgerechten, OrderStatus.Klaar))
            {
                return Hoofdgerechten;
            }
            else if (Nagerechten.Count != 0 && !ListHasMeeBezig(Nagerechten) && !ListOnlyHasStatus(Nagerechten, OrderStatus.Klaar))
            {
                return Nagerechten;
            }
            return new List<OrderGerecht>();
        }

        public List<OrderGerecht> GetNextMeeBezigList()
        {
            if (Voorgerechten.Count != 0 && ListHasMeeBezig(Voorgerechten))
            {
                return Voorgerechten;
            }
            else if (Tussengerechten.Count != 0 && ListHasMeeBezig(Tussengerechten))
            {
                return Tussengerechten;
            }
            else if (Hoofdgerechten.Count != 0 && ListHasMeeBezig(Hoofdgerechten))
            {
                return Hoofdgerechten;
            }
            else if (Nagerechten.Count != 0 && ListHasMeeBezig(Nagerechten))
            {
                return Nagerechten;
            }
            return new List<OrderGerecht>();
        }

        public List<OrderGerecht> GetNextKlaarList()
        {
            if (Voorgerechten.Count != 0 && ListOnlyHasStatus(Voorgerechten, OrderStatus.Klaar))
            {
                return Voorgerechten;
            }
            else if (Tussengerechten.Count != 0 && ListOnlyHasStatus(Tussengerechten, OrderStatus.Klaar))
            {
                return Tussengerechten;
            }
            else if (Hoofdgerechten.Count != 0 && ListOnlyHasStatus(Hoofdgerechten, OrderStatus.Klaar))
            {
                return Hoofdgerechten;
            }
            else if (Nagerechten.Count != 0 && ListOnlyHasStatus(Nagerechten, OrderStatus.Klaar))
            {
                return Nagerechten;
            }
            return new List<OrderGerecht>();
        }

        public override List<OrderGerecht> GetCombinedGerechten()
        {
            List<OrderGerecht> gerechten = new List<OrderGerecht>();
            gerechten.AddRange(this.Voorgerechten);
            gerechten.AddRange(this.Tussengerechten);
            gerechten.AddRange(this.Hoofdgerechten);
            gerechten.AddRange(this.Nagerechten);
            return gerechten;
        }

        public List<OrderGerecht> TypeToList(TypeOfProduct type)
        {
            switch (type)
            {
                case TypeOfProduct.Voorgerecht:
                    return Voorgerechten;
                case TypeOfProduct.Tussengerecht:
                    return Tussengerechten;
                case TypeOfProduct.Hoofdgerecht:
                    return Hoofdgerechten;
                case TypeOfProduct.Nagerecht:
                    return Nagerechten;
                default:
                    return new List<OrderGerecht>();
            }
        }

        public string ToStringOverzicht()
        {
            return $"Voorgerechten: {(Voorgerechten.Count != 0 ? Regex.Replace($"{Voorgerechten[0].IsServed}", "([A-Z])", " $1").Trim() : "Geen Menu Items")}\n" +
                $"Tussengerechten: {(Tussengerechten.Count != 0 ? Regex.Replace($"{Tussengerechten[0].IsServed}", "([A-Z])", " $1").Trim() : "Geen Menu Items")}\n" +
                $"Hoofdgerechten: {(Hoofdgerechten.Count != 0 ? Regex.Replace($"{Hoofdgerechten[0].IsServed}", "([A-Z])", " $1").Trim() : "Geen Menu Items")}\n" +
                $"Nagerechten: {(Nagerechten.Count != 0 ? Regex.Replace($"{Nagerechten[0].IsServed}", "([A-Z])", " $1").Trim() : "Geen Menu Items")}";
        }
    }
}
