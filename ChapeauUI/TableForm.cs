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
        public TableForm(int TableId) // Table table. Hele object meegeven, want minder werk. 
        {
            this.TableId = TableId;
            InitializeComponent();
            this.Text += $" for Table {TableId}";
        }
        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            CheckoutForm checkoutForm = new CheckoutForm(TableId);
            checkoutForm.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            //TableOverviewForm tableOverviewForm = new TableOverviewForm();
            //tableOverviewForm.ShowDialog();
            //this.Close();
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            List<Table> tables = orderService.tables();
            foreach (Table table in tables) 
            {
                if (table.TableID == TableId)
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

        private void checkBoxTable_CheckedChanged(object sender, EventArgs e)
        {
            // Hierin wil ik Table object meegeven. Als ifOccupied = true, dan checkbox.Checked. 
            // Komt vanuit een andere form, hoe ga ik dit doen... 
            TableService tableService = new TableService();
            Table table = null;
            

            if (checkBoxTable.Checked)
            {
                // achtergrond kleur moet naar rood. 
                tableService.UpdateTableOccupy(table);
            }
            else
            {
                // achtergrond kleur default. Groen
                tableService.UpdateTableOccupy(table);
            }

            // alle tafels updaten? 
            tableService.GetAllTables();

        }
    }
}
