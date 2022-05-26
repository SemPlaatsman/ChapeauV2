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
            try
            {
                string query = $"INSERT INTO [ApplicatiebouwChapeau].[Order] (TableID) VALUES (@TableID)";
                SqlParameter[] sql = new SqlParameter[1];
                sql[0] = new SqlParameter("@TableID", TableID);
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
        public void AlterTables(int tableID)
        {
            try
            {
                string query = $"Update [ApplicatiebouwChapeau].[Table] set IsOccupied = 1 where TableID = @TableID";
                SqlParameter[] sqlParameter = new SqlParameter[1];
                sqlParameter[0] = new SqlParameter("@TableID", tableID);
                ExecuteEditQuery(query, sqlParameter);
            }
            catch(Exception e)
            {
                throw new Exception("Data could not be altered in the database. please try again" + e.Message);
            }

        }
    }
}
