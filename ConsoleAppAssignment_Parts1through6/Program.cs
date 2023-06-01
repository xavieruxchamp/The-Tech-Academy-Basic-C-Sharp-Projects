using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAssignment_Parts1through6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1

            //A one-dimensional array of strings.
            string[] descPrograms = { "1. Object-oriented", "2. Versatile", "3. Structured", "4. Scientific" };

            for (int i = 0; i < descPrograms.Length; i++)
            {
                Console.WriteLine("Enter the name of the program corresponding to the following description:\n\n" + descPrograms[i]);
                string nameProgram = Console.ReadLine();
                descPrograms[i] = descPrograms[i] + " = " + nameProgram;
            }

            Console.WriteLine("\nHere is the list of programs and their descriptions:\n");

            foreach (string updatedDesc in descPrograms)
            {
                Console.WriteLine(updatedDesc);
            }

            Console.ReadLine();


            //Part 2

            //An infinite loop.

            //for (int j = 0; ; j++) //The loop statement is missing part is the condition that determines when the loop should terminate.
            //{
            //    Console.WriteLine("Hi!");

            //}

            //Fixing the infinite loop so that it executes properly.

            for (int j = 0; j < descPrograms.Length; j++)
            {
                Console.WriteLine("Hi!");

            }
            Console.ReadLine();

            //Part 3

            //A loop using the “<” conparison operator to determine whether to continue iterating the loop.

            for (int k = 0; k < 4; k++) 
                                        
            {
                Console.WriteLine("Hola!");

            }
            Console.ReadLine();

            //Adding another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.

            Console.WriteLine("Enter a number between 1 and 4");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a <= 4)
            {
                Console.WriteLine("Hola again!");

            }
            else
            {
                Console.WriteLine("Sorry, try again,");
            }
            Console.ReadLine();

            //Part 4

            //A list of strings where each item in the list is unique.
            List<string> Ranks = new List<string>()
            {"Admiral",
            "General",
            "Major",
            "Captain",
            "Sergeant",
            "Colonel"
            };

            //Ask the user to input text to search for in the list.
            Console.WriteLine("Please enter a military rank:\n");
            string uRank = Console.ReadLine();
        

            // Find the index of the user-entered rank in the list.
            int index = Ranks.IndexOf(uRank);

            if (index != -1) //Checking if the user enters text found on list above
            {
                Console.WriteLine("\nGood job! The rank of " + uRank + " is found on our list at Index " + index); //Stops the loop from executing once a match has been found.
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid military rank."); //Telling the user that their input is not on the list.
            }
            Console.ReadLine();

            //Part 5

            //A list of strings that contains at least two identical strings

            List<string> Cars = new List<string>()
            {"Ferrari",
            "Aston Martin",
            "Bugatti",
            "Lamborghini",
            "Ferrari",
            };

            //Ask the user to select text to search for in the list.
            Console.WriteLine("Please enter a performance car brand:\n");
            string uCar = Console.ReadLine();

            //Creating a loop that iterates through the list.
            bool foundMatch = false;
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i] == uCar)
                {
                    Console.WriteLine("Match found at index " + i); //Displaying the indices of the list that contain matching text on the screen.
                    foundMatch = true;
                }
            }

            if (!foundMatch)
            {
                Console.WriteLine("No matching car brands found."); //Telling the user that their input is not on the list. 
            }
            Console.ReadLine();

            //Part 6

            //Create a list of strings that contains at least two identical strings 

            List<string> Builders = new List<string>()
            {"Trammel Crow Residential",
            "Related",
            "Landmark",
            "Trammel Crow Residential",
            "Lennar",
            };

            //Creating a foreach loop that evaluates each item in the list

            foreach (string builder in Builders)
            {
                int duplicate = 0;
                foreach (string otherBuilder in Builders) //Creating an enbedded foreach loop to check if the item is a duplicate
                {
                    if (builder == otherBuilder)
                        duplicate++;
                }
                string message = duplicate > 1 ? " - this item is a duplicate" : " - this item is unique"; //Using a ternary operator to display whether the item is unique or a duplicate. 
                Console.WriteLine(builder + message);
            }
            Console.ReadLine();
        }
    }
}
