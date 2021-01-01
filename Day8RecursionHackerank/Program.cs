using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9RecursionHackerank
{
    class Program
    {
        static int factorial(int n)
        {

            if (n < 2)
            {
                return 1;
            }
            return n * factorial(n - 1);

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
         int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(n));
            Console.ReadLine();
        }
    }
}
