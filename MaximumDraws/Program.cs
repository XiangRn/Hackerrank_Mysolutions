using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumDraws
{
    class Program
    {
        static int maximumDraws(int n)
        {
            return n + 1;

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = maximumDraws(n);

                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
