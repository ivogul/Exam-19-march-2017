using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourGlass
{
    class HourGlass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', 2*n + 1));
            Console.WriteLine(".*" + new string(' ', 2*n - 3) + ".*");
            for (int i = 0; i <= n - 2; i++)
            {
                Console.WriteLine(new string('.', i + 2) + "*" + new string('@', n - (i * 2)) + "*" + new string('.', i + 2));
            }
        }
    }
}
