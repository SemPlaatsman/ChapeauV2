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
            int TableId = 1;
            TableForm tableForm = new TableForm(TableId);
            tableForm.ShowDialog();
            this.Close();

            buttonTable1.BackColor = Color.Red;
        }

        private void buttonTable2_Click(object sender, EventArgs e)
        {
            // pop up met; hoeveel gasten komen hier zitten? koppelen met database 
            // als bezet is, dan buttonTable2.BackColor = Color.Red;
            int TableId = 2;
            TableForm tableForm = new TableForm(TableId);
            tableForm.ShowDialog();
            this.Close();

            buttonTable1.BackColor = Color.Red;
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
            

        }

        private void AssignTables()
        {
            TableService tableService = new TableService();
            tables = tableService.GetAllTables();

            int tableTagIndex = 0;
            foreach (Control control in this.Controls)
            {
                
                if (control.GetType() == typeof(Button) && control != buttonUitloggen)
                {
                    control.Click += TableClick;
                    control.Tag = tables[tableTagIndex++];
                }
            }

        }
    }
}
