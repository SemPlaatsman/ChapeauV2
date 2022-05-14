using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChapeauModel;

namespace ChapeauDAO
{
    public class KitchenDAO : BaseDao
    {
        public List<KitchenOrderOverview> GetKitchenOverviews()
        {
            string query = "SELECT O.[OrderID], O.[TableId], OG.[OrderGerechtId], M.[ProductID], M.[IsDiner], T.[TypeName], M.[ProductName], M.[Price], M.[Stock], M.[IsAlcoholic], OG.[OrderId], OG.[Status], OG.[TimeOfOrder], OG.[Remark] " +
                "FROM ApplicatiebouwChapeau.[Order] AS O " +
                "JOIN ApplicatiebouwChapeau.OrderGerecht AS OG ON O.OrderID = OG.OrderId " +
                "JOIN ApplicatiebouwChapeau.MenuItem AS M ON OG.[ItemId] = M.[ProductID] " +
                "JOIN ApplicatiebouwChapeau.TypeOfProduct AS T ON M.[Type] = T.[TypeID] " +
                "WHERE M.[Type] != 3 AND OG.[OrderId] IN(SELECT DISTINCT O2.[OrderId] " +
                "FROM ApplicatiebouwChapeau.[Order] AS O2 " +
                "JOIN ApplicatiebouwChapeau.OrderGerecht AS OG2 ON O2.[OrderID] = OG2.[OrderId] " +
                "WHERE OG2.[Status] = 0 OR OG2.[Status] IS NULL); ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<KitchenOrderOverview> ReadTables(DataTable dataTable)
        { 
            List<KitchenOrderOverview> kitchenOrderOverviews = new List<KitchenOrderOverview>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderGerecht orderGerecht = new OrderGerecht()
                {
                    OrderGerechtId = (int)dr["OrderGerechtId"],
                    MenuItem = new MenuItem()
                    {
                        ProductId = (int)dr["ProductId"],
                        IsDiner = (bool)dr["IsDiner"],
                        Type = (string)dr["TypeName"],
                        ProductName = (string)dr["ProductName"],
                        Price = (decimal)dr["Price"],
                        Stock = (int)dr["Stock"],
                        IsAlcoholic = (bool)dr["IsAlcoholic"]
                    },
                    OrderId = (int)dr["OrderId"],
                    Status = (bool?)dr["Status"],
                    TimeOfOrder = (DateTime)dr["TimeOfOrder"],
                    Remark = (string)dr["Remark"]
                };
                Order order = new Order()
                {
                    OrderId = (int)dr["OrderID"],
                    TableId = (int)dr["TableId"]
                };
                AddToOverview(order, kitchenOrderOverviews, orderGerecht);
            }
            return kitchenOrderOverviews;
        }

        private void AddToOverview(Order order, List<KitchenOrderOverview> kitchenOrderOverviews, OrderGerecht orderGerecht)
        {
            for (int i = 0; i < kitchenOrderOverviews.Count(); i++)
            {
                if (order.OrderId == kitchenOrderOverviews[i].OrderId)
                {
                    kitchenOrderOverviews[i].Add(orderGerecht);
                    return;
                }
            }
            kitchenOrderOverviews.Add(new KitchenOrderOverview()
            {
                OrderId = order.OrderId,
                TableId = order.TableId
            });
            kitchenOrderOverviews[kitchenOrderOverviews.Count() - 1].Add(orderGerecht);
        }
    }
}
