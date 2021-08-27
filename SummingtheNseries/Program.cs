using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummingtheNseries
{
    class Program
    {
        public static int summingSeries(long n)
        {

            return (int)(n * n  % 1000000007 % 1000000007);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine().Trim());

                int result = summingSeries(n);

                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
