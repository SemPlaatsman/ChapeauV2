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
        public ManualPrice()
        {
            InitializeComponent();
        }

        private void AfrekenenBtn_Click(object sender, EventArgs e)
        {            
            PaymentMethod paymentMethod = new PaymentMethod();
            paymentMethod.ShowDialog();
            this.Close();
        }
    }
}
