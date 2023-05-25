using System;
using System.Collections.Generic;
using System.Text;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

        //Welcome for a shipping company

            Console.WriteLine("Welcome to Package Express. Please follow the instuctions below.");

        //Requesting the weight of the pacjage

            Console.WriteLine("How much does your package weight? (in lbs).");
            int weight = Convert.ToInt32(Console.ReadLine());

            //Displaing an error message when the weight is greater than 50 (program ends).
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                //Prompting the user for the dimensions of the package.
                Console.WriteLine("What is the width of your package?. (in Inches)");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the heigth of your package?. (in Inches)");
                int heigth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of your package?. (In Inches)");
                int length = Convert.ToInt32(Console.ReadLine());

                //Calculate dimensions
                int dimensions = width * heigth * length;

                // Calculating the quote by multiplying the dimensions by the weight, and then dividing the product by a 100.
                decimal quote = (dimensions * weight) / 100m; // Performing division using decimal values

                //Alerting the customer that the package is too big for shipping, when its dimensions is greater than 50 (program ends).
                //Otherwise, displaying quote in local currency
                string result = dimensions > 50 ? "Package too big to be shipped via Package Express." : "Your estimated total for shipping this package is: CAD$" + quote + "\nThank you.";
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
