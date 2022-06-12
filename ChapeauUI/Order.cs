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
using ChapeauInterfaces;

namespace ChapeauUI
{
    public partial class Order : Form
    {
        private List<OrderGerecht> selectedItems;
        private Employee employee;
        private Table table;
        private List<MenuItem> menuitems;
        private MenuItemService menuItemService;
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
            panelOrdered.Visible = false;
            panelVerwijderenBestelling.Visible = false;
            listViewGerechten.View = View.Details;
            listViewGerechten.FullRowSelect = true;
            listViewGerechten.Columns.Add("ID", 30);
            listViewGerechten.Columns.Add("Name", 190);
            listViewGerechten.Columns.Add("Price", 80);
            listViewGerechten.Columns.Add("Stock", 100);
            listViewGerechten.Columns.Add("Alcoholic", 100);
        }

        private void buttonVoorgerecht_Click(object sender, EventArgs e)
        {
            listViewGerechten.Items.Clear();
            labelTypeGerecht.Text = "Voorgerecht";
            menuItemService = new MenuItemService();
            
            panelBestellen.Visible = true;
            
            menuitems = menuItemService.GetAllMenuItems(0);
            
            AddItem(menuitems);
        }

        private void buttonHoofdgerecht_Click(object sender, EventArgs e)
        {

            listViewGerechten.Items.Clear();
            panelBestellen.Visible = true;
            labelTypeGerecht.Text = "Hoofdgerecht";
            menuItemService = new MenuItemService();
            
                menuitems = menuItemService.GetAllMenuItems(1);
            
            AddItem(menuitems);
        }

        private void buttonNagerecht_Click(object sender, EventArgs e)
        {

            listViewGerechten.Items.Clear();
            panelBestellen.Visible = true;
            labelTypeGerecht.Text = "Nagerecht";
            menuItemService = new MenuItemService();
            
                menuitems = menuItemService.GetAllMenuItems(2);
            
            AddItem(menuitems);
        }

       

        

        private void buttonDrankjes_Click(object sender, EventArgs e)
        {
            listViewGerechten.Items.Clear();
            panelBestellen.Visible = true;
            labelTypeGerecht.Text = "Drankjes";
            menuItemService = new MenuItemService();
            menuitems = menuItemService.GetAllMenuItems(3);
            AddItem(menuitems);
        }

        private void AddItem(List<MenuItem> menuItems)
        {
            foreach (MenuItem m in menuitems)
            {
                ListViewItem listViewItem = new ListViewItem(m.ProductId.ToString());
                listViewItem.SubItems.Add(m.ProductName);
                listViewItem.SubItems.Add(m.Price.ToString());
                if (m.Stock < 10)
                {
                    listViewItem.BackColor = Color.OrangeRed;
                }
                listViewItem.SubItems.Add(m.Stock.ToString());
                listViewItem.SubItems.Add(m.IsAlcoholic.ToString());
                listViewItem.Tag = m;
                listViewGerechten.Items.Add(listViewItem);
            }
        }

        private void buttonTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonTerugBestelling_Click(object sender, EventArgs e)
        {
            panelBestellen.Visible = false;
        }

