using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a numnber from 0 to 9:"); //Prompting user to enter a number
            string text = Console.ReadLine(); //Reading input
            File.WriteAllText(@"C:\Users\xavier\xavieruxchamp\The-Tech-Academy-Basic-C-Sharp-Projects\Logs\log.txt", text); //Wrting input into a text file

            string fileContent = File.ReadAllText(@"C:\Users\xavier\xavieruxchamp\The-Tech-Academy-Basic-C-Sharp-Projects\Logs\log.txt"); //Reading text file
            Console.WriteLine("You entered: " + fileContent); //Contents of text file
            Console.ReadLine();
        }
    }
}
