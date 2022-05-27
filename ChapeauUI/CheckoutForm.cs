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
        private Table tableId;
        private decimal newTotal;
        private Employee employee;
        public CheckoutForm(Table TableId, Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.tableId = TableId;
            this.Text += $" voor Tafel {tableId}";
            ShowListView();
        }
        private decimal totalPrice = 0;        
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
            }
            checkoutTotalPriceLbl.Text = string.Format($"€{Convert.ToDecimal(totalPrice):0.00}");
        }

        private void buttonBackToTableOverview_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
        //Dit is zonder fooikeuze. DIT GAAT NAAR BETAALMETHODE
        private void AfrekenenBtn_Click(object sender, EventArgs e)
        {            
            PaymentMethod paymentMethod = new PaymentMethod(this.tableId, newTotal, employee);
            paymentMethod.ShowDialog();            
        }
        //Hier is gekozen voor een fooi. DEZE GAAT NAAR PRIJSWIJZIGING
        private void HandmatigBtn_Click(object sender, EventArgs e)
        {
            try
            {

                ManualPrice manualPrice = new ManualPrice(totalWithBtw, this.tableId, this.employee);

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
