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
        public ReceiptForm(string betaalMethode, int tableId, decimal newTotal, Employee employee)
        {
            InitializeComponent();
            this.betaalMethode = betaalMethode; //enum toepassen.  Engels en NL door elkaar? 
            this.tableId = tableId;
            this.newTotal = newTotal;
            this.employee = employee;
            FillReceipt();
        }
        private decimal totalPrice = 0;
        private int totaalItems = 0; // hier weer Engels
        private decimal btwTotaal = 0;
        private decimal btwItem = 0;
        private decimal totalWithBtw = 0;
        private Employee employee;

        ReceiptService receiptService = new ReceiptService();
        public void FillReceipt()
        {
            betaalMethodeLbl.Text = betaalMethode;
            datumLbl.Text = DateTime.Now.ToString("g");

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
                totaalItems += order.Quantity;

                if(order.IsAlcoholic)
                {
                    btwItem = CheckBtwHigh(order.Price);
                    btwItem = btwItem * order.Quantity;
                    btwTotaal += btwItem; 
                }
                if (!order.IsAlcoholic)
                {
                    btwItem = CheckBtwLow(order.Price);
                    btwItem = btwItem * order.Quantity;
                    btwTotaal += btwItem;
                }
            }
            FillLabels();
        }

        public void FillLabels()
        {
            //Listview gevuld
            receiptTotaalArtikelLbl.Text = $"Totaal {totaalItems} artikelen";
            receiptTotaalArtikelPrijsLbl.Text = $"€{totalPrice.ToString()}";
            btwPriceLbl.Text = string.Format($"{Convert.ToDecimal(btwTotaal):0.00}");
            totalWithBtw = btwTotaal + totalPrice;
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

        private decimal CheckBtwHigh(decimal price)
        {
            return price * 0.21M;
        }
        private decimal CheckBtwLow(decimal price)
        {
            return price * 0.09M;
        }


        private void TerugBtn_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void OpmerkingBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opmerking opgeslagen");
        }

        private void UitprintenBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("          Bestelling afgerond     \n      Je kunt dit venster sluiten");
            this.Hide();
            TableOverviewForm tableOverviewForm = new TableOverviewForm(this.employee);
            tableOverviewForm.ShowDialog();
            this.Close();

            //hier moet ik alleen de order nog sluiten
        }
    }
}
