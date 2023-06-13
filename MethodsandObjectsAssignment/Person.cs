using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsandObjectsAssignment
{
    public class Person //Creating a public super class
    {

        public string FirstName { get; set; } //Giving a property
        public string LastName { get; set; } //Giving a property
        public void SayName() //Creating a public void method
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
