using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauInterfaces;

namespace ChapeauDAO
{
    public class EmployeeDAO : BaseDao
    {
        public List<Employee> GetAllEmployees() 
        {
            try
            {
                string query = "SELECT [EmployeeID] ,[Password],[Category],[FirstName],[LastName],[DateOfBirth],[Email],[PhoneNumber],[Question],[Answer] " +
                    "FROM [ApplicatiebouwChapeau].[Employee]";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                // if something went wrong, it will be written in the errorlogger. 
                throw new Exception("Employees could not be loaded properly. Please try again " + e.Message);
            }
        }

        public Employee GetEmployee(Table table) 
        {
            string query = "SELECT [EmployeeID] ,[Password],[Category],[FirstName],[LastName],[DateOfBirth],[Email],[PhoneNumber],[Question],[Answer] " +
                    "FROM [ApplicatiebouwChapeau].[Employee] WHERE EmployeeID = @EmployeeID";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@EmployeeID", table.EmployeeID);
            return ReadTables(ExecuteSelectQuery(query, sqlParameter))[0];
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            try
            {
                List<Employee> employees = new List<Employee>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Employee employee = new Employee()
                    {
                        EmployeeID = (int)dr["EmployeeID"],
                        FirstName = (string)dr["FirstName"],
                        LastName = (string)dr["LastName"],
                        Password = (string)dr["Password"],
                        Category = (EmployeeCategory)(int)dr["Category"],
                        DateOfBirth = (DateTime)dr["DateOfBirth"],
                        Email = (string)dr["Email"],
                        PhoneNumber = (string)dr["PhoneNumber"],
                        Question = (string)dr["Question"],
                        Answer = (string)dr["Answer"]
                    };
                    employees.Add(employee);
                };
                return employees;
            }
            catch (Exception e)
            {
                throw new Exception("Data could not be retrieved from the database. Please try again" + e.Message);
            }
        }
    }
}
