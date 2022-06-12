using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChapeauModel;
using ChapeauInterfaces;

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
        public Order GetCurrentOrder(Table table)
        {
            try
            {
                string query = "Select TOP(1) o.OrderID, o.tableid from[ApplicatiebouwChapeau].[Order] as O where O.OrderID not in (select Receipt.OrderID from[ApplicatiebouwChapeau].[Receipt]) and O.TableID = @TableId ORDER BY o.OrderID DESC";
                SqlParameter[] sql = new SqlParameter[1];
                sql[0] = new SqlParameter("@TableId", table.TableID);
                return ReadTable(ExecuteSelectQuery(query, sql));
            }
            catch (Exception e)
            {

                throw new Exception("Tables could not be loaded properly. Please try again " + e.Message);
            }
        }
        public Order ReadTable(DataTable dataTable)
        {
            try
            {
                Order order = new Order();
                foreach (DataRow dr in dataTable.Rows)
                {
                    order.OrderId = (int)dr["OrderId"];
                    order.TableId = (int)dr["TableId"];
                }
                return order;
            }
            catch (Exception e)
            {

                throw new Exception("Data could not be retrieved from the database. Please try again" + e.Message);
            }
        }
       
        
        
    }
}
