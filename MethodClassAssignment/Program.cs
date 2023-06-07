using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a class with a void method that takes two integers as parameters.
            //Then, having the method do a math operation on the first integer and display the second integer to the screen.

            //Instantiate the class.
            TwoParam twoParam = new TwoParam();

            twoParam.factDisp(2, 4); //Calling the method in the class, passing in two numbers.
            twoParam.factDisp(a: 9, b: 3); //Calling the method in the class, specifying the parameters by name.
            Console.ReadLine();

        }
    }
}
