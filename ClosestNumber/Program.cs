using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestNumber
{
    class Program
    {
        public static int closestNumber(int a, int b, int x)
        {
            double result = Math.Pow(a, b);
            int kq = Convert.ToInt32(Math.Round(result / x));
            return x * kq;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int a = Convert.ToInt32(firstMultipleInput[0]);

                int b = Convert.ToInt32(firstMultipleInput[1]);

                int x = Convert.ToInt32(firstMultipleInput[2]);

                int result = closestNumber(a, b, x);

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
