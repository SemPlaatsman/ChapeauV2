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
        private Form formToHide;
        private decimal newTotal;
        private int numberOfPersons;
        private decimal pricePerPerson;
        private bool partialPayment = false;
        private decimal partialSum;
        private decimal remainingSum;

        public PaymentMethod(Table table, decimal NewTotal, Employee employee, int numberOfPersons, Form checkoutForm)
        {
            InitializeComponent();
            this.table = table;
            newTotal = NewTotal;
            this.employee = employee;
            this.numberOfPersons = numberOfPersons;
            formToHide = checkoutForm;
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
            //CheckoutForm checkoutForm = new CheckoutForm(table, this.employee);
            //checkoutForm.Show();
            this.Close();
        }
        private void ContantBtn_Click(object sender, EventArgs e)
        {
            paymentMethod += "Contant ";
            if (string.IsNullOrEmpty(textBoxPartialPayment.Text) || partialPayment == true)
            {
                //checkoutForm.FindForm();
                formToHide.Hide();
                this.Hide();
                ReceiptForm receiptForm = new ReceiptForm(paymentMethod, table, newTotal, this.employee, numberOfPersons, formToHide);
                receiptForm.ShowDialog();
                this.Close();
            }
            else
            {
                partialSum = decimal.Parse(textBoxPartialPayment.Text);
                labelPartialPayment.Text = "Deelbetaling verwerkt.";
                if (numberOfPersons > 1)
                {
                    remainingSum = pricePerPerson - partialSum;
                }
                else
                {
                    remainingSum = newTotal - partialSum;
                }
                labelPrice.Text = string.Format($"Rest bedrag: €{Convert.ToDecimal(remainingSum):0.00}");
                partialPayment = true;
            }
        }
        private void PinBtn_Click(object sender, EventArgs e)
        {
            paymentMethod += "Pin ";
            if (string.IsNullOrEmpty(textBoxPartialPayment.Text) || partialPayment == true)
            {
                //checkoutForm.FindForm();
                formToHide.Hide();
                this.Hide();
                ReceiptForm receiptForm = new ReceiptForm(paymentMethod, table, newTotal, this.employee, numberOfPersons, formToHide);
                receiptForm.ShowDialog();
                this.Close();
            }
            else
            {
                partialSum = decimal.Parse(textBoxPartialPayment.Text);
                labelPartialPayment.Text = "Deelbetaling verwerkt.";
                if (numberOfPersons > 1)
                {
                    remainingSum = pricePerPerson - partialSum;
                }
                else
                {
                    remainingSum = newTotal - partialSum;
                }
                labelPrice.Text = string.Format($"Rest bedrag: €{Convert.ToDecimal(remainingSum):0.00}");
                partialPayment = true;
            }
        }
        private void CreditCardBtn_Click(object sender, EventArgs e)
        {
            paymentMethod += "CreditCard ";
            if (string.IsNullOrEmpty(textBoxPartialPayment.Text) || partialPayment == true)
            {
                //checkoutForm.FindForm();
                formToHide.Hide();
                this.Hide();
                ReceiptForm receiptForm = new ReceiptForm(paymentMethod, table, newTotal, this.employee, numberOfPersons, formToHide);
                receiptForm.ShowDialog();
                this.Close();
            }
            else
            {
                partialSum = decimal.Parse(textBoxPartialPayment.Text);
                labelPartialPayment.Text = "Deelbetaling verwerkt.";
                if (numberOfPersons > 1)
                {
                    remainingSum = pricePerPerson - partialSum;
                }
                else
                {
                    remainingSum = newTotal - partialSum;
                }
                labelPrice.Text = string.Format($"Rest bedrag: €{Convert.ToDecimal(remainingSum):0.00}");
                partialPayment = true;
            }
        }
    }
}
