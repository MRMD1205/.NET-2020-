using System;
using System.Collections.Generic;
using System.Text;

namespace Practical3
{
    class RetailerSalesman : Salesman
    {

        public RetailerSalesman(string firstName, string lastName) : base(firstName, lastName)
        {

        }
        public override void Sell()
        {
            Console.WriteLine("My name is " + FullName + " ; I recommand you to buy this product as Retailer salesman.");
        }

    }
}