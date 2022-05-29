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
    public class OrderGerechtDAO : BaseDao
    {
        public List<OrderGerecht> GetAllOrderGerechten()
        {
            string query = "SELECT O.OrderGerechtId, M.ProductID, M.IsDiner, M.[Type], M.ProductName, M.Price, M.Stock, M.IsAlcoholic, O.OrderId, O.[Status], O.TimeOfOrder, O.Remark " +
                "FROM ApplicatiebouwChapeau.OrderGerecht AS O " +
                "JOIN ApplicatiebouwChapeau.MenuItem AS M ON O.ItemId = M.ProductID " +
                "JOIN ApplicatiebouwChapeau.TypeOfProduct AS T ON M.[Type] = T.TypeID " +
                "WHERE O.[Status] != 1;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void ChangeStatus(OrderGerecht orderGerecht, OrderStatus newStatus)
        {
            string query = "UPDATE ApplicatiebouwChapeau.OrderGerecht " +
                "SET[Status] = @newStatus " +
                "WHERE OrderGerechtId = @orderGerechtId; ";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@orderGerechtId", orderGerecht.OrderGerechtId);
            sqlParameters[1] = new SqlParameter("@newStatus", newStatus == OrderStatus.Klaar ? true : newStatus == OrderStatus.MeeBezig ? false : DBNull.Value);
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<OrderGerecht> ReadTables(DataTable dataTable)
        {
            List<OrderGerecht> orderGerechten = new List<OrderGerecht>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderGerecht orderGerecht = new OrderGerecht()
                {
                    OrderGerechtId = (int)dr["OrderGerechtId"],
                    MenuItem = new MenuItem()
                    {
                        ProductId = (int)dr["ProductId"],
                        IsDiner = (bool)dr["IsDiner"],
                        Type = (TypeOfProduct)(int)dr["Type"],
                        ProductName = (string)dr["ProductName"],
                        Price = (decimal)dr["Price"],
                        Stock = (int)dr["Stock"],
                        IsAlcoholic = (bool)dr["IsAlcoholic"]
                    },
                    OrderId = (int)dr["OrderId"],
                    Status = (Convert.IsDBNull(dr["Status"])) ? OrderStatus.MoetNog : (OrderStatus)((int)dr["Status"] + 1),
                    /*Bovenstaande regel code komt van Kitchen- en BarDAO*/
                    TimeOfOrder = (DateTime)dr["TimeOfOrder"],
                    Remark = (string)dr["Remark"]
                };
                orderGerechten.Add(orderGerecht);
            }
            return orderGerechten;
        }
        public void InsertOrderGerecht(int itemID, int orderID, bool? status, DateTime timeOfOrder, string remark)
        {
            string query = "INSERT INTO ApplicatiebouwChapeau.OrderGerecht (ItemID, OrderID, [Status], TimeOfOrder, Remark) Values (@itemID, @OrderID, @Status, @TimeOfOrder, Remark)";
            SqlParameter[] sql = new SqlParameter[5];
            sql[0] = new SqlParameter("@ItemID", itemID);
            sql[1] = new SqlParameter("@OrderID", orderID);
            sql[2] = new SqlParameter("@Status", status);
            sql[3] = new SqlParameter("@TimeOfOrder", timeOfOrder);
            sql[4] = new SqlParameter("@Remark", remark);
            ExecuteEditQuery(query, sql);
        }
    }
}
