using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;

namespace ChapeauDAO
{
    public class RegisterDAO : BaseDao
    {
        public void AddRowRegister(Employee employee)
        {            
            string query = "INSERT INTO [Employee] ([FirstName], [LastName], [DateOfBirth], [Email], [PhoneNumber], [Category], [Password], Question, Answer) VALUES (@FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber, @Category, @Password, @Question, @Answer)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Employee", employee);
            ExecuteEditQuery(query, sqlParameters);
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
                        // zij hebben nog geen EmployeeID, hoe ga ik dit oplossen?
                        FirstName = (string)dr["FirstName"],
                        LastName = (string)dr["LastName"],
                        Category = (int)dr["Category"],
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
