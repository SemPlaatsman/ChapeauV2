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
    }
}
