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
        private Table table;
        private TableOverviewForm overviewForm;
        private Employee employee;
        private decimal priceQuantity;
        private decimal totalPrice = 0;         
        private int numberOfPersons; //Dit is nodig voor PaymentMethod
        public CheckoutForm(Table table, Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.table = table;
            this.Text += $" voor Tafel {table.TableID}";
            ShowListView();
        }

        private void ShowListView()
        {
            CheckoutService checkoutService = new CheckoutService();            
            
            List<Checkout> orders = checkoutService.GetOrderList(table);

            rekeningListView.View = View.Details;
            rekeningListView.FullRowSelect = true;
            rekeningListView.Columns.Add("Keer", 40);
            rekeningListView.Columns.Add("Naam Product", 271);
            rekeningListView.Columns.Add("Prijs", 45);

            foreach (Checkout order in orders)
            {
                priceQuantity = order.Price * order.Quantity;
                ListViewItem li = new ListViewItem(order.Quantity.ToString());
                li.SubItems.Add(order.ProductName);
                li.SubItems.Add(string.Format($"{Convert.ToDecimal(priceQuantity):0.00}"));
                li.Tag = order;
                rekeningListView.Items.Add(li);                
                totalPrice += priceQuantity;                   
            }
            checkoutTotalPriceLbl.Text = string.Format($"€{Convert.ToDecimal(totalPrice):0.00}");
        }

        private void buttonBackToTableOverview_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableForm tableForm = new TableForm(table, overviewForm, employee);
            tableForm.ShowDialog();
            this.Close();
        }
        //Dit is zonder fooikeuze. DIT GAAT NAAR BETAALMETHODE
        private void AfrekenenBtn_Click(object sender, EventArgs e)
        {
            PaymentMethod paymentMethod = new PaymentMethod(table, totalPrice, employee, numberOfPersons, this);
            paymentMethod.Show();
        }
        //Hier is gekozen voor een fooi. DEZE GAAT NAAR PRIJSWIJZIGING
        private void HandmatigBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ManualPrice manualPrice = new ManualPrice(totalPrice, table, employee, this);
                manualPrice.Show();                
            }
            catch (Exception ex)
            {
                //Toont een foutmelding als de order niet bestaat en of geladen kan worden.
                throw new Exception("Order bestaat niet en of kan niet geladen worden. probeer het later opnieuw " + ex.Message);
            }
        }
    }
}
