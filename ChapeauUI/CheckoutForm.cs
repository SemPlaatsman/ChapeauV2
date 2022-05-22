using System;
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
        public CheckoutForm(int TableId)
        {
            InitializeComponent();
            tableId = TableId;
            this.Text += $" for Table {tableId}";
            ShowListView();
        }
        public decimal totalPrice = 0;

        private void ShowListView()
        {
            CheckoutService checkoutService = new CheckoutService();            
            
            List<Checkout> orders = checkoutService.GetOrderList(tableId);

            rekeningListView.View = View.Details;
            rekeningListView.FullRowSelect = true;
            rekeningListView.Columns.Add("ProductName", 254);
            rekeningListView.Columns.Add("Price", 64);

            foreach (Checkout order in orders)
            {
                ListViewItem li = new ListViewItem(order.ProductName);
                li.SubItems.Add(string.Format("{0:#,##0.00}", Convert.ToDecimal(order.Price)));
                li.Tag = order;
                rekeningListView.Items.Add(li);
                totalPrice += order.Price;
            }
            checkoutTotalPriceLbl.Text = $"€{totalPrice.ToString()}";
        }

        //private void listViewNames_Click(object sender, EventArgs e)
        //{
        //    Checkout checkout = (checkout)(rekeningListView.SelectedItems[0].Tag);
        //    textBoxLoginWerknemerNummer.Text = checkout.ProductName.ToString();
        //}

        private void buttonBackToTableOverview_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
        //Dit is zonder fooikeuze. DIT GAAT NAAR BETAALMETHODE
        private void AfrekenenBtn_Click(object sender, EventArgs e)
        {            
            PaymentMethod paymentMethod = new PaymentMethod(tableId, newTotal);
            paymentMethod.ShowDialog();            
        }
        //Hier is gekozen voor een fooi. DEZE GAAT NAAR PRIJSWIJZIGING
        private void HandmatigBtn_Click(object sender, EventArgs e)
        {            
            ManualPrice manualPrice = new ManualPrice(totalPrice, tableId);
            manualPrice.ShowDialog();            
        }
    }
}
