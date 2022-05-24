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
        private Employee Employee; // toevoegen in de constructor later. 
        private List<Table> tables;
        public TableOverviewForm()
        {
            InitializeComponent();
            AssignTables();
            //this.Employee = employee;
        }
        //public int selectedTable = 0;

        private void buttonTable1_Click(object sender, EventArgs e)
        {
            // pop up met; hoeveel gasten komen hier zitten? koppelen met database 
            // als bezet is, dan buttonTable1.BackColor = Color.Red;
            //int TableId = 1;
            //TableForm tableForm = new TableForm(TableId);
            //tableForm.ShowDialog();
            //this.Close();

            //buttonTable1.BackColor = Color.Red;
        }

        private void buttonTable2_Click(object sender, EventArgs e)
        {
            // pop up met; hoeveel gasten komen hier zitten? koppelen met database 
            // als bezet is, dan buttonTable2.BackColor = Color.Red;
            //int TableId = 2;
            //TableForm tableForm = new TableForm(TableId);
            //tableForm.ShowDialog();
            //this.Close();

            //buttonTable1.BackColor = Color.Red;
        }

        private void buttonUitloggen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        private void TableClick(object sender, EventArgs e) 
        {
            //parse een sender naar een Button, parse de Tag van die Button naar een Table en geef de TableID van die Table aan de int tableID
            int tableID = ((Table)((Button)sender).Tag).TableID;
            
            //maak een nieuwe TableForm en geef het bijbehorende tableID mee
            TableForm tableForm = new TableForm(tableID);
            tableForm.ShowDialog();
        }

        private void AssignTables()
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
                    AssignTag(control);
                }
            }

        }

        private void AssignTag(Control control)
        {
            foreach (Table table in tables)
            {
                //als de TableID van een table uit de database overeenkomt met de text van de button voeg dan die Table aan de tag van die button toe
                if (table.TableID == int.Parse(control.Text))
                {
                    control.Tag = table;
                    break;
                }
            }
        }
    }
}
