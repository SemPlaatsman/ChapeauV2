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
using System.Text.RegularExpressions;
using ChapeauInterfaces;

namespace ChapeauUI
{
    public partial class TableForm : Form
    {
        private Table table;
        private TableOverviewForm overviewForm;
        private Employee employee;
        private Employee employeeConnectedToTable;
        private EmployeeService employeeService;
        public TableForm(Table table, TableOverviewForm overviewForm, Employee employee) 
        {
            this.employeeService = new EmployeeService();
            this.employeeConnectedToTable = employeeService.GetEmployee(table);
            this.overviewForm = overviewForm;
            this.table = table;
            this.employee = employee;
            InitializeComponent();
            this.Text += $" for Table {table.TableID}";
        }
        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (table.IsOccupied)
            {
                this.Hide();
                CheckoutForm checkoutForm = new CheckoutForm(table, this.employee);
                checkoutForm.ShowDialog();                
                this.Close();
            }
            else
            {
                MessageBox.Show("Er is nog niks besteld");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowListView()
        {
            KitchenService kitchenService = new KitchenService();
            KitchenOrderOverview kitchenOrderOverview = new KitchenOrderOverview()
            {
                TableId = this.table.TableID
            };
            kitchenOrderOverview = kitchenService.GetKitchenOverviewWithTableId(kitchenOrderOverview.TableId);
            // iets nodig om te items te showen die georderd zijn op deze tafel. 
            listViewOrder.View = View.Details;
            listViewOrder.FullRowSelect = true;
            listViewOrder.Columns.Add("Naam", 170);
            listViewOrder.Columns.Add("Status gerecht", 90);
            listViewOrder.Columns.Add("Duur", 75);
            listViewOrder.Columns.Add("Status geserveerd", 130);
           

            foreach (OrderGerecht item in kitchenOrderOverview.GetCombinedGerechten())
            {
                ListViewItem li = new ListViewItem(item.MenuItem.ProductName);
                li.SubItems.Add(Regex.Replace($"{item.Status.ToString()}", "([A-Z])", " $1").Trim());
                // TimeSpan maken vanaf timeOfOrder -> datetime.now 
                TimeSpan time = DateTime.Now - item.TimeOfOrder;
                li.SubItems.Add(time.ToString("hh':'mm':'ss"));
                li.SubItems.Add(Regex.Replace($"{item.IsServed.ToString()}", "([A-Z])", " $1").Trim());
                listViewOrder.Items.Add(li);
            }
        }
        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            TableService tableService = new TableService();
            OrderService orderService = new OrderService();
            List<Table> tables = orderService.tables();
            int occupation = 1;
            foreach (Table table in tables) 
            {
                if (this.table.TableID == table.TableID)
                {
                    if (!table.IsOccupied)
                    {
                        orderService.InsertNewOrder(table);
                        tableService.AlterTables(table, occupation);
                        // achtergrond kleur moet naar rood. 
                        tableService.UpdateTableOccupy(table, true);
                        tableService.SetEmployee(this.employee, table);
                        this.employeeConnectedToTable = employeeService.GetEmployee(this.table);
                        // overbodig. met refactor eruit halen. 
                        labelCurrentEmployee.Text = $"{this.employee.LastName}, {this.employee.FirstName}";
                        // nu toont hij alleen degene die ingelogd is, maar niet degene die gekoppeld is aan de tafel. Update ook niet live... 
                        this.overviewForm.SetColor();
                    }
                }
            }
            
            Order order = new Order(table, employee);  
            order.ShowDialog();
            this.Close();
        }

        private void checkBoxTable_CheckedChanged(object sender, EventArgs e)
        {
            TableService tableService = new TableService();
            Table table = null;           
            // Dit later omzetten naar Table Object. 
            List<Table> tables = tableService.GetAllTables();
            table = tables.Find(x => x.TableID == this.table.TableID);
            // alle tafels updaten? 
            tableService.GetAllTables();

        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            ShowListView();
            EmployeeService employeeService = new EmployeeService();            
            TableService tableService = new TableService();
            tableService.GetAllTables();
            List<Table> tables = tableService.GetAllTables();
            Table table = null;
            table = tables.Find(x => x.TableID == this.table.TableID);
            if (table.IsOccupied)
            {
                checkBoxTable.Checked = true;
                this.labelCurrentEmployee.Text = $"{table.EmployeeID}";
            }
            else
            {
                checkBoxTable.Checked = false;
            }
        }


    }
}
