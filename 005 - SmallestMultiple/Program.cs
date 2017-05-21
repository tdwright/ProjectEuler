using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005___SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            long knownGood = UpperBound(20);
            Console.WriteLine($"Upper = {knownGood}");
            bool diff = true;
            do
            {
                long tmp = MakeItSmall(knownGood);
                diff = tmp != knownGood;
                knownGood = tmp;
            } while (diff);
            Console.WriteLine($"Final = {knownGood}");
            Console.ReadLine();
        }

        private static long MakeItSmall(long knownGood)
        {
            for (int i = 19; i > 1; i--)
            {
                long trial = knownGood / i;
                Console.WriteLine($"Trying {i} ({trial})...");
                if (TrialDivide(trial, 20))
                {
                    Console.WriteLine($"{trial} works");
                    return trial;
                }
            }
            return knownGood;
        }

        private static long UpperBound(int uBound)
        {
            long acc = 1;
            for(long i= 1;i<=uBound;i++)
            {
                acc = acc * i;
            }
            return acc;
        }

        private static bool TrialDivide(long start, int maxDivisor)
        {
            for(long i=maxDivisor; i>0;i--)
            {
                if (start % i != 0) return false; 
            }
            return true;
        }
    }
}
