using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ErrorHandling;
using HashingAlgorithms;
using ChapeauInterfaces;

namespace ChapeauDAO
{
    public class LoginDAO : BaseDao
    {  
        // login Method + query
        public Employee Login(int employeeID) 
        {
            string query = "SELECT [EmployeeID], [Password], [Category], [FirstName], [LastName], [DateOfBirth], [Email], [PhoneNumber], [Question], [Answer] from [ApplicatiebouwChapeau].[Employee] where EmployeeID = @EmployeeID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@EmployeeID", employeeID);

            if (ExecuteSelectQuery(query, sqlParameters).Rows.Count == 0)
            {
                throw new ChapeauException("incorrect username or password, please make sure you have spelled everything correctly.");
            }
            else
            {
                return ReadUser(ExecuteSelectQuery(query, sqlParameters));
            }
        }

        // Datatable to read the Employee
        private Employee ReadUser(DataTable dataTable)
        {
            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Employee employee = new Employee()
                    {
                        EmployeeID = (int)dr["EmployeeID"],
                        Password = (string)dr["Password"],
                        Category = (EmployeeCategory)dr["Category"],
                        FirstName = (string)dr["FirstName"],
                        LastName = (string)dr["LastName"],
                        DateOfBirth = (DateTime)dr["DateOfBirth"],
                        Email = (string)dr["Email"],
                        PhoneNumber = (string)dr["PhoneNumber"],
                        Question = (string)dr["Question"],
                        Answer = (string)dr["Answer"]                        
                    };
                    return employee;
                };
                Employee newEmployee = new Employee();
                return newEmployee;

            }
            catch (Exception e)
            {
                throw new Exception("Data could not be retrieved from the database. Please try again, error: " + e.Message);
            }
        }
    }
}
