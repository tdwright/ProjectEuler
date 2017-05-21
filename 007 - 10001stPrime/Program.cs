using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007___10001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            const int limit = 10001;
            //const int limit = 10;
            int counter = 0;
            long trialNum = 2;
            do
            {
                if (IsPrime(trialNum))
                {
                    counter++;
                    Console.WriteLine($"{trialNum} is prime # {counter}");
                }
                trialNum++;
            } while (counter < limit);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private static bool IsPrime(long x)
        {
            if (x == 2) return true;
            if (x % 2 == 0) return false;

            long sqrt = (long)Math.Sqrt(x);
            for(int i = 3; i<=sqrt; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}
