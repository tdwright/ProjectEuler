using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009___PythagTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sum = 1000;
            int closest = int.MaxValue;
            for (int c = sum-3; c >= 3; c--)
            {
                for (int b = (sum - c - 1); b >= 2; b--)
                {
                    int a = sum - b - c;
                    if (b < c && a < b && a > 0)
                    {
                        int left = (a * a) + (b * b);
                        int right = (c * c);
                        int diff = left - right;
                        if(diff<closest)
                        {
                            closest = diff;
                            Console.WriteLine($"({a}^2) + ({b}^2) = {c}^2; diff = {diff}");
                        }
                        if (diff == 0)
                        {
                            Console.WriteLine("Done!");
                            Console.WriteLine($"({a}^2) + ({b}^2) = {c}^2; diff = {diff}");
                            Console.WriteLine($"Product = {a * b * c}");
                            break;
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
