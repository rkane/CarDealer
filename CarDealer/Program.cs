using System;

// Advanced C# Class Module 7
// Car Dealership Program 
// Showcases the use of constructors
// including overloaded
// also shows use of static vs non-static methods
// Written by Garan Weber
// 10/09/2016

namespace CarDealer
{

    class Program
    {
        static void Main(string[] args)
        {

            // Calls static Method
            // shows that an instance of the class is not required to call
            // placed here to illustrate that this can be done before any
            // instance is created
            Car.CarHonk();
            // Instantiates 2 instances of the Car class
            // the first uses one constructor and the second
            // uses another
            Car myCar = new Car("Chevy");
            myCar.Model = "Malibu LT";
            myCar.Year = 2010;
            myCar.Color = "Maroon";

            Car myOtherCar = new Car();
            myOtherCar.Make = "Nissan";
            myOtherCar.Model = "Versa Note";
            myOtherCar.Year = 2014;
            myOtherCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            // Calls non-static method
            // can not be called without and instance to call it from
            myCar.CarGasType();


            // so you have time to read
            Console.ReadKey();
        }
    }
    class Car
    {

        // Default Setters and Getters for each property
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


        // Default constructor Constructor with no values
        public Car()
        {

        }

        // Overloaded Constructor to allow passing Make on instantiation
        public Car(string make)
        {
            Make = make;
        }

        // Static Method can be called without instantiation
        public static void CarHonk()
        {
            Console.WriteLine("The car says Honk.");
        }

        // non-static method, can not be called without a valid instance
        // of the Car Class
        public void CarGasType()
        {
            Console.WriteLine("This car uses Premium gas.");

        }
    }
}
