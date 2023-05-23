using System;
using System.Collections.Generic;
using System.Text;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial message and question
            Console.WriteLine("Academy of Learning Career College\nStudent Daily Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // Initial greeting
            Console.WriteLine("Hello, " + name + "!");

            // Various questions followed by a method to save data and to wait for next answer
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // Now we use casting to convert datatypes
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            int whatPage = Convert.ToInt32(page);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.?");
            string experience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int yourHours = Convert.ToInt32(hours);

            // Final message
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
