using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010___SumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int limit = 2000000;
            var primes = Sieve(limit);
            Console.WriteLine(primes.Sum());
            Console.ReadLine();
        }

        private static List<long> Sieve(int limit)
        {
            var numbers = Enumerable.Range(2, limit).ToList();

            int cur = 1;

            while (cur < numbers.Max())
            {
                cur = numbers.First(i => i > cur);
                numbers.RemoveAll(i => i % cur == 0 && i != cur);
                Console.WriteLine($"Removing multiples of {cur}. {numbers.Count} numbers remain.");
            }

            return numbers.Where(i => i < limit).Select(i => (long)i).ToList();
        }
    }
}
