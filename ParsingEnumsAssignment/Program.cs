using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try //Wrapping code in a Try/Catch block
            {
                Console.WriteLine("Enter the current day of the week:\n"); //Prompting the user to enter the current day of the week

                string input = Console.ReadLine(); 
                input = char.ToUpper(input[0]) + input.Substring(1); //Converting the first letter of the input to upper case.

                DaysOfTheWeek NewDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input); //Assigning the value to a variable of the enum data type, and converting the string representation of the enum value to its corresponding enum value.

                Console.WriteLine("You entered: " + NewDay);
            }
            catch (Exception ex) //Showing an Error
            {
                Console.WriteLine("\nError: " + ex.Message + "\nPlease enter an actual day of the week.");
            
            }
            Console.ReadLine();
        }

    }

    public enum DaysOfTheWeek //Creating an enum for the days of the week.
    {
        Monday=1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=6,
        Sunday=7
    }
}
