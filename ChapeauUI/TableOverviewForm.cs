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
            buttonTable1.BackColor = Color.LightGreen;
            if (buttonTable1.BackColor != Color.Red)
            {
                buttonTable1.BackColor = Color.LightGreen;
            }
            else
            {
                buttonTable1.BackColor = Color.Red;
            }
        }
    }
}
