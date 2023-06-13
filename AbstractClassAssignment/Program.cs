using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //Instantating the Employee class.

            employee.SayName(); //Calling a super class method on the employee object

            IQuittable quittableEmployee = new Employee(); //Using polymorphism to create an object of type IQuittable and to call the Quit() method on it
            quittableEmployee.Quit();

            Console.ReadLine();
        }
   
    }
}
