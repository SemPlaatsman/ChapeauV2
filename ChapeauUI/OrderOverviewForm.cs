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
    public partial class OrderOverviewForm : Form
    {
        private Timer timer;

        private OrderOverview orderOverview;
        public OrderOverviewForm(OrderOverview orderOverview)
        {
            this.timer = new Timer();
            this.orderOverview = orderOverview;
            InitializeComponent();
            this.timer.Interval = 5000;
            this.timer.Start();

            KitchenDisplay.SetDefaultGridProperties(dataGridViewOrderOverview);
            dataGridViewOrderOverview.ReadOnly = false;
            dataGridViewOrderOverview.Columns[0].ReadOnly = true;
            dataGridViewOrderOverview.Columns[1].ReadOnly = true;
            dataGridViewOrderOverview.Columns[2].ReadOnly = true;
            dataGridViewOrderOverview.Columns[4].ReadOnly = true;
            dataGridViewOrderOverview.Columns[5].ReadOnly = true;

            this.Text = $"Overview van order {this.orderOverview.OrderId} voor tafel {this.orderOverview.TableId}";

            if (orderOverview.GetCombinedGerechten().FirstOrDefault().MenuItem.Type == TypeOfProduct.Drinken)
            {
                labelPerType.Visible = false;
                comBoxType.Visible = false;
                buttonTypeStatus.Visible = false;
            }
            else
            {
                if (((KitchenOrderOverview)orderOverview).GetNextMeeBezigList().Count > 0)
                {
                    TypeOfProduct nextMeeBezigType = ((KitchenOrderOverview)orderOverview).GetNextMeeBezigList().First().MenuItem.Type;
                    comBoxType.SelectedIndex = nextMeeBezigType == TypeOfProduct.Tussengerecht ? (int)nextMeeBezigType - 3 : nextMeeBezigType != TypeOfProduct.Voorgerecht ? (int)++nextMeeBezigType : (int)nextMeeBezigType;
                    //bovenstaande code vertaald het type van gerecht van de huidige mee bezig list naar de juiste selected index
                    //wanneer het type een tussengerecht is dan doe ik -3 omdat de value van een tussengerecht 4 is en de juiste index in de combobox is 1
                    //wanneer het type niet een voorgerecht is dan is het type een hoofd- of nagerecht en die hebben de waardes 1 en 2 in de enumeration
                    //De juiste indexes van deze types zijn 2 en 3 dus moeten ze met 1 verhoogt worden
                }
                else
                {
                    comBoxType.SelectedIndex = 0;
                }
            }

            LoadOrderOverviewData();
        }

        private void LoadOrderOverviewData()
        {
            dataGridViewOrderOverview.AllowUserToAddRows = true;

            dataGridViewOrderOverview.Rows.Clear();
            if (orderOverview.GetCombinedGerechten().FirstOrDefault().MenuItem.Type == TypeOfProduct.Drinken)
            {
                BarService barService = new BarService();
                this.orderOverview = barService.GetBarOverview(this.orderOverview.OrderId);
            }
            else
            {
                KitchenService kitchenService = new KitchenService();
                this.orderOverview = kitchenService.GetKitchenOverview(this.orderOverview.OrderId);
                SetButtonStatus(buttonTypeStatus, ((KitchenOrderOverview)orderOverview).TypeToList((TypeOfProduct)Enum.Parse(typeof(TypeOfProduct), comBoxType.GetItemText(comBoxType.SelectedItem))));
            }

            foreach (OrderGerecht orderGerecht in orderOverview.GetCombinedGerechten())
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewOrderOverview.Rows[0].Clone();
                row.Cells[0].Value = ((TimeSpan)(DateTime.Now - orderGerecht.TimeOfOrder)).ToString(@"hh\:mm");
                row.Cells[1].Value = orderGerecht.MenuItem.ProductName;
                row.Cells[2].Value = orderGerecht.MenuItem.Type;
                row.Cells[4].Value = Regex.Replace($"{orderGerecht.Status}", "([A-Z])", " $1").Trim();
                row.Cells[5].Value = Regex.Replace($"{orderGerecht.IsServed}", "([A-Z])", " $1").Trim();
                row.MinimumHeight = 30;
                row.Tag = orderGerecht;
                dataGridViewOrderOverview.Rows.Add(row);
            }

            SetButtonStatus(buttonFullStatus, orderOverview.GetCombinedGerechten());

            dataGridViewOrderOverview.AllowUserToAddRows = false;
        }

        public void SetButtonStatus(Button button, List<OrderGerecht> statusIdentifier)
        {
            button.BackColor = Color.White;
            if (statusIdentifier.Count <= 0)
            {
                button.Text = "Geen orders";
                button.Enabled = false;
            }
            else if (OrderOverview.ListOnlyHasStatus(statusIdentifier, OrderStatus.MoetNog))
            {
                button.BackColor = Color.OrangeRed;
                button.Text = "Moet nog";
            }
            else if (OrderOverview.ListOnlyHasStatus(statusIdentifier, OrderStatus.MeeBezig))
            {
                button.BackColor = Color.Yellow;
                button.Text = "Mee bezig";
            }
            else if (OrderOverview.ListOnlyHasStatus(statusIdentifier, OrderStatus.Klaar))
            {
                button.BackColor = Color.MediumSpringGreen;
                button.Text = "Klaar";
            }
            else
            {
                button.Text = "Gemixt";
            }
            button.Tag = statusIdentifier;
        }

        private void buttonTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //van: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.currentcelldirtystatechanged?view=windowsdesktop-6.0
        //dit zorgt ervoor dat een verandering in de combobox gelijk naar de database wordt gepushed nadat er een keuze is gemaakt
        private void dataGridViewOrderOverview_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrderOverview.IsCurrentCellDirty)
            {
                dataGridViewOrderOverview.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridViewOrderOverview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridViewOrderOverview.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (((DataGridViewComboBoxCell)dataGridViewOrderOverview.Rows[e.RowIndex].Cells[e.ColumnIndex]).Value != null)
            {
                OrderGerechtService orderGerechtService = new OrderGerechtService();
                OrderGerecht orderGerecht = (OrderGerecht)dataGridViewOrderOverview.Rows[e.RowIndex].Tag;
                orderGerechtService.ChangeOrderGerechtStatus(orderGerecht, TranslateStringToStatus(cb.Value.ToString()));
                LoadOrderOverviewData();
            }
        }

        private OrderStatus TranslateStringToStatus(string input)
        {
            return (OrderStatus)((DataGridViewComboBoxColumn)dataGridViewOrderOverview.Columns[3]).Items.IndexOf(input);
        }

        private void comBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrderOverviewData();
        }

        private void buttonTypeStatus_Click(object sender, EventArgs e)
        {
            List<OrderGerecht> orders = (List<OrderGerecht>)buttonTypeStatus.Tag;
            if (OrderOverview.ListOnlyHasStatus(orders, OrderStatus.MoetNog))
            {
                //Moet nog
            }
            else if (OrderOverview.ListOnlyHasStatus(orders, OrderStatus.MeeBezig))
            {
                //Mee bezig
            }
            else if (OrderOverview.ListOnlyHasStatus(orders, OrderStatus.Klaar))
            {
                //Klaar
            }
            else if (MessageBox.Show("Weet je zeker dat je de status van de gehele order wilt veranderen naar Klaar?", "Weet je het zeker?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Gemixt
            }
        }

        private void buttonFullStatus_Click(object sender, EventArgs e)
        {
            List<OrderGerecht> orders = (List<OrderGerecht>)buttonFullStatus.Tag;
            if (OrderOverview.ListOnlyHasStatus(orders, OrderStatus.MoetNog))
            {
                //Moet nog
            }
            else if (OrderOverview.ListOnlyHasStatus(orders, OrderStatus.MeeBezig))
            {
                //Mee bezig
            }
            else if (OrderOverview.ListOnlyHasStatus(orders, OrderStatus.Klaar))
            {
                //Klaar
            }
            else if (MessageBox.Show("Weet je zeker dat je de status van de gehele order wilt veranderen naar Klaar?", "Weet je het zeker?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Gemixt
            }
        }
    }
}
