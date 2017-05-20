using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001___FivesAndThrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = Enumerable.Range(1, 1000).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
            Console.WriteLine($"{sum}");
            Console.ReadLine();
        }
    }
}
