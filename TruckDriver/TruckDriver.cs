using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double lvKm = 0.0;
            if (kilometers <= 5000)
            {
                if (season == "Spring" || season == "Autumn") lvKm = 0.75;
                if (season == "Summer") lvKm = 0.90;
                if (season == "Winter") lvKm = 1.05;
            }
            else if (kilometers > 5000 && kilometers <= 10000)
            {
                if (season == "Spring" || season == "Autumn") lvKm = 0.95;
                if (season == "Summer") lvKm = 1.10;
                if (season == "Winter") lvKm = 1.25;
            }
            else if (kilometers > 10000 && kilometers <= 20000) { lvKm = 1.45; }

            var moneyEarned = kilometers * lvKm * 4 * .9;
            Console.WriteLine("{0:f2}", moneyEarned);
        }
    }
}
