using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003___PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            const long target = 600851475143;
            int sqrt = (int)Math.Round(Math.Sqrt(target));

            Console.WriteLine($"Square root of {target} = {sqrt}");

            var primes = Sieve(sqrt);

            Console.WriteLine($"There are {primes.Count} primes smaller than {sqrt}");

            var max = MaxFactor(primes, target);

            Console.WriteLine($"Largest prime factor = {max}");

            Console.ReadLine();
        }

        private static int MaxFactor(List<int> primes, long product)
        {
            var primeFactors = primes.Where(i => product % i == 0);
            return primeFactors.Max();
        }

        private static List<int> Sieve(int sqrt)
        {
            var numbers = Enumerable.Range(2, sqrt).ToList();

            int cur = 1;

            while (cur < sqrt)
            {
                cur = numbers.First(i => i > cur);
                numbers.RemoveAll(i => i % cur == 0 && i != cur);
            }

            return numbers.Where(i=>i<sqrt).ToList();
        }
    }
}
