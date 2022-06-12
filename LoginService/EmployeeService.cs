using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAO;
using ChapeauInterfaces;

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

        public Employee GetEmployee(Table table) 
        {
            Employee employee = employeedb.GetEmployee(table);
            return employee; 
        }
    }
}
