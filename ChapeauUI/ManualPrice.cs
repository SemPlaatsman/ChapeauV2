﻿using System;
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
        public ManualPrice(decimal totalPrice)
        {
            InitializeComponent();
            this.totalPrice = totalPrice;
            totalPriceLbl.Text = $"€{totalPrice.ToString()}";

            totalPrice = decimal.Parse(newPriceTextBox.Text);
        }

        private void AfrekenenBtn_Click(object sender, EventArgs e)
        {            
            PaymentMethod paymentMethod = new PaymentMethod();
            paymentMethod.ShowDialog();
            this.Close();
            
        }
    }
}
