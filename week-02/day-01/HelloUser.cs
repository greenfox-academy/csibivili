﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            string userinput;

            Console.Write("How many kilometers would you like to convert to miles? ");
            userinput = Console.ReadLine();
            double a = double.Parse(userinput);
            double b = 0.621371192 * a;
            Console.WriteLine("I think {0.00}", a); // + " kilometers are " + "{0.00}", b + " in miles.");
            Console.ReadLine();
        }
    }
}