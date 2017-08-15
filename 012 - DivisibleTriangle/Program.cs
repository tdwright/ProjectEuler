using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012___DivisibleTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 0;
            int iteration = 0;
            int factors;
            do
            {
                number += iteration;
                factors = FactCount(number);
                Console.WriteLine($"{number}: {factors}");
                iteration++;
            } while (factors < 500);
            Console.ReadKey();
        }

        static int FactCount(int number)
        {
            var acc = 0;
            int uBound = (int)Math.Ceiling(Math.Sqrt(number));
            for (int i = 1; i <= uBound; i++)
            {
                if (number % i == 0)
                {
                    if (uBound * uBound == number)
                        acc = acc + 1;
                    else
                        acc = acc + 2;
                }
            }
            return acc;
        }
        
    }
}
