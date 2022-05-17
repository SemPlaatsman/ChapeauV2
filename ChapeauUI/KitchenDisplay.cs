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
        int nrOfBoxes = 20;
        public KitchenDisplay()
        {
            InitializeComponent();
            FillLists();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //KitchenService kitchenService = new KitchenService();
            //List<KitchenOrderOverview> kitchenOrderOverview = kitchenService.GetKitchenOverviews();

            TextBox txtBox = new TextBox();
            txtBox.Location = new Point(600, nrOfBoxes);
            nrOfBoxes += 25;
            txtBox.Visible = true;
            //Controls.Add(txtBox);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Controls.Add(txtBox);
        }

        private void FillLists()
        {

        }


    }
}
