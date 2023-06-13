using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuittable //Creating a derived class that inherits from an abstract class (super class), and from an interface
    {
        public override void SayName() //Overriding a method from an abstract class - implementing the SayName() method inside of the Employee class
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("Employee quits"); //Implementing the Quit() method from the interface
        }
    }
}
