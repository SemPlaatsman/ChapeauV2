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
        private string paymentMethod;
        private int tableId;
        private decimal newTotal;
        public ReceiptForm(string paymentMethod, int tableId, decimal newTotal, Employee employee)
        {
            InitializeComponent();
            this.paymentMethod = paymentMethod; 
            this.tableId = tableId;
            this.newTotal = newTotal;
            this.employee = employee;
            FillReceipt();
        }
        private decimal totalPrice = 0;
        private int totalItems = 0; 
        private decimal btwTotal = 0;
        private decimal btwItem = 0;
        private decimal totalWithBtw = 0;
        private Employee employee;
        private DateTime timeOfPayment;

        ReceiptService receiptService = new ReceiptService();
        public void FillReceipt()
        {
            betaalMethodeLbl.Text = paymentMethod;
            timeOfPayment = DateTime.Now;
            datumLbl.Text = timeOfPayment.ToString("g");

            //vul de listview

            List<Receipt> orders = receiptService.GetOrderList(tableId);

            itemsListBox.View = View.Details;
            itemsListBox.FullRowSelect = true;
            itemsListBox.Columns.Add("Naam Product", 237);
            itemsListBox.Columns.Add("Aantal", 56);
            itemsListBox.Columns.Add("Prijs", 42);

            foreach (Receipt order in orders)
            {
                ListViewItem li = new ListViewItem(order.ProductName);
                li.SubItems.Add(order.Quantity.ToString());
                li.SubItems.Add(string.Format("{0:#,##0.00}", Convert.ToDecimal(order.Price)));
                li.Tag = order;
                itemsListBox.Items.Add(li);
                totalPrice += order.Price * order.Quantity;
                totalItems += order.Quantity;

                if(order.IsAlcoholic)
                {
                    btwItem = CheckBtwHigh(order.Price);
                    btwItem = btwItem * order.Quantity;
                    btwTotal += btwItem; 
                }
                if (!order.IsAlcoholic)
                {
                    btwItem = CheckBtwLow(order.Price);
                    btwItem = btwItem * order.Quantity;
                    btwTotal += btwItem;
                }
            }
            FillLabels();
        }
        private decimal CheckBtwHigh(decimal price)
        {
            return price * 0.21M;
        }
        private decimal CheckBtwLow(decimal price)
        {
            return price * 0.09M;
        }

        public void FillLabels()
        {
            //Listview gevuld
            receiptTotaalArtikelLbl.Text = $"Totaal {totalItems} artikelen";
            receiptTotaalArtikelPrijsLbl.Text = string.Format($"{Convert.ToDecimal(totalPrice - btwTotal):0.00}");
            btwPriceLbl.Text = string.Format($"{Convert.ToDecimal(btwTotal):0.00}");
            totalWithBtw = totalPrice;
            totaalMetBtwLbl.Text = string.Format("€" + $"{Convert.ToDecimal(totalWithBtw):0.00}");
            receiptTotaalOriginelePrijsLbl.Text = totaalMetBtwLbl.Text;
            geholpenDoorLbl.Text = $"U bent geholpen door: {receiptService.GetHost(tableId)}";
            tipTotalLbl.Text = string.Format("€" + $"{Convert.ToDecimal(newTotal - totalWithBtw):0.00}");

            if (newTotal <= 0)
            {
                receiptTotaalToonPrijsLbl.Text = receiptTotaalOriginelePrijsLbl.Text;
                tipTotalLbl.Text = "€0,00";
            }

            else if (newTotal < totalWithBtw)
            {
                tipTotalLbl.Text = string.Format("€" + $"{Convert.ToDecimal(totalWithBtw - newTotal):0.00}");
                tipOrDiscountLbl.Text = "Uw korting:";
                receiptTotaalToonPrijsLbl.Text = string.Format($"{Convert.ToDecimal(newTotal):0.00} EUR");
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


        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(remarkTextbox.Text))
            {
                if (newTotal <= totalPrice)
                {
                    receiptService.StoreReceipt(tableId, totalPrice, btwTotal, paymentMethod, timeOfPayment);
                    receiptService.InsertRemark(tableId, remarkTextbox.Text.ToString());
                }
                else
                {
                    totalPrice = newTotal;
                    receiptService.StoreReceipt(tableId, totalPrice, btwTotal, paymentMethod, timeOfPayment);
                    receiptService.InsertRemark(tableId, remarkTextbox.Text.ToString());
                }
            }
            else
            {
                if (newTotal <= totalPrice)
                {
                    receiptService.StoreReceipt(tableId, totalPrice, btwTotal, paymentMethod, timeOfPayment);
                }
                else
                {
                    totalPrice = newTotal;
                    receiptService.StoreReceipt(tableId, totalPrice, btwTotal, paymentMethod, timeOfPayment);
                }
            }

            MessageBox.Show("          Bestelling afgerond     \n      Je kunt dit venster sluiten");            
            TableOverviewForm tableOverviewForm = new TableOverviewForm(this.employee);
            tableOverviewForm.ShowDialog();
            this.Close();

            //hier moet ik alleen de order nog sluiten
        }
    }
}
