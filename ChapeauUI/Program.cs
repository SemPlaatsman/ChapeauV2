using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;

namespace ChapeauUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new KitchenDisplay());
            //Application.Run(new BarDisplay());
            //Application.Run(new OrderOverviewForm(new KitchenOrderOverview()
            //{
            //    Voorgerechten = new List<OrderGerecht>()
            //    {
            //        new OrderGerecht()
            //        {
            //            OrderGerechtId = 999999,
            //            MenuItem = new MenuItem()
            //            {
            //                ProductId = 999999,
            //                IsDiner = false,
            //                Type = TypeOfProduct.Voorgerecht,
            //                ProductName = "test",
            //                Price = 99.99m,
            //                Stock = 32,
            //                IsAlcoholic = false
            //            },
            //            OrderId = 999999,
            //            Status = OrderStatus.MeeBezig,
            //            TimeOfOrder = DateTime.Now,
            //            Remark = string.Empty,
            //            IsServed = ServeerStatus.MeeBezig
            //        }
            //    }
            //}));
        }
    }
}
