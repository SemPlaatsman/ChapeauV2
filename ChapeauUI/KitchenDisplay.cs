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
using ChapeauLogica;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class KitchenDisplay : Form
    {
        int nrOfBoxes = 20;
        public KitchenDisplay()
        {
            InitializeComponent();
            FillLists();
            flowLayoutPanel1.SendToBack();
            dataGridViewMoetNog.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewMoetNog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewMoetNog.RowHeadersVisible = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //KitchenService kitchenService = new KitchenService();
            //List<KitchenOrderOverview> kitchenOrderOverviews = kitchenService.GetKitchenOverviews();

            TextBox txtBox = new TextBox();
            txtBox.Location = new Point(600, nrOfBoxes);
            nrOfBoxes += 25;
            txtBox.Visible = true;
            //Controls.Add(txtBox);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Controls.Add(txtBox);
        }

        private void FillLists()
        {
            KitchenService kitchenService = new KitchenService();
            List<KitchenOrderOverview> kitchenOrderOverviews = kitchenService.GetKitchenOverviews();

            dataGridViewMoetNog.Columns[0].Width = 57;
            dataGridViewMoetNog.Columns[1].Width = 72;
            dataGridViewMoetNog.Columns[2].Width = 480;
            dataGridViewMoetNog.Columns[3].Width = 94;

            foreach (KitchenOrderOverview kitchenOverview in kitchenOrderOverviews)
            {
                List<OrderGerecht> gerechten = kitchenOverview.GetNextOrderList();
                if (gerechten.Count > 0)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewMoetNog.Rows[0].Clone();
                    row.Cells[0].Value = kitchenOverview.OrderId.ToString();
                    row.Cells[1].Value = kitchenOverview.TableId.ToString();
                    row.Cells[2].Value = GetMenuItems(gerechten);
                    row.Cells[3].Value = "Verwerk";
                    dataGridViewMoetNog.Rows.Add(row);
                }
            }
        }

        private string GetMenuItems(List<OrderGerecht> gerechten)
        {
            string list = "";
            Dictionary<string, int> menuItems = new Dictionary<string, int>();
            foreach (OrderGerecht gerecht in gerechten)
            {
                string gerechtName = gerecht.MenuItem.ProductName;
                if (!string.IsNullOrEmpty(gerecht.Remark.Trim()))
                {
                    gerechtName += $" ({gerecht.Remark})";
                }
                if (menuItems.ContainsKey(gerechtName))
                {
                    menuItems[gerechtName]++;
                }
                else
                {
                    menuItems.Add(gerechtName, 1);
                }
            }
            foreach (KeyValuePair<string, int> kvp in menuItems)
            {
                list += $"{kvp.Key} : {kvp.Value}x\n";
            }
            return list;
        }
    }
}
