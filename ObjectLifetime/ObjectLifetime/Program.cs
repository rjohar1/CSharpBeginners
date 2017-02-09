using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car.MyMethod();

            /*
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1998;
            myCar.Color = "Silver";
            */
/*
            // passing values to overloaded constructor
            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            Console.WriteLine("{0} {1} {2} {3}",
              myThirdCar.Make,
              myThirdCar.Model,
              myThirdCar.Year,
              myThirdCar.Color);


            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "98";
            Console.WriteLine("{0} {1} {2} {3}",
               myCar.Make,
               myCar.Model,
               myCar.Year,
               myCar.Color);

            // removing reference to the object
            myOtherCar = null;
            
            Console.WriteLine("{0} {1} {2} {3}",
              myOtherCar.Make,
              myOtherCar.Model,
              myOtherCar.Year,
              myOtherCar.Color);
 */          

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // Constructor
        public Car()
        {
            // We could load from a configuration file,
            // a database, etc.
            Make = "Nissan";
        }

        // overloaded constructor
        public Car(string make, string model, int year, string color)
        {
            // property = parameter
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod.");
            Console.WriteLine(Make);
        }
    }
}


