using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClassAssignment
{
    class TwoParam
    {
        //Create a class with a void method that takes two integers as parameters.

        public void factDisp(int a, int b)  //Creating a method that takes two integers as parameters.
        {
            int factorial = 1;
            for (int i = 1; i <= a; i++)
            {
                factorial *= i; //Having the method do a math operation on the first integer
            }
            
            Console.WriteLine("The Factorial of " + a  + " is: " + factorial + ". \nYou entered " + b + " as the second number.");; //Having the method display the second integer to the screen.
        }
    }
}
