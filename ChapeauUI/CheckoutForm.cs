﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErrorHandling;
using HashingAlgorithms;
using ChapeauModel;
using ChapeauLogica;

namespace ChapeauUI
{
    public partial class CheckoutForm : Form
    {
        private int tableId;
        private decimal newTotal;
        private Employee employee;
        public CheckoutForm(int TableId, Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            tableId = TableId;
            this.Text += $" voor Tafel {tableId}";
            ShowListView();
        }
        private decimal totalPrice = 0;
        private decimal btwTotaal = 0;
        private decimal btwItem = 0;
        private decimal totalWithBtw = 0;

        private void ShowListView()
        {
            CheckoutService checkoutService = new CheckoutService();            
            
            List<Checkout> orders = checkoutService.GetOrderList(tableId);

            rekeningListView.View = View.Details;
            rekeningListView.FullRowSelect = true;
            rekeningListView.Columns.Add("Keer", 43);
            rekeningListView.Columns.Add("Naam Product", 233);
            rekeningListView.Columns.Add("Prijs", 42);

            foreach (Checkout order in orders)
            {
                ListViewItem li = new ListViewItem(order.Quantity.ToString());
                li.SubItems.Add(order.ProductName);
                li.SubItems.Add(string.Format($"{Convert.ToDecimal(order.Price):0.00}"));
                li.Tag = order;
                rekeningListView.Items.Add(li);                
                totalPrice += order.Price * order.Quantity;                

                if (order.IsAlcoholic)
                {
                    btwItem = CheckBtwHigh(order.Price);
                    btwItem = btwItem * order.Quantity;
                    btwTotaal += btwItem;
                }
                if (!order.IsAlcoholic)
                {
                    btwItem = CheckBtwLow(order.Price);
                    btwItem = btwItem * order.Quantity;
                    btwTotaal += btwItem;
                }
            }

            totalWithBtw = totalPrice + btwTotaal;
            checkoutTotalPriceLbl.Text = string.Format($"€{Convert.ToDecimal(totalWithBtw):0.00}");
        }

        private decimal CheckBtwHigh(decimal price)
        {
            return price * 0.21M;
        }
        private decimal CheckBtwLow(decimal price)
        {
            return price * 0.09M;
        }
        

        private void buttonBackToTableOverview_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
        //Dit is zonder fooikeuze. DIT GAAT NAAR BETAALMETHODE
        private void AfrekenenBtn_Click(object sender, EventArgs e)
        {            
            PaymentMethod paymentMethod = new PaymentMethod(tableId, newTotal, employee);
            paymentMethod.ShowDialog();            
        }
        //Hier is gekozen voor een fooi. DEZE GAAT NAAR PRIJSWIJZIGING
        private void HandmatigBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ManualPrice manualPrice = new ManualPrice(totalWithBtw, tableId, this.employee);
                manualPrice.ShowDialog();            
            }
            catch (Exception ex)
            {
                //Toont een foutmelding als de order niet bestaat en of geladen kan worden.
                throw new Exception("Order bestaat niet en of kan niet geladen worden. probeer het later opnieuw " + ex.Message);
            }
        }
    }
}
