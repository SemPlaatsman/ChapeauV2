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
        private decimal newTotal;
        private Employee employee;
        public PaymentMethod(Table table, decimal NewTotal, Employee employee)
        {
            InitializeComponent();
            this.table = table;
            newTotal = NewTotal;
            this.employee = employee;
        }
        private string paymentMethod;
        
        //ReceiptForm receipt = new ReceiptForm();

        private void AnnulerenBtn_Click(object sender, EventArgs e)
        {            
            this.Close();
        }


        private void ContantBtn_Click(object sender, EventArgs e)
        {

            paymentMethod = "Contant";
            ReceiptForm receiptForm = new ReceiptForm(paymentMethod, table, newTotal, this.employee);

            receiptForm.ShowDialog();
            this.Close();
            
        }

        private void PinBtn_Click(object sender, EventArgs e)
        {

            paymentMethod = "Pin";
            ReceiptForm receiptForm = new ReceiptForm(paymentMethod, table, newTotal, this.employee);

            receiptForm.ShowDialog();
            this.Close();
        }

        private void CreditCardBtn_Click(object sender, EventArgs e)
        {

            paymentMethod = "CreditCard";
            ReceiptForm receiptForm = new ReceiptForm(paymentMethod, table, newTotal, this.employee);

            receiptForm.ShowDialog();
            this.Close();
        }
    }
}
