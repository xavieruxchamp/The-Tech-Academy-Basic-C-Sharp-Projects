using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2) //Overloading the "==" operator.
    
        {
            return employee1.ID == employee2.ID;
        }

        public static bool operator !=(Employee employee1, Employee employee2) //Overloading the "!=" operator, since comparision operators must be overloaded in pairs.
        {
            return employee1.ID != employee2.ID;
        }
    }
}
