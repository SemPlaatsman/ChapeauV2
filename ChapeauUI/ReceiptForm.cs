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
        private int tableId;
        private decimal newTotal;
        public ReceiptForm(string BetaalMethode, int TableId, decimal NewTotal)
        {
            InitializeComponent();
            betaalMethode = BetaalMethode;
            tableId = TableId;
            newTotal = NewTotal;
            FillReceipt();
        }
        public decimal totalPrice = 0;
        public int totaalItems = 0;
        public decimal btwTotaal = 0;
        public decimal btwItem = 0;
        public decimal totalWithBtw = 0;
        public void FillReceipt()
        {
            betaalMethodeLbl.Text = betaalMethode;
            datumLbl.Text = DateTime.Now.ToString("g");

            //vul de listview
            ReceiptService receiptService = new ReceiptService();
            List<Receipt> orders = receiptService.GetOrderList(tableId);

            itemsListBox.View = View.Details;
            itemsListBox.FullRowSelect = true;
            itemsListBox.Columns.Add("ProductName", 213);
            itemsListBox.Columns.Add("Quantity", 68);
            itemsListBox.Columns.Add("Price", 54);

            foreach (Receipt order in orders)
            {
                ListViewItem li = new ListViewItem(order.ProductName);
                li.SubItems.Add(order.Quantity.ToString());
                li.SubItems.Add(string.Format("{0:#,##0.00}", Convert.ToDecimal(order.Price)));
                li.Tag = order;
                itemsListBox.Items.Add(li);
                totalPrice += order.Price * order.Quantity;
                totaalItems += order.Quantity;

                if(order.IsAlcoholic)
                {
                    btwItem = order.Price / 100 * 21;
                    btwItem = btwItem * order.Quantity;
                    btwTotaal += btwItem; 
                }
                if (!order.IsAlcoholic)
                {
                    btwItem = order.Price / 100 * 9;
                    btwItem = btwItem * order.Quantity;
                    btwTotaal += btwItem;
                }
            }
            //Listview gevuld
            receiptTotaalArtikelLbl.Text = $"Totaal {totaalItems} artikelen";
            receiptTotaalArtikelPrijsLbl.Text = $"€{totalPrice.ToString()}";
            btwPriceLbl.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(btwTotaal));
            totalWithBtw = btwTotaal + totalPrice;
            totaalMetBtwLbl.Text = string.Format("€" + "{0:#,##0.00}", Convert.ToDecimal(totalWithBtw));
            receiptTotaalOriginelePrijsLbl.Text = totaalMetBtwLbl.Text;
            
            tipTotalLbl.Text = string.Format("€" + "{0:#,##0.00}", Convert.ToDecimal(newTotal - totalWithBtw));

            if (newTotal == 0)
            {
                receiptTotaalToonPrijsLbl.Text = receiptTotaalOriginelePrijsLbl.Text;
            }
            else
            {
                receiptTotaalToonPrijsLbl.Text = string.Format($"{Convert.ToDecimal(newTotal):0.00} EUR");
            }
        }


        private void TerugBtn_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
    }
}
