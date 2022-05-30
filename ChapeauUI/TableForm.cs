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
            CheckoutForm checkoutForm = new CheckoutForm(table, this.employee);
            checkoutForm.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowListView()
        {
            // iets nodig om te items te showen die georderd zijn op deze tafel. 
            listViewOrder.View = View.Details;
            listViewOrder.Columns.Add("Naam", 150);
            listViewOrder.Columns.Add("Status", 80);

/*            foreach (var item in collection)
            {
                Iets met ListItem li... 
                li.add.iets();
            }*/

        }
        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            TableService tableService = new TableService();
            OrderService orderService = new OrderService();
            List<Table> tables = orderService.tables();
            foreach (Table table in tables) 
            {
                if (this.table.TableID == table.TableID)
                {
                    if (!table.IsOccupied)
                    {
                        orderService.InsertNewOrder(table);
                        orderService.AlterTables(table);

                        // dit moet hier komen te staan. Luuk moet dan er dan voor zorgen dat de tafel weer op groen wordt gezet. d.m.v. Methode die hier voor staat. 
/*                        // achtergrond kleur moet naar rood. 
                        tableService.UpdateTableOccupy(table, true);
                        tableService.SetEmployee(this.employee, table);
                        this.employeeConnectedToTable = employeeService.GetEmployee(this.table);
                        labelCurrentEmployee.Text = $"{this.employeeConnectedToTable.FirstName}, {this.employeeConnectedToTable.LastName}";
                        // nu toont hij alleen degene die ingelogd is, maar niet degene die gekoppeld is aan de tafel. Update ook niet live... 
                        this.overviewForm.SetColor();*/
                    }
                }
            }
            this.Hide();
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

            if (checkBoxTable.Checked)
            {
                // achtergrond kleur moet naar rood. 
                tableService.UpdateTableOccupy(table, true);
                tableService.SetEmployee(this.employee, table);
                this.employeeConnectedToTable = employeeService.GetEmployee(this.table);
                labelCurrentEmployee.Text = $"{this.employeeConnectedToTable.FirstName}, {this.employeeConnectedToTable.LastName}";
                // nu toont hij alleen degene die ingelogd is, maar niet degene die gekoppeld is aan de tafel. Update ook niet live... 
                this.overviewForm.SetColor();
            }
            else
            {
                // achtergrond kleur default. Groen
                tableService.UpdateTableOccupy(table, false);
                labelCurrentEmployee.Text = "Geen medewerker gekoppeld";
                this.overviewForm.SetColor();
            }

            // alle tafels updaten? 
            tableService.GetAllTables();

        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            ShowListView();
            TableService tableService = new TableService();
            tableService.GetAllTables();
            List<Table> tables = tableService.GetAllTables();
            Table table = null;
            table = tables.Find(x => x.TableID == this.table.TableID);

            if (table.IsOccupied)
            {
                checkBoxTable.Checked = true;
            }
            else
            {
                checkBoxTable.Checked = false;
            }
        }

    }
}
