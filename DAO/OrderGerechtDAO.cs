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
            string query = "SELECT O.OrderGerechtId, M.ProductID, M.IsDiner, T.TypeName, M.ProductName, M.Price, M.Stock, M.IsAlcoholic, O.OrderId, O.[Status], O.TimeOfOrder, O.Remark " +
                "FROM ApplicatiebouwChapeau.OrderGerecht AS O " +
                "JOIN ApplicatiebouwChapeau.MenuItem AS M ON O.ItemId = M.ProductID " +
                "JOIN ApplicatiebouwChapeau.TypeOfProduct AS T ON M.[Type] = T.TypeID " +
                "WHERE O.[Status] != 1;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
                orderGerechten.Add(orderGerecht);
            }
            return orderGerechten;
        }
        public void InsertOrderGerecht(int itemID, int orderID, int status, DateTime timeOfOrder, string remark)
        {
            //string query = "INSERT INTO ";
        }
    }
}
