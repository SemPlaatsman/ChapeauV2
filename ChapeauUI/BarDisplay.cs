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
            InitializeComponent();
            
            timer = new Timer();
            barService = new BarService();

            timer.Tick += BarTickEvent;
            timer.Interval = 30000;
            //timer.Start();

            SetDefaultGridProperties(dataGridViewMoetNog);
            dataGridViewMoetNog.Columns[4].ReadOnly = false;

            SetDefaultGridProperties(dataGridViewOverzicht);
            dataGridViewOverzicht.Columns[3].ReadOnly = false;

            LoadBarDisplayData();
        }

        private void BarTickEvent(object sender, EventArgs e)
        {
            LoadBarDisplayData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadBarDisplayData();
        }

        private void buttonUitloggen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        public void LoadBarDisplayData()
        {
            dataGridViewMoetNog.AllowUserToAddRows = true;
            dataGridViewOverzicht.AllowUserToAddRows = true;

            dataGridViewMoetNog.Rows.Clear();
            flowLayoutMeeBezig.Controls.Clear();
            dataGridViewOverzicht.Rows.Clear();

            List<BarOrderOverview> barOrderOverviews = barService.GetBarOverviews();

            foreach (BarOrderOverview barOverview in barOrderOverviews)
            {
                AddToOverviewList(barOverview);
                List<OrderGerecht> drinken = barOverview.GetNextMeeBezigList();
                if (drinken.Count > 0)
                {
                    AddGridToMeeBezigLayout(barOverview);
                    continue;
                }
                drinken = barOverview.GetNextMoetNogList();
                if (drinken.Count > 0)
                {
                    AddToMoetNogList(barOverview, drinken);
                }
            }

            dataGridViewMoetNog.ClearSelection();
            dataGridViewOverzicht.ClearSelection();

            dataGridViewMoetNog.AllowUserToAddRows = false;
            dataGridViewOverzicht.AllowUserToAddRows = false;
        }

        private void AddToMoetNogList(BarOrderOverview barOverview, List<OrderGerecht> drinken)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewMoetNog.Rows[0].Clone();
            row.Cells[0].Value = barOverview.OrderId.ToString();
            row.Cells[1].Value = barOverview.TableId.ToString();
            row.Cells[2].Value = ((TimeSpan)(DateTime.Now - drinken.OrderBy(g => g.TimeOfOrder).First().TimeOfOrder)).ToString(@"hh\:mm");
            row.Cells[3].Value = GetMenuItems(drinken);
            row.Cells[4].Value = "Verwerk";
            row.MinimumHeight = 30;
            row.Tag = barOverview;
            dataGridViewMoetNog.Rows.Add(row);
        }

        private void AddToOverviewList(BarOrderOverview kitchenOverview)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewOverzicht.Rows[0].Clone();
            row.Cells[0].Value = kitchenOverview.OrderId.ToString();
            row.Cells[1].Value = kitchenOverview.TableId.ToString();
            row.Cells[2].Style.BackColor = GetColor(kitchenOverview.Drinken);
            row.Cells[2].Value = GetStatus(kitchenOverview.Drinken);
            row.Cells[3].Value = "Open";
            row.MinimumHeight = dataGridViewOverzicht.Columns[3].Width;
            row.Tag = kitchenOverview;
            dataGridViewOverzicht.Rows.Add(row);
        }

        private Color GetColor(List<OrderGerecht> drinken)
        {
            if (drinken.Count == 0)
            {
                return Color.Empty;
            }
            else if (OrderOverview.ListOnlyHasStatus(drinken, OrderStatus.Klaar))
            {
                return Color.MediumSpringGreen;
            }
            else if (drinken[0].Status == OrderStatus.MoetNog)
            {
                return Color.OrangeRed;
            }
            return Color.Yellow;
        }

        private string GetStatus(List<OrderGerecht> drinken)
        {
            string status = "";
            if (drinken.Count == 0)
            {
                return status;
            }
            else if (OrderOverview.ListOnlyHasStatus(drinken, OrderStatus.Klaar))
            {
                status = OrderStatus.Klaar.ToString();
            }
            else if (drinken[0].Status == OrderStatus.MoetNog)
            {
                status = OrderStatus.MoetNog.ToString();
            }
            else
            {
                status = OrderStatus.MeeBezig.ToString();
            }
            return Regex.Replace($"{status}", "([A-Z])", " $1").Trim();
        }

        private string GetMenuItems(List<OrderGerecht> drinken)
        {
            Dictionary<string, int> menuItems = new Dictionary<string, int>();
            foreach (OrderGerecht drink in drinken)
            {
                string drinkName = drink.MenuItem.ProductName;
                if (!string.IsNullOrEmpty(drink.Remark.Trim()))
                {
                    drinkName += $" ({drink.Remark})";
                }
                if (menuItems.ContainsKey(drinkName))
                {
                    menuItems[drinkName]++;
                }
                else
                {
                    menuItems.Add(drinkName, 1);
                }
            }
            
            string list = $"{menuItems.First().Key} : {menuItems.First().Value}:";
            for (int i = 1; i < menuItems.Count(); i++)
            {
                list += $"\n{menuItems.ElementAt(i).Key} : {menuItems.ElementAt(i).Value}x";
            }
            return list;
        }

        private void AddGridToMeeBezigLayout(BarOrderOverview barOrderOverview)
        {
            List<OrderGerecht> drinken = barOrderOverview.GetNextMeeBezigList();
            if (drinken.Count() <= 0)
                return;

            Label orderLabel = new Label();
            orderLabel.Text = $"Order {barOrderOverview.OrderId}: {drinken[0].MenuItem.Type}en voor tafel {barOrderOverview.TableId}";
            orderLabel.Visible = true;
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Segoe UI", 12);
            this.Controls.Add(orderLabel);
            flowLayoutMeeBezig.Controls.Add(orderLabel);

            DataGridView dataGridView = new DataGridView();

            DataGridViewTextBoxColumn txtBoxColumnTijd = new DataGridViewTextBoxColumn();
            txtBoxColumnTijd.HeaderText = "Tijd";
            txtBoxColumnTijd.Width = 44;
            dataGridView.Columns.Add(txtBoxColumnTijd);

            DataGridViewTextBoxColumn txtBoxColumnBestelling = new DataGridViewTextBoxColumn();
            txtBoxColumnBestelling.HeaderText = "Bestelling";
            txtBoxColumnBestelling.Width = 409;
            dataGridView.Columns.Add(txtBoxColumnBestelling);

            DataGridViewButtonColumn buttonColumnKlaar = new DataGridViewButtonColumn();
            buttonColumnKlaar.HeaderText = "Klaar?";
            buttonColumnKlaar.Width = 75;
            dataGridView.Columns.Add(buttonColumnKlaar);

            SetDefaultGridProperties(dataGridView);
            dataGridView.Width = 532;
            dataGridView.Columns[2].ReadOnly = false;
            dataGridView.CellContentClick += dataGridViewsMeeBezig_CellContentClick;
            dataGridView.Tag = barOrderOverview;
            this.Controls.Add(dataGridView);
            flowLayoutMeeBezig.Controls.Add(dataGridView);

            AddDrinksToDataGridView(drinken, dataGridView);

            dataGridView.ClearSelection();
        }

        public void AddDrinksToDataGridView(List<OrderGerecht> drinken, DataGridView dataGridView)
        {
            foreach (OrderGerecht orderGerecht in drinken)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                row.Cells[0].Value = ((TimeSpan)(DateTime.Now - orderGerecht.TimeOfOrder)).ToString(@"hh\:mm");
                row.Cells[1].Value = orderGerecht.MenuItem.ProductName;
                if (!string.IsNullOrEmpty(orderGerecht.Remark))
                {
                    row.Cells[1].Value += $" ({orderGerecht.Remark})";
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
                row.Cells[2] = buttonCell;
                row.MinimumHeight = 30;
                row.Tag = orderGerecht;
                dataGridView.Rows.Add(row);
            }
            dataGridView.AllowUserToAddRows = false;
            dataGridView.Height = CalculateDataGridViewHeight(dataGridView);
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

        public static void SetDefaultGridProperties(DataGridView dataGridView)
        {
            dataGridView.Visible = true;
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Columns.Cast<DataGridViewColumn>().ToList().ForEach(column => column.SortMode = DataGridViewColumnSortMode.NotSortable);
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.BackgroundColor = SystemColors.Control;
        }

        private void dataGridViewMoetNog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex].CellType == typeof(DataGridViewButtonCell) && dataGridView.Rows[e.RowIndex].Tag != null)
            {
                dataGridView.ClearSelection();
                BarOrderOverview barOverview = (BarOrderOverview)dataGridView.Rows[e.RowIndex].Tag;
                List<OrderGerecht> drinken = barOverview.GetNextMoetNogList();
                if (drinken.Count > 0)
                    barService.ChangeOrderStatusWithType(drinken.First(), OrderStatus.MeeBezig);
                LoadBarDisplayData();
            }
        }

        private void dataGridViewOverzicht_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex].CellType == typeof(DataGridViewButtonCell) && dataGridView.Rows[e.RowIndex].Tag != null)
            {
                this.timer.Stop();
                OrderOverviewForm OrderOverviewForm = new OrderOverviewForm((BarOrderOverview)dataGridView.Rows[e.RowIndex].Tag);
                OrderOverviewForm.ShowDialog();
                LoadBarDisplayData();
                this.timer.Start();
            }
        }

        private void dataGridViewsMeeBezig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex].CellType == typeof(DataGridViewButtonCell) && dataGridView.Rows[e.RowIndex].Tag != null)
            {
                dataGridView.ClearSelection();
                OrderGerecht orderGerecht = (OrderGerecht)dataGridView.Rows[e.RowIndex].Tag;
                OrderGerechtService orderGerechtService = new OrderGerechtService();
                if (orderGerecht.Status == OrderStatus.Klaar)
                {
                    orderGerechtService.ChangeOrderGerechtStatus(orderGerecht, OrderStatus.MoetNog);
                }
                else
                {
                    orderGerechtService.ChangeOrderGerechtStatus(orderGerecht, OrderStatus.Klaar);
                    BarOrderOverview barOverview = (BarOrderOverview)dataGridView.Tag;
                    orderGerecht.Status = OrderStatus.Klaar;
                    if (OrderOverview.ListOnlyHasStatus(barOverview.Drinken, OrderStatus.Klaar))
                    {
                        barService.ChangeServeStatusWithType(orderGerecht, ServeerStatus.KanGeserveerdWorden);
                    }
                }
                LoadBarDisplayData();
            }
        }

        private void BarDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }
    }
}
