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
    public partial class TableForm : Form
    {
        private int TableId;
        public TableForm(int TableId)
        {
            this.TableId = TableId;
            InitializeComponent();
        }
        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            CheckoutForm checkoutForm = new CheckoutForm(TableId);
            checkoutForm.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableOverviewForm tableOverviewForm = new TableOverviewForm();
            tableOverviewForm.ShowDialog();
            this.Close();
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            List<Table> tables = orderService.tables();
            foreach (Table table in tables) 
            {
                if (table.TabelID == TableId)
                {
                    if (!table.IsOccupied)
                    {
                        orderService.InsertNewOrder(TableId);
                        orderService.AlterTables(TableId);
                    }
                }
            }
            this.Hide();
            Order order = new Order(TableId);  
            order.ShowDialog();
            this.Close();
        }
    }
}
