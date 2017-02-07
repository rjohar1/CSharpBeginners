﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            //Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
            */

            /*
            int[] numbers = new int[] { 4, 8, 15, 16, 23 };
            Console.WriteLine(numbers[4]);
            Console.ReadLine();
            */

            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */

            /*
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            string zig = "You can get what you want out of life " +
                " if you hlep enought people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (var zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}
