using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //Instantating the Employee class

            employee.SayName(); //Calling a super class method on the employee object
            Console.ReadLine();
        }
    }
}
