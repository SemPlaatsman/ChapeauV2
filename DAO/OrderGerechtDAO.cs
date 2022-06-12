using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChapeauModel;
using ErrorHandling;
using ChapeauInterfaces;

namespace ChapeauDAO
{
    public class OrderGerechtDAO : BaseDao
    {
        public void ChangeStatus(OrderGerecht orderGerecht, OrderStatus newStatus)
        {
            try
            {
                string query = "UPDATE ApplicatiebouwChapeau.OrderGerecht " +
                    "SET[Status] = @newStatus " +
                    "WHERE OrderGerechtId = @orderGerechtId; ";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@orderGerechtId", orderGerecht.OrderGerechtId);
                sqlParameters[1] = new SqlParameter("@newStatus", newStatus == OrderStatus.Klaar ? true : newStatus == OrderStatus.MeeBezig ? false : DBNull.Value);
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while changing the order status of an order gerecht.");
            }
        }

        public List<OrderGerecht> GetOrdersByTableId(Table table)
        {
            try
            {
                string query = "SELECT O.[OrderID], O.[TableId], OG.[OrderGerechtId], M.[ProductID], M.[IsDiner], M.[Type], M.[ProductName], M.[Price], M.[Stock], M.[IsAlcoholic], OG.[OrderId], OG.[Status], OG.[TimeOfOrder], OG.[Remark], OG.[IsServed] " +
                    "FROM ApplicatiebouwChapeau.[Order] AS O " +
                    "JOIN ApplicatiebouwChapeau.OrderGerecht AS OG ON O.OrderID = OG.OrderId " +
                    "JOIN ApplicatiebouwChapeau.MenuItem AS M ON OG.[ItemId] = M.[ProductID] " +
                    "WHERE OG.[OrderId] = (SELECT TOP(1) O2.OrderId FROM ApplicatiebouwChapeau.[Order] AS O2 WHERE O2.TableID = @tableId ORDER BY O2.OrderID DESC) " +
                    "AND DATEPART(DAYOFYEAR, DATEADD(HOUR, @hoursToAdd, GETDATE())) = DATEPART(DAYOFYEAR, TimeOfOrder); ";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@tableId", table.TableID);
                sqlParameters[1] = new SqlParameter("@hoursToAdd", 2);
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while loading a kitchen order overview with table id.");
            }
        }

        public List<OrderGerecht> GetCurrentOrderGerechten(Order order) 
        {
            try
            {
                string query = "SELECT OG.OrderGerechtId, M.ProductID, M.IsDiner, M.[Type], M.ProductName, M.Price, M.Stock, M.IsAlcoholic, OG.OrderId, OG.[Status], OG.TimeOfOrder, OG.Remark, OG.IsServed " +
                    "from [ApplicatiebouwChapeau].[OrderGerecht] as OG " +
                    "join ApplicatiebouwChapeau.[Order] as O on O.OrderID = OG.OrderId " +
                    "JOIN ApplicatiebouwChapeau.MenuItem AS M ON OG.ItemId = M.ProductID " +
                    "where OG.OrderId = @OrderID and OG.IsServed = 0;";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@OrderID", order.OrderId);
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while loading the current order gerechten of an order.");
            }
        }

        public void UpdateIsServed(Order order) 
        {
            try
            {
                string query = "update ApplicatiebouwChapeau.OrderGerecht set IsServed = 1 where IsServed = 0 and OrderID = @OrderID; ";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@OrderID", order.OrderId);
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while updating the serve status of an order gerecht.");
            }
        }

        private List<OrderGerecht> ReadTables(DataTable dataTable)
        {
            try
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
                        Status = (Convert.IsDBNull(dr["Status"])) ? OrderStatus.MoetNog : (bool)dr["Status"] ? OrderStatus.Klaar : OrderStatus.MeeBezig,
                        /*Bovenstaande regel code komt van Kitchen- en BarDAO*/
                        TimeOfOrder = (DateTime)dr["TimeOfOrder"],
                        Remark = Convert.IsDBNull(dr["Remark"]) ? string.Empty : (string)dr["Remark"],
                        IsServed = Convert.IsDBNull(dr["IsServed"]) ? ServeerStatus.MeeBezig : (bool)dr["IsServed"] ? ServeerStatus.IsGeserveerd : ServeerStatus.KanGeserveerdWorden
                    };
                    orderGerechten.Add(orderGerecht);
                }
                return orderGerechten;
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while loading a list of order gerechten.");
            }
        }

        public void InsertOrderGerecht(OrderGerecht orderGerecht)
        {
            try
            {
                string query = "INSERT INTO [ApplicatiebouwChapeau].[OrderGerecht] (ItemID, OrderID, TimeOfOrder, Remark) Values (@ItemID, @OrderID, @TimeOfOrder, @Remark)";
                SqlParameter[] sql = new SqlParameter[4];
                sql[0] = new SqlParameter("@ItemID", orderGerecht.MenuItem.ProductId);
                sql[1] = new SqlParameter("@OrderID", orderGerecht.OrderId);
                sql[2] = new SqlParameter("@TimeOfOrder", orderGerecht.TimeOfOrder);
                sql[3] = new SqlParameter("@Remark", orderGerecht.Remark);
                ExecuteEditQuery(query, sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Data could not be inserted in the database. please try again" + ex.Message);
            }
        }
    }
}
