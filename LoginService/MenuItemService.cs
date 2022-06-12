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
        int IsDiner;

        private DateTime lunch = new DateTime(2022, 6, 14, 16, 00, 00);
        public MenuItemService()
        {
            _menuItemDAO = new MenuItemDAO();
        }
        public List<MenuItem> GetAllMenuItems(int Type)
        {
            if (Type == 3)
            {
                IsDiner = 0;
            }
            else
            {
                if (DateTime.Now.TimeOfDay > lunch.TimeOfDay)
                {
                    IsDiner = 1;
                }
                else
                {
                    IsDiner = 0;
                }
            }
            
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
