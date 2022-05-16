using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class TableOverviewForm : Form
    {
        public TableOverviewForm()
        {
            InitializeComponent();
            this.buttonTable1.Click += TableClick;
            this.buttonTable2.Click += TableClick;
            this.buttonTable3.Click += TableClick;
            this.buttonTable4.Click += TableClick;
            this.buttonTable5.Click += TableClick;
            this.buttonTable6.Click += TableClick;
            this.buttonTable7.Click += TableClick;
            this.buttonTable8.Click += TableClick;
            this.buttonTable9.Click += TableClick;
            this.buttonTable10.Click += TableClick;
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

            //selectedTable = 1;            
            //CheckoutForm checkoutForm = new CheckoutForm(selectedTable);
            buttonTable1.BackColor = Color.Red;
        }

        private void buttonTable2_Click(object sender, EventArgs e)
        {
            // pop up met; hoeveel gasten komen hier zitten? koppelen met database 
            // als bezet is, dan buttonTable2.BackColor = Color.Red;
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
    }
}
