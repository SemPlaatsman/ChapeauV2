using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;

namespace ChapeauDAO
{
    public class CheckoutDAO : BaseDao
    {
        public List<Checkout> Order(int TableId)
        {
            try
            {
                //string query = "SELECT MenuItem.[ProductName], MenuItem.[Price] " +
                //"FROM ApplicatiebouwChapeau.[Order] " +
                //"JOIN ApplicatiebouwChapeau.OrderGerecht ON[Order].[OrderId] = OrderGerecht.[OrderId] " + 
                //"JOIN ApplicatiebouwChapeau.MenuItem ON OrderGerecht.[ItemId] = MenuItem.[ProductID] " +
                //"JOIN ApplicatiebouwChapeau.TypeOfProduct ON MenuItem.[Type] = TypeOfProduct.[TypeID] " +
                //"WHERE[Order].[OrderId] = @TableId;";

                string query = "SELECT MenuItem.[ProductName], MenuItem.[Price] " +
                "FROM ApplicatiebouwChapeau.[Order] " +
                "JOIN ApplicatiebouwChapeau.OrderGerecht ON [Order].[OrderID] = [OrderGerecht].[OrderId] " +
                "JOIN ApplicatiebouwChapeau.MenuItem ON OrderGerecht.[ItemId] = MenuItem.[ProductID] " +
                "WHERE [Order].[OrderID] = (SELECT TOP (1) OrderID " +
                "FROM ApplicatiebouwChapeau.[Order] " +
                "WHERE TableId = @tableId " +
                "ORDER BY OrderID DESC); ";

                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@tableId", TableId);
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                //Toont een foutmelding als de order niet geladen kan worden.
                throw new Exception("Order could not be loaded properly. Please try again " + e.Message);
            }
        }

        private List<Checkout> ReadTables(DataTable dataTable)
        {
            try
            {
                List<Checkout> checkout = new List<Checkout>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Checkout items = new Checkout()
                    {                       
                        ProductName = (string)dr["ProductName"],
                        Price = (decimal)dr["Price"]                        
                    };
                    checkout.Add(items);
                };
                return checkout;
            }
            catch (Exception e)
            {
                throw new Exception("Data could not be retrieved from the database. Please try again" + e.Message);
            }
        }
    }
}
