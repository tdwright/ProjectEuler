using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004___PalindromicFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            var all = GetAllProducts();
            var pals = all.Where(IsPalindrome);
            Console.WriteLine(pals.Max());
            Console.ReadLine();
        }

        private static bool IsPalindrome(int i)
        {
            var chars = i.ToString("0").ToCharArray();
            int bound = chars.Length / 2;
            for(int p = 0; p <=bound; p++)
            {
                if (chars[p] != chars[chars.Length - p - 1]) return false;
            }
            return true;
        }

        private static List<int> GetAllProducts()
        {
            List<int> allProducts = new List<int>();
            for (int x = 100; x <= 999; x++)
            {
                for (int y = 100; y <= 999; y++)
                {
                    allProducts.Add(x * y);
                }
            }
            return allProducts;
        }
    }
}
