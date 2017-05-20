using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002___EvenFibb
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int acc = b;

            while (b<=4000000)
            {
                int oldA = a;
                a = b;
                b = oldA + b;
                if (b%2==0) acc += b;
                Console.WriteLine($"x = {b} ({acc})");
            }
            Console.WriteLine($"Final = {acc}");
            Console.ReadLine();
        }
    }
}
