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
        private decimal totalPrice;
        private Table table;
        private decimal newTotal;
        private Employee employee;
       
        public ManualPrice(decimal totalWithBtw, Table table, Employee employee)
        {
            InitializeComponent();       
            AfrekenenBtn.Enabled = false;
            this.employee = employee;
            this.totalPrice = totalWithBtw;
            this.table = table;
            totalPriceLbl.Text = string.Format($"€{Convert.ToDecimal(totalPrice):0.00}");
        }
        
        private void newPriceTextbox_TextChanged(object sender, EventArgs e)
        {
            AfrekenenBtn.Enabled = !string.IsNullOrEmpty(newPriceTextBox.Text);
        }

        private void AfrekenenBtn_Click(object sender, EventArgs e)
        {
            newTotal = Convert.ToDecimal(newPriceTextBox.Text);

            if(newTotal < totalPrice)
            {
                MessageBox.Show("Het nieuwe bedrag mag niet lager zijn dan het originele bedrag");
            }
            else
            {
                totalPrice = decimal.Parse(newPriceTextBox.Text);
                this.Hide();
                PaymentMethod paymentMethod = new PaymentMethod(table, newTotal, this.employee);
                paymentMethod.ShowDialog();
                this.Close();
            }
        }
    }
}
