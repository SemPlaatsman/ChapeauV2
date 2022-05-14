using ChapeauDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;

namespace LoginService
{
    public class LoginService
    {
        private LoginDAO loginDAO;

        public LoginService()
        {
            loginDAO = new LoginDAO();
        }

        // Parameter is a class object. 
        public Employee LoginUser(Employee employee)
        {
            return loginDAO.Login(employee);
        }
    }
}
