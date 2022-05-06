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
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutForm checkoutForm = new CheckoutForm();
            checkoutForm.ShowDialog();
            this.Close();
        }
    }
}
