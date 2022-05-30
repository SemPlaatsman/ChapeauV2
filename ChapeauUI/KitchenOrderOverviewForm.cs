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
    public partial class KitchenOrderOverviewForm : Form
    {
        private KitchenOrderOverview kitchenOrderOverview;
        public KitchenOrderOverviewForm(KitchenOrderOverview kitchenOrderOverview)
        {
            this.kitchenOrderOverview = kitchenOrderOverview;
            InitializeComponent();
            KitchenDisplay.SetDefaultGridProperties(dataGridViewOrderOverview);
            dataGridViewOrderOverview.ReadOnly = false;
            dataGridViewOrderOverview.Columns[0].ReadOnly = true;
            dataGridViewOrderOverview.Columns[1].ReadOnly = true;
            dataGridViewOrderOverview.Columns[2].ReadOnly = true;

            dataGridViewOrderOverview.Columns[0].Width = 40;
            dataGridViewOrderOverview.Columns[1].Width = 340;
            dataGridViewOrderOverview.Columns[2].Width = 96;
            dataGridViewOrderOverview.Columns[3].Width = 90;
            dataGridViewOrderOverview.Columns[4].Width = 80;
            dataGridViewOrderOverview.Columns[5].Width = 150;
            dataGridViewOrderOverview.Columns[6].Width = 140;

            this.Text = $"Overview van order {this.kitchenOrderOverview.OrderId} voor tafel {this.kitchenOrderOverview.TableId}";

            LoadKitchenOrderOverviewData();
        }

        private void LoadKitchenOrderOverviewData()
        {
            dataGridViewOrderOverview.AllowUserToAddRows = true;

            foreach (OrderGerecht orderGerecht in GetCombinedGerechten())
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewOrderOverview.Rows[0].Clone();
                row.Cells[0].Value = ((TimeSpan)(DateTime.Now - orderGerecht.TimeOfOrder)).ToString(@"hh\:mm");
                row.Cells[1].Value = orderGerecht.MenuItem.ProductName;
                row.Cells[2].Value = orderGerecht.MenuItem.Type;
                row.Cells[4].Value = orderGerecht.Status;
                row.Cells[6].Value = orderGerecht.IsServed;
                row.MinimumHeight = 30;
                row.Tag = orderGerecht;
                dataGridViewOrderOverview.Rows.Add(row);
            }

            dataGridViewOrderOverview.AllowUserToAddRows = false;
        }

        private List<OrderStatus> GetStatus()
        {
            List<OrderStatus> os = new List<OrderStatus>();
            foreach (OrderGerecht item in GetCombinedGerechten())
            {
                os.Add(item.Status);
            }
            return os;
        }
            
        private List<OrderGerecht> GetCombinedGerechten()
        {
            List<OrderGerecht> gerechten = new List<OrderGerecht>();
            gerechten.AddRange(kitchenOrderOverview.Voorgerechten);
            gerechten.AddRange(kitchenOrderOverview.Tussengerechten);
            gerechten.AddRange(kitchenOrderOverview.Hoofdgerechten);
            gerechten.AddRange(kitchenOrderOverview.Nagerechten);
            return gerechten;
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

        }
    }
}
