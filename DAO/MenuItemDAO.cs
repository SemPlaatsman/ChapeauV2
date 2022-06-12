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
    public class MenuItemDAO : BaseDao
    {
        public List<MenuItem> GetAllMenuItems()
        {
            try
            {
                string query = "SELECT [ProductID],[IsDiner],[Type],[ProductName],[Price],[Stock],[IsAlcoholic] " +
                    "FROM [ApplicatiebouwChapeau].[MenuItem] ";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                throw new Exception("Menuitems could not be loaded properly. Please try again " + e.Message);
            }
        }
        public MenuItem GetMenuItemsFromOrder(MenuItem menuItem)
        {
            string query = "Select [ProductID],[IsDiner],[Type],[ProductName],[Price],[Stock],[IsAlcoholic] " +
                           "From[ApplicatiebouwChapeau].[MenuItem] as M " +
                           "Where M.ProductID = @MenuitemID;";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MenuitemID", menuItem.ProductId);
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
        public MenuItem ReadTable(DataTable dataTable)
        {
            try
            {
                MenuItem menuItem = new MenuItem();
                foreach (DataRow dr in dataTable.Rows)
                {
                    menuItem.ProductId = (int)dr["ProductID"];
                    menuItem.IsDiner = (bool)dr["IsDiner"];
                    menuItem.Type = (TypeOfProduct)(int)dr["Type"];
                    menuItem.ProductName = (string)dr["ProductName"];
                    menuItem.Price = (decimal)dr["Price"];
                    menuItem.Stock = (int)dr["Stock"];
                    menuItem.IsAlcoholic = (bool)dr["IsAlcoholic"];
                }
                return menuItem;
            }
            catch (Exception e)
            {

                throw new Exception("Data could not be retrieved from the database. Please try again" + e.Message);
            }
        }
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            try
            {
                List<MenuItem> menuItems = new List<MenuItem>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    MenuItem menuItem = new MenuItem()
                    {
                        ProductId = (int)dr["ProductID"],
                        IsDiner = (bool)dr["IsDiner"],
                        Type = (TypeOfProduct)(int)dr["Type"],
                        ProductName = (string)dr["ProductName"],
                        Price = (decimal)dr["Price"],
                        Stock = (int)dr["Stock"],
                        IsAlcoholic = (bool)dr["IsAlcoholic"],
                        
                    };
                    menuItems.Add(menuItem);
                };
                return menuItems;
            }
            catch (Exception e)
            {
                throw new Exception("Data could not be retrieved from the database. Please try again" + e.Message);
            }
        }
        public void UpdateMenuItem(OrderGerecht orderGerecht)
        {
            string query = "Update [ApplicatiebouwChapeau].[MenuItem] set stock -= 1 where ProductID = @MenuItemId; ";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@MenuItemId", orderGerecht.MenuItem.ProductId);
            ExecuteEditQuery(query, sqlParameter);
        }
    }
}
