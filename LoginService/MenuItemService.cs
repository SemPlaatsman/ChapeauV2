using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAO;

namespace ChapeauLogica
{
    public class MenuItemService
    {
        private MenuItemDAO _menuItemDAO;

        public MenuItemService()
        {
            _menuItemDAO = new MenuItemDAO();
        }
        public List<MenuItem> GetAllMenuItems(int Type, int IsDiner)
        {
            List<MenuItem> menuItems = _menuItemDAO.GetAllMenuItems(Type, IsDiner);
            return menuItems;
        }
        public MenuItem GetMenuItemsFromOrder(MenuItem menuItem)
        {
            MenuItem menuItems = _menuItemDAO.GetMenuItemsFromOrder(menuItem);
            return menuItems;
        }

        public void UpdateMenuItem(OrderGerecht ordergerecht)
        {
            _menuItemDAO.UpdateMenuItem(ordergerecht);
        }
    }
}
