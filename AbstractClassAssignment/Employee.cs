using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    public class Employee : Person //Creating a derived class that inherits from an abstract class ( super class).
    {
        public override void SayName() //Overriding a method from an abstract class - implementing the SayName() method inside of the Employee class
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

    }
}
