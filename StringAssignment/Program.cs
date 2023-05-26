using System;
using System.Collections.Generic;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenating three strings.

            string person = "Joe";

            Console.WriteLine("Hi " + person + "! Welcome! Where are you from?");
            Console.ReadLine();

         //Converting a string to uppercase.

            string car = "Ferrari";
            string vehicle = car.ToUpper();
            Console.WriteLine(vehicle);

            //Creating a Stringbuilder and building a paragraph of text, one sentence at a time.

            StringBuilder name = new StringBuilder();

            name.Append("\nHow are you today?").Append(" Isn't this a beautiful day?").Append(" Enjoy!");

            Console.WriteLine(name);
            Console.ReadLine();

        }
    }
}
