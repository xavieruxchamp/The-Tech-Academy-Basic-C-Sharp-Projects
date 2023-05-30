using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompting user to select from an array of strings

            string[] stringXarray = { "Bread", "Fries", "Gyoza", "Veggies" };

            Console.WriteLine("\nSelect a number for your side:\n");

            Console.WriteLine(
                "1. Bread\n" +
                "2. Fries\n" +
                "3. Gyoza\n" +
                "4. Veggies\n"
                );

            int uSelection = (Convert.ToInt32(Console.ReadLine()) - 1);  //Casting selection from string to integer, and also adjusting entry as a valid index

            int xSelection = Array.IndexOf(stringXarray, uSelection);
            Console.WriteLine("\nYou have selected " + stringXarray[uSelection]);
            Console.ReadLine();

            //Prompting user to select from an array of integers

            int[] intXarray = { 100, 200, 300, 400 };

            Console.WriteLine("\nSelect a class level:\n");

            Console.WriteLine(
                "100, Freshman\n" +
                "200, Sophomere\n" +
                "300, Junior\n" +
                "400, Senior\n"
                );

            int uLevel = Convert.ToInt32(Console.ReadLine());

            int xLevel = Array.IndexOf(intXarray, uLevel);

            if (xLevel != -1) //Checking whether selection is found on list above
            {
                Console.WriteLine("\nYou have selected " + intXarray[xLevel]);
            }
            else
                Console.WriteLine("\nSorry, try again");
                Console.ReadLine();

            //Prompting user to select from a list of strings

            Console.WriteLine("\nPlease select a number from the list of countries below:\n" +
                "1. Canada\n" +
                "2. Denmark\n" +
                "3. Germany\n" +
                "4. Japan\n"
                );

            List<string> strXlist = new List<string> //Creating a list with values included
            {
                "Canada",
                "Denmark",
                "Germany",
                "Japan"
            };

            int uList = Convert.ToInt32(Console.ReadLine()) - 1;  //Adjusting entry as a valid index

            string xList = strXlist[uList];
            Console.WriteLine("\nYou have selected " + xList);
            Console.ReadLine();

        }
    }
}
