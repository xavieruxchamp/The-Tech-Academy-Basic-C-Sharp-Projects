using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethodsAssignment
{
    //Creating a class with three methods. The methods should do some math operation on the received parameter.
    public class Computes
    {

    public static int Factorial(int number) //Each method will take one integer parameter in and return an integer.
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }

    public static int Square(int number) //Each method will take one integer parameter in and return an integer.
        {
            int square = number * number;
            return square;
        }

        public static int Cube(int number) //Each method will take one integer parameter in and return an integer.
        {
            int cube = number * number * number;
            return cube;
        }
    }
}
