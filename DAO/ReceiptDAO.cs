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

        public string Host(int TableId)
        {
            try
            {
                string query = "select EM.FirstName "+
                "from ApplicatiebouwChapeau.[Table] as TA "+
                "join ApplicatiebouwChapeau.[Employee] as EM on TA.EmployeeID = EM.EmployeeID "+
                "where TA.TableID = @tableId; ";

                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@tableId", TableId);
                return ReadHostTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                //Toont een foutmelding als de order niet geladen kan worden.
                throw new Exception("Order kan niet geladen worden. probeer het later opnieuw " + e.Message);
            }
        }

        public void InsertReceipt(int TableId ,decimal totalPrice, decimal btwTotal, string paymentMethod, DateTime timeOfPayment)
        {
            try
            {
                string query = "INSERT INTO ApplicatiebouwChapeau.Receipt (OrderID, TotalPrice, TimeOfPayment, MethodOfPayment, BTW) " +
                    "VALUES((SELECT TOP(1) OrderId " +
                    "FROM ApplicatiebouwChapeau.[Order] " +
                    "WHERE TableId = @tableId " +
                    "ORDER BY OrderId DESC), @totalPrice, @timeOfPayment, @methodOfPayment, @bTW); ";

                SqlParameter[] sqlParameters = new SqlParameter[5];
                sqlParameters[0] = new SqlParameter("@tableId", TableId);

                sqlParameters[1] = new SqlParameter("@totalPrice", totalPrice);
                sqlParameters[2] = new SqlParameter("@methodOfPayment", paymentMethod);
                sqlParameters[3] = new SqlParameter("@timeOfPayment", timeOfPayment);
                sqlParameters[4] = new SqlParameter("@bTW", btwTotal);
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw new Exception("De data kan niet geupload worden naar de database. probeer het later opnieuw" + e.Message);
            }
        }

        public void InsertRemark(int tableId, string remark)
        {
            try
            {
                string query = "INSERT INTO ApplicatiebouwChapeau.Remark(RecieptID, Remark) " +
                    "VALUES((SELECT TOP(1) ReceiptID " +
                    "FROM ApplicatiebouwChapeau.[Receipt] AS R " +
                    "JOIN ApplicatiebouwChapeau.[Order] AS O ON R.OrderID = O.OrderID " +
                    "WHERE TableId = @tableId " +
                    "ORDER BY R.OrderID DESC), @remark);";

                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@tableId", tableId);

                sqlParameters[1] = new SqlParameter("@remark", remark);
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw new Exception("De data kan niet geupload worden naar de database. probeer het later opnieuw" + e.Message);
            }
        }

        private string ReadHostTables(DataTable dataTable)
        {
            try
            {
                return (string)dataTable.Rows[0]["FirstName"];
            }
            catch (Exception e)
            {
                throw new Exception("De data kan niet geladen worden uit de database. probeer het later opnieuw" + e.Message);
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
