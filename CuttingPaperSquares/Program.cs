using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CuttingPaperSquares
{
    class Program
    {
        static long solve(long n, long m)
        {
            return n * m-1;
            
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] nm = Console.ReadLine().Split(' ');

            long n = Convert.ToInt32(nm[0]);

            long m = Convert.ToInt32(nm[1]);


            Console.WriteLine(solve(n,m));
            Console.ReadLine();
        }
    }
}
