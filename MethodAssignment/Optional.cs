using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAssignment
{
    class Optional
    {
        //Creating a class.

        //Creating a method that takes two integers as parameters.
        public static int Multiplication(int a, int b=1) //Making one of paramenters optional.
        {
            return a * b;  //Having the method do a math operation and return an integer result.
        }
    }
}
