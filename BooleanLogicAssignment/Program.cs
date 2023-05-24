using System;
using System.Collections.Generic;
using System.Text;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Basic approval program for car insurance to determine whether or not the applicant is qualified for car insurance.

            Console.WriteLine("Welcome to our car insurance application");

            //Mandatory questions

            Console.WriteLine("What is your age?");
            string A = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            string D = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have??");
            string T = Console.ReadLine();

            //Appying qualification rules to determine whether applicant gets car insurance or not, using Boolean logic.

            //Must be over 15 years of age, must not have DUI's, and must not have more than 3 speeding tickets.

            bool Age = Convert.ToInt32(A) > 15;
            bool Dui = D != "Yes";
            bool Tickets = Convert.ToInt32(T) <= 3;

            //Printing the result of the boolean expressions

            Console.WriteLine("Qualified ?");
            Console.WriteLine(Age && Dui && Tickets);
            Console.ReadLine();

        }
    }
}
