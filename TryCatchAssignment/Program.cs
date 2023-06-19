using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Asking the user for their age.
                Console.WriteLine("What is your age? (use digits only)");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0)
                {
                    // Displaying an error message for zero or negative numbers.
                    Console.WriteLine("Age must be a positive number.");
                }
                else
                {
                    // Displaying the year the user was born.
                    int yearBorn = DateTime.Now.Year - age;
                    Console.WriteLine("You were born in " + yearBorn);
                }
            }
            catch (FormatException)
            {
                // Displaying an error message for invalid input.
                Console.WriteLine("Invalid age entered. Please enter a valid number.");
            }
            Console.ReadLine();
        }
    }
}

