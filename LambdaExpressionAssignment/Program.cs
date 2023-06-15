using System;
using System.Collections.Generic;
using System.Text;


namespace LambdaExpressionAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Creating a list of 10 employees, with 2 employees sharing the FirstName “Joe”.
            List<Employee> employees = new List<Employee>

                {
                    new Employee { Id = 1, FirstName = "Peter", LastName = "Doe" },
                    new Employee { Id = 2, FirstName = "Paul", LastName = "Smith" },
                    new Employee { Id = 3, FirstName = "Mary", LastName = "Johnson" },
                    new Employee { Id = 4, FirstName = "Tristan", LastName = "Miller" },
                    new Employee { Id = 5, FirstName = "Pat", LastName = "Smith" },
                    new Employee { Id = 6, FirstName = "Bob", LastName = "Trump" },
                    new Employee { Id = 7, FirstName = "Tom", LastName = "Obama" },
                    new Employee { Id = 8, FirstName = "Anne", LastName = "Putin" },
                    new Employee { Id = 9, FirstName = "Joe", LastName = "Trudeau" },
                    new Employee { Id = 10, FirstName = "Joe", LastName = "Kennedy" }
                };
            
            //Using a foreach loop, creating a new list of all employees whose first name is “Joe”.
            List<Employee> Joes = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Joes.Add(employee);
                }
            }

            //Using a foreach to print the new list.
            foreach (Employee joe in Joes)
            {
                Console.WriteLine("Id: " + joe.Id + ", First Name: " + joe.FirstName + ", Last Name: " + joe.LastName);
            }
            Console.ReadLine();

            //Performing the same action above with a lambda expression.
            List<Employee> JoesLambda = employees.FindAll(employee => employee.FirstName == "Joe");

            foreach (Employee joelambda in JoesLambda)
            {
                Console.WriteLine("Id: " + joelambda.Id + ", First Name: " + joelambda.FirstName + ", Last Name: " + joelambda.LastName);
            }
            Console.ReadLine();

            //Using a lambda expression to make a list of all employees whose Id number is greater than 5.
            List<Employee> Fiver = employees.FindAll(employee => employee.Id > 5);

            foreach (Employee fiver in Fiver)
            {
                Console.WriteLine("Id: " + fiver.Id + ", First Name: " + fiver.FirstName + ", Last Name: " + fiver.LastName);
            }
            Console.ReadLine();
        }
    }
}
