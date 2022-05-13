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


namespace ChapeauDAO
{
    public class LoginDAO : BaseDao
    {  
        public Employee Login(int werknemersNummer, string password) 
        {
            // ofzoiets... 
            string query = "SELECT EmployeeID from [ApplicatiebouwChapeau].[Employee] where EmployeeID = @EmployeeID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@EmployeeID", werknemersNummer);
            sqlParameters[1] = new SqlParameter("@password", password);

            if (ExecuteSelectQuery(query, sqlParameters).Rows.Count == 0)
            {
                throw new ChapeauException("incorrect username or password, please make sure you have spelled everything correctly.");
            }
            else
            {
                return ReadUser(ExecuteSelectQuery(query, sqlParameters));
            }
        }

        private Employee ReadUser(DataTable dataTable)
        {
            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Employee employee = new Employee()
                    {
                        // deze moeten nog aangepast worden. OOK IN DE EMPLOYEE MODEL
                        FirstName = (string)dr["FirstName"],
                        LastName = (string)dr["LastName"],
                        Password = (string)dr["Password"],
                        Category = (int)dr["Category"],
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
