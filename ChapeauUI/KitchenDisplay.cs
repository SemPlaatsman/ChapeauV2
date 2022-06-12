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
using ChapeauInterfaces;

namespace ChapeauUI
{
    public partial class KitchenDisplay : Form
    {
        private Timer timer;

        private KitchenService kitchenService;

        public KitchenDisplay()
        {
            InitializeComponent();
            try
            {
                this.timer = new Timer();
                this.kitchenService = new KitchenService();

                this.timer.Tick += KitchenTickEvent;
                this.timer.Interval = 30000;
                this.timer.Start();

                SetDefaultGridProperties(dataGridViewMoetNog);
                dataGridViewMoetNog.Columns[5].ReadOnly = false;

                SetDefaultGridProperties(dataGridViewOverzicht);
                dataGridViewOverzicht.Columns[6].ReadOnly = false;
            }
            catch (ChapeauException ce)
            {
                MessageBox.Show(ce.Message);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                MessageBox.Show("Something went wrong while loading the kitchen display.");
            }
            LoadKitchenDisplayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadKitchenDisplayData();
        }

        private void LoadKitchenDisplayData()
        {
            try
            {
                dataGridViewMoetNog.AllowUserToAddRows = true;
                dataGridViewOverzicht.AllowUserToAddRows = true;

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

                dataGridViewMoetNog.Sort(dataGridViewMoetNog.Columns[3], ListSortDirection.Descending);

                dataGridViewMoetNog.ClearSelection();
                dataGridViewOverzicht.ClearSelection();
            }
            catch (ChapeauException ce)
            {
                MessageBox.Show(ce.Message);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                MessageBox.Show("Something went wrong while loading the kitchen display.");
            }
            finally
            {
                dataGridViewMoetNog.AllowUserToAddRows = false;
                dataGridViewOverzicht.AllowUserToAddRows = false;
            }
            
        }

        private void AddToMoetNogList(KitchenOrderOverview kitchenOverview, List<OrderGerecht> gerechten)
        {
            try
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewMoetNog.Rows[0].Clone();
                row.Cells[0].Value = kitchenOverview.OrderId.ToString();
                row.Cells[1].Value = kitchenOverview.TableId.ToString();
                row.Cells[2].Value = gerechten.First().TimeOfOrder.ToString("HH:mm");
                row.Cells[3].Value = ((TimeSpan)(DateTime.Now - gerechten.OrderBy(g => g.TimeOfOrder).First().TimeOfOrder)).ToString(@"hh\:mm");
                row.Cells[4].Value = GetMenuItems(gerechten);
                row.Cells[5].Value = "Verwerk";
                row.MinimumHeight = 30;
                row.Tag = kitchenOverview;
                dataGridViewMoetNog.Rows.Add(row);
            }
            catch (ChapeauException ce)
            {
                MessageBox.Show(ce.Message);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                MessageBox.Show("Something went wrong while loading the kitchen display.");
            }
        }

