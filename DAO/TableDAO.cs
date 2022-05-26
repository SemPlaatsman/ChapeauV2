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

        public void UpdateTableOccupy(Table table) 
        {
            string query = "UPDATE ApplicatiebouwChapeau.[Table] SET IsOccupied = @true where IsOccupied = @false;";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            if (table.IsOccupied == false)
            {
                query = "UPDATE ApplicatiebouwChapeau.[Table] SET IsOccupied = @false where IsOccupied = @true;";
            }
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
