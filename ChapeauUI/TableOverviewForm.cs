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
        }

        private void buttonTable1_Click(object sender, EventArgs e)
        {
            // pop up met; hoeveel gasten komen hier zitten? koppelen met database 
            // als bezet is, dan buttonTable1.BackColor = Color.Red;
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
    }
}
