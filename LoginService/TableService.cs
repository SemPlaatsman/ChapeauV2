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
    }
}
