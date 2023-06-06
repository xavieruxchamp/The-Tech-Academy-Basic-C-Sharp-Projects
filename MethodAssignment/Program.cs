using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a class with a method that takes two integers as parameters, making one of them optional. Then, having the method do a math operation and return an integer result.

            //Instantiating the class.
            Console.WriteLine("Please enter the first number:"); //Asking the user to input two numbers, one at a time.
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the 2nd number: (Optional/Not required)"); //Letting them know that the 2nd number is optional.
            string input = Console.ReadLine();

            int num2;
            bool hasNum2 = int.TryParse(input, out num2);

            int result = hasNum2 ? Optional.Multiplication(num1, num2) : Optional.Multiplication(num1); //Calling the method in the class, passing in one or two numbers, as provided.
            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }
    }
}
