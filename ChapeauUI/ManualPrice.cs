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
        private int tableId;
        private decimal newTotal;
        private Employee employee;
       
        public ManualPrice(decimal totalWithBtw, int TableId, Employee employee)
        {
            InitializeComponent();       
            AfrekenenBtn.Enabled = false;
            this.employee = employee;
            this.totalPrice = totalWithBtw;
            this.tableId = TableId;
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
                PaymentMethod paymentMethod = new PaymentMethod(tableId, newTotal, this.employee);
                paymentMethod.ShowDialog();
                this.Close();
            }
        }
    }
}
