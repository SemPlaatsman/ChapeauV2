using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class PaymentMethod : Form
    {
        public PaymentMethod()
        {
            InitializeComponent();
        }

        private void AnnulerenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutForm checkoutForm = new CheckoutForm();
            checkoutForm.ShowDialog();
            this.Close();
        }

        private void ContantBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.ShowDialog();
            this.Close();
        }

        private void PinBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.ShowDialog();
            this.Close();
        }

        private void CreditCardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.ShowDialog();
            this.Close();
        }
    }
}
