using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStringsandIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers.
            int[] Digits = { 10, 20, 30, 40, 50, 60 };

            //Ask the user for a number to divide each number in the list by.

            //Console.WriteLine("Enter a number");
            //int uDigit = Convert.ToInt32(Console.ReadLine());

            //Write a loop that takes each integer in the list, divides it by the number the user entered,
            //and displays the result to the screen.

            //foreach(int digit in Digits)
            //{
            //    int dDigit = digit / uDigit;
            //    Console.WriteLine(digit + " divided by " + uDigit + " equals " + dDigit);
            //}
            //Console.ReadLine();

            //When the user enters a non-zero number, we get the results of the division.
            //When the user enters zero we get this error: System.DivideByZeroException: 'Attempted to divide by zero.'
            //When the user enters a string we get this error message: System.FormatException: 'Input string was not in a correct format.'

            //Putting the loop in a try/catch block.

            try
            {
                Console.WriteLine("Enter a number");
                int uDigit = Convert.ToInt32(Console.ReadLine());
                foreach (int digit in Digits)
                {
                    int dDigit = digit / uDigit;
                    Console.WriteLine(digit + " divided by " + uDigit + " equals " + dDigit);
                }
            }
            catch (FormatException ex) //Referencing a specific exception handling to ensure that the proper error messages display on the screen below.
            {
                Console.WriteLine(ex.Message); //Display the error message to the screen.           
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) //Displaying any other exception that may arise.
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution completed."); // Making the program print a message that the program has emerged from the try/catch block
            }
            Console.ReadLine(); //This ensures that the code continues after the try/catch block gets executed
        }

            }
}
