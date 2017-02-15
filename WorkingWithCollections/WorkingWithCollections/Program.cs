using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prizm";
            car2.VIN = "B2";

            Book book1 = new Book();
            book1.Author = "Robert Tabor";
            book1.Title = "Microsoft .NET XML Web Services";
            book1.ISBN = "0-000-00000-0";
            */

            /*
            // ArrayLists are dynamically sized
            // cool featuers sorting, remove items
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);
            myArrayList.Remove(book1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            // List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            // myList.Add(book1);  // cannot convert from car to book

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);
                //Console.WriteLine(car.Model);
            }
            */
            /*
            // Dictionary <Tkey, Tvalue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);
            */

            // Array of Strings Initializer
            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            // Object initialzer
            // No need for constructor
            //Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
            //Car Car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "C3" };

            // Collection initialzer
            List<Car> myList = new List<Car>()
            {
                new Car { Make = "Oldsmobile" , Model = "Cutlas Supreme", VIN = "E5" },
                new Car {Make = "Nissan", Model = "Ultima", VIN = "F6" }
            };


            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public string VIN { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
