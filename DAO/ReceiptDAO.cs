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
    public class ReceiptDAO : BaseDao
    {
        public List<Receipt> Order(int TableId)
        {
            try
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
                sqlParameters[0] = new SqlParameter("@tableId", TableId);
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                //Toont een foutmelding als de order niet geladen kan worden.
                throw new Exception("Order kan niet geladen worden. probeer het later opnieuw " + e.Message);
            }
        }

        private List<Receipt> ReadTables(DataTable dataTable)
        {
            try
            {
                List<Receipt> receipt = new List<Receipt>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Receipt items = new Receipt()
                    {
                        ProductName = (string)dr["ProductName"],
                        Price = (decimal)dr["Price"],
                        IsAlcoholic = (bool)dr ["IsAlcoholic"],
                        Quantity = (int)dr["quantity"]
                    };
                    receipt.Add(items);
                };
                return receipt;
            }
            catch (Exception e)
            {
                throw new Exception("De data kan niet geladen worden uit de database. probeer het later opnieuw" + e.Message);
            }
        }
    }
}
