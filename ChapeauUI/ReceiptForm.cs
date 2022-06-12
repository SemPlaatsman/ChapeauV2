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
using ChapeauInterfaces;

namespace ChapeauUI
{
    public partial class ReceiptForm : Form
    {
        private Table table;
        private Employee employee;
        private DateTime timeOfPayment;
        private Form formToShow;
        private string paymentMethod;
        private decimal newTotal;
        private int numberOfPersons;
        private decimal totalPrice = 0;
        private int totalItems = 0; 
        private decimal btwTotal = 0;
        private decimal btwItem = 0;
        private decimal totalWithBtw = 0;
        private decimal priceQuantity;

        public ReceiptForm(string paymentMethod, Table table, decimal newTotal, Employee employee, int numberOfPersons, Form checkoutForm)
        {
            InitializeComponent();
            this.paymentMethod = paymentMethod; 
            this.table = table;
            this.newTotal = newTotal;
            this.employee = employee;
            this.numberOfPersons = numberOfPersons;
            formToShow = checkoutForm;
            FillReceipt();
        }

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
            receiptTotaalArtikelLbl.Text = $"Totaal {totalItems} artikelen (zonder btw)";
            receiptTotaalArtikelPrijsLbl.Text = string.Format($"\u20AC{Convert.ToDecimal(totalPrice - btwTotal):0.00}");
            btwPriceLbl.Text = string.Format($"\u20AC{Convert.ToDecimal(btwTotal):0.00}");
            totalWithBtw = totalPrice;
            totaalMetBtwLbl.Text = string.Format($"\u20AC{Convert.ToDecimal(totalWithBtw):0.00}");
            receiptTotaalOriginelePrijsLbl.Text = totaalMetBtwLbl.Text;
            geholpenDoorLbl.Text = $"U bent geholpen door: {receiptService.GetHost(table.TableID)}";
            tipTotalLbl.Text = string.Format($"\u20AC{Convert.ToDecimal(newTotal - totalWithBtw):0.00}");

            if(numberOfPersons != 0)
            {
                receiptBetaling.Text = $"BETAALMETHODE (X{numberOfPersons}):";
            }

            //prijs onder 0 word verandert naar de originele prijs en de fooi staat op 0,00
            if (newTotal <= totalWithBtw)
            {
                receiptTotaalToonPrijsLbl.Text = receiptTotaalOriginelePrijsLbl.Text;
                tipTotalLbl.Text = "\u20AC0,00";
            }
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
            formToShow.Show();
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
                    receiptService.StoreRemark(table.TableID, remarkTextbox.Text.ToString());
                }
                else
                {
                    totalPrice = newTotal;
                    receiptService.StoreReceipt(table.TableID, totalPrice, btwTotal, paymentMethod, timeOfPayment);
                    receiptService.StoreRemark(table.TableID, remarkTextbox.Text.ToString());
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
            //De tafel word vrij gemaakt
            tableService.AlterTables(table, occupation);
            //Je word nu naar de TableoverviewForm gestuurd
            Close();
        }
    }
}
