using System;
using System.Collections.Generic;
using System.Text;

namespace WhileandDoWhileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //A while loop example
            //Initializing variable
            int ranking = 1;
            //C# checks for value of ranking before executing code
            while (ranking <= 5)
            {
                Console.WriteLine(ranking);
                //modifying value of ranking to avoid infinite looping
                ranking++;
            }
            Console.ReadLine();


            //A do while loop example
            //Initializing variable
            int terminal = 1;
            //C# performs code always
            do
            {
                Console.WriteLine(terminal);
                //modifying value of ranking
                terminal++;
            } while (terminal <= 5); //C# checks condition after executing code
            Console.ReadLine();
        }
    }
}
