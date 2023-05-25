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

            Console.WriteLine("Welcome to Package Express!\n\n" + "Please follow the instuctions below:\n");

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

                // Check if dimensions are greater than 50
                bool isTooBig = dimensions > 50;

                // Calculating the quote by multiplying the dimensions by the weight, and then dividing the product by a 100.
                decimal quote = (decimal)(dimensions * weight) / 100;

                //Alerting the customer that the package is too big for shipping, when its dimensions is greater than 50 (program ends).
                //Otherwise, displaying quote in local currency
                string result = isTooBig ? "Package too big to be shipped via Package Express." : String.Format("\n\nYour estimated total for shipping this package is: CAD{0:C}", quote);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
