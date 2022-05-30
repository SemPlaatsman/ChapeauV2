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
        private KitchenService kitchenService;

        public KitchenDisplay()
        {
            kitchenService = new KitchenService();

            InitializeComponent();

            flowLayoutMeeBezig.SendToBack();

            SetDefaultGridProperties(dataGridViewMoetNog);
            dataGridViewMoetNog.Columns[4].ReadOnly = false;

            dataGridViewMoetNog.Columns[0].Width = 42;
            dataGridViewMoetNog.Columns[1].Width = 38;
            dataGridViewMoetNog.Columns[2].Width = 40;
            dataGridViewMoetNog.Columns[3].Width = 380;
            dataGridViewMoetNog.Columns[4].Width = 80;

            SetDefaultGridProperties(dataGridViewOverzicht);
            dataGridViewOverzicht.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewOverzicht.Columns[0].Width = 42;
            dataGridViewOverzicht.Columns[1].Width = 38;
            dataGridViewOverzicht.Columns[2].Width = 235;
            dataGridViewOverzicht.Columns[3].Width = 65;

            flowLayoutMeeBezig.FlowDirection = FlowDirection.TopDown;
            flowLayoutMeeBezig.AutoScroll = true;
            flowLayoutMeeBezig.WrapContents = false;

            LoadKitchenDisplayData();
        }
        
        private void LoadKitchenDisplayData()
        {
            dataGridViewMoetNog.AllowUserToAddRows = true;
            dataGridViewOverzicht.AllowUserToAddRows = true;

            FillLists();

            dataGridViewMoetNog.AllowUserToAddRows = false;
            dataGridViewOverzicht.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadKitchenDisplayData();
        }

        private void FillLists()
        {
            dataGridViewMoetNog.Rows.Clear();
            flowLayoutMeeBezig.Controls.Clear();
            dataGridViewOverzicht.Rows.Clear();

            List<KitchenOrderOverview> kitchenOrderOverviews = kitchenService.GetKitchenOverviews();

            foreach (KitchenOrderOverview kitchenOverview in kitchenOrderOverviews)
            {
                AddToOverviewList(kitchenOverview);
                List<OrderGerecht> gerechten = kitchenOverview.GetNextMeeBezigList();
                if (gerechten.Count > 0)
                {
                    AddGridToMeeBezigLayout(kitchenOverview);
                    continue;
                }
                gerechten = kitchenOverview.GetNextMoetNogList();
                if (gerechten.Count > 0)
                {
                    AddToMoetNogList(kitchenOverview, gerechten);
                }
            }
        }

        private void AddToMoetNogList(KitchenOrderOverview kitchenOverview, List<OrderGerecht> gerechten)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewMoetNog.Rows[0].Clone();
            row.Cells[0].Value = kitchenOverview.OrderId.ToString();
            row.Cells[1].Value = kitchenOverview.TableId.ToString();
            row.Cells[2].Value = ((TimeSpan)(DateTime.Now - gerechten.OrderBy(g => g.TimeOfOrder).First().TimeOfOrder)).ToString(@"hh\:mm");
            row.Cells[3].Value = GetMenuItems(gerechten);
            row.Cells[4].Value = "Verwerk";
            row.MinimumHeight = 30;
            row.Tag = kitchenOverview;
            dataGridViewMoetNog.Rows.Add(row);
        }

        private void AddToOverviewList(KitchenOrderOverview kitchenOverview)
        {
            //TODO: vul een lijst met alle orders
            DataGridViewRow row = (DataGridViewRow)dataGridViewOverzicht.Rows[0].Clone();
            row.Cells[0].Value = kitchenOverview.OrderId.ToString();
            row.Cells[1].Value = kitchenOverview.TableId.ToString();
            row.Cells[2].Value = kitchenOverview.ToStringOverzicht();
            row.Cells[3].Value = "Open";
            row.MinimumHeight = 30;
            row.Tag = kitchenOverview;
            dataGridViewOverzicht.Rows.Add(row);
        }

        private string GetMenuItems(List<OrderGerecht> gerechten)
        {
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
            string list = $"{gerechten[0].MenuItem.Type}en:";
            foreach (KeyValuePair<string, int> kvp in menuItems)
            {
                list += $"\n{kvp.Key} : {kvp.Value}x";
            }
            return list;
        }

        private void AddGridToMeeBezigLayout(KitchenOrderOverview kitchenOrderOverview)
        {
            List<OrderGerecht> gerechten = kitchenOrderOverview.GetNextMeeBezigList();

            Label orderLabel = new Label();
            orderLabel.Text = $"Order {kitchenOrderOverview.OrderId}: {gerechten[0].MenuItem.Type}en voor tafel {kitchenOrderOverview.TableId}";
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
            dataGridView.Tag = kitchenOrderOverview;
            this.Controls.Add(dataGridView);
            flowLayoutMeeBezig.Controls.Add(dataGridView);

            AddGerechtenToDataGridView(gerechten, dataGridView);
        }

        private void AddGerechtenToDataGridView(List<OrderGerecht> gerechten, DataGridView dataGridView)
        {
            foreach (OrderGerecht orderGerecht in gerechten)
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
                }
                LoadKitchenDisplayData();
            }
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
            DataGridView dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex].CellType == typeof(DataGridViewButtonCell) && dataGridView.Rows[e.RowIndex].Tag != null)
            {
                dataGridView.ClearSelection();
                KitchenOrderOverview kitchenOverview = (KitchenOrderOverview)dataGridView.Rows[e.RowIndex].Tag;
                kitchenService.ChangeNextOrderStatus(kitchenOverview.GetNextMoetNogList()[0], OrderStatus.MeeBezig);
                LoadKitchenDisplayData();
            }
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

        private void dataGridViewOverzicht_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex].CellType == typeof(DataGridViewButtonCell) && dataGridView.Rows[e.RowIndex].Tag != null)
            {
                KitchenOrderOverviewForm kitchenOrderOverviewForm = new KitchenOrderOverviewForm((KitchenOrderOverview)dataGridView.Rows[e.RowIndex].Tag);
                kitchenOrderOverviewForm.ShowDialog();
            }
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
