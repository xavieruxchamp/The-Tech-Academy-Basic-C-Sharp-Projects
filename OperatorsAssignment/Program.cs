using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee //Instantiating the 1st object
            {
                //Assigning values to its property
                ID = 1,
                FirstName = "Peter",
                LastName = "Parker"
            };

            Employee employee2 = new Employee //Instantiating the 2nd object
            {
                //Assigning values to its property
                ID = 2,
                FirstName = "Linda",
                LastName = "Carter"
            };

            Console.WriteLine(employee1 == employee2 ? "Employee 1 and Employee 2 have the same ID." : "Employee 1 and Employee 2 have different IDs."); //Using ternary conditional operator to return one of two messages
            Console.ReadLine();
        }
    }
}
