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
    public partial class ManualPrice : Form
    {
        private decimal totalPrice;
        private int tableId;
        private decimal newTotal;
        public ManualPrice(decimal totalPrice, int TableId)
        {
            InitializeComponent();       
            AfrekenenBtn.Enabled = false;
            this.totalPrice = totalPrice;
            this.tableId = TableId;
            totalPriceLbl.Text = $"€{totalPrice.ToString()}";            
        }
        
        private void newPriceTextbox_TextChanged(object sender, EventArgs e)
        {
            AfrekenenBtn.Enabled = !string.IsNullOrEmpty(newPriceTextBox.Text);
        }

        private void AfrekenenBtn_Click(object sender, EventArgs e)
        {
            totalPrice = decimal.Parse(newPriceTextBox.Text);
            newTotal = Convert.ToDecimal(newPriceTextBox.Text);
            PaymentMethod paymentMethod = new PaymentMethod(tableId, newTotal);
            paymentMethod.ShowDialog();
            this.Close();            
        }
    }
}
