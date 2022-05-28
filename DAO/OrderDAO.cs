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
    public class OrderDAO : BaseDao
    {
        public void InsertOrder(Table TableID)
        {
            try
            {
                string query = $"INSERT INTO [ApplicatiebouwChapeau].[Order] (TableID) VALUES (@TableID)";
                SqlParameter[] sql = new SqlParameter[1];
                sql[0] = new SqlParameter("@TableID", TableID.TableID);
                ExecuteEditQuery(query, sql);
            }
            catch (Exception e)
            {
                throw new Exception("Tables could not be inserted properly. Please try again " + e.Message);
            }
        }
        public List<Table> GetAllTables()
        {
            try
            {
                string query = "SELECT [TableID], [EmployeeID], [IsOccupied], [AmountOfGuests] FROM [ApplicatiebouwChapeau].[Table]";
                SqlParameter[] sql = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sql)); 
            }
            catch (Exception e)
            {
                throw new Exception("Tables could not be loaded properly. Please try again " + e.Message);
            }
        }
        public List<Table> ReadTables(DataTable dataTable)
        {
            try
            {
                List<Table> tables = new List<Table>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Table table = new Table()
                    {
                        TableID = (int)dr["TableID"],
                        EmployeeID = (int)dr["EmployeeID"],
                        IsOccupied = (bool)dr["IsOccupied"],
                        AmountOfGuests = (int)dr["AmountOfGuests"]
                    };
                    tables.Add(table);
                };
                return tables;
            }
            catch (Exception e)
            {
                throw new Exception("Data could not be retrieved from the database. Please try again" + e.Message);
            }
        }
        public void AlterTables(Table tableID)
        {
            try
            {
                string query = $"Update [ApplicatiebouwChapeau].[Table] set IsOccupied = 1 where TableID = @TableID";
                SqlParameter[] sqlParameter = new SqlParameter[1];
                sqlParameter[0] = new SqlParameter("@TableID", tableID.TableID);
                ExecuteEditQuery(query, sqlParameter);
            }
            catch(Exception e)
            {
                throw new Exception("Data could not be altered in the database. please try again" + e.Message);
            }

        }
        public List<CurrentOrderItem> GetCurrentOrder(Table Table)
        {
            string query = "SELECT DISTINCT M1.ProductName, M1.Price, M1.IsAlcoholic, (SELECT COUNT(M3.ProductName) " +
                "FROM ApplicatiebouwChapeau.[Order] AS O3 " +
                "JOIN ApplicatiebouwChapeau.OrderGerecht AS OG3 ON O3.[OrderID] = OG3.[OrderId] " +
                "JOIN ApplicatiebouwChapeau.MenuItem AS M3 ON OG3.[ItemId] = M3.[ProductID] " +
                "WHERE OG3.ItemId = OG1.ItemId AND O3.OrderID = O1.OrderID) AS Quantity " +
                "FROM ApplicatiebouwChapeau.[Order] AS O1 " +
                "JOIN ApplicatiebouwChapeau.OrderGerecht AS OG1 ON O1.[OrderID] = OG1.[OrderId] " +
                "JOIN ApplicatiebouwChapeau.MenuItem AS M1 ON OG1.[ItemId] = M1.[ProductID] " +
                "WHERE O1.[OrderID] = (SELECT TOP(1) O2.OrderID " +
                "FROM ApplicatiebouwChapeau.[Order] AS O2 " +
                "WHERE O2.TableId = @tableId " +
                "ORDER BY O2.OrderID DESC);";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableId", Table.TableID);
            return ReadTablesCurrentOrder(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<CurrentOrderItem> ReadTablesCurrentOrder(DataTable dataTable)
        {
            try
            {
                List<CurrentOrderItem> orderItems = new List<CurrentOrderItem>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    CurrentOrderItem items = new CurrentOrderItem()
                    {
                        ProductName = (string)dr["ProductName"],
                        Price = (decimal)dr["Price"],
                        IsAlcoholic = (bool)dr["IsAlcoholic"],
                        Quantity = (int)dr["quantity"]
                    };
                    orderItems.Add(items);
                };
                return orderItems;
            }
            catch (Exception e)
            {
                throw new Exception("De data kan niet geladen worden uit de database. probeer het later opnieuw" + e.Message);
            }
        }
    }
}
