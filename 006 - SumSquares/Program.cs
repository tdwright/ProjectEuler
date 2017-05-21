using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006___SumSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 100;
            long a = SumOfSquares(limit);
            Console.WriteLine($"Sum of squares = {a}");
            long b = SquareOfSums(limit);
            Console.WriteLine($"Square of sums = {b}");

            Console.WriteLine($"Difference = {a-b}");
            Console.ReadLine();
        }

        private static long SumOfSquares(int Limit)
        {
            long acc = 0;
            for(int i = 1; i<=Limit; i++)
            {
                acc += i * i;
            }
            return acc;
        }

        private static long SquareOfSums(int Limit)
        {
            long acc = 0;
            for (int i = 1; i <= Limit; i++)
            {
                acc += i;
            }
            return acc * acc;
        }
    }
}
