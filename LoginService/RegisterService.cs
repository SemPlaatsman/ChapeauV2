using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAO;
using ChapeauModel;

namespace ChapeauLogica
{
    public class RegisterService
    {
        private RegisterDAO registerDB;

        public RegisterService()
        {
            this.registerDB = new RegisterDAO();
        }

        // weet niet of dit perse klopt. NOG GOED CHECKEN
        public void AddEmployee(Employee employee) 
        {
            registerDB.AddRowRegister(employee);
        }
    }
}
