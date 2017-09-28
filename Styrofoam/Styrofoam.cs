using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());
            double windowCount = double.Parse(Console.ReadLine());
            double sqMetersFoamInPack = double.Parse(Console.ReadLine());
            double packPrice = double.Parse(Console.ReadLine());
            var foamNeeded = (area - (windowCount * 2.4)) * 1.1;
            //Console.WriteLine(foamNeeded);
            var packNeeded = Math.Ceiling(foamNeeded / sqMetersFoamInPack);
            //Console.WriteLine(packNeeded);
            if (budget >= packNeeded * packPrice)
            {
                Console.WriteLine("Spent: {0:f2}", packNeeded * packPrice);
                Console.WriteLine("Left: {0:f2}", budget - (packNeeded * packPrice));
            }
            else
                Console.WriteLine("Need more: {0:f2}", packNeeded * packPrice - budget);
        }
    }
}
