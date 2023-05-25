using System;
using System.Collections.Generic;
using System.Text;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”

            Console.WriteLine("Welcome to Package Express. Please follow the instuctions below.");

            //The user must then be prompted for the package weight.

            Console.WriteLine("How much does your package weight?.");




            //If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.

            //The user must then be prompted for the package width.

            Console.WriteLine("What is the width of your package?.");

            //Then the package height.

            Console.WriteLine("What is the height of your package?.");

            //Then the package length.

            Console.WriteLine("What is the lenght of your package?.");

            //If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.

            Console.WriteLine("Package too big to be shipped via Package Express.");

            //Next, multiply the three dimensions(height, width, &length) together, and multiply the product by the weight.Finally, divide the outcome by 100.

            //The result of that calculation is the quote.

            //Display the quote to the user as a dollar amount.

            Console.WriteLine("Your estimated total for shipping this package is: " + estimate +"\nThank you.");

            //For example: 

            //Welcome to Package Express.Please follow the instructions below.
            //Please enter the package weight:
            //40
            //Please enter the package width:
            //10
            //Please enter the package height:
            // 12
            //Please enter the package length:
            // 11
            //Your estimated total for shipping this package is: $528.00
            //Thank you!

        }
    }
}
