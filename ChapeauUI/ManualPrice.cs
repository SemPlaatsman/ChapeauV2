using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class ManualPrice : Form
    {
        private Table table;
        private Employee employee;
        private Form formToHide;
        private decimal totalPrice;
        private int numberOfPersons = 0;
        private decimal newTotal;
       
        public ManualPrice(decimal totalWithBtw, Table table, Employee employee, Form checkoutForm)
        {
            InitializeComponent();
            AfrekenenBtn.Enabled = false;
            this.employee = employee;
            this.totalPrice = totalWithBtw;
            this.table = table;
            formToHide = checkoutForm;
            ShowLabels();
        }
        private void ShowLabels()
        {
            totalPriceLbl.Text = string.Format($"\u20AC{Convert.ToDecimal(totalPrice):0.00}");
        }

        private void newPriceTextbox_TextChanged(object sender, EventArgs e)
        {
            AfrekenenBtn.Enabled = !string.IsNullOrEmpty(newPriceTextBox.Text);
        }

        private void AfrekenenBtn_Click(object sender, EventArgs e)
        {
            newTotal = Convert.ToDecimal(newPriceTextBox.Text);

            if (newTotal < totalPrice)
            {
                MessageBox.Show("Het nieuwe bedrag mag niet lager zijn dan het originele bedrag");
            }
            else
            {
                totalPrice = decimal.Parse(newPriceTextBox.Text);
                if (!string.IsNullOrEmpty(textBoxNumberOfPersons.Text))
                {
                    numberOfPersons = int.Parse(textBoxNumberOfPersons.Text);
                }
                PaymentMethod paymentMethod = new PaymentMethod(table, newTotal, this.employee, numberOfPersons, formToHide);
                paymentMethod.Show();
                this.Close();
            }            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
