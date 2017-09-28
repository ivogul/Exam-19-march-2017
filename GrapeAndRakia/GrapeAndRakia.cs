using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeAndRakia
{
    class GrapeAndRakia
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double dobiv = double.Parse(Console.ReadLine());
            double brak = double.Parse(Console.ReadLine());
            double totalDobiv = area * dobiv - brak;
            //Console.WriteLine(totalDobiv);
            double rakiaLitri = (totalDobiv * 0.45) / 7.5;
            //Console.WriteLine(rakiaLitri);
            double grozde = totalDobiv * .55;
            //Console.WriteLine(grozde);
            var incomeRakia = rakiaLitri * 9.80;
            var incomeGrozde = grozde * 1.50;
            Console.WriteLine("{0:f2}", incomeRakia);
            Console.WriteLine("{0:f2}", incomeGrozde);

        }
    }
}
