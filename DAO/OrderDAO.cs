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
        public void InsertOrder(int TableID)
        {
            string query = $"INSERT INTO Order (TableID) VALUES (@TableID)";
            SqlParameter[] sql = new SqlParameter[1];
            sql[0] = new SqlParameter("@TableID", TableID);
            ExecuteEditQuery(query, sql);
        }

    }
}
