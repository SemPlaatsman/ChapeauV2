using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAO;

namespace ChapeauLogica
{
    public class TableService
    {
        private TableDAO tableDAO;

        public TableService()
        {
            tableDAO = new TableDAO();
        }

        public List<Table> GetAllTables()
        {
            List<Table> tables = tableDAO.GetAllTables();
            return tables;
        }

        public void UpdateTableOccupy(Table table, bool isChecked) 
        {
            tableDAO.UpdateTableOccupy(table, isChecked);
        }

        public void SetEmployee(Employee employee, Table table) 
        {
            tableDAO.SetEmployee(employee, table);
        }
        public void AlterTables(Table tableId, int occupation)
        {
            tableDAO.AlterTables(tableId, occupation);
        }
    }
}
