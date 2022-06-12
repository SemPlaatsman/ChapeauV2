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
    public partial class TableOverviewForm : Form
    {
        // private fields
        private Employee employee; 
        TableService tableService;
        private List<Table> tables;
        private KitchenOrderOverview KitchenOrderOverview;
        private OrderGerechtService orderGerechtService;
        private OrderService orderService;
        private List<OrderGerecht> orderGerechten;

        // constructor
        public TableOverviewForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.tableService = new TableService();
            this.KitchenOrderOverview = new KitchenOrderOverview();
            this.orderService = new OrderService();
            this.orderGerechtService = new OrderGerechtService();
        }

        // log out of form, back to Login.cs
        private void buttonUitloggen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        private void TableClick(object sender, EventArgs e) 
        {
            //parse een sender naar een Button, parse de Tag van die Button naar een Table en geef de TableID van die Table aan de Table table
            Table table = ((Table)((Button)sender).Tag);
            
            //maak een nieuwe TableForm en geef het bijbehorende table mee
            TableForm tableForm = new TableForm(table, this, this.employee);
            tableForm.ShowDialog(); 
        }

        public void AssignTables()
        {
            //pak alle Tables die in database staan
            TableService tableService = new TableService();
            tables = tableService.GetAllTables();

            foreach (Control control in this.Controls)
            {
                //als een Control een Button is en niet de uitlog-button is, voeg dan aan die button de TableClick event toe en assign een tag
                if (control.GetType() == typeof(Button) && control != buttonUitloggen)
                {
                    AssignTag(control);
                }
            }
            //gebruik gemaakt van SoC. 
            SetColor();
        }

        private void AssignEvent() 
        {
            //pak alle Tables die in database staan
            TableService tableService = new TableService();
            tables = tableService.GetAllTables();

            foreach (Control control in this.Controls)
            {
                //als een Control een Button is en niet de uitlog-button is, voeg dan aan die button de TableClick event toe en assign een tag
                if (control.GetType() == typeof(Button) && control != buttonUitloggen)
                {
                    control.Click += TableClick;
                }
            }
            SetColor();
        }

        private void AssignTag(Control control)
        {
            foreach (Table table in this.tables)
            {
                //als de TableID van een table uit de database overeenkomt met de text van de button voeg dan die Table aan de tag van die button toe
                if (table.TableID == int.Parse(control.Text))
                {
                    control.Tag = table;
                    break;
                }
            }
        }

        private void TableOverviewForm_Load(object sender, EventArgs e)
        {
            // de Load is een soort van constructor. Word aangemaakt op het moment dat deze form geopend / gelaad wordt. 
            AssignTables();
            AssignEvent();
            // kleur veranderen afhankelijk van IsOccupied
            SetColor();
            this.timerRefreshOverview.Start();
        }

        // methode die de kleur van de tafel neerzet. 
        public void SetColor()
        {
            foreach (Control control in this.Controls)
            {
                Table table = null;
                //als een Control een Button is en niet de uitlog-button is, voeg dan aan die button de TableClick event toe en assign een tag
                if (control.GetType() == typeof(Button) && control != buttonUitloggen)
                {
                    table = (Table)control.Tag;
                    ChangeColor(control, table);
                }
            }
        }

        private void ChangeColor(Control control, Table table) 
        {
            if (!table.IsOccupied)
            {
                control.BackColor = Color.LightGreen;
            }
            else
            {
                control.BackColor = Color.Red;
            }
        }

        //Timer die elke 3 seconde de form opnieuw laadt, veranderingen vanuit de DB meeneemt.
        private void timerRefreshOverview_Tick(object sender, EventArgs e)
        {
            AssignTables();
            ShowPictureBox();
        }

        private void ShowPictureBox() 
        {
            this.orderGerechten = new List<OrderGerecht>();
            OrderService orderService = new OrderService();
            ChapeauModel.Order order = null;
            OrderGerechtService orderGerechtService = new OrderGerechtService();
            List<PictureBox> pictureBoxes = new List<PictureBox>();

            pictureBoxes.Add(pictureBoxTable1);
            pictureBoxes.Add(pictureBoxTable2);
            pictureBoxes.Add(pictureBoxTable3);
            pictureBoxes.Add(pictureBoxTable4);
            pictureBoxes.Add(pictureBoxTable5);
            pictureBoxes.Add(pictureBoxTable6);
            pictureBoxes.Add(pictureBoxTable7);
            pictureBoxes.Add(pictureBoxTable8);
            pictureBoxes.Add(pictureBoxTable9);
            pictureBoxes.Add(pictureBoxTable10);
            int index = 0;

            foreach (Table table in this.tables)
            {
                order = orderService.GetCurrentOrder(table);
                orderGerechten = orderGerechtService.GetCurrentOrderGerechten(order);

                if (orderGerechten.Count > 0)
                {
                    pictureBoxes[index].Visible = true;
                }
                index++;

            }
        }

        private void pictureBoxTable1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order bezorgd op tafel 1");
            
            pictureBoxTable1.Visible = false;
        }

        private void pictureBoxTable2_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.TableID = 2;
            ChapeauModel.Order order = this.orderService.GetCurrentOrder(table);
            this.orderGerechtService.UpdateIsServed(order);
            MessageBox.Show("Order bezorgd op tafel 2");
            pictureBoxTable2.Visible = false;
        }

        private void pictureBoxTable3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order bezorgd op tafel 3");
            pictureBoxTable3.Visible = false;
        }

        private void pictureBoxTable4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order bezorgd op tafel 4");
            pictureBoxTable4.Visible = false;
        }

        private void pictureBoxTable5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order bezorgd op tafel 5");
            pictureBoxTable5.Visible = false;
        }

        private void pictureBoxTable6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order bezorgd op tafel 6");
            pictureBoxTable6.Visible = false;
        }

        private void pictureBoxTable7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order bezorgd op tafel 7");
            pictureBoxTable7.Visible = false;
        }

        private void pictureBoxTable8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order bezorgd op tafel 8");
            pictureBoxTable8.Visible = false;
        }

        private void pictureBoxTable9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order bezorgd op tafel 9");
            pictureBoxTable9.Visible = false;
        }

        private void pictureBoxTable10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order bezorgd op tafel 10");
            pictureBoxTable10.Visible = false;
        }
    }
}
