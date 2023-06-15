using System;
using System.Collections.Generic;
using System.Text;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employeeName = { "Joe", "Ann", "Pat" }; // Instantiating an Employee object with type “string”.
            int[] employeeID = {1, 2, 3}; // Instantiating an Employee object with type “int”

            Employee.dispItem(employeeName); //Assigning  a list of strings as the property value of Things.
            Employee.dispItem(employeeID); //Assigning  a list of integers as the property value of Things.
        }
    }
}
