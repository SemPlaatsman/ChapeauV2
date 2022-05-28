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
        public KitchenDisplay()
        {
            InitializeComponent();
            FillLists();
            flowLayoutMeeBezig.SendToBack();
            dataGridViewMoetNog.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewMoetNog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewMoetNog.RowHeadersVisible = false;
            dataGridViewMoetNog.ReadOnly = true;
            dataGridViewMoetNog.Columns[3].ReadOnly = false;
            dataGridViewMoetNog.BackgroundColor = SystemColors.Control;
            dataGridViewMoetNog.BorderStyle = BorderStyle.None;

            flowLayoutMeeBezig.FlowDirection = FlowDirection.TopDown;
            flowLayoutMeeBezig.AutoScroll = true;
            flowLayoutMeeBezig.WrapContents = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //KitchenService kitchenService = new KitchenService();
            //List<KitchenOrderOverview> kitchenOrderOverviews = kitchenService.GetKitchenOverviews();
        }

        private void FillLists()
        {
            KitchenService kitchenService = new KitchenService();
            List<KitchenOrderOverview> kitchenOrderOverviews = kitchenService.GetKitchenOverviews();

            dataGridViewMoetNog.Columns[0].Width = 57;
            dataGridViewMoetNog.Columns[1].Width = 72;
            dataGridViewMoetNog.Columns[2].Width = 425;
            dataGridViewMoetNog.Columns[3].Width = 75;

            foreach (KitchenOrderOverview kitchenOverview in kitchenOrderOverviews)
            {
                List<OrderGerecht> gerechten = kitchenOverview.GetNextMeeBezigList();
                if (gerechten.Count > 0)
                {
                    AddToMeeBezigLayout(kitchenOverview);
                    continue;
                }
                gerechten = kitchenOverview.GetNextMoetNogList();
                if (gerechten.Count > 0)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewMoetNog.Rows[0].Clone();
                    row.Cells[0].Value = kitchenOverview.OrderId.ToString();
                    row.Cells[1].Value = kitchenOverview.TableId.ToString();
                    row.Cells[2].Value = GetMenuItems(gerechten);
                    row.Cells[3].Value = "Verwerk";
                    row.Tag = kitchenOverview;
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

        private void AddToMeeBezigLayout(KitchenOrderOverview kitchenOrderOverview)
        {
            List<OrderGerecht> gerechten = kitchenOrderOverview.GetNextMeeBezigList();

            Label orderLabel = new Label();
            orderLabel.Text = $"Order {kitchenOrderOverview.OrderId} voor tafel {kitchenOrderOverview.TableId}";
            orderLabel.Visible = true;
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Segoe UI", 12);
            this.Controls.Add(orderLabel);
            flowLayoutMeeBezig.Controls.Add(orderLabel);

            DataGridView dataGridView = new DataGridView();

            DataGridViewTextBoxColumn txtBoxColumn = new DataGridViewTextBoxColumn();
            txtBoxColumn.HeaderText = "Bestelling";
            txtBoxColumn.Width = 491;
            dataGridView.Columns.Add(txtBoxColumn);

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Klaar?";
            buttonColumn.Width = 87;
            dataGridView.Columns.Add(buttonColumn);

            dataGridView.Width = 582;
            dataGridView.Visible = true;
            dataGridView.ReadOnly = true;
            dataGridView.Columns[1].ReadOnly = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView.CellContentClick += dataGridViewsMeeBezig_CellContentClick;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.Tag = kitchenOrderOverview;
            this.Controls.Add(dataGridView);
            flowLayoutMeeBezig.Controls.Add(dataGridView);

            
            foreach (OrderGerecht orderGerecht in gerechten)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                row.Cells[0].Value = orderGerecht.MenuItem.ProductName;
                if (!string.IsNullOrEmpty(orderGerecht.Remark))
                {
                    row.Cells[0].Value += $" ({orderGerecht.Remark})";
                }

                DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                buttonCell.FlatStyle = FlatStyle.Popup;
                if (orderGerecht.Status == OrderStatus.Klaar)
                {
                    buttonCell.Style.BackColor = Color.MediumSpringGreen;
                    buttonCell.Value = "Klaar";
                }
                else
                {
                    buttonCell.Style.BackColor = Color.OrangeRed;
                    buttonCell.Value = "Moet nog";
                }
                row.Cells[1] = buttonCell;
                row.Tag = orderGerecht;
                dataGridView.Rows.Add(row);
            }
            dataGridView.Height = CalculateDataGridViewHeight(dataGridView);
        }

        private void dataGridViewsMeeBezig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("yes");
        }

        private void DataGridView_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private int CalculateDataGridViewHeight(DataGridView dataGridView)
        {
            int output = 40;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                output += row.Height;
            }
            return output;
        }

        private void dataGridViewMoetNog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && dataGridViewMoetNog.Rows[e.RowIndex].Tag != null)
            {
                //string test = $"{((KitchenOrderOverview)dataGridViewMoetNog.Rows[e.RowIndex].Tag).OrderId}";
                //MessageBox.Show(test);
                //TODO: verander status naar mee bezig
                //TODO: reload lists
                //AddToMeeBezigLayout((KitchenOrderOverview)dataGridViewMoetNog.Rows[e.RowIndex].Tag);
            }
        }
    }
}
