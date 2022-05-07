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
            string query = "";
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
                    Id = (int)dr["Id"],
                    Name = (string)dr["name"],
                    SalesPrice = (decimal)dr["salesPrice"],
                    Stock = (int)dr["stock"],
                    Alcoholic = Convert.ToBoolean(dr["alcoholic"]),
                    NrOfSales = (int)dr["nrOfSales"]
                };
                orderGerechten.Add(orderGerecht);
            }
            return orderGerechten;
        }
    }
}
