using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ErrorHandling;

namespace ChapeauDAO
{
    public class TableDAO : BaseDao
    {
        public List<Table> GetAllTables()
        {
            string query = "SELECT TableID, EmployeeID, IsOccupied, AmountOfGuests FROM ApplicatiebouwChapeau.[Table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateTableOccupy(Table table, bool isChecked) 
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TableID", table.TableID);

            if (isChecked)
            {
                query = "UPDATE ApplicatiebouwChapeau.[Table] SET IsOccupied = 1 where IsOccupied = 0 AND TableID = @TableID;";
            }
            else
            {
                query = "UPDATE ApplicatiebouwChapeau.[Table] SET IsOccupied = 0 where IsOccupied = 1 AND TableID = @TableID;";
            }
            ExecuteEditQuery(query, sqlParameters);
        }

        // Table table misschien ook nog meegeven. 
        public void SetEmployee(Employee employee, Table table)
        {
            string query = "Update ApplicatiebouwChapeau.[Table] SET [EmployeeID] = @EmployeeID where [TableID] = @TableID;";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@EmployeeID", employee.EmployeeID);
            sqlParameters[1] = new SqlParameter("@TableID", table.TableID);

            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Table> ReadTables(DataTable dataTable)
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
    }
}
