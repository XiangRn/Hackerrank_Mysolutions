using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockandDivisors
{
    class Program
    {
        public static int divisors(int n)
        {
            int s = (int)Math.Sqrt(n);
            int res = 0;
            for (int i = 1; i <= s; ++i)
            {
                if (n % i == 0)
                {
                    if (i % 2 == 0) res++;
                    if (n / i != i && (n / i) % 2 == 0) res++;
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = divisors(n);

                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
