using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErrorHandling;
using HashingAlgorithms;
using ChapeauLogica;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class BarDisplay : Form
    {
        private Timer timer;

        private BarService barService;
        
        public BarDisplay()
        {
            timer = new Timer();
            barService = new BarService();

            timer.Tick += BarTickEvent;
            timer.Interval = 10000;
            //timer.Start();

            InitializeComponent();
        }

        private void BarTickEvent(object sender, EventArgs e)
        {
            //TODO: Refresh bar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Refresh bar
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
