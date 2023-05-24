using System;
using System.Collections.Generic;
using System.Text;

namespace MathandComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initial greeting
            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1 details:
            Console.WriteLine("Person 1");

            Console.WriteLine("What is your Hourly Rate?");
            string p1hr = Console.ReadLine();
            double person1HR = Convert.ToDouble(p1hr);

            Console.WriteLine("How many hours do your work per week?");
            string p1hw = Console.ReadLine();
            double person1HW = Convert.ToDouble(p1hw);

            double p1Yearly = person1HR * person1HW * 52;

            ////Person 2 details:
            Console.WriteLine("Person 2");

            Console.WriteLine("What is your Hourly Rate?");
            string p2hr = Console.ReadLine();
            double person2HR = Convert.ToDouble(p1hr);

            Console.WriteLine("How many hours do your work per week?");
            string p2hw = Console.ReadLine();
            double person2HW = Convert.ToDouble(p2hw);

            double p2Yearly = person2HR * person2HW * 52;

            //Printing Annual salary of Person 1

            Console.WriteLine("Annual salary of Person 1:\n" + p1Yearly);

            //Printing Annual salary of Person 2

            Console.WriteLine("Annual salary of Person 2:\n" + p2Yearly);

            //Checking to see if Person 1 makes more money than Person 2

            bool comp = p1Yearly > p2Yearly;
            Console.WriteLine("Person 1 makes more money than Person 2\n" + comp);
            Console.ReadLine();

        }
    }
}
