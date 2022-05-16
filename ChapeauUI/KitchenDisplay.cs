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
using ChapeauLogica;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class KitchenDisplay : Form
    {
        public KitchenDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitchenService kitchenService = new KitchenService();
            List<KitchenOrderOverview> kitchenOrderOverview = kitchenService.GetKitchenOverviews();
            MessageBox.Show("Success");
        }
    }
}
