using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a const variable.
            const string carBrand = "Ferrari";

            // Creating a variable using the keyword "var".
            var carOne = new Car("Testarossa");

            // Chaining two constructors together.
            var carTwo = new Car("Enzo", 2002);

            Console.WriteLine("Your car models are: " + carOne.Model + " and " + carTwo.Model);
            Console.WriteLine("Your car years are: " + carOne.Year + " and " + carTwo.Year);
            Console.ReadLine();
        }
    }

    class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string model) : this(model, 2000)
        {
            Model = model;
        }

        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }
    }
}
