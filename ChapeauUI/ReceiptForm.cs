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
        private Table table;
        private Employee employee;
        private string paymentMethod;
        private decimal newTotal;
        private int numberOfPersons;
        public ReceiptForm(string paymentMethod, Table table, decimal newTotal, Employee employee, int numberOfPersons)
        {
            InitializeComponent();
            this.paymentMethod = paymentMethod; 
            this.table = table;
            this.newTotal = newTotal;
            this.employee = employee;
            this.numberOfPersons = numberOfPersons;
            FillReceipt();
        }
        private decimal totalPrice = 0;
        private int totalItems = 0; 
        private decimal btwTotal = 0;
        private decimal btwItem = 0;
        private decimal totalWithBtw = 0;
        private decimal priceQuantity;
        private DateTime timeOfPayment;

        ReceiptService receiptService = new ReceiptService();
        public void FillReceipt()
        {
            //vul de listview

            List<Receipt> orders = receiptService.GetOrderList(table.TableID);

            itemsListBox.View = View.Details;
            itemsListBox.FullRowSelect = true;
            itemsListBox.Columns.Add("Naam Product", 201);
            itemsListBox.Columns.Add("Aantal", 46);
            itemsListBox.Columns.Add("Prijs", 47);

            foreach (Receipt order in orders)
            {
                priceQuantity = order.Price * order.Quantity;
                ListViewItem li = new ListViewItem(order.ProductName);
                li.SubItems.Add(order.Quantity.ToString());
                li.SubItems.Add(string.Format($"{Convert.ToDecimal(priceQuantity):0.00}"));
                li.Tag = order;
                itemsListBox.Items.Add(li);
                totalPrice += priceQuantity;
                totalItems += order.Quantity;
                //hier wordt gekeken of het product 21% of 9% btw bevat.
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
        //In deze methode worden de Labels die op de bon staan gevuld.
        public void FillLabels()
        {
            //Listview gevuld
            betaalMethodeLbl.Text = paymentMethod;
            timeOfPayment = DateTime.Now;
            datumLbl.Text = timeOfPayment.ToString("g");
            receiptTotaalArtikelLbl.Text = $"Totaal {totalItems} artikelen";
            receiptTotaalArtikelPrijsLbl.Text = string.Format($"{Convert.ToDecimal(totalPrice - btwTotal):0.00}");
            btwPriceLbl.Text = string.Format($"{Convert.ToDecimal(btwTotal):0.00}");
            totalWithBtw = totalPrice;
            totaalMetBtwLbl.Text = string.Format("€" + $"{Convert.ToDecimal(totalWithBtw):0.00}");
            receiptTotaalOriginelePrijsLbl.Text = totaalMetBtwLbl.Text;
            geholpenDoorLbl.Text = $"U bent geholpen door: {receiptService.GetHost(table.TableID)}";
            tipTotalLbl.Text = string.Format("€" + $"{Convert.ToDecimal(newTotal - totalWithBtw):0.00}");

            if(numberOfPersons != 0)
            {
                receiptBetaling.Text = $"BETAALMETHODE (X{numberOfPersons}):";
            }

            //prijs onder 0 word verandert naar de originele prijs en de fooi staat op 0,00
            if (newTotal <= 0)
            {
                receiptTotaalToonPrijsLbl.Text = receiptTotaalOriginelePrijsLbl.Text;
                tipTotalLbl.Text = "€0,00";
            }
            //zodra de nieuwe prijs onder de originele prijs is word deze verandert naar de originele prijs en de fooi staat op 0,00            
            //else if (newTotal < totalWithBtw)
            //{
            //    tipTotalLbl.Text = string.Format("€" + $"{Convert.ToDecimal(totalWithBtw - newTotal):0.00}");
            //    tipOrDiscountLbl.Text = "Uw korting:";
            //    receiptTotaalToonPrijsLbl.Text = string.Format($"{Convert.ToDecimal(newTotal):0.00} EUR");
            //}
            //hier is fooi gegeven de totaalprijs zal worden aangepast naar newTotal
            else
            {
                receiptTotaalToonPrijsLbl.Text = string.Format($"{Convert.ToDecimal(newTotal):0.00} EUR");
            }
        }
        //Hierin word de btw berekend. Hier 21%
        private decimal CheckBtwHigh(decimal price)
        {
            return price * 0.21M;
        }
        //Hierin word de btw berekend. Hier 9%
        private decimal CheckBtwLow(decimal price)
        {
            return price * 0.09M;
        }

        private void TerugBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutForm checkoutForm = new CheckoutForm(table, employee);
            checkoutForm.ShowDialog();
            this.Close();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            int occupation = 0;
            TableService tableService = new TableService();
            if (!string.IsNullOrEmpty(remarkTextbox.Text))
            {
                if (newTotal <= totalPrice)
                {
                    receiptService.StoreReceipt(table.TableID, totalPrice, btwTotal, paymentMethod, timeOfPayment);
                    receiptService.InsertRemark(table.TableID, remarkTextbox.Text.ToString());
                }
                else
                {
                    totalPrice = newTotal;
                    receiptService.StoreReceipt(table.TableID, totalPrice, btwTotal, paymentMethod, timeOfPayment);
                    receiptService.InsertRemark(table.TableID, remarkTextbox.Text.ToString());
                }
            }
            else
            {
                if (newTotal <= totalPrice)
                {
                    receiptService.StoreReceipt(table.TableID, totalPrice, btwTotal, paymentMethod, timeOfPayment);
                }
                else
                {
                    totalPrice = newTotal;
                    receiptService.StoreReceipt(table.TableID, totalPrice, btwTotal, paymentMethod, timeOfPayment);
                }
            }
            //Hier krijgt u de bevestiging van de betaling. De bon en indien aanwezig remark zijn opgeslagen in de database.
            MessageBox.Show("          Bestelling afgerond     \n      Je kunt dit venster sluiten");
            tableService.AlterTables(table, occupation);

            this.Hide();
            TableOverviewForm tableOverviewForm = new TableOverviewForm(employee);
            tableOverviewForm.ShowDialog();
            this.Close();
        }
    }
}
