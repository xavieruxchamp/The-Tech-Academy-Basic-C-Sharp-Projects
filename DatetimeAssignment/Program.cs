using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentdatetime = DateTime.Now;
            Console.WriteLine("The current time is:" + currentdatetime); //Printing current time to the screen
            Console.WriteLine("Please enter the number of hours from now:"); //Prompting user to enter a number
            string text = Console.ReadLine(); //Reading input

            int hoursinfuture = Convert.ToInt32(text); // Converting user input to hours
            DateTime futuretime = currentdatetime.AddHours(hoursinfuture); // Calculating the future time

            Console.WriteLine(text + " hours from now it will be: " + futuretime); // Printing the future time to the console
            Console.ReadLine();
        }
    }
}
