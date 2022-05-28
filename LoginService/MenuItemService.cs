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
        public List<MenuItem> GetAllMenuItems()
        {
            List<MenuItem> menuItems = _menuItemDAO.GetAllMenuItems();
            return menuItems;
        }
        public List<MenuItem> GetMenuItemsFromOrder(Order order)
        {
            List<MenuItem> menuItems = _menuItemDAO.GetMenuItemsFromOrder(order);
            return menuItems;
        }
    }
}
