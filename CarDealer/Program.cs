using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    class Program
    {
        static void Main(string[] args)
        {
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


            Car.CarHonk();
            myCar.CarGasType();

            Console.ReadKey();
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {

        }

        public Car(string make)
        {
            Make = make;
        }

        public static void CarHonk()
        {
            Console.WriteLine("The car says Honk.");
        }

        public void CarGasType()
        {
            Console.WriteLine("This car uses Premium gas.");

        }
    }
}
