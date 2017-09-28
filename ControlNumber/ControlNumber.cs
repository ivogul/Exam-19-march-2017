using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            int moves = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    sum += (i * 2) + (j * 3);
                    moves++;
                    if (sum >= controlNumber) break;
                }
                if (sum >= controlNumber) break;
            }

            if (sum >= controlNumber)
            {
                Console.WriteLine("{0} moves", moves);
                Console.WriteLine("Score: {0} >= {1}", sum, controlNumber);
            }
            else Console.WriteLine("{0} moves", moves);
        }
    }
}
