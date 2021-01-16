using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExtraLongFactorials
{
    class Program
    {
        static void extraLongFactorials(int n)
        {
            BigInteger S = 1;
            for (int i = 2; i <= n; i++)
            {
                S *= i;
            }
            Console.WriteLine(S);

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine());
            extraLongFactorials(n);

            Console.ReadLine();
        }
    }
}
