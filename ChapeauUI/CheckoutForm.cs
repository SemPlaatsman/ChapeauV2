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
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
        }

        private void buttonBackToTableOverview_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableForm tableForm = new TableForm();
            tableForm.ShowDialog();
            this.Close();
        }
        //Dit is zonder fooikeuze. DIT GAAT NAAR BETAALMETHODE
        private void AfrekenenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentMethod paymentMethod = new PaymentMethod();
            paymentMethod.ShowDialog();
            this.Close();
        }
        //Hier is gekozen voor een fooi. DEZE GAAT NAAR PRIJSWIJZIGING
        private void HandmatigBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManualPrice manualPrice = new ManualPrice();
            manualPrice.ShowDialog();
            this.Close();
        }
    }
}
