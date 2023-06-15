using System;
using System.Collections.Generic;
using System.Text;

namespace ParametersAssignment
{
    public class Employee
    {
        public static void dispItem<Things>(Things[] array) //Adding a property called “Things” with a generic list as its data type.
        {
            foreach (Things item in array) //Matching the generic type of the class
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    
}
