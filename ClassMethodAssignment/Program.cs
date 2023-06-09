using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
        //Creating a Class, which includes a void method that outputs an integer. Then, having the method divide the data passed to it by 2.

            DataBy2 databy2 = new DataBy2(); //Instantiating the class.

            Console.WriteLine("Please enter a number:"); //Having the user enter a number.
            int a = Convert.ToInt32(Console.ReadLine());

            databy2.DivMethod(a); //Calling the method using number provided.

            Console.ReadLine();

            //Creating a method with output parameters.
            databy2.outParam(); //Calling method above
        
            //Overloading a method.

            Console.WriteLine("\nPlease provide your Input."); //Having the user enter a string
            string b = Console.ReadLine();

            databy2.DivMethod(b); //Calling the method using string provided.

            StaticClass.PrintMessage(); //Calling final method below
            Console.ReadLine();

        }
        public static class StaticClass //Declaring a class to be static.
        {
            public static void PrintMessage()
            {
                Console.WriteLine("\nThis is the end of the program\n");
            }
        }


    }
}
