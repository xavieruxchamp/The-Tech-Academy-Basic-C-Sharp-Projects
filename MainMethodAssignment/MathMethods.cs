using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssignment
{
    class MathMethods
    {
        // Creating a class.
        public static int mOperator(int a, int b) //Creating a method that will take in an integer, creating a math operation for this integer, then return the answer as an integer.
        {
            return a * b;
         }

        public static int mOperator(decimal c, decimal d) //Adding a second method to the class with the same name that will take in a decimal, to use it in a  different math operation, and to then return the answer as an integer.
        {
            double cDouble = (double)c;
            double dDouble = (double)d;

            return (int)Math.Pow(cDouble, dDouble);
        }

        public static int mOperator(string word) //Adding a third method to the class, with the same name, that will take in a string
        {
            int num = int.Parse(word); // Converting the string to an integer

            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial; // Returning the factorial result
        }
    }
}
