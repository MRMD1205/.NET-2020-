using System;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman cs = new CarSalesman("Mayank", "Dama");
            cs.Sell();

            RetailerSalesman rs = new RetailerSalesman("Mayank", "Dama");
            rs.Sell();
        }
    }
}
