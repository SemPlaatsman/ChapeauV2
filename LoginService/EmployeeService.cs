using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAO;

namespace ChapeauLogica
{
    public class EmployeeService
    {
        private EmployeeDAO employeedb;

        public EmployeeService()
        {
            employeedb = new EmployeeDAO();
        }

        public List<Employee> GetAllEmployees() 
        {
            List<Employee> employees = employeedb.GetAllEmployees();
            return employees;
        }
    }
}
