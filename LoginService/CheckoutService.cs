﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAO;
using ChapeauInterfaces;

namespace ChapeauLogica
{
    public class CheckoutService
    {
        private CheckoutDAO checkoutDAO;

        public CheckoutService()
        {
            checkoutDAO = new CheckoutDAO();
        }

        public List<Checkout> GetOrderList(Table TableId)
        {
            List<Checkout> orders = checkoutDAO.Order(TableId);
            return orders;
        }
    }
}
