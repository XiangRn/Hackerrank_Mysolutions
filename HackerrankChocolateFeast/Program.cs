using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankChocolateFeast
{
    class Program
    {
        static int chocolateFeast(int n, int c, int m)
        {
            int S = 0; int bars_first = n / c;
            S += bars_first; int wrappers_residual = 0;
            while (bars_first / m > 0)
            {
                wrappers_residual += bars_first % m;
                S += bars_first / m;
                wrappers_residual += bars_first / m;
                bars_first = wrappers_residual;
                wrappers_residual = 0;
            }
            return S;

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] ncm = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(ncm[0]);

                int c = Convert.ToInt32(ncm[1]);

                int m = Convert.ToInt32(ncm[2]);

                int result = chocolateFeast(n, c, m);

                Console.WriteLine(result);
            }

         
            Console.ReadLine();
        }
    }
}
