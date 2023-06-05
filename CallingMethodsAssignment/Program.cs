using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user what number they want to do the math operations on.
            Console.WriteLine("Please provide a number so that we could Square it, Cube it, and calculate its Factorial");
            int number = Convert.ToInt32(Console.ReadLine());

            //Creating a class with three methods under a separate file

            //Calling each method in turn, passing the user input to the method
            int squaredNumber = Computes.Square(number);
            int cubedNumber = Computes.Cube(number);
            int factNumber = Computes.Factorial(number);

            //Displaying each returned integer to the screen.
            Console.WriteLine($"Squared: {squaredNumber}, Cubed: {cubedNumber}, Factorial: {factNumber}");
            Console.ReadLine();

        }
    }
}
