using ChapeauDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauInterfaces;

namespace ChapeauLogica
{
    public class LoginService
    {
        private LoginDAO loginDAO;

        public LoginService()
        {
            loginDAO = new LoginDAO();
        }

        // Parameter is a class object. 
        public Employee Login(int employeeID)
        {
            return loginDAO.Login(employeeID);
        }
    }
}
