using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    public abstract class Person
    {
        public string FirstName { get; set; } //Giving a property to the class
        public string LastName { get; set; } //Giving a property to the class
        public virtual void SayName() //Creating a public virtual void method
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
