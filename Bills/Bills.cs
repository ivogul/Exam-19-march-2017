using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            var electricityLv = 0.0;
            var waterLv = months * 20.0;
            var internetLv = months * 15.0;
            var otherLv = 0.0;
            for (int i = 0; i < months; i++)
            {
                double elMonth = double.Parse(Console.ReadLine());
                electricityLv += elMonth;
                otherLv += (elMonth + 35) * 1.2;
            }
            Console.WriteLine("Electricity: {0:f2} lv", electricityLv);
            Console.WriteLine("Water: {0:f2} lv", waterLv);
            Console.WriteLine("Internet: {0:f2} lv", internetLv);
            Console.WriteLine("Other: {0:f2} lv", otherLv);
            Console.WriteLine("Average: {0:f2} lv", (electricityLv + waterLv + internetLv + otherLv) / months);
        }
    }
}
