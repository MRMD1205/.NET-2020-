﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, country;
            while (true)
            {
                Console.Write("Please enter your name : ");
                name = Console.ReadLine();
                if (Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {

                    Console.WriteLine("Where are you from? : ");
                    country = Console.ReadLine();

                    if (Regex.IsMatch(country, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("\nHeyy...Welcome " + name + " from country " + country);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter valid Country!!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("\nPlease enter valid name!!");
                    Console.ReadKey();
                    Console.Clear();
                }


                Console.ReadKey();
            }
        }
    }
}