using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{    public class Employee
    {
        // nog helemaal aanpassen. moet alles erin wat ook in sql staat? email, phonenumber etc... 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Category { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Questiom { get; set; }
        public string Answer { get; set; }
    }
}