        private void listViewGerechten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGerechten.SelectedItems.Count <= 0)
            {
                return;
            }
            if (int.Parse(listViewGerechten.SelectedItems[0].SubItems[3].Text) < 1)
            {
                panelOrdered.Visible = true;
            }
            else
            {
                textBoxAmount.Text = "1";
                labelErrorMessage.Text = "";
                if (listViewGerechten.SelectedItems.Count == 0)
                {
                    return;
                }
                panelItemSelected.Visible = true;
                labelSelectedItem.Text = listViewGerechten.SelectedItems[0].SubItems[1].Text;
            }
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
            if (amount > int.Parse(listViewGerechten.SelectedItems[0].SubItems[3].Text)) 
            {
                labelErrorMessage.ForeColor = Color.Red;
                labelErrorMessage.Text = $"Niet genoeg voorraad, voorraad: {int.Parse(listViewGerechten.SelectedItems[0].SubItems[3].Text)}";
            }
            else
            {
                OrderGerecht gerecht = new OrderGerecht();
                gerecht.MenuItem = ((MenuItem)listViewGerechten.SelectedItems[0].Tag);
                gerecht.Status = OrderStatus.MoetNog;
                gerecht.TimeOfOrder = DateTime.Now;
                gerecht.Remark = textBoxRemark.Text;
                for (int i = 0; i < amount; i++)
                {
                    selectedItems.Add(gerecht);
                }
                panelItemSelected.Visible = false;
                textBoxRemark.Clear();
                RefreshListView();
            }
        }

        private void buttonViewOrder_Click(object sender, EventArgs e)
        {
            panelViewOrder.Visible = true;
            listViewViewOrder.View = View.Details;
            listViewViewOrder.FullRowSelect = true;
            listViewViewOrder.Columns.Add("Id", 30);
            listViewViewOrder.Columns.Add("Naam", 100);
            listViewViewOrder.Columns.Add("Prijs", 50);
            listViewViewOrder.Columns.Add("Alcoholisch", 80);
            listViewViewOrder.Columns.Add("Opmerking", 180);
            listViewViewOrder.Columns.Add("Aantal", 70);
            
            
        }
        private void RefreshListView()
        {
            menuItemService = new MenuItemService();
            foreach (KeyValuePair<OrderGerecht, int> item in GetItems())
            {
                MenuItem menuItem = menuItemService.GetMenuItemsFromOrder(item.Key.MenuItem);
                ListViewItem liItem = new ListViewItem(menuItem.ProductId.ToString());
                liItem.SubItems.Add(menuItem.ProductName);
                liItem.SubItems.Add(menuItem.Price.ToString());
                if (menuItem.IsAlcoholic)
                {
                    liItem.SubItems.Add("Ja");
                }
                else
                {
                    liItem.SubItems.Add("Nee");
                }
                liItem.SubItems.Add(item.Key.Remark.ToString());
                liItem.SubItems.Add(item.Value.ToString());
                liItem.Tag = item.Key;
                listViewViewOrder.Items.Add(liItem);
            }
            
        }

        private Dictionary<OrderGerecht, int> GetItems()
        {
            Dictionary<OrderGerecht, int> items = new Dictionary<OrderGerecht, int>();
            foreach (OrderGerecht gerecht in selectedItems)
            {
                if (items.ContainsKey(gerecht))
                {
                    items[gerecht]++;
                }
                else
                {
                    items.Add(gerecht, 1);
                }
            }
            return items;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewViewOrder.SelectedItems)
            {
                int newAmount = int.Parse(listViewViewOrder.SelectedItems[0].SubItems[5].Text) + 1;
                listViewViewOrder.Items[listViewViewOrder.SelectedItems[0].Index].SubItems[5].Text = $"{newAmount}";
            }   
        }

        

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewViewOrder.SelectedItems)
            {
                int newAmount = int.Parse(listViewViewOrder.SelectedItems[0].SubItems[5].Text) - 1;
                if (newAmount <= 0)
                {
                    listViewViewOrder.Items.Remove(listViewViewOrder.SelectedItems[0]); 
                }
                else
                {
                    listViewViewOrder.Items[listViewViewOrder.SelectedItems[0].Index].SubItems[5].Text = $"{newAmount}";
                }
            }
           
        }


        public List<OrderGerecht> GetItemsFromListView()
        {
            List<OrderGerecht> orders = new List<OrderGerecht>();
            OrderService orderService = new OrderService();
            foreach (ListViewItem item in listViewViewOrder.Items)
            {
                OrderGerecht o = new OrderGerecht();
                o.OrderId = orderService.GetCurrentOrder(table).OrderId;
                o.MenuItem = ((OrderGerecht)item.Tag).MenuItem;
                o.TimeOfOrder = DateTime.Now;
                o.Remark = item.SubItems[4].Text;
                o.IsServed = 0;
                orders.Add(o);  
            }
            return orders;
        }

        private void buttonBestel_Click(object sender, EventArgs e)
        {
            if (listViewViewOrder.Items.Count == 0)
            {
                panelOrdered.Visible = true;
                labelBesteld.Text = "*Lege Bestelling";
            }
            else
            {
                labelBesteld.Text = "Besteld!";
                OrderGerechtService orderGerechtService = new OrderGerechtService();
                selectedItems = GetItemsFromListView();
                menuItemService = new MenuItemService();
                int index = 0;
                foreach (KeyValuePair<OrderGerecht, int> item in GetItems())
                {
                    for (int i = 0; i < int.Parse(listViewViewOrder.Items[index].SubItems[5].Text); i++)
                    {
                        orderGerechtService.InsertOrderGerecht(item.Key);
                        menuItemService.UpdateMenuItem(item.Key);
                    }
                    index++;
                }
                listViewViewOrder.Clear();
                panelOrdered.Visible = true;
            }
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            string Remark = textBoxComment.Text;
            foreach (ListViewItem item in listViewViewOrder.SelectedItems)
            {
                item.SubItems[4].Text = Remark;
                listViewViewOrder.Items.Add((ListViewItem)item.Clone());
                listViewViewOrder.Items.Remove(listViewViewOrder.SelectedItems[0]);
            }
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (listViewViewOrder.Items.Count == 0)
            {
                labelNoItems.Text = "*Order is leeg.";
            }
            else
            {
                panelVerwijderenBestelling.Show();
            }
        }

        private void buttonJaVerwijderen_Click(object sender, EventArgs e)
        {
            listViewViewOrder.Items.Clear();
            panelVerwijderenBestelling.Visible = false;
        }

        private void buttonNeeVerwijderen_Click(object sender, EventArgs e)
        {
            panelVerwijderenBestelling.Visible = false;
        }

        private void buttonOrderedOk_Click(object sender, EventArgs e)
        {
            panelOrdered.Visible = false;
        }

        private void buttonTerugSelectedItems_Click(object sender, EventArgs e)
        {
            panelViewOrder.Visible = false;
            labelNoItems.Text = "";
        }
    }
}
