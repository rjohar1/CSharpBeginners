﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);

            // Attaching en event handler
            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start();

            Console.WriteLine("Press enter to remove the red event");
            Console.ReadLine();

            // Detach an event handler
            myTimer.Elapsed -= MyTimer_Elapsed1;

            Console.ReadLine();
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed Time: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Elapsed Time: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
