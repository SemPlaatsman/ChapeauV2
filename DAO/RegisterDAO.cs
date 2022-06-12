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
    public class RegisterDAO : BaseDao
    {
        public void AddRowRegister(Employee employee)
        {
            string query = "INSERT INTO [ApplicatiebouwChapeau].[Employee] ([FirstName], [LastName], [DateOfBirth], [Email], [PhoneNumber], [Category], [Password], [Question], [Answer])" +
                " VALUES (@FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber, @Category, @Password, @Question, @Answer)";
            SqlParameter[] sqlParameters = new SqlParameter[9];
            sqlParameters[0] = new SqlParameter("@FirstName", employee.FirstName);
            sqlParameters[1] = new SqlParameter("@LastName", employee.LastName);
            sqlParameters[2] = new SqlParameter("@DateOfBirth", employee.DateOfBirth);
            sqlParameters[3] = new SqlParameter("@Email", employee.Email);
            sqlParameters[4] = new SqlParameter("@PhoneNumber", employee.PhoneNumber);
            sqlParameters[5] = new SqlParameter("@Category", employee.Category + 1);
            sqlParameters[6] = new SqlParameter("@Password", employee.Password);
            sqlParameters[7] = new SqlParameter("@Question", employee.Question);
            sqlParameters[8] = new SqlParameter("@Answer", employee.Answer);
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
                        FirstName = (string)dr["FirstName"],
                        LastName = (string)dr["LastName"],
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
