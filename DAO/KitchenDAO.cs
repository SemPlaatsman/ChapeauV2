﻿using System;
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
    public class KitchenDAO : BaseDao
    {
        private void PushLateOrders()
        {
            try
            {
                string query = "UPDATE ApplicatiebouwChapeau.OrderGerecht " +
                    "SET[Status] = 0 WHERE OrderGerechtId IN (SELECT OG1.OrderGerechtId " +
                    "FROM ApplicatiebouwChapeau.OrderGerecht AS OG1 " +
                    "JOIN ApplicatiebouwChapeau.MenuItem AS M1 ON M1.ProductID = OG1.ItemId " +
                    "WHERE OG1.[Status] IS NULL AND OrderID IN (SELECT DISTINCT OG2.OrderId " +
                    "FROM ApplicatiebouwChapeau.OrderGerecht AS OG2 " +
                    "WHERE OG2.[Status] = 0 AND OG2.[Status] IS NOT NULL) " +
                    "AND M1.[Type] IN (SELECT M3.[Type] " +
                    "FROM ApplicatiebouwChapeau.OrderGerecht AS OG3 " +
                    "JOIN ApplicatiebouwChapeau.MenuItem AS M3 ON M3.ProductID = OG3.ItemId " +
                    "WHERE OG3.OrderId = OG1.OrderId AND OG3.[Status] = 0 AND OG3.[Status] IS NOT NULL) " +
                    "AND M1.[Type] != @typeOfDrink); ";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@typeOfDrink", (int)TypeOfProduct.Drinken);
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while changing conflicting behaviour in kitchen orders.");
            }
        }

        public List<KitchenOrderOverview> GetKitchenOverviews()
        {
            try
            {
                PushLateOrders();

                string query = "SELECT O.[OrderID], O.[TableId], OG.[OrderGerechtId], M.[ProductID], M.[IsDiner], M.[Type], M.[ProductName], M.[Price], M.[Stock], M.[IsAlcoholic], OG.[OrderId], OG.[Status], OG.[TimeOfOrder], OG.[Remark], OG.[IsServed] " +
                    "FROM ApplicatiebouwChapeau.[Order] AS O " +
                    "JOIN ApplicatiebouwChapeau.OrderGerecht AS OG ON O.OrderID = OG.OrderId " +
                    "JOIN ApplicatiebouwChapeau.MenuItem AS M ON OG.[ItemId] = M.[ProductID] " +
                    "WHERE M.[Type] != @typeOfDrink AND OG.[OrderId] IN (SELECT DISTINCT O2.[OrderId] " +
                    "FROM ApplicatiebouwChapeau.[Order] AS O2 " +
                    "JOIN ApplicatiebouwChapeau.OrderGerecht AS OG2 ON O2.[OrderID] = OG2.[OrderId] " +
                    "JOIN ApplicatiebouwChapeau.MenuItem AS M2 ON OG2.[ItemId] = M2.[ProductID] " +
                    "WHERE M2.[Type] != @typeOfDrink AND OG2.[IsServed] != 1 OR OG2.[IsServed] IS NULL) " +
                    "AND DATEPART(DAYOFYEAR, DATEADD(HOUR, @hoursToAdd, GETDATE())) = DATEPART(DAYOFYEAR, TimeOfOrder); ";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@typeOfDrink", (int)TypeOfProduct.Drinken);
                sqlParameters[1] = new SqlParameter("@hoursToAdd", 2);
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while loading the kitchen order overviews.");
            }
        }

        public void ChangeFullOrderStatus(OrderOverview kitchenOrderOverview, OrderStatus newStatus)
        {
            try
            {
                string query = "UPDATE ApplicatiebouwChapeau.OrderGerecht " +
                    "SET[Status] = @newStatus " +
                    "FROM ApplicatiebouwChapeau.OrderGerecht AS OG " +
                    "JOIN ApplicatiebouwChapeau.MenuItem AS M ON OG.ItemId = M.ProductID " +
                    "WHERE OG.OrderId = @orderId " +
                    "AND M.[Type] != @typeOfDrink; ";
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@orderId", kitchenOrderOverview.OrderId);
                sqlParameters[1] = new SqlParameter("@newStatus", newStatus == OrderStatus.Klaar ? true : newStatus == OrderStatus.MeeBezig ? false : DBNull.Value);
                sqlParameters[2] = new SqlParameter("@typeOfDrink", TypeOfProduct.Drinken);
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while changing the order status of a kitchen order.");
            }
        }

        public void ChangeOrderStatusWithType(OrderGerecht orderGerecht, OrderStatus newStatus)
        {
            try
            {
                string query = "UPDATE ApplicatiebouwChapeau.OrderGerecht " +
                    "SET [Status] = @newStatus " +
                    "FROM ApplicatiebouwChapeau.OrderGerecht AS OG " +
                    "JOIN ApplicatiebouwChapeau.MenuItem AS M ON OG.ItemId = M.ProductID " +
                    "WHERE OG.OrderId = @orderId AND M.[Type] = @typeId; ";
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@orderId", orderGerecht.OrderId);
                sqlParameters[1] = new SqlParameter("@newStatus", newStatus == OrderStatus.Klaar ? true : newStatus == OrderStatus.MeeBezig ? false : DBNull.Value);
                sqlParameters[2] = new SqlParameter("@typeId", (int)orderGerecht.MenuItem.Type);
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while changing the order status of a type within a kitchen order.");
            }
        }

        public void ChangeFullServeStatus(OrderOverview kitchenOrderOverview, ServeerStatus serveerStatus)
        {
            try
            {
                string query = "UPDATE ApplicatiebouwChapeau.OrderGerecht " +
                    "SET IsServed = @serveerStatus " +
                    "FROM ApplicatiebouwChapeau.OrderGerecht AS OG " +
                    "JOIN ApplicatiebouwChapeau.MenuItem AS M ON OG.ItemId = M.ProductID " +
                    "WHERE OG.OrderId = @orderId AND M.[Type] != @typeOfDrink; ";
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@serveerStatus", serveerStatus == ServeerStatus.IsGeserveerd ? true : serveerStatus == ServeerStatus.KanGeserveerdWorden ? false : DBNull.Value);
                sqlParameters[1] = new SqlParameter("@orderId", kitchenOrderOverview.OrderId);
                sqlParameters[2] = new SqlParameter("@typeOfDrink", (int)TypeOfProduct.Drinken);
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while changing the serve status of a kitchen order.");
            }
        }

        public void ChangeServeStatusWithType(OrderGerecht orderGerecht, ServeerStatus serveerStatus)
        {
            try
            {
                string query = "UPDATE ApplicatiebouwChapeau.OrderGerecht " +
                    "SET IsServed = @serveerStatus " +
                    "FROM ApplicatiebouwChapeau.OrderGerecht AS OG " +
                    "JOIN ApplicatiebouwChapeau.MenuItem AS M ON OG.ItemId = M.ProductID " +
                    "WHERE OG.OrderId = @orderId AND M.[Type] = @typeId; ";
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@serveerStatus", serveerStatus == ServeerStatus.IsGeserveerd ? true : serveerStatus == ServeerStatus.KanGeserveerdWorden ? false : DBNull.Value);
                sqlParameters[1] = new SqlParameter("@orderId", orderGerecht.OrderId);
                sqlParameters[2] = new SqlParameter("@typeId", (int)orderGerecht.MenuItem.Type);
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while changing the serve status of a type within a kitchen order.");
            }
        }

        public KitchenOrderOverview GetKitchenOverview(int orderId)
        {
            try
            {
                PushLateOrders();

                string query = "SELECT O.[OrderID], O.[TableId], OG.[OrderGerechtId], M.[ProductID], M.[IsDiner], M.[Type], M.[ProductName], M.[Price], M.[Stock], M.[IsAlcoholic], OG.[OrderId], OG.[Status], OG.[TimeOfOrder], OG.[Remark], OG.[IsServed] " +
                    "FROM ApplicatiebouwChapeau.[Order] AS O " +
                    "JOIN ApplicatiebouwChapeau.OrderGerecht AS OG ON O.OrderID = OG.OrderId " +
                    "JOIN ApplicatiebouwChapeau.MenuItem AS M ON OG.[ItemId] = M.[ProductID] " +
                    "WHERE M.[Type] != @typeOfDrink AND OG.[OrderId] = @orderId " +
                    "AND DATEPART(DAYOFYEAR, DATEADD(HOUR, @hoursToAdd, GETDATE())) = DATEPART(DAYOFYEAR, TimeOfOrder); ";
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@orderId", orderId);
                sqlParameters[1] = new SqlParameter("@typeOfDrink", (int)TypeOfProduct.Drinken);
                sqlParameters[2] = new SqlParameter("@hoursToAdd", 2);
                return ReadTable(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while loading a kitchen order overview.");
            }
        }

        public KitchenOrderOverview GetKitchenOverviewWithTableId(int tableId)
        {
            try
            {
                string query = "SELECT O.[OrderID], O.[TableId], OG.[OrderGerechtId], M.[ProductID], M.[IsDiner], M.[Type], M.[ProductName], M.[Price], M.[Stock], M.[IsAlcoholic], OG.[OrderId], OG.[Status], OG.[TimeOfOrder], OG.[Remark], OG.[IsServed] " +
                    "FROM ApplicatiebouwChapeau.[Order] AS O " +
                    "JOIN ApplicatiebouwChapeau.OrderGerecht AS OG ON O.OrderID = OG.OrderId " +
                    "JOIN ApplicatiebouwChapeau.MenuItem AS M ON OG.[ItemId] = M.[ProductID] " +
                    "WHERE M.[Type] != @typeOfDrink AND OG.[OrderId] = (SELECT TOP(1) O2.OrderId FROM ApplicatiebouwChapeau.[Order] AS O2 WHERE O2.TableID = @tableId ORDER BY O2.OrderID DESC) " +
                    "AND DATEPART(DAYOFYEAR, DATEADD(HOUR, @hoursToAdd, GETDATE())) = DATEPART(DAYOFYEAR, TimeOfOrder); ";
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@tableId", tableId);
                sqlParameters[1] = new SqlParameter("@typeOfDrink", (int)TypeOfProduct.Drinken);
                sqlParameters[2] = new SqlParameter("@hoursToAdd", 2);
                return ReadTable(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while loading a kitchen order overview with table id.");
            }
        }

        private KitchenOrderOverview ReadTable(DataTable dataTable)
        {
            try
            {
                KitchenOrderOverview kitchenOrderOverview = new KitchenOrderOverview();

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
                        /* De bovenstaande regel code kijkt eerst of Convert.IsDBNull(...) true returned. 
                        Als dat zo is dan wordt de waarde null gebruikt, 
                        als Convert.IsDBNull false returned dan wordt (bool)dr["Status"] gebruikt (die de andere twee waardes van een nullable bool kan hebben).
                        Dit wordt gedaan omdat je een DBNull niet direct naar een nullable bool kan casten.*/
                        TimeOfOrder = (DateTime)dr["TimeOfOrder"],
                        Remark = Convert.IsDBNull(dr["Remark"]) ? String.Empty : (string)dr["Remark"],
                        /* Zelfde reden als hierboven is genoemd alleen dan maak ik een empty string wanneer de value null is.*/
                        IsServed = Convert.IsDBNull(dr["IsServed"]) ? ServeerStatus.MeeBezig : (bool)dr["IsServed"] ? ServeerStatus.IsGeserveerd : ServeerStatus.KanGeserveerdWorden
                    };
                    kitchenOrderOverview.OrderId = (int)dr["OrderID"];
                    kitchenOrderOverview.TableId = (int)dr["TableId"];
                    kitchenOrderOverview.Add(orderGerecht);
                }
                return kitchenOrderOverview;
            }
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while loading a kitchen order overview.");
            }
        }

        private List<KitchenOrderOverview> ReadTables(DataTable dataTable)
        {
            try
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
                            Type = (TypeOfProduct)(int)dr["Type"],
                            ProductName = (string)dr["ProductName"],
                            Price = (decimal)dr["Price"],
                            Stock = (int)dr["Stock"],
                            IsAlcoholic = (bool)dr["IsAlcoholic"]
                        },
                        OrderId = (int)dr["OrderId"],
                        Status = (Convert.IsDBNull(dr["Status"])) ? OrderStatus.MoetNog : (bool)dr["Status"] ? OrderStatus.Klaar : OrderStatus.MeeBezig,
                        /* De bovenstaande regel code kijkt eerst of Convert.IsDBNull(...) true returned. 
                        Als dat zo is dan wordt de waarde null gebruikt, 
                        als Convert.IsDBNull false returned dan wordt (bool)dr["Status"] gebruikt (die de andere twee waardes van een nullable bool kan hebben).
                        Dit wordt gedaan omdat je een DBNull niet direct naar een nullable bool kan casten.*/
                        TimeOfOrder = (DateTime)dr["TimeOfOrder"],
                        Remark = Convert.IsDBNull(dr["Remark"]) ? String.Empty : (string)dr["Remark"],
                        /* Zelfde reden als hierboven is genoemd alleen dan maak ik een empty string wanneer de value null is.*/
                        IsServed = Convert.IsDBNull(dr["IsServed"]) ? ServeerStatus.MeeBezig : (bool)dr["IsServed"] ? ServeerStatus.IsGeserveerd : ServeerStatus.KanGeserveerdWorden
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
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while loading a list of kitchen order overviews.");
            }
        }

        private void AddToOverview(Order order, List<KitchenOrderOverview> kitchenOrderOverviews, OrderGerecht orderGerecht)
        {
            try
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
            catch (Exception e)
            {
                ErrorLogger.WriteLogToFile(e);
                throw new ChapeauException("Something went wrong while adding an order to a kitchen order overview");
            }
        }
    }
}
