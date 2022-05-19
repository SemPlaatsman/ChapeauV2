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
using ChapeauModel;
using ChapeauLogica;

namespace ChapeauUI
{
    public partial class ReceiptForm : Form
    {
        private string betaalMethode;
        public ReceiptForm(string BetaalMethode)
        {
            InitializeComponent();
            betaalMethode = BetaalMethode;
            FillReceipt();
        }

        public void FillReceipt()
        {
            betaalMethodeLbl.Text = betaalMethode;
            datumLbl.Text = DateTime.Now.ToString("g");
        }


        private void TerugBtn_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
    }
}
