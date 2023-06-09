using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodAssignment
{
    public class DataBy2
    {

        public void DivMethod(int a)  //Creating a void method that outputs an integer.
        {
            int b = a / 2; //Having the method divide the data passed to it by 2
            Console.WriteLine("The result is: " + b); //Displaying the entered number, divided by two.
        }

        public void DivMethod(string Input)  //Overloading a method.
        {
            Console.WriteLine("\nYour input was: " + Input); //Displaying the entered number, divided by two.
        }

        public void outParam()  //Creating a method with output parameters.
        {
            Console.WriteLine("\nWe will be with you in a moment...\n");
        }

    }
}