        private void AddToOverviewList(KitchenOrderOverview kitchenOverview)
        {
            try
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewOverzicht.Rows[0].Clone();
                row.Cells[0].Value = kitchenOverview.OrderId.ToString();
                row.Cells[1].Value = kitchenOverview.TableId.ToString();
                row.Cells[2].Style.BackColor = GetColor(kitchenOverview.Voorgerechten);
                row.Cells[2].Value = GetStatus(kitchenOverview.Voorgerechten);
                row.Cells[3].Style.BackColor = GetColor(kitchenOverview.Tussengerechten);
                row.Cells[3].Value = GetStatus(kitchenOverview.Tussengerechten);
                row.Cells[4].Style.BackColor = GetColor(kitchenOverview.Hoofdgerechten);
                row.Cells[4].Value = GetStatus(kitchenOverview.Hoofdgerechten);
                row.Cells[5].Style.BackColor = GetColor(kitchenOverview.Nagerechten);
                row.Cells[5].Value = GetStatus(kitchenOverview.Nagerechten);
                row.Cells[6].Value = "Open";
                row.MinimumHeight = dataGridViewOverzicht.Columns[6].Width;
                row.Tag = kitchenOverview;
                dataGridViewOverzicht.Rows.Add(row);
            }
            catch (ChapeauException ce)
            {
                MessageBox.Show(ce.Message);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                MessageBox.Show("Something went wrong while loading the kitchen display.");
            }
        }
        
        private Color GetColor(List<OrderGerecht> gerechten)
        {
            try
            {
                if (gerechten.Count == 0)
                {
                    return Color.Empty;
                }
                else if (OrderOverview.ListOnlyHasStatus(gerechten, OrderStatus.Klaar))
                {
                    return Color.MediumSpringGreen;
                }
                else if (gerechten[0].Status == OrderStatus.MoetNog)
                {
                    return Color.OrangeRed;
                }
            }
            catch (ChapeauException ce)
            {
                MessageBox.Show(ce.Message);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                MessageBox.Show("Something went wrong while loading the kitchen display.");
            }
            return Color.Yellow;
        }

        private string GetStatus(List<OrderGerecht> gerechten)
        {
            string status = "";
            try
            {
                if (gerechten.Count == 0)
                {
                    return status;
                }
                else if (OrderOverview.ListOnlyHasStatus(gerechten, OrderStatus.Klaar))
                {
                    status = OrderStatus.Klaar.ToString();
                }
                else if (gerechten[0].Status == OrderStatus.MoetNog)
                {
                    status = OrderStatus.MoetNog.ToString();
                }
                else
                {
                    status = OrderStatus.MeeBezig.ToString();
                }
            }
            catch (ChapeauException ce)
            {
                MessageBox.Show(ce.Message);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                MessageBox.Show("Something went wrong while loading the kitchen display.");
            }
            return Regex.Replace($"{status}", "([A-Z])", " $1").Trim();
        }

        private string GetMenuItems(List<OrderGerecht> gerechten)
        {
            string list = "";
            try
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
                list = $"{gerechten.First().MenuItem.Type}en:";
                foreach (KeyValuePair<string, int> kvp in menuItems)
                {
                    list += $"\n{kvp.Key} : {kvp.Value}x";
                }
            }
            catch (ChapeauException ce)
            {
                MessageBox.Show(ce.Message);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                MessageBox.Show("Something went wrong while loading the kitchen display.");
            }
            return list;
        }

        private void AddGridToMeeBezigLayout(KitchenOrderOverview kitchenOrderOverview)
        {
            try
            {
                List<OrderGerecht> gerechten = kitchenOrderOverview.GetNextMeeBezigList();
                if (gerechten.Count() <= 0)
                    return;

                Label orderLabel = new Label();
                orderLabel.Text = $"Order {kitchenOrderOverview.OrderId}: {gerechten[0].MenuItem.Type}en voor tafel {kitchenOrderOverview.TableId}";
                orderLabel.Visible = true;
                orderLabel.AutoSize = true;
                orderLabel.Font = new Font("Segoe UI", 12);
                this.Controls.Add(orderLabel);
                flowLayoutMeeBezig.Controls.Add(orderLabel);

                DataGridView dataGridView = new DataGridView();

                DataGridViewTextBoxColumn txtBoxColumnTijd = new DataGridViewTextBoxColumn();
                txtBoxColumnTijd.HeaderText = "Looptijd";
                txtBoxColumnTijd.Width = 55;
                dataGridView.Columns.Add(txtBoxColumnTijd);

                DataGridViewTextBoxColumn txtBoxColumnBestelling = new DataGridViewTextBoxColumn();
                txtBoxColumnBestelling.HeaderText = "Bestelling";
                txtBoxColumnBestelling.Width = 378;
                dataGridView.Columns.Add(txtBoxColumnBestelling);

                DataGridViewButtonColumn buttonColumnKlaar = new DataGridViewButtonColumn();
                buttonColumnKlaar.HeaderText = "Klaar?";
                buttonColumnKlaar.Width = 70;
                dataGridView.Columns.Add(buttonColumnKlaar);

                SetDefaultGridProperties(dataGridView);
                dataGridView.Width = 504;
                dataGridView.Columns[2].ReadOnly = false;
                dataGridView.CellContentClick += dataGridViewsMeeBezig_CellContentClick;
                dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Descending);
                dataGridView.Tag = kitchenOrderOverview;
                this.Controls.Add(dataGridView);
                flowLayoutMeeBezig.Controls.Add(dataGridView);

                AddGerechtenToDataGridView(gerechten, dataGridView);

                dataGridView.ClearSelection();
            }
            catch (ChapeauException ce)
            {
                MessageBox.Show(ce.Message);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                MessageBox.Show("Something went wrong while loading the kitchen display.");
            }
        }

        private void AddGerechtenToDataGridView(List<OrderGerecht> gerechten, DataGridView dataGridView)
        {
            try
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
            catch (ChapeauException ce)
            {
                MessageBox.Show(ce.Message);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                MessageBox.Show("Something went wrong while loading the kitchen display.");
            }
        }

        private void dataGridViewsMeeBezig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dataGridView = (DataGridView)sender;
                if (dataGridView.Columns[e.ColumnIndex].CellType == typeof(DataGridViewButtonCell) && dataGridView.Rows[e.RowIndex].Tag != null)
                {
                    dataGridView.ClearSelection();
                    OrderGerecht orderGerecht = (OrderGerecht)dataGridView.Rows[e.RowIndex].Tag;
                    OrderGerechtService orderGerechtService = new OrderGerechtService();
                    if (orderGerecht.Status == OrderStatus.Klaar)
                        orderGerechtService.ChangeOrderGerechtStatus(orderGerecht, OrderStatus.MoetNog);
                    else
                    {
                        orderGerechtService.ChangeOrderGerechtStatus(orderGerecht, OrderStatus.Klaar);
                        KitchenOrderOverview kitchenOverview = (KitchenOrderOverview)dataGridView.Tag;
                        orderGerecht.Status = OrderStatus.Klaar;
                        if (OrderOverview.ListOnlyHasStatus(kitchenOverview.TypeToList(orderGerecht.MenuItem.Type), OrderStatus.Klaar))
                        {
                            kitchenService.ChangeServeStatusWithType(orderGerecht, ServeerStatus.KanGeserveerdWorden);
                        }
                    }
                    LoadKitchenDisplayData();
                }
            }
            catch (ChapeauException ce)
            {
                MessageBox.Show(ce.Message);
            }
            catch (Exception ex)
            {
                ErrorLogger.WriteLogToFile(ex);
                MessageBox.Show("Something went wrong while loading the kitchen display.");
            }
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
            try
            {
                DataGridView dataGridView = (DataGridView)sender;
                if (e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex].CellType == typeof(DataGridViewButtonCell) && dataGridView.Rows[e.RowIndex].Tag != null)
                {
                    dataGridView.ClearSelection();
                    KitchenOrderOverview kitchenOverview = (KitchenOrderOverview)dataGridView.Rows[e.RowIndex].Tag;
                    List<OrderGerecht> gerechten = kitchenOverview.GetNextMoetNogList();
                    if (gerechten.Count > 0)
                        kitchenService.ChangeOrderStatusWithType(gerechten.First(), OrderStatus.MeeBezig);
                    LoadKitchenDisplayData();
                }
            }
            catch (ChapeauException ce)
            {
                MessageBox.Show(ce.Message);
            }
            catch (Exception ex)
            {
                ErrorLogger.WriteLogToFile(ex);
                MessageBox.Show("Something went wrong while loading the kitchen display.");
            }
        }

        public static void SetDefaultGridProperties(DataGridView dataGridView)
        {
            try
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
            catch (ChapeauException ce)
            {
                MessageBox.Show(ce.Message);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                MessageBox.Show("Something went wrong while loading the kitchen display.");
            }
        }

        private void dataGridViewOverzicht_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dataGridView = (DataGridView)sender;
                if (dataGridView.Columns[e.ColumnIndex].CellType == typeof(DataGridViewButtonCell) && dataGridView.Rows[e.RowIndex].Tag != null)
                {
                    this.timer.Stop();
                    OrderOverviewForm OrderOverviewForm = new OrderOverviewForm((KitchenOrderOverview)dataGridView.Rows[e.RowIndex].Tag);
                    OrderOverviewForm.ShowDialog();
                    LoadKitchenDisplayData();
                    this.timer.Start();
                }
            }
            catch (ChapeauException ce)
            {
                MessageBox.Show(ce.Message);
            }
            catch (Exception ex)
            {
                ErrorLogger.WriteLogToFile(ex);
                MessageBox.Show("Something went wrong while loading the kitchen display.");
            }
        }

        private void buttonUitloggen_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        private void KitchenTickEvent(object sender, EventArgs e)
        {
            LoadKitchenDisplayData();
        }

        private void KitchenDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }
    }
}
