using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a class, with 3 methods with unique signatures, in other workds, sharing the same name but with different parameters.
            // Each of the methods perform different math opertations. 

            //Instantiatng the class
            //Calling the first method, passing in an integer.
            int result1 = MathMethods.mOperator(5, 3);
            Console.WriteLine("Result 1: " + result1);

            //Instantiatng the class
            //Calling the second method with decimal parameters
            int result2 = MathMethods.mOperator(2.5m, 3.7m);
            Console.WriteLine("Result 2: " + result2);

            //Instantiatng the class
            //Calling the third method with a string parameter
            int result3 = MathMethods.mOperator("4");
            Console.WriteLine("Result 3: " + result3);
            Console.ReadLine();
        }
    }
}
