using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();

                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
               // Console.WriteLine(l);  // l does not exist in the current context
            }

            HelperMethod();

            // Calling Public Method from Car Class
            Car myCar = new Car();
            myCar.DoSomething();

            //Console.WriteLine(i);  Variable exist inside of the code block
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for private static: " + k);
            Console.ReadLine();
        }

        private static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod: " + k);
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(HelperMethod());
        }

        private string HelperMethod()
        {
            return "Hello World!";
        }
    }
}
