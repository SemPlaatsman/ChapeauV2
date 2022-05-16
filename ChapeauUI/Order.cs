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
        public Order(int TableId)
        {
            InitializeComponent();
            
        }

        private void Order_Load(object sender, EventArgs e)
        {
            panelBestellen.Visible = false;
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
                if (m.Type == "Voorgerecht")
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
                if (m.Type == "Hoofdgerecht")
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
                if (m.Type == "Nagerecht")
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
                if (m.Type == "Drinken")
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
            TableOverviewForm tableOverviewForm = new TableOverviewForm();  
            tableOverviewForm.ShowDialog();
            this.Close();
        }

        private void buttonTerugBestelling_Click(object sender, EventArgs e)
        {
            panelBestellen.Visible = false;
        }

        private void buttonToevoegen_Click(object sender, EventArgs e)
        {
            //listViewGerechten.SelectedItems;
        }
    }
}
