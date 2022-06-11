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
    public partial class PaymentMethod : Form
    {
        private Table table;
        private Employee employee;
        private decimal newTotal;
        private int numberOfPersons;
        private decimal pricePerPerson;
        private bool partialPayment = false;
        private decimal partialSum;
        private decimal remainingSum;
        public PaymentMethod(Table table, decimal NewTotal, Employee employee, int numberOfPersons)
        {
            InitializeComponent();
            this.table = table;
            newTotal = NewTotal;
            this.employee = employee;
            this.numberOfPersons = numberOfPersons;
            DisplayPrice();
        }

        private void DisplayPrice()
        {
            if (numberOfPersons != 0)
            {
                pricePerPerson = newTotal / numberOfPersons;
                labelPrice.Text = string.Format($"Totaal bedrag: €{Convert.ToDecimal(pricePerPerson):0.00}");
            }
            else
            {
                labelPrice.Text = string.Format($"Totaal bedrag: €{Convert.ToDecimal(newTotal):0.00}");
            }
            
        }
        private string paymentMethod;
        
        private void AnnulerenBtn_Click(object sender, EventArgs e)
        {            
            this.Hide();
            CheckoutForm checkoutForm = new CheckoutForm(table, employee);
            checkoutForm.ShowDialog();
            this.Close();
        }

        private void ContantBtn_Click(object sender, EventArgs e)
        {
            paymentMethod += "Contant ";
            if (string.IsNullOrEmpty(textBoxPartialPayment.Text) || partialPayment == true)
            {
                this.Hide();
                ReceiptForm receiptForm = new ReceiptForm(paymentMethod, table, newTotal, this.employee, numberOfPersons);
                receiptForm.ShowDialog();
                this.Close();
            }
            else
            {
                partialSum = decimal.Parse(textBoxPartialPayment.Text);
                labelPartialPayment.Text = "Deelbetaling verwerkt.";
                remainingSum = newTotal - partialSum;
                labelPrice.Text = string.Format($"Rest bedrag: €{Convert.ToDecimal(remainingSum):0.00}");
                partialPayment = true;
            }
        }

        private void PinBtn_Click(object sender, EventArgs e)
        {
            paymentMethod += "Pin ";
            if (string.IsNullOrEmpty(textBoxPartialPayment.Text) || partialPayment == true)
            {
                this.Hide();
                ReceiptForm receiptForm = new ReceiptForm(paymentMethod, table, newTotal, this.employee, numberOfPersons);
                receiptForm.ShowDialog();
                this.Close();
            }
            else
            {
                partialSum = decimal.Parse(textBoxPartialPayment.Text);
                labelPartialPayment.Text = "Deelbetaling verwerkt.";
                remainingSum = newTotal - partialSum;
                labelPrice.Text = string.Format($"Rest bedrag: €{Convert.ToDecimal(remainingSum):0.00}");
                partialPayment = true;
            }
        }

        private void CreditCardBtn_Click(object sender, EventArgs e)
        {
            paymentMethod += "CreditCard ";
            if (string.IsNullOrEmpty(textBoxPartialPayment.Text) || partialPayment == true)
            {
                this.Hide();
                ReceiptForm receiptForm = new ReceiptForm(paymentMethod, table, newTotal, this.employee, numberOfPersons);
                receiptForm.ShowDialog();
                this.Close();
            }
            else
            {
                partialSum = decimal.Parse(textBoxPartialPayment.Text);
                labelPartialPayment.Text = "Deelbetaling verwerkt.";
                remainingSum = newTotal - partialSum;
                labelPrice.Text = string.Format($"Rest bedrag: €{Convert.ToDecimal(remainingSum):0.00}");
                partialPayment = true;
            }
        }
    }
}
