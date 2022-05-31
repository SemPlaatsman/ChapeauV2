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
        private Table table;

        public Order(Table TableId, Employee employee) 

        {
            this.table = TableId;
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
                    listViewItem.Tag = m;
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
                    listViewItem.Tag = m;
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
                    listViewItem.Tag = m;
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
                    listViewItem.Tag = m;
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
            this.selectedItems = new List<OrderGerecht>();
            int amount = int.Parse(textBoxAmount.Text);
            if (amount < 1)
            {
                labelErrorMessage.ForeColor = Color.Red;
                labelErrorMessage.Text = "Aantal kan niet onder de 1 zijn.";
            }
            else
            {
                OrderGerecht gerecht = new OrderGerecht();
                gerecht.MenuItem = ((MenuItem)listViewGerechten.SelectedItems[0].Tag);
                //gerecht.OrderId = 
                gerecht.Status = OrderStatus.MoetNog;
                gerecht.TimeOfOrder = DateTime.Now;
                gerecht.Remark = textBoxRemark.Text;
                for (int i = 0; i < amount; i++)
                {
                    selectedItems.Add(gerecht);
                }
                panelItemSelected.Visible = false;
                RefreshListView(selectedItems);
            }
        }

        private void buttonViewOrder_Click(object sender, EventArgs e)
        {
            panelViewOrder.Visible = true;
            listViewViewOrder.View = View.Details;
            listViewViewOrder.FullRowSelect = true;
            listViewViewOrder.Columns.Add("Id", 50);
            listViewViewOrder.Columns.Add("Naam", 100);
            listViewViewOrder.Columns.Add("Prijs", 100);
            listViewViewOrder.Columns.Add("Alcoholic", 100);
            listViewViewOrder.Columns.Add("Opmerking", 200);
            
        }
        private void RefreshListView(List<OrderGerecht> selectedItems)
        {
            MenuItemService menuItemService = new MenuItemService();
            foreach (OrderGerecht O in selectedItems)
            {
                List<MenuItem> menuItems = menuItemService.GetMenuItemsFromOrder(O.MenuItem);
                MenuItem menuItem = menuItems.FirstOrDefault();
                ListViewItem item = new ListViewItem(menuItem.ProductId.ToString());
                item.SubItems.Add(menuItem.ProductName);
                item.SubItems.Add(menuItem.Price.ToString());
                item.SubItems.Add(menuItem.IsAlcoholic.ToString());
                item.SubItems.Add(O.Remark.ToString());
                item.Tag = menuItem;
                listViewViewOrder.Items.Add(item);
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewViewOrder.SelectedItems)
            {
                listViewViewOrder.Items.Add((ListViewItem)item.Clone());
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelViewOrder.Visible = false;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewViewOrder.SelectedItems)
            {
                listViewViewOrder.Items.Remove(listViewViewOrder.SelectedItems[0]); 
            }
           
        }


        public List<OrderGerecht> GetItemsFromListView()
        {
            List<OrderGerecht> orders = new List<OrderGerecht>();
            OrderService orderService = new OrderService();
            //orderService.
            foreach (ListViewItem item in listViewViewOrder.Items)
            {
                OrderGerecht o = new OrderGerecht();
                o.MenuItem = (MenuItem)item.Tag;
                o.TimeOfOrder = DateTime.Now;
                o.Remark = item.SubItems[4].Text;
                o.IsServed = 0;
                o.Status = OrderStatus.MoetNog;
                orders.Add(o);  
            }
            return orders;
        }

        private void buttonBestel_Click(object sender, EventArgs e)
        {
            OrderGerechtService orderGerechtService = new OrderGerechtService();
            selectedItems = GetItemsFromListView();
            foreach (OrderGerecht orderGerecht in selectedItems)
            {
                orderGerechtService.InsertOrderGerecht(orderGerecht);
            }
            MessageBox.Show("Besteld!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
