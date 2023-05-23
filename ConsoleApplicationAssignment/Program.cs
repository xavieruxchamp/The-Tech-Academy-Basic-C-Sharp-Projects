using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Takes an input from the user, multiplies it by 50, then prints the result to the console. (allowing inputs larger than 10, 000, 000).

            double etfCont = 21000000;
            double potValue = etfCont * 50;
            Console.WriteLine("The potential value of your portfolio is: " + potValue);
            Console.ReadLine();

            //Takes an input from the user, adds 25 to it, then prints the result to the console.

            int accruedVac = 100;
            int newVac = accruedVac + 25;
            Console.WriteLine("We have added 25 more days to your Vacation days: " + newVac);
            Console.ReadLine();

            //Takes an input from the user, divides it by 12.5, then prints the result to the console.

            float cost = 99.99f;
            float perWidget = cost / 12.5f;
            Console.WriteLine("Here is the cost per widget: " + perWidget);
            Console.ReadLine();

            //Takes an input from the user, checks if it is greater than 50, then prints the true / false result to the console.

            int yourRate = 67;
            bool comp = yourRate > 50;
            Console.WriteLine("Your rate is more than 50:\n" + comp);
            Console.ReadLine();

            //Takes an input from the user, divides it by 7, then prints the remainder to the console.

            int a = 24;
            int remainder = a / 7;
            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}
