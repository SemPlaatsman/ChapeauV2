﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class BarOrderOverview : OrderOverview
    {
        public List<OrderGerecht> Drinken;

        public BarOrderOverview()
        {
            Drinken = new List<OrderGerecht>();
        }

        public override void Add(OrderGerecht orderGerecht)
        {
            if (orderGerecht.MenuItem.Type == TypeOfProduct.Drinken)
                Drinken.Add(orderGerecht);
            else
                throw new Exception($"An attempts was made to add a OrderGerecht with the type {orderGerecht.MenuItem.Type} to a {this.GetType().Name} which is not possible!");
        }

        public List<OrderGerecht> GetNextMoetNogList()
        {
            if (Drinken.Count != 0 && !ListHasMeeBezig(Drinken) && !ListOnlyHasStatus(Drinken, OrderStatus.Klaar))
            {
                return Drinken;
            }
            return new List<OrderGerecht>();
        }

        public List<OrderGerecht> GetNextMeeBezigList()
        {
            if (Drinken.Count != 0 && ListHasMeeBezig(Drinken))
            {
                return Drinken;
            }
            return new List<OrderGerecht>();
        }

        public override List<OrderGerecht> GetCombinedGerechten()
        {
            return Drinken;
        }

        public override List<OrderGerecht> TypeToList(TypeOfProduct type)
        {
            if (type == TypeOfProduct.Drinken)
            {
                return Drinken;
            }
            return new List<OrderGerecht>();
        }
    }
}
