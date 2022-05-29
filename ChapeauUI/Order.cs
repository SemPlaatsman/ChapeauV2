using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogica;

namespace ChapeauUI
{
    public partial class Order : Form
    {
        private List<OrderGerecht> selectedItems;
        private Employee employee;

        public Order(Table TableId, Employee employee) 

        {
            this.employee = employee;
            InitializeComponent();
            
        }

        private void Order_Load(object sender, EventArgs e)
        {
            panelBestellen.Visible = false;
            panelItemSelected.Visible = false;
            panelViewOrder.Visible = false; 
            listViewGerechten.View = View.Details;
            listViewGerechten.FullRowSelect = true;
            listViewGerechten.Columns.Add("ID", 100);
            listViewGerechten.Columns.Add("Name", 100);
            listViewGerechten.Columns.Add("Price", 100);
            listViewGerechten.Columns.Add("Stock", 100);
            listViewGerechten.Columns.Add("Alcoholic", 100);
        }

        private void buttonVoorgerecht_Click(object sender, EventArgs e)
        {
            listViewGerechten.Items.Clear();
            labelTypeGerecht.Text = "Voorgerecht";
            MenuItemService menuItemService = new MenuItemService();
            List<MenuItem>orderedItems = menuItemService.GetAllMenuItems();
            panelBestellen.Visible = true;
            foreach (MenuItem m in orderedItems)
            {
                if (m.Type == TypeOfProduct.Voorgerecht)
                {
                    ListViewItem listViewItem = new ListViewItem(m.ProductId.ToString());
                    listViewItem.SubItems.Add(m.ProductName);
                    listViewItem.SubItems.Add(m.Price.ToString());
                    listViewItem.SubItems.Add(m.Stock.ToString());
                    listViewItem.SubItems.Add(m.IsAlcoholic.ToString());
                    listViewGerechten.Items.Add(listViewItem);
                }
            }
        }

        private void buttonHoofdgerecht_Click(object sender, EventArgs e)
        {

            listViewGerechten.Items.Clear();
            panelBestellen.Visible = true;
            labelTypeGerecht.Text = "Hoofdgerecht";
            MenuItemService menuItemService = new MenuItemService();
            List<MenuItem> orderedItems = menuItemService.GetAllMenuItems();
            panelBestellen.Visible = true;
            foreach (MenuItem m in orderedItems)
            {
                if (m.Type == TypeOfProduct.Hoofdgerecht)
                {
                    ListViewItem listViewItem = new ListViewItem(m.ProductId.ToString());
                    listViewItem.SubItems.Add(m.ProductName);
                    listViewItem.SubItems.Add(m.Price.ToString());
                    listViewItem.SubItems.Add(m.Stock.ToString());
                    listViewItem.SubItems.Add(m.IsAlcoholic.ToString());
                    listViewGerechten.Items.Add(listViewItem);
                }
            }
        }

        private void buttonNagerecht_Click(object sender, EventArgs e)
        {

            listViewGerechten.Items.Clear();
            panelBestellen.Visible = true;
            labelTypeGerecht.Text = "Nagerecht";
            MenuItemService menuItemService = new MenuItemService();
            List<MenuItem> orderedItems = menuItemService.GetAllMenuItems();
            panelBestellen.Visible = true;
            foreach (MenuItem m in orderedItems)
            {
                if (m.Type == TypeOfProduct.Nagerecht)
                {
                    ListViewItem listViewItem = new ListViewItem(m.ProductId.ToString());
                    listViewItem.SubItems.Add(m.ProductName);
                    listViewItem.SubItems.Add(m.Price.ToString());
                    listViewItem.SubItems.Add(m.Stock.ToString());
                    listViewItem.SubItems.Add(m.IsAlcoholic.ToString());
                    listViewGerechten.Items.Add(listViewItem);
                }
            }
        }

        private void buttonDrankjes_Click(object sender, EventArgs e)
        {
            listViewGerechten.Items.Clear();
            panelBestellen.Visible = true;
            labelTypeGerecht.Text = "Drankjes";
            MenuItemService menuItemService = new MenuItemService();
            List<MenuItem> orderedItems = menuItemService.GetAllMenuItems();
            panelBestellen.Visible = true;
            foreach (MenuItem m in orderedItems)
            {
                if (m.Type == TypeOfProduct.Drinken)
                {
                    ListViewItem listViewItem = new ListViewItem(m.ProductId.ToString());
                    listViewItem.SubItems.Add(m.ProductName);
                    listViewItem.SubItems.Add(m.Price.ToString());
                    listViewItem.SubItems.Add(m.Stock.ToString());
                    listViewItem.SubItems.Add(m.IsAlcoholic.ToString());
                    listViewGerechten.Items.Add(listViewItem);
                }
            }
        }

        private void buttonTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableOverviewForm tableOverviewForm = new TableOverviewForm(this.employee);  
            tableOverviewForm.ShowDialog();
            this.Close();
        }

        private void buttonTerugBestelling_Click(object sender, EventArgs e)
        {
            panelBestellen.Visible = false;
        }
        private void listViewGerechten_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAmount.Text = "1";
            labelErrorMessage.Text = "";
            if (listViewGerechten.SelectedItems.Count == 0)
            {
                return;
            }
            panelItemSelected.Visible = true;
            labelSelectedItem.Text= listViewGerechten.SelectedItems[0].SubItems[1].Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxRemark.Clear();
            textBoxAmount.Clear();
            panelItemSelected.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            labelErrorMessage.Text = "";
            selectedItems = new List<OrderGerecht>();
            int amount = int.Parse(textBoxAmount.Text);
            if (amount < 1)
            {
                labelErrorMessage.ForeColor = Color.Red;
                labelErrorMessage.Text = "Aantal kan niet onder de 1 zijn.";
            }
            else
            {
                OrderGerecht gerecht = new OrderGerecht();
                gerecht.OrderGerechtId = int.Parse(listViewGerechten.SelectedItems[0].Text);
                //gerecht.OrderId = 
                gerecht.Status = OrderStatus.MoetNog;
                gerecht.TimeOfOrder = DateTime.Now;
                gerecht.Remark = textBoxRemark.Text;
                selectedItems = new List<OrderGerecht>();
                for (int i = 0; i < amount; i++)
                {
                    selectedItems.Add(gerecht);
                }
            }
            
        }

        private void buttonViewOrder_Click(object sender, EventArgs e)
        {
            panelViewOrder.Visible = true;
            listViewViewOrder.View = View.Details;
            listViewViewOrder.FullRowSelect = true;
            listViewViewOrder.Columns.Add("ID", 100);
            listViewViewOrder.Columns.Add("Name", 100);
            listViewViewOrder.Columns.Add("Price", 100);
            listViewViewOrder.Columns.Add("Stock", 100);
            listViewViewOrder.Columns.Add("Alcoholic", 100);
        }
        private void RefreshListView(List<OrderGerecht> selectedItems)
        {
           
        }
    }
}
